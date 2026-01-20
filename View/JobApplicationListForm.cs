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
namespace Online_Job_Management_System_Kamao.View
{
    public partial class JobApplicationListForm: Form
    {
        private Admin admin;
        private Recruiter recruiter;


        public JobApplicationListForm(Admin admin,Recruiter recruiter)
        {
            this.admin = admin;
            this.recruiter = recruiter;
            InitializeComponent();
        }

        private void JobApplicationListForm_Load(object sender, EventArgs e)
        {
            if (admin != null)
            {
                JobApplicationController jobApclr = new JobApplicationController();
                List<JobApplication> jobApplicationList = jobApclr.GetJobApplicationsByJobCreator(admin.AdminId);
                dataGridView1.DataSource = jobApplicationList;

            }
            else if (recruiter != null)
            {
                JobApplicationController jobApclr = new JobApplicationController();
                List<JobApplication> jobApplicationList = jobApclr.GetJobApplicationsByJobCreator(recruiter.RecruiterId);
                dataGridView1.DataSource = jobApplicationList;
            }
            else if(admin == null)
            {
                MessageBox.Show("No admin found.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitbutton1_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                this.Hide();
                AdminHomeForm adminHomeForm = new AdminHomeForm(admin);
                adminHomeForm.Show();
            }
            else if (recruiter != null)
            {
                this.Hide();
                RecruiterHomeForm recruiterHomeForm = new RecruiterHomeForm(recruiter);
                recruiterHomeForm.Show();
            }
        }

        private void searchbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin!=null)
                {
                    if (jobidsearchtextbox.Text == "")
                    {
                        MessageBox.Show("Please enter a job Id to search.");
                        return;
                    }
                    else
                    {
                        string jobid = jobidsearchtextbox.Text;
                        JobApplicationController jobApclr = new JobApplicationController();
                        List<JobApplication> jobApplicationList = jobApclr.GetJobApplicationsByJobId(jobid,admin.AdminId);
                        if (jobApplicationList.Count == 0)
                        {
                            MessageBox.Show("No job applications found for the given Job ID.");
                        }
                        else
                        {
                            dataGridView1.DataSource = jobApplicationList;
                        }
                    }

                }
                else if (recruiter != null)
                {
                    if (jobidsearchtextbox.Text == "")
                    {
                        MessageBox.Show("Please enter a job Id to search.");
                        return;
                    }
                    else
                    {
                        string jobid = jobidsearchtextbox.Text;
                        JobApplicationController jobApclr = new JobApplicationController();
                        List<JobApplication> jobApplicationList = jobApclr.GetJobApplicationsByJobId(jobid,recruiter.RecruiterId);
                        if (jobApplicationList.Count == 0)
                        {
                            MessageBox.Show("No job applications found for the given Job ID.");
                        }
                        else
                        {
                            dataGridView1.DataSource = jobApplicationList;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for job applications: " + ex.Message);
                return;
            }
            
        }

        private void jobidsearchtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                JobApplicationController jobApclr = new JobApplicationController();
                List<JobApplication> jobApplicationList = jobApclr.GetJobApplicationsByJobCreator(admin.AdminId);
                dataGridView1.DataSource = jobApplicationList;

                jobidsearchtextbox.Clear();
                jobidsearchtextbox.Enabled = true;


            }
            else if (recruiter != null)
            {
                JobApplicationController jobApclr = new JobApplicationController();
                List<JobApplication> jobApplicationList = jobApclr.GetJobApplicationsByJobCreator(recruiter.RecruiterId);
                dataGridView1.DataSource = jobApplicationList;

                jobidsearchtextbox.Clear();
                jobidsearchtextbox.Enabled = true;
            }
            
        }
    }
}
