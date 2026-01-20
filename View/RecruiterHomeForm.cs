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
    public partial class RecruiterHomeForm: Form
    {
        private Recruiter recruiter;
        public RecruiterHomeForm(Recruiter recruiter)
        {
            this.recruiter = recruiter;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RecruiterHomeForm_Load(object sender, EventArgs e)
        {
            List<Recruiter> recruiterList = new List<Recruiter>();
            recruiterList.Add(recruiter);
            dataGridView1.DataSource = recruiterList;
            dataGridView1.Columns["Role"].Visible = false;
            dataGridView1.Columns["AdminId"].Visible = false;

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
                companytextbox.Text = dgr.Cells[4].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            passwordtextbox.Clear();
            confirmpasswordtextbox.Clear();
            emailtextbox.Clear();
            companytextbox.Clear();
            nametextbox.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (nametextbox.Text == "" || passwordtextbox.Text == "" || emailtextbox.Text == "" || companytextbox.Text == ""||confirmpasswordtextbox.Text=="")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else
                {
                    if (passwordtextbox.Text!=confirmpasswordtextbox.Text||passwordtextbox.Text.Length > 6 || passwordtextbox.Text.Length < 4)
                    {
                        MessageBox.Show("Password mismatch or password length should be greater than 6 or less than 4");
                        return;
                    }
                    else {
                        if (emailtextbox.Text.EndsWith("@gmail.com"))
                        {
                            recruiter.RecruiterName = nametextbox.Text;
                            recruiter.RecruiterPassword = passwordtextbox.Text;
                            recruiter.RecruiterEmail = emailtextbox.Text;
                            recruiter.RecruiterCompany = companytextbox.Text;

                            Login lgn = new Login(recruiter.RecruiterId, recruiter.RecruiterPassword, 2);
                            LoginController lcr = new LoginController();
                            lcr.UpdateLogin(lgn);

                            RecruiterController rcr = new RecruiterController();
                            rcr.UpdateRecruiter(recruiter);

                            EmailSenderController em = new EmailSenderController();
                            em.SendIdPasswordToEmail(recruiter.RecruiterEmail,recruiter.RecruiterId,recruiter.RecruiterPassword);
                            MessageBox.Show("Recruiter details updated successfully.Check your email "+ recruiter.RecruiterEmail);

                            nametextbox.Clear();
                            passwordtextbox.Clear();
                            confirmpasswordtextbox.Clear();
                            emailtextbox.Clear();
                            companytextbox.Clear();
                            nametextbox.Enabled = true;

                            List<Recruiter> recruiterList = new List<Recruiter>();
                            recruiterList.Add(recruiter);
                            dataGridView1.DataSource = recruiterList;
                            dataGridView1.Columns["Role"].Visible = false;
                            dataGridView1.Columns["AdminId"].Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Enter a valid email.");
                            return;

                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RecruiterController rcr=new RecruiterController();
                rcr.DeleteRecruiter(recruiter.RecruiterId);


                JobApplicationController jobApController = new JobApplicationController();
                jobApController.DeleteJobApplicationByJobCreator(recruiter.RecruiterId);

                JobController jobController = new JobController();
                jobController.DeleteJobByJobCreator(recruiter.RecruiterId);

                LoginController lcr = new LoginController();
                lcr.DeleteLogin(recruiter.RecruiterId);


                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                MessageBox.Show("Recruiter deleted successfully.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecruiterJobAddForm jobAddForm = new RecruiterJobAddForm(recruiter);
            jobAddForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobApplicationListForm jobApplicationListForm = new JobApplicationListForm(null, recruiter);
            jobApplicationListForm.Show();
        }
    }
}
