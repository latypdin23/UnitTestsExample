using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Employer e=new Employer();
            e.Name = "Dina";
            e.DateOfBirth = new DateTime(1996, 09, 23);

            if(e.DateOfBirth < DateTime.Today)
            {

            }
            int a = 0;
        }
    }
}
