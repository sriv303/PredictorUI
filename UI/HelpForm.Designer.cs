namespace PredictorUI
{
    partial class HelpForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(715, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the ScorePredictor program! Here is a quick guide on how to use the program: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(292, 23);
            label2.TabIndex = 1;
            label2.Text = "--> First create an account and login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(899, 23);
            label3.TabIndex = 2;
            label3.Text = "--> On the simulate page add two teams of 11 players and select a venue. Confirm the selection displays the results!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(424, 23);
            label4.TabIndex = 3;
            label4.Text = "--> Click a row and press delete to remove any player";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(841, 23);
            label5.TabIndex = 4;
            label5.Text = "--> You can view past matches on the match history page by double clicking on the row header for a match";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label6.Location = new Point(12, 264);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 5;
            label6.Text = "Enjoy the program!";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(944, 328);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HelpForm";
            Text = "Score Predictor - Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}