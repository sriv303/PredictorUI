using PredictorUI.Common;
using PredictorUI.Models;
using System.ComponentModel;

namespace PredictorUI
{
    public partial class MatchDetailsForm : Form
    {

        private readonly DataService dataService;
        private readonly MatchService matchService;
        private SharedData sharedData;
        public MatchDetailsForm(SharedData sharedData)

        {
            InitializeComponent();
            dataService = new DataService();
            matchService = new MatchService();
            this.sharedData = sharedData;
        }

        private void MatchDetailsForm_Load(object sender, EventArgs e)
        {
            var matchDetails = dataService.GetMatchDetails(sharedData.MatchId);

            if (matchDetails == null)
            {
                MessageBox.Show("Cannot find the match details"); return;
            }

            var matchReport = matchService.TranformScoreCard(matchDetails);
            dgvBattingCardA.DataSource = new BindingList<BattingStats>(matchReport.TeamAInnings.BattingCard.ToList());
            dgvBattingCardB.DataSource = new BindingList<BattingStats>(matchReport.TeamBInnings.BattingCard.ToList());
            dgvBowlingCardA.DataSource = new BindingList<BowlingStats>(matchReport.TeamAInnings.BowlingCard.ToList());
            dgvBowlingCardB.DataSource = new BindingList<BowlingStats>(matchReport.TeamBInnings.BowlingCard.ToList());
            dgvBattingCardA.Columns.Remove("IsOut");
            dgvBattingCardB.Columns.Remove("IsOut");
            dgvBowlingCardA.Columns.Remove("BallsBowled");
            dgvBowlingCardB.Columns.Remove("BallsBowled");

            lblMatchID.Text = matchReport.MatchId.ToString();
            lblMatchDate.Text = matchReport.MatchDate.ToShortDateString();
            lblVenue.Text = matchReport.VenueName;
            lblMatchResult.Text = matchReport.Result;
            lblTeamAScore.Text = $"{matchReport.TeamAInnings.InningsTotal}/{matchReport.TeamAInnings.InningsWickets} from {matchReport.TeamAInnings.OversCount} overs";
            lblTeamBScore.Text = $"{matchReport.TeamBInnings.InningsTotal}/{matchReport.TeamBInnings.InningsWickets} from {matchReport.TeamBInnings.OversCount} overs";
        }
    }
}
