using PredictorUI.Common;
using PredictorUI.Models;
using System.ComponentModel;

namespace PredictorUI
{
    public partial class MatchHistoryForm : Form
    {
        private readonly DataService dataService;
        private SharedData sharedData;


        public MatchHistoryForm(SharedData sharedData)
        {
            InitializeComponent();
            this.dataService = new DataService();
            this.sharedData = sharedData;

            if (sharedData.LastSimulationSuccess)
            {
                ShowMatchDetails();
                sharedData.LastSimulationSuccess = false;                
            }
        }

        private void MatchHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sharedData.WelcomeForm.Show();
        }

        private void MatchHistoryForm_Load(object sender, EventArgs e)
        {
            var history = dataService.SearchMatches(sharedData.User);
            var trimmedData = history.Select(h => new { MatchId = h.Id, PendingResult = string.IsNullOrEmpty(h.ScoreCard), MatchDate = h.MatchDate.ToShortDateString(), Venue = h.Venue.Name, UserName = h.UserName }).ToList();
            dgvMatchHistory.DataSource = trimmedData;

        }

        private void dgvMatchHistory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectdItem = dgvMatchHistory.SelectedRows[0];
            if (selectdItem != null)
            {
                var pending = (bool)dgvMatchHistory.SelectedRows[0].Cells[1].Value;
                if (!pending)
                {
                    sharedData.MatchId = (int)dgvMatchHistory.SelectedRows[0].Cells[0].Value;
                    ShowMatchDetails();
                }
                else
                {
                    MessageBox.Show("This match is not predicted yet");
                }
            }
        }

        private void ShowMatchDetails()
        {
            var detailsForm = new MatchDetailsForm(sharedData);
            detailsForm.ShowDialog(this);
        }
    }
}
