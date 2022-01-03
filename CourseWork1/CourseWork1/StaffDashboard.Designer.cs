
namespace CourseWork1
{
    partial class StaffDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.visitorCount = new System.Windows.Forms.TextBox();
            this.visitorCategory = new System.Windows.Forms.TextBox();
            this.visitTime = new System.Windows.Forms.TextBox();
            this.submitButtonStaff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketRateButton = new System.Windows.Forms.Button();
            this.staffLogOutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(897, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Customer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer\'s Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time Of Visit";
            // 
            // visitorCount
            // 
            this.visitorCount.Location = new System.Drawing.Point(572, 78);
            this.visitorCount.Name = "visitorCount";
            this.visitorCount.Size = new System.Drawing.Size(391, 22);
            this.visitorCount.TabIndex = 6;
            // 
            // visitorCategory
            // 
            this.visitorCategory.Location = new System.Drawing.Point(572, 123);
            this.visitorCategory.Name = "visitorCategory";
            this.visitorCategory.Size = new System.Drawing.Size(391, 22);
            this.visitorCategory.TabIndex = 7;
            // 
            // visitTime
            // 
            this.visitTime.Location = new System.Drawing.Point(572, 171);
            this.visitTime.Name = "visitTime";
            this.visitTime.Size = new System.Drawing.Size(391, 22);
            this.visitTime.TabIndex = 8;
            // 
            // submitButtonStaff
            // 
            this.submitButtonStaff.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.submitButtonStaff.ForeColor = System.Drawing.Color.White;
            this.submitButtonStaff.Location = new System.Drawing.Point(407, 285);
            this.submitButtonStaff.Name = "submitButtonStaff";
            this.submitButtonStaff.Size = new System.Drawing.Size(556, 56);
            this.submitButtonStaff.TabIndex = 11;
            this.submitButtonStaff.Text = "Submit Entry";
            this.submitButtonStaff.UseVisualStyleBackColor = false;
            this.submitButtonStaff.Click += new System.EventHandler(this.visitRecordSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(407, 361);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 343);
            this.dataGridView1.TabIndex = 14;
            // 
            // ticketRateButton
            // 
            this.ticketRateButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ticketRateButton.ForeColor = System.Drawing.Color.White;
            this.ticketRateButton.Location = new System.Drawing.Point(407, 721);
            this.ticketRateButton.Name = "ticketRateButton";
            this.ticketRateButton.Size = new System.Drawing.Size(1044, 56);
            this.ticketRateButton.TabIndex = 16;
            this.ticketRateButton.Text = "Show Ticket Rates";
            this.ticketRateButton.UseVisualStyleBackColor = false;
            this.ticketRateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // staffLogOutButton
            // 
            this.staffLogOutButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.staffLogOutButton.ForeColor = System.Drawing.Color.White;
            this.staffLogOutButton.Location = new System.Drawing.Point(988, 285);
            this.staffLogOutButton.Name = "staffLogOutButton";
            this.staffLogOutButton.Size = new System.Drawing.Size(463, 56);
            this.staffLogOutButton.TabIndex = 17;
            this.staffLogOutButton.Text = "Log Out";
            this.staffLogOutButton.UseVisualStyleBackColor = false;
            this.staffLogOutButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ticket Price";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // ticketPrice
            // 
            this.ticketPrice.Location = new System.Drawing.Point(572, 218);
            this.ticketPrice.Name = "ticketPrice";
            this.ticketPrice.Size = new System.Drawing.Size(391, 22);
            this.ticketPrice.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(985, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Time of Entrance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1006, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Time of Exit";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1006, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1099, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 22);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1099, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 22);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1099, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(352, 22);
            this.textBox3.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1007, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Day";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1099, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(352, 22);
            this.textBox4.TabIndex = 27;
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 865);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ticketPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffLogOutButton);
            this.Controls.Add(this.ticketRateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.submitButtonStaff);
            this.Controls.Add(this.visitTime);
            this.Controls.Add(this.visitorCategory);
            this.Controls.Add(this.visitorCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaffDashboard";
            this.Text = "StaffDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffDashboard_FormClosing);
            this.Load += new System.EventHandler(this.StaffDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox visitorCount;
        private System.Windows.Forms.TextBox visitorCategory;
        private System.Windows.Forms.TextBox visitTime;
        private System.Windows.Forms.Button submitButtonStaff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ticketRateButton;
        private System.Windows.Forms.Button staffLogOutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ticketPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
    }
}