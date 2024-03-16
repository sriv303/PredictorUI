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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dgvMatchHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMatchHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatchHistory.Location = new Point(28, 56);
            dgvMatchHistory.Name = "dgvMatchHistory";
            dgvMatchHistory.Size = new Size(592, 268);
            dgvMatchHistory.TabIndex = 0;
            dgvMatchHistory.RowHeaderMouseDoubleClick += dgvMatchHistory_RowHeaderMouseDoubleClick;
            // 
            // MatchHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 386);
            Controls.Add(dgvMatchHistory);
            Name = "MatchHistoryForm";
            Text = "MatchHistory";
            FormClosed += MatchHistoryForm_FormClosed;
            Load += MatchHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatchHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMatchHistory;
    }
}