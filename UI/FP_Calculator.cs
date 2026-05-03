namespace Function_Point_Calculator
{
    public partial class FP_Calculator : Form
    {
        public FP_Calculator()
        {
            InitializeComponent();
        }

        private void FP_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnManualDI_Click(object sender, EventArgs e)
        {
            using (UI.DI_Calculator diForm = new UI.DI_Calculator())
            {
                if (diForm.ShowDialog() == DialogResult.OK)
                {
                    // txtDI.Text = diForm.FinalDI.ToString();
                }
            }
        }
    }
}
