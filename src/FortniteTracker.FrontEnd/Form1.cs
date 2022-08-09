using FortniteTracker.Domain;

namespace FortniteTracker.FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            Info.SetResultsFolder();
        }

        private void btnProxies_Click(object sender, EventArgs e)
        {
            Info.SetProxies();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            Info.SetAccounts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Info.Clear();
        }
    }
}