
namespace CourseWork1
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ticketRateInput = new System.Windows.Forms.TextBox();
            this.price1HrInput = new System.Windows.Forms.TextBox();
            this.price2HrInput = new System.Windows.Forms.TextBox();
            this.price3HrInput = new System.Windows.Forms.TextBox();
            this.price4HrInput = new System.Windows.Forms.TextBox();
            this.price1WholeDayInput = new System.Windows.Forms.TextBox();
            this.AddTicket = new System.Windows.Forms.Button();
            this.adminLogoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price for 1Hrs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price for 2 Hrs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price for 3 Hrs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price for 4 Hrs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "For Whole Day";
            // 
            // ticketRateInput
            // 
            this.ticketRateInput.Location = new System.Drawing.Point(452, 60);
            this.ticketRateInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketRateInput.Name = "ticketRateInput";
            this.ticketRateInput.Size = new System.Drawing.Size(149, 20);
            this.ticketRateInput.TabIndex = 7;
            // 
            // price1HrInput
            // 
            this.price1HrInput.Location = new System.Drawing.Point(452, 94);
            this.price1HrInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price1HrInput.Name = "price1HrInput";
            this.price1HrInput.Size = new System.Drawing.Size(149, 20);
            this.price1HrInput.TabIndex = 8;
            // 
            // price2HrInput
            // 
            this.price2HrInput.Location = new System.Drawing.Point(452, 132);
            this.price2HrInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price2HrInput.Name = "price2HrInput";
            this.price2HrInput.Size = new System.Drawing.Size(149, 20);
            this.price2HrInput.TabIndex = 9;
            // 
            // price3HrInput
            // 
            this.price3HrInput.Location = new System.Drawing.Point(854, 62);
            this.price3HrInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price3HrInput.Name = "price3HrInput";
            this.price3HrInput.Size = new System.Drawing.Size(149, 20);
            this.price3HrInput.TabIndex = 10;
            // 
            // price4HrInput
            // 
            this.price4HrInput.Location = new System.Drawing.Point(854, 99);
            this.price4HrInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price4HrInput.Name = "price4HrInput";
            this.price4HrInput.Size = new System.Drawing.Size(149, 20);
            this.price4HrInput.TabIndex = 11;
            // 
            // price1WholeDayInput
            // 
            this.price1WholeDayInput.Location = new System.Drawing.Point(854, 133);
            this.price1WholeDayInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price1WholeDayInput.Name = "price1WholeDayInput";
            this.price1WholeDayInput.Size = new System.Drawing.Size(149, 20);
            this.price1WholeDayInput.TabIndex = 12;
            // 
            // AddTicket
            // 
            this.AddTicket.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddTicket.ForeColor = System.Drawing.Color.White;
            this.AddTicket.Location = new System.Drawing.Point(364, 583);
            this.AddTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTicket.Name = "AddTicket";
            this.AddTicket.Size = new System.Drawing.Size(208, 51);
            this.AddTicket.TabIndex = 13;
            this.AddTicket.Text = "Add Ticket";
            this.AddTicket.UseVisualStyleBackColor = false;
            this.AddTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminLogoutButton
            // 
            this.adminLogoutButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.adminLogoutButton.ForeColor = System.Drawing.Color.White;
            this.adminLogoutButton.Location = new System.Drawing.Point(364, 165);
            this.adminLogoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminLogoutButton.Name = "adminLogoutButton";
            this.adminLogoutButton.Size = new System.Drawing.Size(323, 40);
            this.adminLogoutButton.TabIndex = 14;
            this.adminLogoutButton.Text = "Log Out";
            this.adminLogoutButton.UseVisualStyleBackColor = false;
            this.adminLogoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(585, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "View Daily Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(844, 583);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 50);
            this.button3.TabIndex = 16;
            this.button3.Text = "View Weekly Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 210);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 355);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(691, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "View Graph";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(691, 210);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Customer";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Income";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(311, 355);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 666);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminLogoutButton);
            this.Controls.Add(this.AddTicket);
            this.Controls.Add(this.price1WholeDayInput);
            this.Controls.Add(this.price4HrInput);
            this.Controls.Add(this.price3HrInput);
            this.Controls.Add(this.price2HrInput);
            this.Controls.Add(this.price1HrInput);
            this.Controls.Add(this.ticketRateInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ticketRateInput;
        private System.Windows.Forms.TextBox price1HrInput;
        private System.Windows.Forms.TextBox price2HrInput;
        private System.Windows.Forms.TextBox price3HrInput;
        private System.Windows.Forms.TextBox price4HrInput;
        private System.Windows.Forms.TextBox price1WholeDayInput;
        private System.Windows.Forms.Button AddTicket;
        private System.Windows.Forms.Button adminLogoutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}