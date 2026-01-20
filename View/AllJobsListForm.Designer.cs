namespace Online_Job_Management_System_Kamao.View
{
    partial class AllJobsListForm
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
            this.searchbutton1 = new System.Windows.Forms.Button();
            this.searchtitletextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitbutton1 = new System.Windows.Forms.Button();
            this.titletextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salarytextbox = new System.Windows.Forms.TextBox();
            this.jobApplybutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.jobidtextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbutton1
            // 
            this.searchbutton1.Location = new System.Drawing.Point(951, 76);
            this.searchbutton1.Name = "searchbutton1";
            this.searchbutton1.Size = new System.Drawing.Size(161, 35);
            this.searchbutton1.TabIndex = 0;
            this.searchbutton1.Text = "Search By Title";
            this.searchbutton1.UseVisualStyleBackColor = true;
            this.searchbutton1.Click += new System.EventHandler(this.searchbutton1_Click);
            // 
            // searchtitletextbox
            // 
            this.searchtitletextbox.Location = new System.Drawing.Point(599, 80);
            this.searchtitletextbox.Name = "searchtitletextbox";
            this.searchtitletextbox.Size = new System.Drawing.Size(346, 26);
            this.searchtitletextbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 362);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exitbutton1
            // 
            this.exitbutton1.Location = new System.Drawing.Point(1007, 188);
            this.exitbutton1.Name = "exitbutton1";
            this.exitbutton1.Size = new System.Drawing.Size(105, 50);
            this.exitbutton1.TabIndex = 3;
            this.exitbutton1.Text = "Exit";
            this.exitbutton1.UseVisualStyleBackColor = true;
            this.exitbutton1.Click += new System.EventHandler(this.exitbutton1_Click);
            // 
            // titletextbox
            // 
            this.titletextbox.Location = new System.Drawing.Point(162, 150);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(336, 26);
            this.titletextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salary :";
            // 
            // salarytextbox
            // 
            this.salarytextbox.Location = new System.Drawing.Point(162, 197);
            this.salarytextbox.Name = "salarytextbox";
            this.salarytextbox.Size = new System.Drawing.Size(233, 26);
            this.salarytextbox.TabIndex = 7;
            // 
            // jobApplybutton
            // 
            this.jobApplybutton.Location = new System.Drawing.Point(628, 141);
            this.jobApplybutton.Name = "jobApplybutton";
            this.jobApplybutton.Size = new System.Drawing.Size(105, 50);
            this.jobApplybutton.TabIndex = 8;
            this.jobApplybutton.Text = "Apply Job";
            this.jobApplybutton.UseVisualStyleBackColor = true;
            this.jobApplybutton.Click += new System.EventHandler(this.jobApplybutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Job Id :";
            // 
            // jobidtextbox
            // 
            this.jobidtextbox.Location = new System.Drawing.Point(162, 99);
            this.jobidtextbox.Name = "jobidtextbox";
            this.jobidtextbox.Size = new System.Drawing.Size(165, 26);
            this.jobidtextbox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 65);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(59, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "All Jobs List Form:";
            // 
            // AllJobsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jobidtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobApplybutton);
            this.Controls.Add(this.salarytextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titletextbox);
            this.Controls.Add(this.exitbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchtitletextbox);
            this.Controls.Add(this.searchbutton1);
            this.Name = "AllJobsListForm";
            this.Text = "AllJobsListForm";
            this.Load += new System.EventHandler(this.AllJobsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbutton1;
        private System.Windows.Forms.TextBox searchtitletextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitbutton1;
        private System.Windows.Forms.TextBox titletextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salarytextbox;
        private System.Windows.Forms.Button jobApplybutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jobidtextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}