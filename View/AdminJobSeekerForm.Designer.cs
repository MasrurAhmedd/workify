namespace Online_Job_Management_System_Kamao.View
{
    partial class AdminJobSeekerForm
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
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.maleradiobutton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.confirmpasswordtextbox = new System.Windows.Forms.TextBox();
            this.femaleradiobutton = new System.Windows.Forms.RadioButton();
            this.otherradiobutton = new System.Windows.Forms.RadioButton();
            this.resetbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.skilltextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.useridtextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(173, 103);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(100, 26);
            this.nametextbox.TabIndex = 0;
            // 
            // maleradiobutton
            // 
            this.maleradiobutton.AutoSize = true;
            this.maleradiobutton.Location = new System.Drawing.Point(150, 217);
            this.maleradiobutton.Name = "maleradiobutton";
            this.maleradiobutton.Size = new System.Drawing.Size(68, 24);
            this.maleradiobutton.TabIndex = 1;
            this.maleradiobutton.TabStop = true;
            this.maleradiobutton.Text = "Male";
            this.maleradiobutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(12, 260);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(97, 41);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(845, 146);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(482, 100);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(249, 26);
            this.emailtextbox.TabIndex = 8;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(173, 140);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(100, 26);
            this.passwordtextbox.TabIndex = 9;
            // 
            // confirmpasswordtextbox
            // 
            this.confirmpasswordtextbox.Location = new System.Drawing.Point(173, 174);
            this.confirmpasswordtextbox.Name = "confirmpasswordtextbox";
            this.confirmpasswordtextbox.Size = new System.Drawing.Size(100, 26);
            this.confirmpasswordtextbox.TabIndex = 10;
            // 
            // femaleradiobutton
            // 
            this.femaleradiobutton.AutoSize = true;
            this.femaleradiobutton.Location = new System.Drawing.Point(251, 217);
            this.femaleradiobutton.Name = "femaleradiobutton";
            this.femaleradiobutton.Size = new System.Drawing.Size(87, 24);
            this.femaleradiobutton.TabIndex = 11;
            this.femaleradiobutton.TabStop = true;
            this.femaleradiobutton.Text = "Female";
            this.femaleradiobutton.UseVisualStyleBackColor = true;
            this.femaleradiobutton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // otherradiobutton
            // 
            this.otherradiobutton.AutoSize = true;
            this.otherradiobutton.Location = new System.Drawing.Point(377, 217);
            this.otherradiobutton.Name = "otherradiobutton";
            this.otherradiobutton.Size = new System.Drawing.Size(74, 24);
            this.otherradiobutton.TabIndex = 12;
            this.otherradiobutton.TabStop = true;
            this.otherradiobutton.Text = "Other";
            this.otherradiobutton.UseVisualStyleBackColor = true;
            this.otherradiobutton.CheckedChanged += new System.EventHandler(this.otherradiobutton_CheckedChanged);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(276, 260);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(97, 41);
            this.resetbutton.TabIndex = 13;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(403, 260);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(97, 41);
            this.deletebutton.TabIndex = 14;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(150, 260);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(97, 41);
            this.updatebutton.TabIndex = 15;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(537, 260);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(97, 41);
            this.searchbutton.TabIndex = 16;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(672, 260);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(97, 41);
            this.exitbutton.TabIndex = 17;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Skill";
            // 
            // skilltextbox
            // 
            this.skilltextbox.Location = new System.Drawing.Point(482, 140);
            this.skilltextbox.Name = "skilltextbox";
            this.skilltextbox.Size = new System.Drawing.Size(236, 26);
            this.skilltextbox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "User ID";
            // 
            // useridtextbox
            // 
            this.useridtextbox.Location = new System.Drawing.Point(173, 68);
            this.useridtextbox.Name = "useridtextbox";
            this.useridtextbox.Size = new System.Drawing.Size(100, 26);
            this.useridtextbox.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 50);
            this.panel1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "[User ID need for Search, Update, Delete]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(33, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Admin Job Seeker Home Form";
            // 
            // AdminJobSeekerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.useridtextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.skilltextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.otherradiobutton);
            this.Controls.Add(this.femaleradiobutton);
            this.Controls.Add(this.confirmpasswordtextbox);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maleradiobutton);
            this.Controls.Add(this.nametextbox);
            this.Name = "AdminJobSeekerForm";
            this.Text = "AdminJobSeekerForm";
            this.Load += new System.EventHandler(this.AdminJobSeekerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.RadioButton maleradiobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox confirmpasswordtextbox;
        private System.Windows.Forms.RadioButton femaleradiobutton;
        private System.Windows.Forms.RadioButton otherradiobutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox skilltextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox useridtextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}