﻿namespace Client
{
    partial class StartingGUI
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
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.SessionCodeInput = new System.Windows.Forms.TextBox();
            this.SessionCodeLabel = new System.Windows.Forms.Label();
            this.JoinGameBtn = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(12, 64);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(119, 23);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "Create a new game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // SessionCodeInput
            // 
            this.SessionCodeInput.Location = new System.Drawing.Point(89, 38);
            this.SessionCodeInput.Name = "SessionCodeInput";
            this.SessionCodeInput.Size = new System.Drawing.Size(297, 20);
            this.SessionCodeInput.TabIndex = 1;
            // 
            // SessionCodeLabel
            // 
            this.SessionCodeLabel.AutoSize = true;
            this.SessionCodeLabel.Location = new System.Drawing.Point(12, 41);
            this.SessionCodeLabel.Name = "SessionCodeLabel";
            this.SessionCodeLabel.Size = new System.Drawing.Size(71, 13);
            this.SessionCodeLabel.TabIndex = 2;
            this.SessionCodeLabel.Text = "Session code";
            // 
            // JoinGameBtn
            // 
            this.JoinGameBtn.Location = new System.Drawing.Point(267, 64);
            this.JoinGameBtn.Name = "JoinGameBtn";
            this.JoinGameBtn.Size = new System.Drawing.Size(119, 23);
            this.JoinGameBtn.TabIndex = 3;
            this.JoinGameBtn.Text = "Join existing game";
            this.JoinGameBtn.UseVisualStyleBackColor = true;
            this.JoinGameBtn.Click += new System.EventHandler(this.JoinGameBtn_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(12, 15);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(65, 13);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = "Player name";
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(89, 12);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(297, 20);
            this.UserNameInput.TabIndex = 5;
            // 
            // StartingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 98);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.JoinGameBtn);
            this.Controls.Add(this.SessionCodeLabel);
            this.Controls.Add(this.SessionCodeInput);
            this.Controls.Add(this.NewGameBtn);
            this.MaximizeBox = false;
            this.Name = "StartingGUI";
            this.Text = "Game manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.TextBox SessionCodeInput;
        private System.Windows.Forms.Label SessionCodeLabel;
        private System.Windows.Forms.Button JoinGameBtn;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameInput;
    }
}

