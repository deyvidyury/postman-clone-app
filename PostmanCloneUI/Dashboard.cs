using PostmanCloneLibrary;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess apiAccess = new ApiAccess();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private async void callApi_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API...";
            resultsText.Text = "";

            if (apiAccess.IsValidUrl(apiText.Text) == false)
            {
                systemStatus.Text = "Invalid URL";
                return;
            }

            try
            {
                resultsText.Text = await apiAccess.CallApiAsync(apiText.Text);

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
