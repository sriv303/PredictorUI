using PredictorUI.Common;
using PredictorUI.Models;
using System.ComponentModel;
using System.Data;

namespace PredictorUI
{
    public partial class SimulationForm : Form
    {
        private BindingList<Player> availablePlayersBindings1 = [];
        private BindingList<Player> availablePlayersBindings2 = [];
        private BindingList<Player> selectedPlayersBindings1 = [];
        private BindingList<Player> selectedPlayersBindings2 = [];
        private AutoCompleteStringCollection aCompl = [];

        private readonly IDataService dataService;
        public SimulationForm()
        {
            InitializeComponent();
            this.dataService = new DataService();
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
            var venues = dataService.GetVenues();
            cmbVenue.DataSource = venues;
            cmbVenue.ValueMember = "Id";
            cmbVenue.DisplayMember = "Profile";
            cmbVenue.SelectedIndex = -1;

            var players = dataService.SearchPlayers("");

            foreach (var player in players)
            {
                availablePlayersBindings1.Add(player);
                availablePlayersBindings2.Add(player);
            }

            var playerNames = players.Select(p => p.PlayerProfile).ToArray();
            aCompl.AddRange(playerNames);

            InitialiseControls(1);
            InitialiseControls(2);

            UpdateControlsState();

            btnAddPlayer1.Enabled = cmbAvailablePlayers1.SelectedIndex != -1;
            btnAddPlayer2.Enabled = cmbAvailablePlayers2.SelectedIndex != -1;

            this.dgvSelectedPlayers1.Columns["Name"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void btnAddPlayer1_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (Models.Player)(cmbAvailablePlayers1.SelectedItem);
            int cntBowlers = selectedPlayersBindings1.Count(p => p.IsBowler || p.IsAllrounder);
            int cntBatsmen = selectedPlayersBindings1.Count(p => p.IsBatsman && !p.IsBowler);

            if (cntBatsmen >= 6 && selectedPlayer.IsBatsman && !selectedPlayer.IsBowler)
            {
                MessageBox.Show("Cannot add more than 6 batsmen");
                btnAddPlayer1.Enabled = false;
            }
            else
            {
                selectedPlayersBindings1.Add(selectedPlayer);
                dgvSelectedPlayers1.DataSource = selectedPlayersBindings1;

                availablePlayersBindings1.Remove(selectedPlayer);
                availablePlayersBindings2.Remove(selectedPlayer);
            }


            UpdateControlsState();
        }


        private void dgvSelectedPlayers1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvSelectedPlayers1.SelectedRows.Count == 1)
            {
                availablePlayersBindings1.Add((Player)dgvSelectedPlayers1.SelectedRows[0].DataBoundItem);
                availablePlayersBindings2.Add((Player)dgvSelectedPlayers1.SelectedRows[0].DataBoundItem);

            }
        }

        private void btnAddPlayer2_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (Models.Player)(cmbAvailablePlayers2.SelectedItem);
            int cntBowlers = selectedPlayersBindings2.Count(p => p.IsBowler || p.IsAllrounder);
            int cntBatsmen = selectedPlayersBindings2.Count(p => p.IsBatsman && !p.IsBowler);

            if (cntBatsmen >= 6 && selectedPlayer.IsBatsman && !selectedPlayer.IsBowler)
            {
                MessageBox.Show("Cannot add more than 6 batsmen");
                btnAddPlayer1.Enabled = false;
            }
            else
            {
                selectedPlayersBindings2.Add(selectedPlayer);
                dgvSelectedPlayers2.DataSource = selectedPlayersBindings2;

                availablePlayersBindings1.Remove(selectedPlayer);
                availablePlayersBindings2.Remove(selectedPlayer);
            }

            UpdateControlsState();
        }

        private void dgvSelectedPlayers2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvSelectedPlayers2.SelectedRows.Count == 1)
            {
                availablePlayersBindings1.Add((Player)dgvSelectedPlayers2.SelectedRows[0].DataBoundItem);
                availablePlayersBindings2.Add((Player)dgvSelectedPlayers2.SelectedRows[0].DataBoundItem);

            }
        }

        private void cmbAvailablePlayers1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPlayer1.Enabled = cmbAvailablePlayers1.SelectedIndex != -1 && selectedPlayersBindings1.Count < 11;

        }
        private void cmbAvailablePlayers2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPlayer2.Enabled = cmbAvailablePlayers2.SelectedIndex != -1 && selectedPlayersBindings2.Count < 11;
        }

        private void InitialiseControls(int team)
        {
            var comboBox = team == 1 ? cmbAvailablePlayers1 : cmbAvailablePlayers2;
            var dataGridView = team == 1 ? dgvSelectedPlayers1 : dgvSelectedPlayers2;
            var availablePlayers = team == 1 ? availablePlayersBindings1 : availablePlayersBindings2;
            var selectedPlayers = team == 1 ? selectedPlayersBindings1 : selectedPlayersBindings2;

            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox.Items.Clear();
            comboBox.DataSource = availablePlayers;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "PlayerProfile";
            comboBox.AutoCompleteCustomSource = aCompl;

            dataGridView.DataSource = selectedPlayers;
            dataGridView.Columns.Remove("PlayerProfile");
            dataGridView.Columns.Remove("Id");
            dataGridView.Columns.Remove("IsBatsman");
            dataGridView.Columns.Remove("IsBowler");
            dataGridView.Columns.Remove("IsAllrounder");
        }
        private void UpdateControlsState()
        {
            cmbAvailablePlayers1.SelectedIndex = -1;
            cmbAvailablePlayers2.SelectedIndex = -1;
            int cntPlayers1 = selectedPlayersBindings1.Count;
            int cntPlayers2 = selectedPlayersBindings2.Count;
            btnConfirmSelection.Enabled = (cntPlayers1 == 11 && cntPlayers2 == 11 && cmbVenue.SelectedIndex!=-1);

            lblPlayerCount1.Text = $"{selectedPlayersBindings1.Count} of 11 players added";
            lblPlayerCount2.Text = $"{selectedPlayersBindings2.Count} of 11 players added";
        }

        private void dgvSelectedPlayers2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateControlsState();
        }

        private void dgvSelectedPlayers1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateControlsState();
        }

        private void btnAutoSelect_Click(object sender, EventArgs e)
        {
            selectedPlayersBindings1.Clear();
            selectedPlayersBindings2.Clear();

            var rnd = new Random();
            var cnt = 0;

            var batsmen = availablePlayersBindings1.Where(p => p.IsBatsman && !p.IsBowler).ToArray();

            while (cnt < 12)
            {
                var p1 = batsmen[rnd.Next(batsmen.Count())];
                if (selectedPlayersBindings1.Count < 6 && !selectedPlayersBindings1.Any(p => p.Id == p1.Id))
                {
                    selectedPlayersBindings1.Add(batsmen[rnd.Next(batsmen.Count())]);
                    cnt++;
                }

                p1 = batsmen[rnd.Next(batsmen.Count())];
                if (selectedPlayersBindings2.Count < 6 && !selectedPlayersBindings2.Any(p => p.Id == p1.Id))
                {
                    selectedPlayersBindings2.Add(batsmen[rnd.Next(batsmen.Count())]);
                    cnt++;
                }
            }
            cnt = 0;

            var bowlers = availablePlayersBindings1.Where(p => p.IsBowler).ToArray();

            while (cnt < 10)
            {
                var p1 = bowlers[rnd.Next(bowlers.Count())];
                if (selectedPlayersBindings1.Count < 11 && !selectedPlayersBindings1.Any(p => p.Id == p1.Id))
                {
                    selectedPlayersBindings1.Add(bowlers[rnd.Next(bowlers.Count())]);
                    cnt++;
                }

                p1 = bowlers[rnd.Next(bowlers.Count())];
                if (selectedPlayersBindings2.Count < 11 && !selectedPlayersBindings2.Any(p => p.Id == p1.Id))
                {
                    selectedPlayersBindings2.Add(bowlers[rnd.Next(bowlers.Count())]);
                    cnt++;
                }
            }

            //btnConfirmSelection.Enabled = true;
            UpdateControlsState();
        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
