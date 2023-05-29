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
    public partial class MainForm : Form
    {
        List<Employer> employers;
        List<Project> projects;
        List<Task> tasks;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            employers = Postgres.GetAllEmployers();
            projects = Postgres.GetAllProjects();
            tasks = Postgres.GetAllTasks();

            gridEmployers.DataSource= employers;
            gridTasks.DataSource= tasks;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(TaskForm taskForm=new TaskForm())
            {
                if(taskForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
