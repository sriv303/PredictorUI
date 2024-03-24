namespace PredictorUI
{
    partial class MatchDetailsForm
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
            lblMatchDateHeading = new Label();
            lblMatchDate = new Label();
            lblVenueHeading = new Label();
            lblVenue = new Label();
            dgvBattingCardA = new DataGridView();
            dgvBattingCardB = new DataGridView();
            dgvBowlingCardA = new DataGridView();
            dgvBowlingCardB = new DataGridView();
            lblMatchResult = new Label();
            lblTeamAScore = new Label();
            lblTeamBScore = new Label();
            lblTeamABattingHeading = new Label();
            lblTeamBBowlingHeading = new Label();
            lblTeamBBattingHeading = new Label();
            lblTeamABowlingHeading = new Label();
            lblMatchIDHeading = new Label();
            lblMatchID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBattingCardA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBattingCardB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBowlingCardA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBowlingCardB).BeginInit();
            SuspendLayout();
            // 
            // lblMatchDateHeading
            // 
            lblMatchDateHeading.AutoSize = true;
            lblMatchDateHeading.Font = new Font("Segoe UI", 9.75F);
            lblMatchDateHeading.Location = new Point(564, 44);
            lblMatchDateHeading.Name = "lblMatchDateHeading";
            lblMatchDateHeading.Size = new Size(78, 17);
            lblMatchDateHeading.TabIndex = 0;
            lblMatchDateHeading.Text = "Match Date:";
            // 
            // lblMatchDate
            // 
            lblMatchDate.AutoSize = true;
            lblMatchDate.Font = new Font("Segoe UI", 9.75F);
            lblMatchDate.Location = new Point(648, 44);
            lblMatchDate.Name = "lblMatchDate";
            lblMatchDate.Size = new Size(73, 17);
            lblMatchDate.TabIndex = 1;
            lblMatchDate.Text = "13th march";
            // 
            // lblVenueHeading
            // 
            lblVenueHeading.AutoSize = true;
            lblVenueHeading.Font = new Font("Segoe UI", 9.75F);
            lblVenueHeading.Location = new Point(739, 44);
            lblVenueHeading.Name = "lblVenueHeading";
            lblVenueHeading.Size = new Size(46, 17);
            lblVenueHeading.TabIndex = 2;
            lblVenueHeading.Text = "Venue:";
            // 
            // lblVenue
            // 
            lblVenue.AutoSize = true;
            lblVenue.Font = new Font("Segoe UI", 9.75F);
            lblVenue.Location = new Point(787, 44);
            lblVenue.Name = "lblVenue";
            lblVenue.Size = new Size(90, 17);
            lblVenue.TabIndex = 3;
            lblVenue.Text = "Eden Gardens";
            // 
            // dgvBattingCardA
            // 
            dgvBattingCardA.AllowUserToAddRows = false;
            dgvBattingCardA.AllowUserToDeleteRows = false;
            dgvBattingCardA.AllowUserToResizeColumns = false;
            dgvBattingCardA.AllowUserToResizeRows = false;
            dgvBattingCardA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBattingCardA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBattingCardA.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBattingCardA.Location = new Point(31, 110);
            dgvBattingCardA.Name = "dgvBattingCardA";
            dgvBattingCardA.ReadOnly = true;
            dgvBattingCardA.Size = new Size(600, 340);
            dgvBattingCardA.TabIndex = 4;
            // 
            // dgvBattingCardB
            // 
            dgvBattingCardB.AllowUserToAddRows = false;
            dgvBattingCardB.AllowUserToDeleteRows = false;
            dgvBattingCardB.AllowUserToResizeColumns = false;
            dgvBattingCardB.AllowUserToResizeRows = false;
            dgvBattingCardB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBattingCardB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBattingCardB.Location = new Point(669, 110);
            dgvBattingCardB.Name = "dgvBattingCardB";
            dgvBattingCardB.ReadOnly = true;
            dgvBattingCardB.Size = new Size(600, 340);
            dgvBattingCardB.TabIndex = 5;
            // 
            // dgvBowlingCardA
            // 
            dgvBowlingCardA.AllowUserToAddRows = false;
            dgvBowlingCardA.AllowUserToDeleteRows = false;
            dgvBowlingCardA.AllowUserToResizeColumns = false;
            dgvBowlingCardA.AllowUserToResizeRows = false;
            dgvBowlingCardA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBowlingCardA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBowlingCardA.Location = new Point(31, 507);
            dgvBowlingCardA.Name = "dgvBowlingCardA";
            dgvBowlingCardA.ReadOnly = true;
            dgvBowlingCardA.Size = new Size(600, 227);
            dgvBowlingCardA.TabIndex = 6;
            // 
            // dgvBowlingCardB
            // 
            dgvBowlingCardB.AllowUserToAddRows = false;
            dgvBowlingCardB.AllowUserToDeleteRows = false;
            dgvBowlingCardB.AllowUserToResizeColumns = false;
            dgvBowlingCardB.AllowUserToResizeRows = false;
            dgvBowlingCardB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBowlingCardB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBowlingCardB.Location = new Point(669, 507);
            dgvBowlingCardB.Name = "dgvBowlingCardB";
            dgvBowlingCardB.ReadOnly = true;
            dgvBowlingCardB.Size = new Size(600, 227);
            dgvBowlingCardB.TabIndex = 7;
            // 
            // lblMatchResult
            // 
            lblMatchResult.AutoSize = true;
            lblMatchResult.Font = new Font("Segoe UI", 9.75F);
            lblMatchResult.Location = new Point(615, 774);
            lblMatchResult.Name = "lblMatchResult";
            lblMatchResult.Size = new Size(80, 17);
            lblMatchResult.TabIndex = 8;
            lblMatchResult.Text = "Match result";
            // 
            // lblTeamAScore
            // 
            lblTeamAScore.AutoSize = true;
            lblTeamAScore.Font = new Font("Segoe UI", 9.75F);
            lblTeamAScore.Location = new Point(484, 453);
            lblTeamAScore.Name = "lblTeamAScore";
            lblTeamAScore.Size = new Size(88, 17);
            lblTeamAScore.TabIndex = 9;
            lblTeamAScore.Text = "Team A Score";
            // 
            // lblTeamBScore
            // 
            lblTeamBScore.AutoSize = true;
            lblTeamBScore.Font = new Font("Segoe UI", 9.75F);
            lblTeamBScore.Location = new Point(1116, 453);
            lblTeamBScore.Name = "lblTeamBScore";
            lblTeamBScore.Size = new Size(87, 17);
            lblTeamBScore.TabIndex = 10;
            lblTeamBScore.Text = "Team B Score";
            // 
            // lblTeamABattingHeading
            // 
            lblTeamABattingHeading.AutoSize = true;
            lblTeamABattingHeading.Location = new Point(31, 90);
            lblTeamABattingHeading.Name = "lblTeamABattingHeading";
            lblTeamABattingHeading.Size = new Size(95, 17);
            lblTeamABattingHeading.TabIndex = 11;
            lblTeamABattingHeading.Text = "Team A Batting";
            // 
            // lblTeamBBowlingHeading
            // 
            lblTeamBBowlingHeading.AutoSize = true;
            lblTeamBBowlingHeading.Location = new Point(31, 486);
            lblTeamBBowlingHeading.Name = "lblTeamBBowlingHeading";
            lblTeamBBowlingHeading.Size = new Size(99, 17);
            lblTeamBBowlingHeading.TabIndex = 12;
            lblTeamBBowlingHeading.Text = "Team B Bowling";
            // 
            // lblTeamBBattingHeading
            // 
            lblTeamBBattingHeading.AutoSize = true;
            lblTeamBBattingHeading.Location = new Point(689, 90);
            lblTeamBBattingHeading.Name = "lblTeamBBattingHeading";
            lblTeamBBattingHeading.Size = new Size(94, 17);
            lblTeamBBattingHeading.TabIndex = 13;
            lblTeamBBattingHeading.Text = "Team B Batting";
            // 
            // lblTeamABowlingHeading
            // 
            lblTeamABowlingHeading.AutoSize = true;
            lblTeamABowlingHeading.Location = new Point(669, 486);
            lblTeamABowlingHeading.Name = "lblTeamABowlingHeading";
            lblTeamABowlingHeading.Size = new Size(100, 17);
            lblTeamABowlingHeading.TabIndex = 14;
            lblTeamABowlingHeading.Text = "Team A Bowling";
            // 
            // lblMatchIDHeading
            // 
            lblMatchIDHeading.AutoSize = true;
            lblMatchIDHeading.Font = new Font("Segoe UI", 9.75F);
            lblMatchIDHeading.Location = new Point(465, 44);
            lblMatchIDHeading.Name = "lblMatchIDHeading";
            lblMatchIDHeading.Size = new Size(67, 17);
            lblMatchIDHeading.TabIndex = 15;
            lblMatchIDHeading.Text = "Match ID: ";
            // 
            // lblMatchID
            // 
            lblMatchID.AutoSize = true;
            lblMatchID.Font = new Font("Segoe UI", 9.75F);
            lblMatchID.Location = new Point(528, 44);
            lblMatchID.Name = "lblMatchID";
            lblMatchID.Size = new Size(20, 17);
            lblMatchID.TabIndex = 16;
            lblMatchID.Text = "-1";
            // 
            // MatchDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1302, 823);
            Controls.Add(lblMatchID);
            Controls.Add(lblMatchIDHeading);
            Controls.Add(lblTeamABowlingHeading);
            Controls.Add(lblTeamBBattingHeading);
            Controls.Add(lblTeamBBowlingHeading);
            Controls.Add(lblTeamABattingHeading);
            Controls.Add(lblTeamBScore);
            Controls.Add(lblTeamAScore);
            Controls.Add(lblMatchResult);
            Controls.Add(dgvBowlingCardB);
            Controls.Add(dgvBowlingCardA);
            Controls.Add(dgvBattingCardB);
            Controls.Add(dgvBattingCardA);
            Controls.Add(lblVenue);
            Controls.Add(lblVenueHeading);
            Controls.Add(lblMatchDate);
            Controls.Add(lblMatchDateHeading);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MatchDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Predictor - Match Details";
            Load += MatchDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBattingCardA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBattingCardB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBowlingCardA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBowlingCardB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatchDateHeading;
        private Label lblMatchDate;
        private Label lblVenueHeading;
        private Label lblVenue;
        private DataGridView dgvBattingCardA;
        private DataGridView dgvBattingCardB;
        private DataGridView dgvBowlingCardA;
        private DataGridView dgvBowlingCardB;
        private Label lblMatchResult;
        private Label lblTeamAScore;
        private Label lblTeamBScore;
        private Label lblTeamABattingHeading;
        private Label lblTeamBBowlingHeading;
        private Label lblTeamBBattingHeading;
        private Label lblTeamABowlingHeading;
        private Label lblMatchIDHeading;
        private Label lblMatchID;
    }
}