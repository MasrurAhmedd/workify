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

namespace Online_Job_Management_System_Kamao.View
{
    public partial class SignupChoiceForm: Form
    {
        private Recruiter recruiter;
        private JobSeeker jobSeeker;
        public SignupChoiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecruiterSignUpForm recruiterSignUpForm = new RecruiterSignUpForm(recruiter);
            recruiterSignUpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobSeekerSignUpForm jobSeekerSignUpForm = new JobSeekerSignUpForm(jobSeeker);
            jobSeekerSignUpForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void SignupChoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
