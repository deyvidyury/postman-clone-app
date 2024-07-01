namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private async void callApi_Click(object sender, EventArgs e)
        {

            try
            {
                systemStatus.Text = "Calling API...";

                await Task.Delay(2000);

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsText.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error";
            }
        }
    }
}
