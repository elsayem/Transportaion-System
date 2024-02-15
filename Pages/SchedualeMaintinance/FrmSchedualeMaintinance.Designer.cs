namespace TransportReservationSystem.Pages.SchedualeMaintinance
{
    partial class FrmSchedualeMaintinance
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
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            referesh = new Button();
            Sch_MaintinacesGridView = new DataGridView();
            AddSchedule_MaintinaceBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            Dashboard = new Label();
            ((System.ComponentModel.ISupportInitialize)Sch_MaintinacesGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(156, 39, 176);
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            UpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(777, 565);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 36);
            UpdateBtn.TabIndex = 54;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(156, 39, 176);
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(935, 565);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 36);
            DeleteBtn.TabIndex = 53;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // referesh
            // 
            referesh.BackColor = Color.FromArgb(156, 39, 176);
            referesh.Cursor = Cursors.Hand;
            referesh.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            referesh.FlatAppearance.BorderSize = 0;
            referesh.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            referesh.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            referesh.FlatStyle = FlatStyle.Flat;
            referesh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            referesh.ForeColor = Color.White;
            referesh.Location = new Point(1093, 565);
            referesh.Margin = new Padding(3, 4, 3, 4);
            referesh.Name = "referesh";
            referesh.Size = new Size(101, 36);
            referesh.TabIndex = 52;
            referesh.Text = "Refresh";
            referesh.UseVisualStyleBackColor = false;
            referesh.Click += referesh_Click;
            // 
            // Sch_MaintinacesGridView
            // 
            Sch_MaintinacesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Sch_MaintinacesGridView.Location = new Point(279, 321);
            Sch_MaintinacesGridView.Name = "Sch_MaintinacesGridView";
            Sch_MaintinacesGridView.RowHeadersWidth = 51;
            Sch_MaintinacesGridView.Size = new Size(915, 222);
            Sch_MaintinacesGridView.TabIndex = 51;
            // 
            // AddSchedule_MaintinaceBtn
            // 
            AddSchedule_MaintinaceBtn.BackColor = Color.FromArgb(156, 39, 176);
            AddSchedule_MaintinaceBtn.Cursor = Cursors.Hand;
            AddSchedule_MaintinaceBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            AddSchedule_MaintinaceBtn.FlatAppearance.BorderSize = 0;
            AddSchedule_MaintinaceBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            AddSchedule_MaintinaceBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            AddSchedule_MaintinaceBtn.FlatStyle = FlatStyle.Flat;
            AddSchedule_MaintinaceBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddSchedule_MaintinaceBtn.ForeColor = Color.White;
            AddSchedule_MaintinaceBtn.Location = new Point(279, 247);
            AddSchedule_MaintinaceBtn.Margin = new Padding(3, 4, 3, 4);
            AddSchedule_MaintinaceBtn.Name = "AddSchedule_MaintinaceBtn";
            AddSchedule_MaintinaceBtn.Size = new Size(287, 47);
            AddSchedule_MaintinaceBtn.TabIndex = 50;
            AddSchedule_MaintinaceBtn.Text = "Add Schedule Maintinace";
            AddSchedule_MaintinaceBtn.UseVisualStyleBackColor = false;
            AddSchedule_MaintinaceBtn.Click += AddSchedule_MaintinaceBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Dashboard);
            panel1.Location = new Point(12, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 176);
            panel1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(14, 20);
            label2.Name = "label2";
            label2.Size = new Size(178, 141);
            label2.TabIndex = 2;
            label2.Text = "ITI";
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = SystemColors.ControlDark;
            Dashboard.Location = new Point(181, 58);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(505, 56);
            Dashboard.TabIndex = 1;
            Dashboard.Text = "Schedule Maintinace";
            Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmSchedualeMaintinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 640);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(referesh);
            Controls.Add(Sch_MaintinacesGridView);
            Controls.Add(AddSchedule_MaintinaceBtn);
            Controls.Add(panel1);
            Name = "FrmSchedualeMaintinance";
            Text = "FrmSchedualeMaintinance";
            Load += FrmSchedualeMaintinance_Load;
            ((System.ComponentModel.ISupportInitialize)Sch_MaintinacesGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button referesh;
        private DataGridView Sch_MaintinacesGridView;
        private Button AddSchedule_MaintinaceBtn;
        private Panel panel1;
        private Label label2;
        private Label Dashboard;
    }
}