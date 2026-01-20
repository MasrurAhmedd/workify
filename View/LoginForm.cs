using Online_Job_Management_System_Kamao.Controller;
using Online_Job_Management_System_Kamao.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Online_Job_Management_System_Kamao.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupChoiceForm signupChoiceForm = new SignupChoiceForm();
            signupChoiceForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(useridtextbox.Text == "" || passwordtextbox.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                string userId = useridtextbox.Text;
                string password = passwordtextbox.Text;

                LoginController lgc = new LoginController();
                Login login = lgc.SearchLogin(userId, password);

                if (login != null)
                {
                    if (login.LoginId.Equals(userId) && login.LoginPassword.Equals(password) && login.Role == 1)
                    {
                        AdminController ac = new AdminController();
                        Admin a = ac.SearchAdmin(userId, password);
                        this.Hide();
                        AdminHomeForm ahf = new AdminHomeForm(a);
                        ahf.Show();
                    }

                    else if (login.LoginId.Equals(userId) && login.LoginPassword.Equals(password) && login.Role == 2)
                    {
                        RecruiterController rcr = new RecruiterController();
                        Recruiter r = rcr.SearchRecruiter(userId, password);
                        this.Hide();
                        RecruiterHomeForm rhf = new RecruiterHomeForm(r);
                        rhf.Show();
                    }

                    else if (login.LoginId.Equals(userId) && login.LoginPassword.Equals(password) && login.Role == 3)
                    {
                        JobSeekerController jsc = new JobSeekerController();
                        JobSeeker j = jsc.SearchJobSeeker(userId, password);
                        this.Hide();
                        JobSeekerHomeForm jsh = new JobSeekerHomeForm(j);
                        jsh.Show();
                        
                    }

                    else
                    {
                        MessageBox.Show("Invalid Id or Password ");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid Id or Password");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
