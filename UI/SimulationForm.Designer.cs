namespace PredictorUI
{
    partial class SimulationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cmbAvailablePlayers1 = new ComboBox();
            btnAddPlayer1 = new Button();
            dgvSelectedPlayers1 = new DataGridView();
            groupBox1 = new GroupBox();
            lblPlayerCount1 = new Label();
            groupBox2 = new GroupBox();
            lblPlayerCount2 = new Label();
            cmbAvailablePlayers2 = new ComboBox();
            dgvSelectedPlayers2 = new DataGridView();
            btnAddPlayer2 = new Button();
            btnConfirmSelection = new Button();
            btnAutoSelect = new Button();
            cmbVenue = new ComboBox();
            lblVenue = new Label();
            btnClear = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvSelectedPlayers1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedPlayers2).BeginInit();
            SuspendLayout();
            // 
            // cmbAvailablePlayers1
            // 
            cmbAvailablePlayers1.FormattingEnabled = true;
            cmbAvailablePlayers1.Location = new Point(21, 62);
            cmbAvailablePlayers1.Name = "cmbAvailablePlayers1";
            cmbAvailablePlayers1.Size = new Size(296, 25);
            cmbAvailablePlayers1.Sorted = true;
            cmbAvailablePlayers1.TabIndex = 0;
            cmbAvailablePlayers1.SelectedIndexChanged += cmbAvailablePlayers1_SelectedIndexChanged;
            // 
            // btnAddPlayer1
            // 
            btnAddPlayer1.Font = new Font("Segoe UI", 9.75F);
            btnAddPlayer1.Location = new Point(355, 62);
            btnAddPlayer1.Name = "btnAddPlayer1";
            btnAddPlayer1.Size = new Size(75, 23);
            btnAddPlayer1.TabIndex = 6;
            btnAddPlayer1.Text = "Add Player";
            btnAddPlayer1.UseVisualStyleBackColor = true;
            btnAddPlayer1.Click += btnAddPlayer1_Click;
            // 
            // dgvSelectedPlayers1
            // 
            dgvSelectedPlayers1.AllowUserToAddRows = false;
            dgvSelectedPlayers1.AllowUserToOrderColumns = true;
            dgvSelectedPlayers1.AllowUserToResizeColumns = false;
            dgvSelectedPlayers1.AllowUserToResizeRows = false;
            dgvSelectedPlayers1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelectedPlayers1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectedPlayers1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSelectedPlayers1.Location = new Point(21, 129);
            dgvSelectedPlayers1.MultiSelect = false;
            dgvSelectedPlayers1.Name = "dgvSelectedPlayers1";
            dgvSelectedPlayers1.ReadOnly = true;
            dgvSelectedPlayers1.ShowEditingIcon = false;
            dgvSelectedPlayers1.Size = new Size(507, 340);
            dgvSelectedPlayers1.TabIndex = 9;
            dgvSelectedPlayers1.UserDeletedRow += dgvSelectedPlayers1_UserDeletedRow;
            dgvSelectedPlayers1.UserDeletingRow += dgvSelectedPlayers1_UserDeletingRow;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(lblPlayerCount1);
            groupBox1.Controls.Add(cmbAvailablePlayers1);
            groupBox1.Controls.Add(dgvSelectedPlayers1);
            groupBox1.Controls.Add(btnAddPlayer1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Team A";
            // 
            // lblPlayerCount1
            // 
            lblPlayerCount1.AutoSize = true;
            lblPlayerCount1.Font = new Font("Segoe UI", 9.75F);
            lblPlayerCount1.Location = new Point(21, 103);
            lblPlayerCount1.Name = "lblPlayerCount1";
            lblPlayerCount1.Size = new Size(79, 17);
            lblPlayerCount1.TabIndex = 10;
            lblPlayerCount1.Text = "Player count";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblPlayerCount2);
            groupBox2.Controls.Add(cmbAvailablePlayers2);
            groupBox2.Controls.Add(dgvSelectedPlayers2);
            groupBox2.Controls.Add(btnAddPlayer2);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(644, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 495);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Team B";
            // 
            // lblPlayerCount2
            // 
            lblPlayerCount2.AutoSize = true;
            lblPlayerCount2.Location = new Point(21, 103);
            lblPlayerCount2.Name = "lblPlayerCount2";
            lblPlayerCount2.Size = new Size(79, 17);
            lblPlayerCount2.TabIndex = 10;
            lblPlayerCount2.Text = "Player count";
            // 
            // cmbAvailablePlayers2
            // 
            cmbAvailablePlayers2.FormattingEnabled = true;
            cmbAvailablePlayers2.Location = new Point(21, 62);
            cmbAvailablePlayers2.Name = "cmbAvailablePlayers2";
            cmbAvailablePlayers2.Size = new Size(298, 25);
            cmbAvailablePlayers2.Sorted = true;
            cmbAvailablePlayers2.TabIndex = 0;
            cmbAvailablePlayers2.SelectedIndexChanged += cmbAvailablePlayers2_SelectedIndexChanged;
            // 
            // dgvSelectedPlayers2
            // 
            dgvSelectedPlayers2.AllowUserToAddRows = false;
            dgvSelectedPlayers2.AllowUserToOrderColumns = true;
            dgvSelectedPlayers2.AllowUserToResizeColumns = false;
            dgvSelectedPlayers2.AllowUserToResizeRows = false;
            dgvSelectedPlayers2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelectedPlayers2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectedPlayers2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSelectedPlayers2.Location = new Point(21, 129);
            dgvSelectedPlayers2.MultiSelect = false;
            dgvSelectedPlayers2.Name = "dgvSelectedPlayers2";
            dgvSelectedPlayers2.ReadOnly = true;
            dgvSelectedPlayers2.ShowEditingIcon = false;
            dgvSelectedPlayers2.Size = new Size(487, 340);
            dgvSelectedPlayers2.TabIndex = 9;
            dgvSelectedPlayers2.UserDeletedRow += dgvSelectedPlayers2_UserDeletedRow;
            dgvSelectedPlayers2.UserDeletingRow += dgvSelectedPlayers2_UserDeletingRow;
            // 
            // btnAddPlayer2
            // 
            btnAddPlayer2.Font = new Font("Segoe UI", 9.75F);
            btnAddPlayer2.Location = new Point(355, 62);
            btnAddPlayer2.Name = "btnAddPlayer2";
            btnAddPlayer2.Size = new Size(75, 23);
            btnAddPlayer2.TabIndex = 6;
            btnAddPlayer2.Text = "Add Player";
            btnAddPlayer2.UseVisualStyleBackColor = true;
            btnAddPlayer2.Click += btnAddPlayer2_Click;
            // 
            // btnConfirmSelection
            // 
            btnConfirmSelection.BackColor = SystemColors.MenuBar;
            btnConfirmSelection.Enabled = false;
            btnConfirmSelection.Font = new Font("Segoe UI", 9.75F);
            btnConfirmSelection.ForeColor = SystemColors.Highlight;
            btnConfirmSelection.Location = new Point(584, 629);
            btnConfirmSelection.Name = "btnConfirmSelection";
            btnConfirmSelection.Size = new Size(209, 59);
            btnConfirmSelection.TabIndex = 12;
            btnConfirmSelection.Text = "Confirm Selection";
            btnConfirmSelection.UseVisualStyleBackColor = false;
            btnConfirmSelection.Click += btnConfirmSelection_Click;
            // 
            // btnAutoSelect
            // 
            btnAutoSelect.BackColor = SystemColors.MenuBar;
            btnAutoSelect.Font = new Font("Segoe UI", 9.75F);
            btnAutoSelect.ForeColor = SystemColors.Highlight;
            btnAutoSelect.Location = new Point(351, 629);
            btnAutoSelect.Name = "btnAutoSelect";
            btnAutoSelect.Size = new Size(209, 59);
            btnAutoSelect.TabIndex = 13;
            btnAutoSelect.Text = "Auto Select Teams";
            btnAutoSelect.UseVisualStyleBackColor = false;
            btnAutoSelect.Click += btnAutoSelect_Click;
            // 
            // cmbVenue
            // 
            cmbVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbVenue.FormattingEnabled = true;
            cmbVenue.Location = new Point(77, 62);
            cmbVenue.Name = "cmbVenue";
            cmbVenue.Size = new Size(292, 23);
            cmbVenue.Sorted = true;
            cmbVenue.TabIndex = 14;
            cmbVenue.SelectedIndexChanged += cmbVenue_SelectedIndexChanged;
            // 
            // lblVenue
            // 
            lblVenue.AutoSize = true;
            lblVenue.Font = new Font("Segoe UI", 9.75F);
            lblVenue.Location = new Point(32, 65);
            lblVenue.Name = "lblVenue";
            lblVenue.Size = new Size(43, 17);
            lblVenue.TabIndex = 15;
            lblVenue.Text = "Venue";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuBar;
            btnClear.Font = new Font("Segoe UI", 9.75F);
            btnClear.Location = new Point(809, 629);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(209, 59);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // SimulationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1242, 728);
            Controls.Add(btnClear);
            Controls.Add(lblVenue);
            Controls.Add(cmbVenue);
            Controls.Add(btnAutoSelect);
            Controls.Add(btnConfirmSelection);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SimulationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Predictor - Match Simulation";
            FormClosed += SimulationForm_FormClosed;
            Load += SimulationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSelectedPlayers1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedPlayers2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAvailablePlayers1;
        private Button btnAddPlayer1;
        private DataGridView dgvSelectedPlayers1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmbAvailablePlayers2;
        private DataGridView dgvSelectedPlayers2;
        private Button btnAddPlayer2;
        private Button btnConfirmSelection;
        private Label lblPlayerCount1;
        private Label lblPlayerCount2;
        private Button btnAutoSelect;
        private ComboBox cmbVenue;
        private Label lblVenue;
        private Button btnClear;
        private System.Windows.Forms.Timer timer1;
    }
}