namespace PredictorUI
{
    partial class MatchHistoryForm
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
            dgvMatchHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMatchHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvMatchHistory
            // 
            dgvMatchHistory.AllowUserToAddRows = false;
            dgvMatchHistory.AllowUserToDeleteRows = false;
            dgvMatchHistory.AllowUserToResizeColumns = false;
            dgvMatchHistory.AllowUserToResizeRows = false;
            dgvMatchHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatchHistory.BackgroundColor = Color.LightSteelBlue;
            dgvMatchHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatchHistory.GridColor = Color.Black;
            dgvMatchHistory.Location = new Point(28, 63);
            dgvMatchHistory.Name = "dgvMatchHistory";
            dgvMatchHistory.Size = new Size(554, 304);
            dgvMatchHistory.TabIndex = 0;
            dgvMatchHistory.RowHeaderMouseDoubleClick += dgvMatchHistory_RowHeaderMouseDoubleClick;
            // 
            // MatchHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(610, 437);
            Controls.Add(dgvMatchHistory);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MatchHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Predictor - Match History";
            FormClosed += MatchHistoryForm_FormClosed;
            Load += MatchHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatchHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMatchHistory;
    }
}