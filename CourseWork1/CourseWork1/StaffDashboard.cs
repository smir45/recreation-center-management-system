using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void StaffDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindData("ticket-price.csv");
        }

        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //creating header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //datas
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(width, height);
        }

        private void visitRecordSubmit_Click(object senderm, EventArgs e)
        {
            /**
             * centre (opeaning/closing) time
             */

            int Ticket_Price         = 0;
            string Number_of_Visitor = visitorCount.Text;
            string Visitor_Category  = visitorCategory.Text;
            string Visit_Time        = visitTime.Text;

             if (!int.TryParse(ticketPrice.Text, out Ticket_Price))
            {
                this.showError("Ticket Price Is Required or is invalid number Format");
            }
            else if (String.IsNullOrEmpty(Number_of_Visitor))
            {
                this.showError("Number of Visitor Is Required");
            }
            else if (String.IsNullOrEmpty(Visitor_Category))
            {
                this.showError("Visitor Category Is Required");
            }
            else if (String.IsNullOrEmpty(Visit_Time))
            {
                this.showError("Visit Time Is Required");
            }
            else if (String.IsNullOrEmpty(textBox1.Text))
            {
                this.showError("Entry TIme is reuiqred");
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                this.showError("Total Price Is required");
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                this.showError("Exit Time is Required");
            }
            else
            {
                string Entry = textBox1.Text;
                string Total = textBox3.Text;
                string Exit  = textBox2.Text;
                string day = textBox4.Text;
                this.NewRecord(Number_of_Visitor, Visitor_Category, Visit_Time, Ticket_Price, Total ,day,Entry,Exit);
            }

        }

        private void NewRecord(string numberVisitor, string visitorpCategory, string visithour, int price, string total, string day, string now, string end)
        {
            string filePath = "visitor-details.csv";

            try
            {
                if (!File.Exists(filePath))
                {
                    string clientHeader = $"\"Number of Visitor\",\"Visitor Category\",\"Visit Hour\",\"Ticket Price\",\"Total Price\",\"Visit Day\",\"Start Time\",\"End Time\"{Environment.NewLine}";
                    File.WriteAllText(filePath, clientHeader);
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
                {
                  
                    file.WriteLine(numberVisitor + "," + visitorpCategory + "," + visithour + "," + price + "," +  total + "," + day + "," + now + "," + end);
                    visitorCount.Text = "";
                    visitorCategory.Text = "";
                    visitTime.Text ="";
                    ticketPrice.Text ="";
                    MessageBox.Show("Record Added :)");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("WRONG WRONG WRONG", ex);
            }
        }

        private void showError(string key)
        {
            MessageBox.Show(key);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void showChartButton_Click(object sender, EventArgs e)
        {

        }
    }
}