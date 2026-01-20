using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Job_Management_System_Kamao.Controller;
using Online_Job_Management_System_Kamao.Model;

namespace Online_Job_Management_System_Kamao.View
{
    public partial class AdminJobSeekerForm : Form
    {
        private Admin admin;
        public AdminJobSeekerForm(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminJobSeekerForm_Load(object sender, EventArgs e)
        {
            JobSeekerController jsc = new JobSeekerController();
            List<JobSeeker> jobSeekerList = jsc.GetAllJobSeeker();
            dataGridView1.DataSource = jobSeekerList;
        }

        private void otherradiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametextbox.Text == "" || emailtextbox.Text == "" || passwordtextbox.Text == "" || confirmpasswordtextbox.Text == "" || skilltextbox.Text == "" || (!maleradiobutton.Checked && !femaleradiobutton.Checked && !otherradiobutton.Checked))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else if (passwordtextbox.Text.Length > 6 || passwordtextbox.Text.Length < 4 || passwordtextbox.Text != confirmpasswordtextbox.Text)
                {
                    MessageBox.Show("Password mismatch Or password length is greater than 6 or less than 4");
                }
                else
                {
                    if (emailtextbox.Text.EndsWith("@gmail.com"))
                    {
                        if (useridtextbox.Text != "")
                        {
                            MessageBox.Show("Please clear the user Id textbox before adding a new recruiter. It is used to update or delete a recruiter.");
                        }
                        else
                        {
                            string email = emailtextbox.Text;
                            string name = nametextbox.Text;
                            string password = passwordtextbox.Text;
                            string skill = skilltextbox.Text;
                            string gender = "";

                            if (maleradiobutton.Checked)
                            {
                                gender = maleradiobutton.Text;
                            }
                            else if (femaleradiobutton.Checked)
                            {
                                gender = femaleradiobutton.Text;
                            }
                            else if (otherradiobutton.Checked)
                            {
                                gender = otherradiobutton.Text;
                            }

                            CountController countController = new CountController();
                            Count count = countController.SearchCount(1);
                            int objnum = count.Objcount + 1;

                            Count c = new Count(1, objnum);
                            countController.UpdateCount(c);
                            string jsId = "J-" + objnum;

                            JobSeeker jobSeeker = new JobSeeker(jsId, name, password, gender, email, skill);

                            LoginController lcr = new LoginController();
                            Login login = new Login(jobSeeker.JobSeekerId, jobSeeker.JobSeekerPassword, jobSeeker.Role);
                            lcr.AddLogin(login);
                            JobSeekerController jsc = new JobSeekerController();
                            jsc.AddJobSeeker(jobSeeker);
                            EmailSenderController em = new EmailSenderController();
                            em.SendIdPasswordToEmail(jobSeeker.JobSeekerEmail, jobSeeker.JobSeekerId, jobSeeker.JobSeekerPassword);
                            MessageBox.Show("Job Seeker added successfully. Check your email " + jobSeeker.JobSeekerEmail);
                            List<JobSeeker> jobSeekerList = jsc.GetAllJobSeeker();
                            dataGridView1.DataSource = jobSeekerList;

                            nametextbox.Clear();
                            passwordtextbox.Clear();
                            confirmpasswordtextbox.Clear();
                            emailtextbox.Clear();
                            skilltextbox.Clear();
                            maleradiobutton.Checked = false;
                            femaleradiobutton.Checked = false;
                            otherradiobutton.Checked = false;
                            nametextbox.Enabled = true;
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email address");
                    }
                }
            }
            catch
            {

            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtextbox.Text == "" || nametextbox.Text == "" || emailtextbox.Text == "" || passwordtextbox.Text == "" || confirmpasswordtextbox.Text == "" || skilltextbox.Text == "" || (!maleradiobutton.Checked && !femaleradiobutton.Checked && !otherradiobutton.Checked))
                {
                    MessageBox.Show("Please fill all the fields also User Id textbox");
                    return;
                }
                else if (passwordtextbox.Text.Length > 6 || passwordtextbox.Text.Length < 4 || passwordtextbox.Text != confirmpasswordtextbox.Text)
                {
                    MessageBox.Show("Password mismatch Or password length is greater than 6 or less than 4");
                }
                else
                {
                    if (emailtextbox.Text.EndsWith("@gmail.com"))
                    {
                        string userid = useridtextbox.Text;
                        string name = nametextbox.Text;
                        string email = emailtextbox.Text;
                        string password = passwordtextbox.Text;
                        string skill = skilltextbox.Text;
                        string gender = "";

                        if (maleradiobutton.Checked)
                        {
                            gender = maleradiobutton.Text;
                        }
                        else if (femaleradiobutton.Checked)
                        {
                            gender = femaleradiobutton.Text;
                        }
                        else if (otherradiobutton.Checked)
                        {
                            gender = otherradiobutton.Text;
                        }

                        LoginController lgc = new LoginController();
                        Login lgs = lgc.SearchLogin(userid);
                        if (lgs == null)
                        {
                            MessageBox.Show("User with this Id does not exist. Please enter a valid Id.");
                            return;
                        }
                        else
                        {
                            JobSeekerController jsc = new JobSeekerController();
                            JobSeeker js = jsc.SearchJobSeeker(userid, lgs.LoginPassword);

                            if (js == null)
                            {
                                MessageBox.Show("User with this Id does not exist. Please enter a valid Id.");
                                return;
                            }
                            else
                            {
                                Login lgn = new Login(userid, password, 3);
                                LoginController lcr = new LoginController();
                                lcr.UpdateLogin(lgn);

                                JobSeeker jbs = new JobSeeker(userid, name, password, gender, email, skill);
                                jsc.UpdateJobSeeker(jbs);

                                EmailSenderController emc = new EmailSenderController();
                                emc.SendIdPasswordToEmail(email, useridtextbox.Text, password);
                                MessageBox.Show("JobSeeker updated successfully. Check your email " + email);

                                List<JobSeeker> jobseekerList = jsc.GetAllJobSeeker();
                                dataGridView1.DataSource = jobseekerList;
                                useridtextbox.Clear();
                                nametextbox.Clear();
                                passwordtextbox.Clear();
                                confirmpasswordtextbox.Clear();
                                emailtextbox.Clear();
                                skilltextbox.Clear();
                                nametextbox.Enabled = true;

                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email. ");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            useridtextbox.Clear();
            nametextbox.Clear();
            passwordtextbox.Clear();
            confirmpasswordtextbox.Clear();
            emailtextbox.Clear();
            skilltextbox.Clear();
            maleradiobutton.Checked = false;
            femaleradiobutton.Checked = false;
            otherradiobutton.Checked = false;
            nametextbox.Enabled = true;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtextbox.Text == "")
                {
                    MessageBox.Show("Please fill the user Id field");
                    return;
                }
                else
                {
                    string userid = useridtextbox.Text;
                    LoginController lgc = new LoginController();
                    Login lgs = lgc.SearchLogin(userid);
                    if (lgs == null)
                    {
                        MessageBox.Show("User with this Id does not exist. Please enter a valid Id.");
                        return;
                    }
                    else
                    {
                        JobSeekerController jsc = new JobSeekerController();
                        JobSeeker js = jsc.SearchJobSeeker(userid, lgs.LoginPassword);
                        if (js == null)
                        {
                            MessageBox.Show("User with this Id does not exist. Please enter a valid Id.");
                            return;
                        }
                        else
                        {
                            JobApplicationController jobApController = new JobApplicationController();
                            jobApController.DeleteJobApplicationByJobSeekerId(userid);

                            jsc.DeleteJobSeeker(userid);

                            lgc.DeleteLogin(userid);


                            MessageBox.Show("Job Seeker deleted successfully");
                            List<JobSeeker> jobseekerList = jsc.GetAllJobSeeker();
                            dataGridView1.DataSource = jobseekerList;
                            useridtextbox.Clear();
                            nametextbox.Clear();
                            passwordtextbox.Clear();
                            confirmpasswordtextbox.Clear();
                            emailtextbox.Clear();
                            skilltextbox.Clear();
                            maleradiobutton.Checked = false;
                            femaleradiobutton.Checked = false;
                            otherradiobutton.Checked = false;
                            nametextbox.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtextbox.Text == "")
                {
                    MessageBox.Show("Please fill the user Id field");
                }
                else
                {
                    string userid = useridtextbox.Text;
                    LoginController lcr = new LoginController();
                    Login lgn = lcr.SearchLogin(userid);
                    if (lgn == null)
                    {
                        MessageBox.Show("User with this Id does not exist. Please enter a valid Id.");
                        return;
                    }
                    else
                    {
                        if (userid == lgn.LoginId && lgn.Role == 3)
                        {
                            JobSeekerController jsc = new JobSeekerController();
                            JobSeeker js = jsc.SearchJobSeeker(userid, lgn.LoginPassword);
                            if (js != null)
                            {
                                useridtextbox.Text = js.JobSeekerId;
                                nametextbox.Text = js.JobSeekerName;
                                passwordtextbox.Text = js.JobSeekerPassword;
                                confirmpasswordtextbox.Text = js.JobSeekerPassword;
                                emailtextbox.Text = js.JobSeekerEmail;
                                skilltextbox.Text = js.JobSeekerSkill;
                                if (js.JobSeekerGender == "Male")
                                {
                                    maleradiobutton.Checked = true;
                                }
                                else if (js.JobSeekerGender == "Female")
                                {
                                    femaleradiobutton.Checked = true;
                                }
                                else if (js.JobSeekerGender == "Other")
                                {
                                    otherradiobutton.Checked = true;
                                }
                                else
                                {
                                    MessageBox.Show("No recruiter found with this Id.");
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeForm adminHomeForm = new AdminHomeForm(admin);
            adminHomeForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgr = dataGridView1.Rows[e.RowIndex];
                useridtextbox.Text = dgr.Cells[0].Value.ToString();
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
                useridtextbox.Enabled = true;
            }
        }
    }
}
