using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace ToDo.View
{
    partial class SettingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userProfileLabel = new System.Windows.Forms.Label();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.sizeControlPanel = new System.Windows.Forms.Panel();
            this.namePanel.SuspendLayout();
            this.emailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.sizeControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(450, 290);
            this.mainPanel.TabIndex = 0;
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Location = new System.Drawing.Point(47, 86);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(251, 51);
            this.namePanel.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 25);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(17, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userProfileLabel
            // 
            this.userProfileLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.userProfileLabel.Location = new System.Drawing.Point(122, 35);
            this.userProfileLabel.Name = "userProfileLabel";
            this.userProfileLabel.Size = new System.Drawing.Size(121, 23);
            this.userProfileLabel.TabIndex = 0;
            this.userProfileLabel.Text = "User Profile";
            this.userProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailPanel
            // 
            this.emailPanel.Controls.Add(this.emailTextBox);
            this.emailPanel.Controls.Add(this.emailLabel);
            this.emailPanel.Location = new System.Drawing.Point(47, 143);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(251, 48);
            this.emailPanel.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(80, 10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(155, 25);
            this.emailTextBox.TabIndex = 0;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(17, 10);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 23);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(142, 207);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 32);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.SkyBlue;
            this.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox.Location = new System.Drawing.Point(304, 86);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(109, 105);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 2;
            this.profilePictureBox.TabStop = false;
            // 
            // sizeControlPanel
            // 
            this.sizeControlPanel.Controls.Add(this.namePanel);
            this.sizeControlPanel.Controls.Add(this.userProfileLabel);
            this.sizeControlPanel.Controls.Add(this.emailPanel);
            this.sizeControlPanel.Controls.Add(this.editButton);
            this.sizeControlPanel.Controls.Add(this.profilePictureBox);
            this.sizeControlPanel.Location = new System.Drawing.Point(0, 0);
            this.sizeControlPanel.Name = "sizeControlPanel";
            this.sizeControlPanel.Size = new System.Drawing.Size(450, 290);
            this.sizeControlPanel.TabIndex = 0;
            // 
            // SettingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sizeControlPanel);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "SettingUserControl";
            this.Size = new System.Drawing.Size(450, 290);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.sizeControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel mainPanel, namePanel, emailPanel,sizeControlPanel;
        private Label userProfileLabel, nameLabel, emailLabel;
        private TextBox nameTextBox, emailTextBox;
        private PictureBox profilePictureBox;
        private Button editButton;
    }
}
