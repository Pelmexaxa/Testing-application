
namespace TestingApplication
{
    partial class TeamManagement
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
            this.listBox_freeChar = new System.Windows.Forms.ListBox();
            this.button_GoToTeam = new System.Windows.Forms.Button();
            this.button_LeaveOnTeam = new System.Windows.Forms.Button();
            this.button_accept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_inTeamChar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_freeChar
            // 
            this.listBox_freeChar.FormattingEnabled = true;
            this.listBox_freeChar.Location = new System.Drawing.Point(12, 46);
            this.listBox_freeChar.Name = "listBox_freeChar";
            this.listBox_freeChar.Size = new System.Drawing.Size(141, 95);
            this.listBox_freeChar.TabIndex = 0;
            // 
            // button_GoToTeam
            // 
            this.button_GoToTeam.Location = new System.Drawing.Point(159, 61);
            this.button_GoToTeam.Name = "button_GoToTeam";
            this.button_GoToTeam.Size = new System.Drawing.Size(75, 23);
            this.button_GoToTeam.TabIndex = 1;
            this.button_GoToTeam.Text = ">";
            this.button_GoToTeam.UseVisualStyleBackColor = true;
            this.button_GoToTeam.Click += new System.EventHandler(this.button_GoToTeam_Click);
            // 
            // button_LeaveOnTeam
            // 
            this.button_LeaveOnTeam.Location = new System.Drawing.Point(159, 103);
            this.button_LeaveOnTeam.Name = "button_LeaveOnTeam";
            this.button_LeaveOnTeam.Size = new System.Drawing.Size(75, 23);
            this.button_LeaveOnTeam.TabIndex = 2;
            this.button_LeaveOnTeam.Text = "<";
            this.button_LeaveOnTeam.UseVisualStyleBackColor = true;
            this.button_LeaveOnTeam.Click += new System.EventHandler(this.button_LeaveOnTeam_Click);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(100, 163);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(191, 34);
            this.button_accept.TabIndex = 4;
            this.button_accept.Text = "Подтвердить";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ваши сотрудники";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Свободные сотрудники";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox_inTeamChar
            // 
            this.listBox_inTeamChar.FormattingEnabled = true;
            this.listBox_inTeamChar.Location = new System.Drawing.Point(240, 46);
            this.listBox_inTeamChar.Name = "listBox_inTeamChar";
            this.listBox_inTeamChar.Size = new System.Drawing.Size(141, 95);
            this.listBox_inTeamChar.TabIndex = 3;
            // 
            // TeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 216);
            this.Controls.Add(this.listBox_inTeamChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.button_LeaveOnTeam);
            this.Controls.Add(this.button_GoToTeam);
            this.Controls.Add(this.listBox_freeChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeamManagement";
            this.ShowIcon = false;
            this.Text = "Настройка команды";
            this.Load += new System.EventHandler(this.TeamManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_freeChar;
        private System.Windows.Forms.Button button_GoToTeam;
        private System.Windows.Forms.Button button_LeaveOnTeam;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_inTeamChar;
    }
}