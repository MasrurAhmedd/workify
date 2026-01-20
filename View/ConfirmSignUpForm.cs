using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Job_Management_System_Kamao.Controller;
using Online_Job_Management_System_Kamao.Model;

namespace Online_Job_Management_System_Kamao.View
{
    public partial class ConfirmSignUpForm : Form
    {
        private int role;
        private JobSeeker jobSeeker;
        private Recruiter recruiter;
        private string otp;
        public ConfirmSignUpForm(JobSeeker jobSeeker, Recruiter recruiter,string otp,int role)
        {
            this.jobSeeker = jobSeeker;
            this.recruiter = recruiter;
            this.otp = otp;
            this.role = role;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (role == 3)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();

                }
                else if (role == 2)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }

        }

        private void ConfirmSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (otptextbox.Text == "")
                {
                    MessageBox.Show("Please enter the OTP");
                    return;
                }
                else if (otptextbox.Text != otp)
                {
                    MessageBox.Show("Invalid OTP. Please try again.");
                    return;
                }
                else
                {

                    if (role == 3)
                    {
                        LoginController loginController = new LoginController();
                        Login lg = new Login(jobSeeker.JobSeekerId, jobSeeker.JobSeekerPassword, role);
                        loginController.AddLogin(lg);

                        JobSeekerController jobSeekerController = new JobSeekerController();
                        jobSeekerController.AddJobSeeker(jobSeeker);

                        EmailSenderController emailSenderController = new EmailSenderController();
                        emailSenderController.SendIdPasswordToEmail(jobSeeker.JobSeekerEmail, jobSeeker.JobSeekerId, jobSeeker.JobSeekerPassword);

                        MessageBox.Show("OTP verified successfully.User id and Password has been send to your email " + jobSeeker.JobSeekerEmail);
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                    else if (role == 2)
                    {
                        LoginController loginController = new LoginController();
                        Login lg = new Login(recruiter.RecruiterId, recruiter.RecruiterPassword, role);
                        loginController.AddLogin(lg);

                        RecruiterController rcr = new RecruiterController();
                        rcr.AddRecruiter(recruiter);

                        EmailSenderController emailSenderController = new EmailSenderController();
                        emailSenderController.SendIdPasswordToEmail(recruiter.RecruiterEmail, recruiter.RecruiterId, recruiter.RecruiterPassword);

                        MessageBox.Show("OTP verified successfully.User id and Password has been send to your email " + recruiter.RecruiterEmail);
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }
        }
                


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (role == 2)
                {
                    EmailSenderController emailSenderController = new EmailSenderController();
                    otp = emailSenderController.GenerateOtp();
                    emailSenderController.SendOtpToEmail(recruiter.RecruiterEmail, otp);
                    MessageBox.Show("OTP has been sent to your email " + recruiter.RecruiterEmail);
                }
                else if (role == 3)
                {
                    EmailSenderController emailSenderController = new EmailSenderController();
                    otp = emailSenderController.GenerateOtp();
                    emailSenderController.SendOtpToEmail(jobSeeker.JobSeekerEmail, otp);
                    MessageBox.Show("OTP has been sent to your email " + jobSeeker.JobSeekerEmail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }

        }
    }
}
