using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Job_Management_System_Kamao.Controller;
using Online_Job_Management_System_Kamao.Model;

namespace Online_Job_Management_System_Kamao.View
{
    public partial class AdminHomeForm: Form
    {
        private Admin admin;
        public AdminHomeForm(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            List<Admin> adminList = new List<Admin>();
            adminList.Add(admin);
            dataGridView1.DataSource = adminList;
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            passwordtextbox.Clear();
            confirmpasswordtextbox.Clear();
            emailtextbox.Clear();
            nametextbox.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgr = dataGridView1.Rows[e.RowIndex];
                nametextbox.Text = dgr.Cells[1].Value.ToString();
                passwordtextbox.Text = dgr.Cells[2].Value.ToString();
                confirmpasswordtextbox.Text = dgr.Cells[2].Value.ToString();
                emailtextbox.Text = dgr.Cells[3].Value.ToString();
            }

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametextbox.Text == "" || passwordtextbox.Text == "" || emailtextbox.Text == "" || confirmpasswordtextbox.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else
                {
                    if (passwordtextbox.Text != confirmpasswordtextbox.Text || passwordtextbox.Text.Length > 6 || passwordtextbox.Text.Length < 4)
                    {
                        MessageBox.Show("Password does not match or length should be greater than 6 or less than 4");
                        return;
                    }
                    else
                    {
                        if (emailtextbox.Text.EndsWith("@gmail.com"))
                        {
                            admin.AdminName = nametextbox.Text;
                            admin.AdminPassword = passwordtextbox.Text;
                            admin.AdminEmail = emailtextbox.Text;
                            AdminController acr = new AdminController();
                            acr.UpdateAdmin(admin);
                            Login lg= new Login(admin.AdminName,admin.AdminPassword,1);
                            LoginController lcr = new LoginController();
                            lcr.UpdateLogin(lg);
                            MessageBox.Show("Admin Updated Successfully");

                            List<Admin> adminList = new List<Admin>();
                            adminList.Add(admin);
                            dataGridView1.DataSource = adminList;
                            nametextbox.Clear();
                            passwordtextbox.Clear();
                            emailtextbox.Clear();
                            confirmpasswordtextbox.Clear();
                            nametextbox.Enabled = true;


                        }
                        else
                        {
                            MessageBox.Show("Invalid Email.");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminJobSeekerForm adminJobSeekerForm = new AdminJobSeekerForm(admin);
            adminJobSeekerForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRecruiterForm adminRecruiterForm = new AdminRecruiterForm(admin);
            adminRecruiterForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddJobForm adminAddJobForm = new AdminAddJobForm(admin);
            adminAddJobForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobApplicationListForm jobApplicationListForm = new JobApplicationListForm(admin, null);
            jobApplicationListForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
