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
    public partial class RecruiterSignUpForm: Form
    {
        private int role = 2; 
        private Recruiter recruiter;
        private JobSeeker jobSeeker;
        public RecruiterSignUpForm(Recruiter recruiter)
        {
            this.recruiter = recruiter;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupChoiceForm signupChoiceForm = new SignupChoiceForm();
            signupChoiceForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametextbox.Text == "" || emailtextbox.Text == "" || passwordtextbox.Text == "" || confirmpasswordtextbox.Text == "" || companytextbox.Text == "")
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
                        string name = nametextbox.Text;
                        string email = emailtextbox.Text;
                        string password = passwordtextbox.Text;
                        string company = companytextbox.Text;


                        CountController countController = new CountController();
                        Count count = countController.SearchCount(1);
                        int objnum = count.Objcount+1;

                        Count c = new Count(1, objnum);
                        countController.UpdateCount(c);

                        string recruiterId = "R-" + objnum;

                        Recruiter rec = new Recruiter(recruiterId, name, password, email, company);

                        EmailSenderController em = new EmailSenderController();
                        string otp = em.GenerateOtp();
                        em.SendOtpToEmail(email, otp);

                        this.Hide();
                        ConfirmSignUpForm confirmSignUpForm = new ConfirmSignUpForm(jobSeeker, rec, otp, 2);
                        confirmSignUpForm.Show();

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
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }


        }
        

        private void RecruiterSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            emailtextbox.Clear();
            passwordtextbox.Clear();
            confirmpasswordtextbox.Clear();
            companytextbox.Clear();
            nametextbox.Enabled = true;
        }
    }
}
