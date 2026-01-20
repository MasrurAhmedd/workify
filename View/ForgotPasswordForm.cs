using Online_Job_Management_System_Kamao.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Job_Management_System_Kamao.Model;
using Online_Job_Management_System_Kamao.Controller;

namespace Online_Job_Management_System_Kamao.View
{
    public partial class ForgotPasswordForm: Form
    {
        private string userId;
        private string email;
        private string otp;
        private Recruiter r;
        private JobSeeker j;
        private int role=0;
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                if (useridtextbox.Text == "" || emailtextbox.Text == ""||otpconfirmtextbox.Text==""||newpasswordtextbox.Text==""||confirmpasswordtextbox.Text=="") 
                { 
                    MessageBox.Show("Please fill all the fields.");
                }
                else if (!otpconfirmtextbox.Text.Equals(otp))
                {
                    MessageBox.Show("Invalid OTP. Please try again.");
                }
                else
                {
                    if (newpasswordtextbox.Text.Length > 6 || newpasswordtextbox.Text.Length < 4 || newpasswordtextbox.Text != confirmpasswordtextbox.Text)
                    {
                        MessageBox.Show("Password mismatch Or password length is greater than 6 or less than 4");
                    }
                    else
                    {
                        Login lgn = new Login();
                        lgn.LoginId = userId;
                        lgn.LoginPassword = newpasswordtextbox.Text;
                        lgn.Role = role;
                        LoginController lcr = new LoginController();
                        lcr.UpdateLogin(lgn);

                        


                        if (role == 2)
                        {
                            r.RecruiterPassword = newpasswordtextbox.Text;
                            RecruiterController rcr = new RecruiterController();
                            rcr.UpdateRecruiter(r);

                            EmailSenderController em = new EmailSenderController();
                            em.SendIdPasswordToEmail(email, userId, newpasswordtextbox.Text);
                            MessageBox.Show("Password updated successfully. Please check your email "+email);

                            this.Hide();
                            LoginForm lgf = new LoginForm();
                            lgf.Show();
                        }
                        else if (role == 3)
                        {
                            j.JobSeekerPassword = newpasswordtextbox.Text;
                            JobSeekerController jcr = new JobSeekerController();
                            jcr.UpdateJobSeeker(j);

                            EmailSenderController em = new EmailSenderController();
                            em.SendIdPasswordToEmail(email, userId, newpasswordtextbox.Text);
                            MessageBox.Show("Password updated successfully. Please check your email " + email);

                            this.Hide();
                            LoginForm lgf = new LoginForm();
                            lgf.Show();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(useridtextbox.Text == "" || emailtextbox.Text == "")
            {
                MessageBox.Show("Please fill user id and email.");
                return;
            }
            else if (!emailtextbox.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            else
            {
                userId = useridtextbox.Text;
                email = emailtextbox.Text;
                LoginController lcr = new LoginController();
                Login login =lcr.SearchLogin(userId);

                if(login == null)
                {
                    MessageBox.Show("User ID do not match.");
                    return;
                }
                else
                {
                    if (login.Role == 2)
                    {
                        RecruiterController rcr = new RecruiterController();
                        r = rcr.SearchRecruiterEmail(login.LoginId, email);
                        if (r!=null)
                        {
                            role = 2;
                            EmailSenderController em = new EmailSenderController();
                            otp = em.GenerateOtp();
                            em.SendOtpToEmail(email, otp);
                            MessageBox.Show("Otp has been send to "+email);
                        }
                        else
                        {
                            MessageBox.Show("Email do not match.");
                            
                        }

                    }
                    else if (login.Role == 3)
                    {
                        JobSeekerController jcr = new JobSeekerController();
                        j = jcr.SearchJobSeekerEmail(login.LoginId, email);
                        if (j != null)
                        {
                            role = 3;
                            EmailSenderController em = new EmailSenderController();
                            otp = em.GenerateOtp();
                            em.SendOtpToEmail(email, otp);
                            MessageBox.Show("Otp has been send to ." + email);
                        }
                        else
                        {
                            MessageBox.Show("Email do not match.");
                            
                        }
                    }
                }

                    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
