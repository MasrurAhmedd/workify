namespace Online_Job_Management_System_Kamao.View
{
    partial class AdminAddJobForm
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
            this.addbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jobidtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptiontextbox = new System.Windows.Forms.TextBox();
            this.salarytextbox = new System.Windows.Forms.TextBox();
            this.titletextbox = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.searchbutton5 = new System.Windows.Forms.Button();
            this.exitbutton6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(54, 269);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(92, 38);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 167);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 37);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // jobidtextbox
            // 
            this.jobidtextbox.Location = new System.Drawing.Point(175, 47);
            this.jobidtextbox.Name = "jobidtextbox";
            this.jobidtextbox.Size = new System.Drawing.Size(100, 26);
            this.jobidtextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deadline";
            // 
            // descriptiontextbox
            // 
            this.descriptiontextbox.Location = new System.Drawing.Point(175, 168);
            this.descriptiontextbox.Name = "descriptiontextbox";
            this.descriptiontextbox.Size = new System.Drawing.Size(306, 26);
            this.descriptiontextbox.TabIndex = 10;
            // 
            // salarytextbox
            // 
            this.salarytextbox.Location = new System.Drawing.Point(175, 126);
            this.salarytextbox.Name = "salarytextbox";
            this.salarytextbox.Size = new System.Drawing.Size(105, 26);
            this.salarytextbox.TabIndex = 11;
            // 
            // titletextbox
            // 
            this.titletextbox.Location = new System.Drawing.Point(175, 85);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(186, 26);
            this.titletextbox.TabIndex = 12;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(204, 269);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(92, 38);
            this.updatebutton.TabIndex = 13;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(357, 269);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(92, 38);
            this.resetbutton.TabIndex = 14;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(524, 269);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(92, 38);
            this.deletebutton.TabIndex = 15;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // searchbutton5
            // 
            this.searchbutton5.Location = new System.Drawing.Point(690, 269);
            this.searchbutton5.Name = "searchbutton5";
            this.searchbutton5.Size = new System.Drawing.Size(92, 38);
            this.searchbutton5.TabIndex = 16;
            this.searchbutton5.Text = "Search";
            this.searchbutton5.UseVisualStyleBackColor = true;
            this.searchbutton5.Click += new System.EventHandler(this.searchbutton5_Click);
            // 
            // exitbutton6
            // 
            this.exitbutton6.Location = new System.Drawing.Point(851, 269);
            this.exitbutton6.Name = "exitbutton6";
            this.exitbutton6.Size = new System.Drawing.Size(92, 38);
            this.exitbutton6.TabIndex = 17;
            this.exitbutton6.Text = "Exit";
            this.exitbutton6.UseVisualStyleBackColor = true;
            this.exitbutton6.Click += new System.EventHandler(this.exitbutton6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(769, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Admin Job Form to Add Delete Search job cannot Update the job if admin did not po" +
    "st it ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "[Job Id has to be empty to add a new Job]";
            // 
            // AdminAddJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1088, 474);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitbutton6);
            this.Controls.Add(this.searchbutton5);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.titletextbox);
            this.Controls.Add(this.salarytextbox);
            this.Controls.Add(this.descriptiontextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobidtextbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addbutton);
            this.Name = "AdminAddJobForm";
            this.Text = "AdminAddJobForm";
            this.Load += new System.EventHandler(this.AdminAddJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox jobidtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptiontextbox;
        private System.Windows.Forms.TextBox salarytextbox;
        private System.Windows.Forms.TextBox titletextbox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button searchbutton5;
        private System.Windows.Forms.Button exitbutton6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}