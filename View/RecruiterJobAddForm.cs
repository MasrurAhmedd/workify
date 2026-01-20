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
using System.Security.Cryptography;

namespace Online_Job_Management_System_Kamao.View
{
    public partial class RecruiterJobAddForm: Form
    {
        private Recruiter recruiter;
        public RecruiterJobAddForm(Recruiter recruiter)
        {
            this.recruiter = recruiter;
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecruiterHomeForm rhf = new RecruiterHomeForm(recruiter);
            rhf.Show();
        }

        private void JobAddForm_Load(object sender, EventArgs e)
        {
           
                JobController jcr = new JobController();
                List<Job> joblistByCreator = jcr.SearchJobByCreator(recruiter.RecruiterId);
                dataGridView1.DataSource = joblistByCreator;
                dataGridView1.Columns["JobCreator"].Visible = false;

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (titletextbox.Text == "" || salarytextbox.Text == "" || descriptiontextbox.Text == "")
                {
                    MessageBox.Show("Please fill all the fields Except Job Id.");
                }
                else
                {
                    if(jobidtextbox.Text != "")
                    {
                        MessageBox.Show("Job Id is auto-generated. Please leave it blank.");
                        return;
                    }
                    else
                    {
                        DateTime today = DateTime.Now;
                        if (today > dateTimePicker1.Value)
                        {
                            MessageBox.Show("Job deadline cannot be before the post date.");
                        }
                        else
                        {
                            string title = titletextbox.Text;
                            float salary = float.Parse(salarytextbox.Text);
                            string description = descriptiontextbox.Text;
                            DateTime deadline = dateTimePicker1.Value;


                            JobCountController jobcountController = new JobCountController();
                            JobCount count = jobcountController.SearchJobCount(1);
                            int objnum = count.JobCountObj + 1;

                            JobCount c = new JobCount(1, objnum);
                            jobcountController.UpdateJobCount(c);
                            string jbId = "Job-" + objnum;

                            JobCountController jbc = new JobCountController();
                            JobCount jc = jbc.SearchJobCount(1);


                            string creator = recruiter.RecruiterId;

                            Job job = new Job(jbId, title, salary, description, today, deadline, creator);

                            JobController jcr = new JobController();
                            jcr.AddJob(job);
                            MessageBox.Show("Job added successfully.");
                            titletextbox.Clear();
                            salarytextbox.Clear();
                            descriptiontextbox.Clear();
                            dateTimePicker1.Value = DateTime.Now;
                            jobidtextbox.Clear();


                            List<Job> joblistByCreator = jcr.SearchJobByCreator(recruiter.RecruiterId);
                            dataGridView1.DataSource = joblistByCreator;
                            dataGridView1.Columns["JobCreator"].Visible = false;


                        }
                    }
                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        
         
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgr = dataGridView1.Rows[e.RowIndex];
                jobidtextbox.Text = dgr.Cells[0].Value.ToString();
                titletextbox.Text = dgr.Cells[1].Value.ToString();
                salarytextbox.Text = dgr.Cells[2].Value.ToString();
                descriptiontextbox.Text = dgr.Cells[3].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dgr.Cells[5].Value.ToString());
            }

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (jobidtextbox.Text == "" || titletextbox.Text == "" || salarytextbox.Text == "" || descriptiontextbox.Text == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                    return;
                }
                else
                {
                    DateTime today = DateTime.Now;
                    if (today > dateTimePicker1.Value)
                    {
                        MessageBox.Show("Job deadline cannot be before the post date.");
                    }
                    else
                    {
                        string jobid = jobidtextbox.Text;
                        JobController jcr= new JobController();
                        Job jb=jcr.SearchJob(jobid, recruiter.RecruiterId);
                        if (jb==null)
                        {
                            MessageBox.Show("This job does not exist.");
                        }
                        else
                        {
                            string title = titletextbox.Text;
                            float salary = float.Parse(salarytextbox.Text);
                            string description = descriptiontextbox.Text;
                            DateTime deadline = dateTimePicker1.Value;

                            Job jbu = new Job(jobid,title,salary,description,today,deadline,recruiter.RecruiterId);
                            jcr.UpdateJob(jbu);
                            MessageBox.Show("Job updated successfully.");
                            titletextbox.Clear();
                            salarytextbox.Clear();
                            descriptiontextbox.Clear();
                            dateTimePicker1.Value = DateTime.Now;
                            jobidtextbox.Clear();

                            List<Job> joblistByCreator = jcr.SearchJobByCreator(recruiter.RecruiterId);
                            dataGridView1.DataSource = joblistByCreator;
                            dataGridView1.Columns["JobCreator"].Visible = false;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            titletextbox.Clear();
            salarytextbox.Clear();
            descriptiontextbox.Clear();
            jobidtextbox.Clear();
            dateTimePicker1.Value = DateTime.Now;
            titletextbox.Enabled = true;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(jobidtextbox.Text == "")
                {
                    MessageBox.Show("Please enter the Job Id to delete.");
                    return;
                }
                else
                {
                    string jobid = jobidtextbox.Text;
                    JobController jcr = new JobController();
                    Job jb = jcr.SearchJob(jobid, recruiter.RecruiterId);
                    if (jb == null)
                    {
                        MessageBox.Show("This job does not exist.");
                    }
                    else
                    {
                        JobApplicationController jobApplicationController = new JobApplicationController();
                        jobApplicationController.DeleteJobApplicationByJobId(jobid);

                        jcr.DeleteJob(jobid);
                        MessageBox.Show("Job deleted successfully.");
                        jobidtextbox.Clear();
                        titletextbox.Clear();
                        salarytextbox.Clear();
                        descriptiontextbox.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                        List<Job> joblistByCreator = jcr.SearchJobByCreator(recruiter.RecruiterId);
                        dataGridView1.DataSource = joblistByCreator;
                        dataGridView1.Columns["JobCreator"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (jobidtextbox.Text == "")
                {
                    MessageBox.Show("Please enter the Job Id to search.");
                    return;
                }
                else
                {
                    string jobid = jobidtextbox.Text;
                    JobController jcr = new JobController();
                    Job jb = jcr.SearchJob(jobid, recruiter.RecruiterId);
                    if (jb == null)
                    {
                        MessageBox.Show("This job does not exist.");
                    }
                    else
                    {
                        titletextbox.Text = jb.JobTitle;
                        salarytextbox.Text = jb.JobSalary.ToString();
                        descriptiontextbox.Text = jb.JobDescription;
                        dateTimePicker1.Value = jb.JobDeadline;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }     
        }
    }
}
