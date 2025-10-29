using System.Windows.Forms;
using System.Drawing;
using System.IO;
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
            this.taskPanel = new System.Windows.Forms.Panel();
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.settingPannel = new System.Windows.Forms.Panel();
            this.settingPictureBox = new System.Windows.Forms.PictureBox();
            this.settingLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.taskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).BeginInit();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.settingPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.taskPanel);
            this.mainPanel.Controls.Add(this.profilePanel);
            this.mainPanel.Controls.Add(this.homePanel);
            this.mainPanel.Controls.Add(this.settingPannel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(260, 500);
            this.mainPanel.TabIndex = 0;
            // 
            // taskPanel
            // 
            this.taskPanel.Controls.Add(this.taskLabel);
            this.taskPanel.Controls.Add(this.taskPictureBox);
            this.taskPanel.Location = new System.Drawing.Point(41, 327);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(145, 65);
            this.taskPanel.TabIndex = 0;
            // 
            // taskLabel
            // 
            this.taskLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.taskLabel.Location = new System.Drawing.Point(65, 18);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(64, 23);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Tasks";
            this.taskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskPictureBox
            // 
            this.taskPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("taskPictureBox.Image")));
            this.taskPictureBox.Location = new System.Drawing.Point(3, 3);
            this.taskPictureBox.Name = "taskPictureBox";
            this.taskPictureBox.Size = new System.Drawing.Size(56, 57);
            this.taskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.taskPictureBox.TabIndex = 1;
            this.taskPictureBox.TabStop = false;
            this.taskPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.nameLabel);
            this.profilePanel.Controls.Add(this.profilePictureBox);
            this.profilePanel.Location = new System.Drawing.Point(58, 41);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(128, 194);
            this.profilePanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 146);
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
            this.profilePictureBox.Size = new System.Drawing.Size(122, 130);
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
            settingPannel.Cursor = Cursors.Hand;
            taskPanel.Cursor = Cursors.Hand;
            homePanel.Cursor = Cursors.Hand;
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
            // settingPannel
            // 
            this.settingPannel.Controls.Add(this.settingPictureBox);
            this.settingPannel.Controls.Add(this.settingLabel);
            this.settingPannel.Location = new System.Drawing.Point(41, 400);
            this.settingPannel.Name = "settingPannel";
            this.settingPannel.Size = new System.Drawing.Size(164, 62);
            this.settingPannel.TabIndex = 2;
            // 
            // settingPictureBox
            // 
            this.settingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("settingPictureBox.Image")));
            this.settingPictureBox.Location = new System.Drawing.Point(5, 5);
            this.settingPictureBox.Name = "settingPictureBox";
            this.settingPictureBox.Size = new System.Drawing.Size(54, 50);
            this.settingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingPictureBox.TabIndex = 0;
            this.settingPictureBox.TabStop = false;
            // 
            // settingLabel
            // 
            this.settingLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.settingLabel.Location = new System.Drawing.Point(65, 13);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(95, 35);
            this.settingLabel.TabIndex = 1;
            this.settingLabel.Text = "Settings";
            this.settingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavBarUserControl
            // 
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "NavBarUserControl";
            this.Size = new System.Drawing.Size(260, 500);
            this.mainPanel.ResumeLayout(false);
            this.taskPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.settingPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel mainPanel,profilePanel,homePanel,taskPanel,settingPannel;
        private Label nameLabel,homeLabel,taskLabel, settingLabel;
        private PictureBox profilePictureBox,homePictureBox,taskPictureBox, settingPictureBox;
    }
}
