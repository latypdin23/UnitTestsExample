using Rectangle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainLogic
{
    
    public partial class MainForm : Form
    {
        private readonly MainFormViewModel _viewModel = new MainFormViewModel();
        public MainForm()
        {
            InitializeComponent();
            txtWidth.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.Width));
            txtLength.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.Length));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                S.Text = _viewModel.GetArea().ToString();
                P.Text = _viewModel.GetPerimeter().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
