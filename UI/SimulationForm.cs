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

            ResetFocus();

            btnAddPlayer1.Enabled = cmbAvailablePlayers1.SelectedIndex != -1;
            btnAddPlayer2.Enabled = cmbAvailablePlayers2.SelectedIndex != -1;
        }

        private void btnAddPlayer1_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (Models.Player)(cmbAvailablePlayers1.SelectedItem);
            int cntBowlers = selectedPlayersBindings1.Count(p => p.IsBowler);
            int cntBatsmen = selectedPlayersBindings1.Count(p => p.IsBatsman);
            if (cntBatsmen >= 6 && selectedPlayer.IsBatsman)
            {
                MessageBox.Show("Cannot add more than 6 batsmen");
                btnAddPlayer1.Enabled = false;
            }
            else if (cntBowlers >= 5 && selectedPlayer.IsBowler)
            {
                MessageBox.Show("Cannot add more than 5 bowlers");
                btnAddPlayer1.Enabled = false;
            }
            else
            {
                selectedPlayersBindings1.Add(selectedPlayer);
                dgvSelectedPlayers1.DataSource = selectedPlayersBindings1;

                availablePlayersBindings1.Remove(selectedPlayer);
                availablePlayersBindings2.Remove(selectedPlayer);
            }


            ResetFocus();
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
            int cntBowlers = selectedPlayersBindings2.Count(p => p.IsBowler);
            int cntBatsmen = selectedPlayersBindings2.Count(p => p.IsBatsman);
            if (cntBatsmen >= 6 && selectedPlayer.IsBatsman)
            {
                MessageBox.Show("Cannot add more than 6 batsmen");
                btnAddPlayer2.Enabled = false;
            }
            else if (cntBowlers >= 5 && selectedPlayer.IsBowler)
            {
                MessageBox.Show("Cannot add more than 5 bowlers");
                btnAddPlayer2.Enabled = false;
            }
            else
            {
                selectedPlayersBindings2.Add(selectedPlayer);
                dgvSelectedPlayers2.DataSource = selectedPlayersBindings2;

                availablePlayersBindings1.Remove(selectedPlayer);
                availablePlayersBindings2.Remove(selectedPlayer);
            }

            ResetFocus();
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
        private void ResetFocus()
        {
            cmbAvailablePlayers1.SelectedIndex = -1;
            cmbAvailablePlayers2.SelectedIndex = -1;
            int cntPlayers1 = selectedPlayersBindings1.Count;
            int cntPlayers2 = selectedPlayersBindings2.Count;
            btnConfirmSelection.Enabled = (cntPlayers1 == 11 && cntPlayers2 == 11);
        }

        private void dgvSelectedPlayers2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ResetFocus();
        }

        private void dgvSelectedPlayers1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ResetFocus();
        }
    }
}
