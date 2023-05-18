using NLog;
using Rectangle;
using System;
using System.Windows.Forms;

namespace MainLogic
{
    
    public partial class MainForm : Form
    {
        private readonly MainFormViewModel _viewModel = new MainFormViewModel();
        private static Logger logger = LogManager.GetCurrentClassLogger();

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
                logger.Info("Вычислена длина");
                P.Text = _viewModel.GetPerimeter().ToString();
                logger.Info("Вычислен периметр");
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
