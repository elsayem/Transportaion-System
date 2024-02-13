﻿namespace TransportReservationSystem
{
    partial class FrmPassengers
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
            Dashboard = new Label();
            label3 = new Label();
            label2 = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            button1 = new Button();
            PassengersGridView = new DataGridView();
            AddPassngerBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PassengersGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(Dashboard);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(146, 48);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 176);
            panel1.TabIndex = 10;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = SystemColors.ControlDark;
            Dashboard.Location = new Point(161, 35);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(278, 56);
            Dashboard.TabIndex = 1;
            Dashboard.Text = "Passengers";
            Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(171, 109);
            label3.Name = "label3";
            label3.Size = new Size(266, 28);
            label3.TabIndex = 3;
            label3.Text = "Generated by Team 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(178, 141);
            label2.TabIndex = 2;
            label2.Text = "ITI";
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
            UpdateBtn.Location = new Point(604, 636);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 36);
            UpdateBtn.TabIndex = 43;
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
            DeleteBtn.Location = new Point(762, 636);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 36);
            DeleteBtn.TabIndex = 42;
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
            button1.Location = new Point(920, 636);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 41;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PassengersGridView
            // 
            PassengersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PassengersGridView.Location = new Point(106, 392);
            PassengersGridView.Name = "PassengersGridView";
            PassengersGridView.RowHeadersWidth = 51;
            PassengersGridView.Size = new Size(915, 222);
            PassengersGridView.TabIndex = 40;
            PassengersGridView.CellContentClick += PassengersGridView_CellContentClick;
            // 
            // AddPassngerBtn
            // 
            AddPassngerBtn.BackColor = Color.FromArgb(156, 39, 176);
            AddPassngerBtn.Cursor = Cursors.Hand;
            AddPassngerBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            AddPassngerBtn.FlatAppearance.BorderSize = 0;
            AddPassngerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            AddPassngerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            AddPassngerBtn.FlatStyle = FlatStyle.Flat;
            AddPassngerBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddPassngerBtn.ForeColor = Color.White;
            AddPassngerBtn.Location = new Point(106, 295);
            AddPassngerBtn.Margin = new Padding(3, 4, 3, 4);
            AddPassngerBtn.Name = "AddPassngerBtn";
            AddPassngerBtn.Size = new Size(320, 57);
            AddPassngerBtn.TabIndex = 39;
            AddPassngerBtn.Text = "Add Passenger";
            AddPassngerBtn.UseVisualStyleBackColor = false;
            AddPassngerBtn.Click += AddPassngerBtn_Click;
            // 
            // FrmPassengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1097, 817);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(button1);
            Controls.Add(PassengersGridView);
            Controls.Add(AddPassngerBtn);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPassengers";
            Text = "FrmMain";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PassengersGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Dashboard;
        private Label label3;
        private Label label2;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button button1;
        private DataGridView PassengersGridView;
        private Button AddPassngerBtn;
    }
}