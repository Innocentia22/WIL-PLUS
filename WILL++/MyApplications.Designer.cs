namespace WILL__
{
    partial class MyApplications
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnMessages = new Button();
            btnResources = new Button();
            btnNotifications = new Button();
            btnMyProfile = new Button();
            btnMyApplications = new Button();
            btnFindOpportunities = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Company = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            DateApplied = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(8, 33, 61);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnMessages);
            pnlSidebar.Controls.Add(btnResources);
            pnlSidebar.Controls.Add(btnNotifications);
            pnlSidebar.Controls.Add(btnMyProfile);
            pnlSidebar.Controls.Add(btnMyApplications);
            pnlSidebar.Controls.Add(btnFindOpportunities);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(400, 661);
            pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(22, 119, 255);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(50, 606);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(315, 32);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnMessages
            // 
            btnMessages.BackColor = Color.FromArgb(22, 119, 255);
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.ForeColor = Color.White;
            btnMessages.Location = new Point(50, 478);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(315, 32);
            btnMessages.TabIndex = 12;
            btnMessages.Text = "Messages";
            btnMessages.UseVisualStyleBackColor = false;
            // 
            // btnResources
            // 
            btnResources.BackColor = Color.FromArgb(22, 119, 255);
            btnResources.FlatStyle = FlatStyle.Flat;
            btnResources.ForeColor = Color.White;
            btnResources.Location = new Point(50, 545);
            btnResources.Name = "btnResources";
            btnResources.Size = new Size(315, 32);
            btnResources.TabIndex = 11;
            btnResources.Text = "Resources";
            btnResources.UseVisualStyleBackColor = false;
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.FromArgb(22, 119, 255);
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = Color.White;
            btnNotifications.Location = new Point(50, 416);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(315, 32);
            btnNotifications.TabIndex = 10;
            btnNotifications.Text = "Notifications";
            btnNotifications.UseVisualStyleBackColor = false;
            // 
            // btnMyProfile
            // 
            btnMyProfile.BackColor = Color.FromArgb(22, 119, 255);
            btnMyProfile.FlatStyle = FlatStyle.Flat;
            btnMyProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyProfile.ForeColor = Color.White;
            btnMyProfile.Location = new Point(50, 349);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(315, 32);
            btnMyProfile.TabIndex = 6;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = false;
            // 
            // btnMyApplications
            // 
            btnMyApplications.BackColor = Color.FromArgb(22, 119, 255);
            btnMyApplications.FlatStyle = FlatStyle.Flat;
            btnMyApplications.ForeColor = Color.DarkBlue;
            btnMyApplications.Location = new Point(50, 284);
            btnMyApplications.Name = "btnMyApplications";
            btnMyApplications.Size = new Size(315, 32);
            btnMyApplications.TabIndex = 7;
            btnMyApplications.Text = "My Applications";
            btnMyApplications.UseVisualStyleBackColor = false;
            btnMyApplications.Click += btnMyApplications_Click;
            // 
            // btnFindOpportunities
            // 
            btnFindOpportunities.BackColor = Color.FromArgb(22, 119, 255);
            btnFindOpportunities.FlatStyle = FlatStyle.Flat;
            btnFindOpportunities.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFindOpportunities.ForeColor = Color.White;
            btnFindOpportunities.Location = new Point(50, 215);
            btnFindOpportunities.Name = "btnFindOpportunities";
            btnFindOpportunities.Size = new Size(315, 32);
            btnFindOpportunities.TabIndex = 8;
            btnFindOpportunities.Text = "Find Opportunities";
            btnFindOpportunities.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(22, 119, 255);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(50, 148);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(315, 32);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(8, 33, 61);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 94);
            label2.Name = "label2";
            label2.Size = new Size(108, 51);
            label2.TabIndex = 3;
            label2.Text = "Work-Intergrated \r\nLearning Plus\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 42F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 20);
            label1.Name = "label1";
            label1.Size = new Size(215, 74);
            label1.TabIndex = 2;
            label1.Text = "WIL++";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 32, 51);
            label3.Location = new Point(683, 38);
            label3.Name = "label3";
            label3.Size = new Size(239, 40);
            label3.TabIndex = 14;
            label3.Text = "My Applications";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(683, 103);
            label4.Name = "label4";
            label4.Size = new Size(215, 42);
            label4.TabIndex = 15;
            label4.Text = "Track your WIL and in-service\r\ntraining applications.\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Location = new Point(473, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 100);
            panel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 31);
            label5.Name = "label5";
            label5.Size = new Size(62, 30);
            label5.TabIndex = 0;
            label5.Text = "5\r\nSubmitted\r\n";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Location = new Point(636, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(135, 100);
            panel2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 34);
            label6.Name = "label6";
            label6.Size = new Size(79, 30);
            label6.TabIndex = 0;
            label6.Text = "2\r\nUnder Review";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Location = new Point(796, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(135, 100);
            panel3.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 34);
            label7.Name = "label7";
            label7.Size = new Size(63, 30);
            label7.TabIndex = 1;
            label7.Text = "2 \r\nShortlisted\r\n";
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Location = new Point(954, 199);
            panel4.Name = "panel4";
            panel4.Size = new Size(135, 100);
            panel4.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 33);
            label8.Name = "label8";
            label8.Size = new Size(57, 30);
            label8.TabIndex = 2;
            label8.Text = "2\r\nAccepted\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Company, Position, Type, DateApplied, Status, Action });
            dataGridView1.Location = new Point(473, 349);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(602, 101);
            dataGridView1.TabIndex = 18;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.Name = "Company";
            // 
            // Position
            // 
            Position.HeaderText = "Opportunity";
            Position.Name = "Position";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // DateApplied
            // 
            DateApplied.HeaderText = "Date Applied";
            DateApplied.Name = "DateApplied";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            // 
            // MyApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 661);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pnlSidebar);
            MaximizeBox = false;
            Name = "MyApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyApplications-WIL++";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnLogout;
        private Button btnMessages;
        private Button btnResources;
        private Button btnNotifications;
        private Button btnMyProfile;
        private Button btnMyApplications;
        private Button btnFindOpportunities;
        private Button btnDashboard;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Panel panel3;
        private Label label7;
        private Panel panel4;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn DateApplied;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Action;
    }
}