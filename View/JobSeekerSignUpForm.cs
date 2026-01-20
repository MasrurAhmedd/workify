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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Online_Job_Management_System_Kamao.View
{
    public partial class JobSeekerSignUpForm: Form
    {
        private int role = 3;
        private Recruiter recruiter;
        private JobSeeker jobSeeker;
        public JobSeekerSignUpForm(JobSeeker jobseeker)
        {
            this.jobSeeker = jobseeker;
            InitializeComponent();
        }

        private void JobSeekerSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupChoiceForm signupChoiceForm = new SignupChoiceForm();
            signupChoiceForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametextbox.Text == "" || emailtextbox.Text == "" || passwordtextbox.Text == "" || confirmpasswordtextbox.Text == ""||( !maleradiobutton.Checked && !femaleradiobutton.Checked && !otherradiobutton.Checked))
                {
                    MessageBox.Show("Please fill all the fields.");
                    return;
                }
                else
                {
                    if(passwordtextbox.Text.Length>6|| passwordtextbox.Text.Length < 4 || passwordtextbox.Text != confirmpasswordtextbox.Text)
                    {
                        MessageBox.Show("Passwords do not match or password length is greater then 6 or less then 4 .");
                        return;
                    }
                    else
                    {
                        if (emailtextbox.Text.EndsWith("@gmail.com"))
                        {
                            string email = emailtextbox.Text;
                            string name = nametextbox.Text;
                            string password = passwordtextbox.Text;
                            string skill= skilltextbox.Text;
                            string gender="";

                            if (maleradiobutton.Checked)
                            {
                                gender =maleradiobutton.Text;
                            }
                            else if (femaleradiobutton.Checked)
                            {
                                gender = femaleradiobutton.Text;
                            }
                            else if (otherradiobutton.Checked)
                            {
                                gender =otherradiobutton.Text;
                            }

                            CountController countController = new CountController();
                            Count count = countController.SearchCount(1);
                            int objnum=count.Objcount+1;

                            Count c = new Count(1,objnum);
                            countController.UpdateCount(c);
                            string jsId = "J-" + objnum;

                            jobSeeker = new JobSeeker(jsId, name, password, gender , email, skill);

                            EmailSenderController em=new EmailSenderController();
                            string otp = em.GenerateOtp();
                            em.SendOtpToEmail(email, otp);

                            this.Hide();
                            ConfirmSignUpForm confirmSignUpForm = new ConfirmSignUpForm(jobSeeker,recruiter,otp,role);
                            confirmSignUpForm.Show();


                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid email.");
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

        private void maleradiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
