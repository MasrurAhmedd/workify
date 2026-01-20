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
    public partial class AdminRecruiterForm: Form
    {
        private Admin admin;
        public AdminRecruiterForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void AdminRecruiterForm_Load(object sender, EventArgs e)
        {
            RecruiterController rc = new RecruiterController();
            List<Recruiter> recruiterList = rc.GetAllRecruiter();
            dataGridView1.DataSource = recruiterList;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
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
                        if(useridtextbox.Text != "")
                        {
                            MessageBox.Show("Please clear the user Id textbox before adding a new recruiter. It is used to update or delete a recruiter.");
                        }
                        else 
                        {
                            string name = nametextbox.Text;
                            string email = emailtextbox.Text;
                            string password = passwordtextbox.Text;
                            string company = companytextbox.Text;


                            CountController countController = new CountController();
                            Count count = countController.SearchCount(1);
                            int objnum = count.Objcount + 1;

                            Count c = new Count(1, objnum);
                            countController.UpdateCount(c);

                            string recruiterId = "R-" + objnum;

                            Recruiter rec = new Recruiter(recruiterId, name, password, email, company);
                            Login lgn = new Login(recruiterId, password, 2);
                            LoginController lcr = new LoginController();
                            lcr.AddLogin(lgn);
                            RecruiterController rcr = new RecruiterController();
                            rcr.AddRecruiter(rec);


                            EmailSenderController em = new EmailSenderController();
                            em.SendIdPasswordToEmail(email, recruiterId, password);
                            MessageBox.Show("Recruiter added successfully. Check your email " + email);

                            RecruiterController rc = new RecruiterController();
                            List<Recruiter> recruiterList = rc.GetAllRecruiter();
                            dataGridView1.DataSource = recruiterList;
                            useridtextbox.Clear();
                            nametextbox.Clear();
                            passwordtextbox.Clear();
                            confirmpasswordtextbox.Clear();
                            emailtextbox.Clear();
                            companytextbox.Clear();
                            nametextbox.Enabled = true;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgr = dataGridView1.Rows[e.RowIndex];
                useridtextbox.Text = dgr.Cells[0].Value.ToString();
                nametextbox.Text = dgr.Cells[1].Value.ToString();
                passwordtextbox.Text = dgr.Cells[2].Value.ToString();
                confirmpasswordtextbox.Text = dgr.Cells[2].Value.ToString();
                emailtextbox.Text = dgr.Cells[3].Value.ToString();
                companytextbox.Text = dgr.Cells[4].Value.ToString();
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            useridtextbox.Clear();
            nametextbox.Clear();
            passwordtextbox.Clear();
            confirmpasswordtextbox.Clear();
            emailtextbox.Clear();
            companytextbox.Clear();
            nametextbox.Enabled = true;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(useridtextbox.Text==""||nametextbox.Text == "" || emailtextbox.Text == "" || passwordtextbox.Text == "" || confirmpasswordtextbox.Text == "" || companytextbox.Text == "")
                {
                    MessageBox.Show("Please fill all the fields also user the Id textbox");
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
                        string company = companytextbox.Text;

                        LoginController lgc = new LoginController();
                        Login lgs=lgc.SearchLogin(userid);
                        if (lgs == null)
                        {
                            MessageBox.Show("User with this Id does not exist. Please enter a valid Id.");
                            return;
                        }
                        else
                        {

                            Login lgn = new Login(userid, password, 2);
                            LoginController lcr = new LoginController();
                            lcr.UpdateLogin(lgn);

                            Recruiter rec = new Recruiter(userid, name, password, email, company);
                            RecruiterController rcr = new RecruiterController();
                            rcr.UpdateRecruiter(rec);

                            EmailSenderController em = new EmailSenderController();
                            em.SendIdPasswordToEmail(email, useridtextbox.Text, password);
                            MessageBox.Show("Recruiter updated successfully. Check your email " + email);
                            RecruiterController rc = new RecruiterController();
                            List<Recruiter> recruiterList = rc.GetAllRecruiter();
                            dataGridView1.DataSource = recruiterList;
                            useridtextbox.Clear();
                            nametextbox.Clear();
                            passwordtextbox.Clear();
                            confirmpasswordtextbox.Clear();
                            emailtextbox.Clear();
                            companytextbox.Clear();
                            nametextbox.Enabled = true;
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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtextbox.Text == "")
                {
                    MessageBox.Show("Please fill the user Id textbox to delete a recruiter.");
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
                        if (lgs.LoginId == userid && lgs.Role == 2)
                        {
                            RecruiterController rcr = new RecruiterController();
                            Recruiter rec=rcr.SearchRecruiter(userid, lgs.LoginPassword);
                            if (rec == null)
                            {
                                MessageBox.Show("No recruiter found with this Id.");
                                return;
                            }
                            else
                            {
                                rcr.DeleteRecruiter(userid);

                                JobApplicationController jobApController = new JobApplicationController();
                                jobApController.DeleteJobApplicationByJobCreator(userid);

                                JobController jobController = new JobController();
                                jobController.DeleteJobByJobCreator(userid);

                                lgc.DeleteLogin(userid);

                                

                                MessageBox.Show("Recruiter deleted successfully.");
                                useridtextbox.Clear();
                                nametextbox.Clear();
                                passwordtextbox.Clear();
                                confirmpasswordtextbox.Clear();
                                emailtextbox.Clear();
                                companytextbox.Clear();
                                nametextbox.Enabled = true;
                                RecruiterController rc = new RecruiterController();
                                List<Recruiter> recruiterList = rc.GetAllRecruiter();
                                dataGridView1.DataSource = recruiterList;
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

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtextbox.Text == "")
                {
                    MessageBox.Show("Please fill the user Id textbox to search a recruiter.");
                    return;
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
                        if(userid==lgn.LoginId && lgn.Role == 2)
                        {
                            RecruiterController rcr = new RecruiterController();
                            Recruiter rec = rcr.SearchRecruiter(userid,lgn.LoginPassword);
                            if (rec != null)
                            {
                                nametextbox.Text = rec.RecruiterName;
                                passwordtextbox.Text = rec.RecruiterPassword;
                                confirmpasswordtextbox.Text = rec.RecruiterPassword;
                                emailtextbox.Text = rec.RecruiterEmail;
                                companytextbox.Text = rec.RecruiterCompany;
                            }
                            else
                            {
                                MessageBox.Show("No recruiter found with this Id.");
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
    }
}
