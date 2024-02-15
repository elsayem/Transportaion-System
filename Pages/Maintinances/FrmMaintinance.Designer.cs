namespace TransportReservationSystem.Pages
{
    partial class FrmMaintinance
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
            panel1 = new Panel();
            label2 = new Label();
            Dashboard = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            button1 = new Button();
            MaintinacesGridView = new DataGridView();
            AddReservationBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaintinacesGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Dashboard);
            panel1.Location = new Point(24, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 176);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
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
            label2.Click += label2_Click;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = SystemColors.ControlDark;
            Dashboard.Location = new Point(181, 58);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(280, 56);
            Dashboard.TabIndex = 1;
            Dashboard.Text = "Maintinace";
            Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            Dashboard.Click += Dashboard_Click;
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
            UpdateBtn.Location = new Point(703, 552);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 36);
            UpdateBtn.TabIndex = 48;
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
            DeleteBtn.Location = new Point(861, 552);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 36);
            DeleteBtn.TabIndex = 47;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(156, 39, 176);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1019, 552);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 46;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MaintinacesGridView
            // 
            MaintinacesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaintinacesGridView.Location = new Point(205, 308);
            MaintinacesGridView.Name = "MaintinacesGridView";
            MaintinacesGridView.RowHeadersWidth = 51;
            MaintinacesGridView.Size = new Size(915, 222);
            MaintinacesGridView.TabIndex = 45;
            // 
            // AddReservationBtn
            // 
            AddReservationBtn.BackColor = Color.FromArgb(156, 39, 176);
            AddReservationBtn.Cursor = Cursors.Hand;
            AddReservationBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            AddReservationBtn.FlatAppearance.BorderSize = 0;
            AddReservationBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            AddReservationBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            AddReservationBtn.FlatStyle = FlatStyle.Flat;
            AddReservationBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddReservationBtn.ForeColor = Color.White;
            AddReservationBtn.Location = new Point(205, 227);
            AddReservationBtn.Margin = new Padding(3, 4, 3, 4);
            AddReservationBtn.Name = "AddReservationBtn";
            AddReservationBtn.Size = new Size(199, 53);
            AddReservationBtn.TabIndex = 44;
            AddReservationBtn.Text = "Add Maintinance";
            AddReservationBtn.UseVisualStyleBackColor = false;
            AddReservationBtn.Click += AddReservationBtn_Click;
            // 
            // FrmMaintinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 605);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(button1);
            Controls.Add(MaintinacesGridView);
            Controls.Add(AddReservationBtn);
            Controls.Add(panel1);
            Name = "FrmMaintinance";
            Text = "FrmMaintinance";
            Load += FrmMaintinance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaintinacesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Dashboard;
        private Label label2;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button button1;
        private DataGridView MaintinacesGridView;
        private Button AddReservationBtn;
    }
}