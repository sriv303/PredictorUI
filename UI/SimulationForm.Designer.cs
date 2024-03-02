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
            cmbAvailablePlayers1 = new ComboBox();
            btnAddPlayer1 = new Button();
            dgvSelectedPlayers1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cmbAvailablePlayers2 = new ComboBox();
            dgvSelectedPlayers2 = new DataGridView();
            btnAddPlayer2 = new Button();
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
            cmbAvailablePlayers1.Size = new Size(296, 23);
            cmbAvailablePlayers1.Sorted = true;
            cmbAvailablePlayers1.TabIndex = 0;
            cmbAvailablePlayers1.SelectedIndexChanged += cmbAvailablePlayers1_SelectedIndexChanged;
            // 
            // btnAddPlayer1
            // 
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
            dgvSelectedPlayers1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectedPlayers1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSelectedPlayers1.Location = new Point(21, 129);
            dgvSelectedPlayers1.MultiSelect = false;
            dgvSelectedPlayers1.Name = "dgvSelectedPlayers1";
            dgvSelectedPlayers1.ReadOnly = true;
            dgvSelectedPlayers1.ShowEditingIcon = false;
            dgvSelectedPlayers1.Size = new Size(409, 336);
            dgvSelectedPlayers1.TabIndex = 9;
            dgvSelectedPlayers1.UserDeletingRow += dgvSelectedPlayers1_UserDeletingRow;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cmbAvailablePlayers1);
            groupBox1.Controls.Add(dgvSelectedPlayers1);
            groupBox1.Controls.Add(btnAddPlayer1);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 471);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Team A";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(cmbAvailablePlayers2);
            groupBox2.Controls.Add(dgvSelectedPlayers2);
            groupBox2.Controls.Add(btnAddPlayer2);
            groupBox2.Location = new Point(608, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 465);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Team B";
            // 
            // cmbAvailablePlayers2
            // 
            cmbAvailablePlayers2.FormattingEnabled = true;
            cmbAvailablePlayers2.Location = new Point(21, 62);
            cmbAvailablePlayers2.Name = "cmbAvailablePlayers2";
            cmbAvailablePlayers2.Size = new Size(298, 23);
            cmbAvailablePlayers2.Sorted = true;
            cmbAvailablePlayers2.TabIndex = 0;
            cmbAvailablePlayers2.SelectedIndexChanged += cmbAvailablePlayers2_SelectedIndexChanged;
            // 
            // dgvSelectedPlayers2
            // 
            dgvSelectedPlayers2.AllowUserToAddRows = false;
            dgvSelectedPlayers2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectedPlayers2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSelectedPlayers2.Location = new Point(21, 129);
            dgvSelectedPlayers2.MultiSelect = false;
            dgvSelectedPlayers2.Name = "dgvSelectedPlayers2";
            dgvSelectedPlayers2.ReadOnly = true;
            dgvSelectedPlayers2.ShowEditingIcon = false;
            dgvSelectedPlayers2.Size = new Size(409, 330);
            dgvSelectedPlayers2.TabIndex = 9;
            dgvSelectedPlayers2.UserDeletingRow += dgvSelectedPlayers2_UserDeletingRow;
            // 
            // btnAddPlayer2
            // 
            btnAddPlayer2.Location = new Point(355, 62);
            btnAddPlayer2.Name = "btnAddPlayer2";
            btnAddPlayer2.Size = new Size(75, 23);
            btnAddPlayer2.TabIndex = 6;
            btnAddPlayer2.Text = "Add Player";
            btnAddPlayer2.UseVisualStyleBackColor = true;
            btnAddPlayer2.Click += btnAddPlayer2_Click;
            // 
            // SimulationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 558);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SimulationForm";
            Text = "SimulationForm";
            Load += SimulationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSelectedPlayers1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSelectedPlayers2).EndInit();
            ResumeLayout(false);
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
    }
}