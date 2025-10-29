using System.Windows.Forms;
using System.Drawing;

namespace ToDo.View
{
    partial class NavBarUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBarUserControl));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.profilePanel);
            this.mainPanel.Controls.Add(this.homePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(260, 500);
            this.mainPanel.TabIndex = 0;
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.nameLabel);
            this.profilePanel.Controls.Add(this.profilePictureBox);
            this.profilePanel.Location = new System.Drawing.Point(58, 96);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(121, 139);
            this.profilePanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Black;
            this.profilePictureBox.Location = new System.Drawing.Point(3, 3);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(110, 99);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Controls.Add(this.homePictureBox);
            this.homePanel.Location = new System.Drawing.Point(41, 251);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(145, 58);
            this.homePanel.TabIndex = 1;
            // 
            // homeLabel
            // 
            this.homeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.homeLabel.Location = new System.Drawing.Point(65, 17);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(70, 23);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePictureBox
            // 
            this.homePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homePictureBox.Image")));
            this.homePictureBox.Location = new System.Drawing.Point(3, 3);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(56, 50);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePictureBox.TabIndex = 0;
            this.homePictureBox.TabStop = false;
            // 
            // NavBarUserControl
            // 
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "NavBarUserControl";
            this.Size = new System.Drawing.Size(260, 500);
            this.mainPanel.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel mainPanel,profilePanel,homePanel;
        private Label nameLabel,homeLabel;
        private PictureBox profilePictureBox,homePictureBox;
    }
}
