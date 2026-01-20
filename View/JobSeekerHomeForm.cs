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
    public partial class JobSeekerHomeForm : Form
    {
        private JobSeeker jobSeeker;
        public JobSeekerHomeForm(JobSeeker jobSeeker)
        {
            this.jobSeeker = jobSeeker;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgr = dataGridView1.Rows[e.RowIndex];
                nametextbox.Text = dgr.Cells[1].Value.ToString();
                passwordtextbox.Text = dgr.Cells[2].Value.ToString();
                confirmpasswordtextbox.Text = dgr.Cells[2].Value.ToString();

                string gender = dgr.Cells[3].Value.ToString();
                if (gender.Equals("Male"))
                {
                    maleradiobutton.Checked = true;
                }
                else if (gender.Equals("Female"))
                {
                    femaleradiobutton.Checked = true;
                }
                else
                {
                    otherradiobutton.Checked = true;
                }

                emailtextbox.Text = dgr.Cells[4].Value.ToString();
                skilltextbox.Text = dgr.Cells[5].Value.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void JobSeekerHomeForm_Load(object sender, EventArgs e)
        {
            List<JobSeeker> jobSeekerList = new List<JobSeeker>();
            jobSeekerList.Add(jobSeeker);
            dataGridView1.DataSource = jobSeekerList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            emailtextbox.Clear();
            passwordtextbox.Clear();
            confirmpasswordtextbox.Clear();
            skilltextbox.Clear();
            maleradiobutton.Checked = false;
            femaleradiobutton.Checked = false;
            otherradiobutton.Checked = false;
            nametextbox.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametextbox.Text == "" || emailtextbox.Text == "" || passwordtextbox.Text == "" || skilltextbox.Text == "" || (!maleradiobutton.Checked && !femaleradiobutton.Checked && !otherradiobutton.Checked))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else
                {
                    if (passwordtextbox.Text !=confirmpasswordtextbox.Text|| passwordtextbox.Text.Length > 6 || passwordtextbox.Text.Length < 4)
                    {
                        MessageBox.Show("{Password mismatch or Password length should be greater than 6 or less than 4");
                        return;
                    }
                    else
                    {
                        if (emailtextbox.Text.EndsWith("@gmail.com"))
                        {
                            jobSeeker.JobSeekerName = nametextbox.Text;
                            jobSeeker.JobSeekerEmail = emailtextbox.Text;
                            jobSeeker.JobSeekerPassword = passwordtextbox.Text;
                            jobSeeker.JobSeekerSkill = skilltextbox.Text;

                            if (maleradiobutton.Checked)
                            {
                                jobSeeker.JobSeekerGender = maleradiobutton.Text;
                            }
                            else if (femaleradiobutton.Checked)
                            {
                                jobSeeker.JobSeekerGender = femaleradiobutton.Text;
                            }
                            else if (otherradiobutton.Checked)
                            {
                                jobSeeker.JobSeekerGender = otherradiobutton.Text;
                            }

                            LoginController lcr = new LoginController();

                            Login login = new Login(jobSeeker.JobSeekerId, jobSeeker.JobSeekerPassword, jobSeeker.Role);
                            lcr.UpdateLogin(login);

                            JobSeekerController jsc = new JobSeekerController();
                            jsc.UpdateJobSeeker(jobSeeker);

                            EmailSenderController em = new EmailSenderController();
                            em.SendIdPasswordToEmail(jobSeeker.JobSeekerEmail, jobSeeker.JobSeekerId, jobSeeker.JobSeekerPassword);

                            MessageBox.Show("Profile updated successfully.Check your email " + jobSeeker.JobSeekerEmail);
                            nametextbox.Clear();
                            emailtextbox.Clear();
                            passwordtextbox.Clear();
                            confirmpasswordtextbox.Clear();
                            skilltextbox.Clear();
                            maleradiobutton.Checked = false;
                            femaleradiobutton.Checked = false;
                            otherradiobutton.Checked = false;

                            List<JobSeeker> jobSeekersList = new List<JobSeeker>();
                            jobSeekersList.Add(jobSeeker);
                            dataGridView1.DataSource = jobSeekersList;
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

        private void JobSeekerHomeForm_Load_1(object sender, EventArgs e)
        {
            List<JobSeeker> jobSeekerList = new List<JobSeeker>();
            jobSeekerList.Add(jobSeeker);
            dataGridView1.DataSource = jobSeekerList;
            dataGridView1.Columns["Role"].Visible = false;
            dataGridView1.Columns["AdminId"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                JobApplicationController jobApController = new JobApplicationController();
                jobApController.DeleteJobApplicationByJobSeekerId(jobSeeker.JobSeekerId);

                JobSeekerController jsc = new JobSeekerController();
                jsc.DeleteJobSeeker(jobSeeker.JobSeekerId);

                LoginController lcr = new LoginController();


                lcr.DeleteLogin(jobSeeker.JobSeekerId);



                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                MessageBox.Show("Job Seeker deleted successfully.");
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
            AllJobsListForm allJobsListForm = new AllJobsListForm(jobSeeker);
            allJobsListForm.Show();
        }
    }
}
