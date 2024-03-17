using PredictorUI.Common;
using PredictorUI.Models;
using System.ComponentModel;

namespace PredictorUI
{
    public partial class MatchHistoryForm : Form
    {
        private readonly DataService dataService;
        private SharedData sharedData;
        private MatchService matchService;


        public MatchHistoryForm(SharedData sharedData)
        {
            InitializeComponent();
            this.dataService = new DataService();
            this.sharedData = sharedData;
            this.matchService = new MatchService();

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
            RefreshMatchHistoryGrid();
        }

        private void dgvMatchHistory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectdItem = dgvMatchHistory.SelectedRows[0];
            if (selectdItem != null)
            {
                var pending = (bool)dgvMatchHistory.SelectedRows[0].Cells[1].Value;
                sharedData.MatchId = (int)dgvMatchHistory.SelectedRows[0].Cells[0].Value;
                if (!pending)
                {
                    ShowMatchDetails();
                }
                else
                {
                    DialogResult confirmResult =  MessageBox.Show("Predict this match?", "", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var result = matchService.PredictScore(sharedData.MatchId);
                        if (result != null && result.Equals("Success", StringComparison.CurrentCultureIgnoreCase))
                        {
                            sharedData.LastSimulationSuccess = true;                           
                            ShowMatchDetails();
                            RefreshMatchHistoryGrid();

                        }
                    }
                    else
                    {
                        RefreshMatchHistoryGrid();
                    }
                    //btnSimulatePendingMatch.Enabled = true;
                }
            }
        }

        private void ShowMatchDetails()
        {
            var detailsForm = new MatchDetailsForm(sharedData);
            detailsForm.ShowDialog(this);
        }

 

        private void RefreshMatchHistoryGrid()
        {
            var history = dataService.SearchMatches(sharedData.User);
            var trimmedData = history.Select(h => new { MatchId = h.Id, PendingResult = string.IsNullOrEmpty(h.ScoreCard), MatchDate = h.MatchDate.ToShortDateString(), Venue = h.Venue.Name, UserName = h.UserName }).ToList();
            dgvMatchHistory.DataSource = trimmedData;
        }
    }
}
