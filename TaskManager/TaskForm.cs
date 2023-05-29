using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Database;
using TaskManager.Model;

namespace TaskManager
{
    public partial class TaskForm : Form
    {
        List<Employer> employers;
        List<Project> projects;
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            employers = Postgres.GetAllEmployers();
            projects = Postgres.GetAllProjects();

            cmbProjects.DataSource = projects;
            cmbIspolnitel.DataSource = employers;
            cmbInitiator.DataSource = employers;
        }

        private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project p=cmbProjects.SelectedItem as Project;
            dateStart.MinDate = p.DateStart; dateStart.MaxDate = p.DateEnd;
            dateEnd.MinDate = p.DateStart; dateEnd.MaxDate= p.DateEnd;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Task task = new Task(txtDescription.Text,
                                  dateStart.Value, dateEnd.Value,
                                  cmbInitiator.SelectedItem as Employer,
                                  cmbIspolnitel.SelectedItem as Employer,
                                  cmbProjects.SelectedItem as Project);
            Postgres.SaveTask(task);
        }
    }
}
