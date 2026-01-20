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
    public partial class AllJobsListForm: Form
    {
        private JobSeeker jobSeeker;
        public AllJobsListForm(JobSeeker jobSeeker)
        {
            this.jobSeeker = jobSeeker;
            InitializeComponent();
        }

        private void exitbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobSeekerHomeForm jobSeekerHomeForm = new JobSeekerHomeForm(jobSeeker);
            jobSeekerHomeForm.Show();
        }

        private void searchbutton1_Click(object sender, EventArgs e)
        {
            if(searchtitletextbox.Text == "")
            {
                MessageBox.Show("Please enter a job title to search.");
                return;
            }
            {
                string title = searchtitletextbox.Text;
                JobController jobController = new JobController();
                List<Job> jobList = jobController.SearchJobByTitle(title);

                if (jobList.Count == 0)
                {
                    MessageBox.Show("No jobs found .");
                }
                else
                {
                    dataGridView1.DataSource = jobList;
                    dataGridView1.Columns["JobCreator"].Visible = false;
                }
            }
        }

        private void AllJobsListForm_Load(object sender, EventArgs e)
        {
            JobController jobController = new JobController();
            List<Job> jobList = jobController.GetAllJobs();

                dataGridView1.DataSource = jobList;
                dataGridView1.Columns["JobCreator"].Visible = false; 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1 ) 
            {
                DataGridViewRow dgr = dataGridView1.Rows[e.RowIndex];
                jobidtextbox.Text = dgr.Cells[0].Value.ToString();
                titletextbox.Text = dgr.Cells[1].Value.ToString();
                salarytextbox.Text = dgr.Cells[2].Value.ToString();
            }
        }

        private void jobApplybutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (jobidtextbox.Text == "" || titletextbox.Text == "" || salarytextbox.Text == "")
                {
                    MessageBox.Show("Please select a job to apply.");
                    return;
                }
                else
                {
                    string jobId = jobidtextbox.Text;
                    string title=titletextbox.Text;
                    
                     JobController jobController = new JobController();
                    Job jbb=jobController.ApplyJob(jobId,title);
                    if(jbb == null)
                    {
                        MessageBox.Show("Job not found.");
                        return;
                    }
                    else
                    {
                        JobApplicationController jacr = new JobApplicationController();
                        JobApplication ja = jacr.CheckedApply(jobId, jobSeeker.JobSeekerId);
                        if (ja != null)
                        {
                            MessageBox.Show("You have already applied for this job.");
                            return;
                        }
                        else
                        {
                            DateTime today = DateTime.Now;
                            if (today > jbb.JobDeadline)
                            {
                                MessageBox.Show("You cannot apply for this job as the deadline has passed.");
                                return;

                            }
                            else
                            {
                                float salary = float.Parse(salarytextbox.Text);


                                JobApplicationCountController countController = new JobApplicationCountController();
                                JobApplicationCount jacount = countController.SearchJobApplicationCount(1);
                                int objnum = jacount.JobApplicationObjCount + 1;

                                JobApplicationCount c = new JobApplicationCount(1, objnum);
                                countController.UpdateJobApplicationCount(c);

                                string jobApplicationId = "JAC-" + objnum;
                                JobApplication jobApplication = new JobApplication(jobApplicationId, today, jobSeeker.JobSeekerId, jobSeeker.JobSeekerEmail, jobSeeker.JobSeekerSkill, jobId, title, jbb.JobCreator);
                                jacr.AddJobApplication(jobApplication);

                                MessageBox.Show("You have successfully applied for the job : " + title);
                                jobidtextbox.Clear();
                                titletextbox.Clear();
                                salarytextbox.Clear();
                                searchtitletextbox.Clear();
                                jobidtextbox.Enabled = true;

                                JobController jobCtrlr = new JobController();
                                List<Job> jobList = jobCtrlr.GetAllJobs();

                                dataGridView1.DataSource = jobList;
                                dataGridView1.Columns["JobCreator"].Visible = false;

                            }



                        }
                    }

                       

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying for the job: " + ex.Message);
            }
        }
    }
}
