using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1
{

    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ticketRate   = (ticketRateInput.Text);
            double price1Hr     = 0.00;
            double price2Hr     = 0.00;
            double price3Hr     = 0.00;
            double price4Hr     = 0.00;
            double priceUHr     = 0.00;
            object[] TicketData = new object[6];

            if (string.IsNullOrEmpty(ticketRate))
            {
                MessageBox.Show("Ticket Rate cant be empty");
            }
            else if (!double.TryParse(price1HrInput.Text, out price1Hr))
            {
                this.ShowError("1 Hour ");
            }
            else if (!double.TryParse(price2HrInput.Text, out price2Hr))
            {
                this.ShowError("2 Hours ");
            }
            else if (!double.TryParse(price3HrInput.Text, out price3Hr))
            {
                this.ShowError("3 Hours ");
            }
            else if (!double.TryParse(price4HrInput.Text, out price4Hr))
            {
                this.ShowError("4 Hours ");
            }
            else if (!double.TryParse(price1WholeDayInput.Text, out priceUHr))
            {
                this.ShowError("Full Day "); 
            }
            else
            {
                this.addRecordToCsv(ticketRate,price1Hr,price2Hr,price3Hr,price4Hr,priceUHr);
            }
        }

        private void addRecordToCsv(string rate, double price1hr, double price2hr, double price3hr, double price4hr, double priceuhr)
        {
            string filePath = "ticket-price.csv";

            try
            {
                if (!File.Exists(filePath))
                {
                    string clientHeader = $"\"Ticket Rate\",\"1 Hrs\",\"2 Hrs\",\"3 Hrs\",\"4 Hrs\",\"Whole Day\"{Environment.NewLine}";
                    File.WriteAllText(filePath, clientHeader);
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
                {
                    file.WriteLine( rate + "," + price1hr + "," + price2hr + "," + price3hr + "," + price4hr + "," + priceuhr);
                    ticketRateInput.Text = "";
                    price1HrInput.Text = "";
                    price2HrInput.Text = "";
                    price3HrInput.Text = "";
                    price4HrInput.Text = "";
                    price1WholeDayInput.Text = "";
                    MessageBox.Show("Record Added :)");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("WRONG", ex);
            }
        }

        private void ShowError(string key)
        {
            MessageBox.Show(key + "Price Must Be A Number");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var path = System.IO.File.ReadAllLines("visitor-details.csv").Skip(1);
            List<MappedFile> lst = new List<MappedFile>();

            foreach (string lines in path)
            {
                var line = lines.Split(',');
                lst.Add(new MappedFile(line[1], line[0]));
            }

            dataGridView1.DataSource = lst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var path = System.IO.File.ReadAllLines("visitor-details.csv").Skip(1);
            List<MappedFile2> lst = new List<MappedFile2>();

            foreach (string lines in path)
            {
                var line = lines.Split(',');
                lst.Add(new MappedFile2(line[5], line[0], line[4]));
            }

            dataGridView1.DataSource = lst;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.RowCount;

            string day; double c1 = 0, c2 = 0;

            for (int i = 0; i < rowCount; i++)

            {

                day = (dataGridView1.Rows[i].Cells[0].Value).ToString();

                c1 =
Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());

                c2 =
Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());


                chart1.Series["Total Customer"].Points.AddXY(day, c1);

                chart1.Series["Total Income"].Points.AddXY(day, c2);


            }
        }
    }

    public class MappedFile
    {
        public string Category { get; set; }
        public string Visitors { get; set; }

        public MappedFile(string category, string totalVisitor)
        {
            Category = category;
            Visitors = totalVisitor;
        }
    }

    public class MappedFile2
    {
        public string Category { get; set; }
        public string Visitors { get; set; }
        public string Earning { get; set; }

        public MappedFile2(string category, string totalVisitor, string earning)
        {
            Category = category;
            Visitors = totalVisitor;
            Earning = earning;
        }
    }
}
