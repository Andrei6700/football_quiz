namespace Football_Quiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdbOption1;
        private System.Windows.Forms.RadioButton rdbOption2;
        private System.Windows.Forms.RadioButton rdbOption3;
        private System.Windows.Forms.RadioButton rdbOption4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblLastWrong;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox cmbScoreStrategy;

        /// <summary>
        /// Curăță resursele folosite.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Cod generat de Windows Form Designer

        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbOption1 = new System.Windows.Forms.RadioButton();
            this.rdbOption2 = new System.Windows.Forms.RadioButton();
            this.rdbOption3 = new System.Windows.Forms.RadioButton();
            this.rdbOption4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblLastWrong = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cmbScoreStrategy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(30, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(104, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question text";
            // 
            // rdbOption1
            // 
            this.rdbOption1.AutoSize = true;
            this.rdbOption1.Location = new System.Drawing.Point(33, 60);
            this.rdbOption1.Name = "rdbOption1";
            this.rdbOption1.Size = new System.Drawing.Size(66, 17);
            this.rdbOption1.TabIndex = 1;
            this.rdbOption1.TabStop = true;
            this.rdbOption1.Text = "Option A";
            this.rdbOption1.UseVisualStyleBackColor = true;
            // 
            // rdbOption2
            // 
            this.rdbOption2.AutoSize = true;
            this.rdbOption2.Location = new System.Drawing.Point(33, 87);
            this.rdbOption2.Name = "rdbOption2";
            this.rdbOption2.Size = new System.Drawing.Size(66, 17);
            this.rdbOption2.TabIndex = 2;
            this.rdbOption2.TabStop = true;
            this.rdbOption2.Text = "Option B";
            this.rdbOption2.UseVisualStyleBackColor = true;
            // 
            // rdbOption3
            // 
            this.rdbOption3.AutoSize = true;
            this.rdbOption3.Location = new System.Drawing.Point(33, 114);
            this.rdbOption3.Name = "rdbOption3";
            this.rdbOption3.Size = new System.Drawing.Size(66, 17);
            this.rdbOption3.TabIndex = 3;
            this.rdbOption3.TabStop = true;
            this.rdbOption3.Text = "Option C";
            this.rdbOption3.UseVisualStyleBackColor = true;
            // 
            // rdbOption4
            // 
            this.rdbOption4.AutoSize = true;
            this.rdbOption4.Location = new System.Drawing.Point(33, 141);
            this.rdbOption4.Name = "rdbOption4";
            this.rdbOption4.Size = new System.Drawing.Size(67, 17);
            this.rdbOption4.TabIndex = 4;
            this.rdbOption4.TabStop = true;
            this.rdbOption4.Text = "Option D";
            this.rdbOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(33, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(250, 60);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score:";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(250, 87);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(69, 13);
            this.lblRemaining.TabIndex = 7;
            this.lblRemaining.Text = "Remaining: 0";
            // 
            // lblLastWrong
            // 
            this.lblLastWrong.AutoSize = true;
            this.lblLastWrong.ForeColor = System.Drawing.Color.Red;
            this.lblLastWrong.Location = new System.Drawing.Point(250, 114);
            this.lblLastWrong.Name = "lblLastWrong";
            this.lblLastWrong.Size = new System.Drawing.Size(71, 13);
            this.lblLastWrong.TabIndex = 8;
            this.lblLastWrong.Text = "Last Wrong: -";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(253, 141);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 23);
            this.progressBar.TabIndex = 9;
            // 
            // cmbScoreStrategy
            // 
            this.cmbScoreStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScoreStrategy.FormattingEnabled = true;
            this.cmbScoreStrategy.Location = new System.Drawing.Point(253, 180);
            this.cmbScoreStrategy.Name = "cmbScoreStrategy";
            this.cmbScoreStrategy.Size = new System.Drawing.Size(200, 21);
            this.cmbScoreStrategy.TabIndex = 10;
            this.cmbScoreStrategy.SelectedIndexChanged += new System.EventHandler(this.CmbScoreStrategy_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(571, 231);
            this.Controls.Add(this.cmbScoreStrategy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblLastWrong);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdbOption4);
            this.Controls.Add(this.rdbOption3);
            this.Controls.Add(this.rdbOption2);
            this.Controls.Add(this.rdbOption1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Football Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
