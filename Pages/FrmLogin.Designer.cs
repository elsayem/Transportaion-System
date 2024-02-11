﻿namespace TransportReservationSystem
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            EmailInput = new TextBox();
            pictureBox4 = new PictureBox();
            PasswordInput = new TextBox();
            label1 = new Label();
            ShowPasswordBtn = new CustomControls.RJControls.RJToggleButton();
            label2 = new Label();
            PassengerRBtn = new CustomControls.RJControls.RJRadioButton();
            StaffRBtn = new CustomControls.RJControls.RJRadioButton();
            panel1 = new Panel();
            LoginBtnPic = new PictureBox();
            LoginBtn = new Button();
            RegisterBtnPic = new PictureBox();
            RegisterBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginBtnPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RegisterBtnPic).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = Properties.Resources.Coach_Bus_mockup_04;
            pictureBox1.Location = new Point(-5, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(966, 873);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.avatar;
            pictureBox2.Location = new Point(1078, 33);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.EmailInput3;
            pictureBox3.Location = new Point(997, 259);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(339, 93);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // EmailInput
            // 
            EmailInput.BorderStyle = BorderStyle.None;
            EmailInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailInput.ForeColor = Color.DarkGray;
            EmailInput.Location = new Point(1029, 282);
            EmailInput.Margin = new Padding(3, 4, 3, 4);
            EmailInput.Multiline = true;
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(254, 27);
            EmailInput.TabIndex = 0;
            EmailInput.TextChanged += EmailInput_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PasswordInput1;
            pictureBox4.Location = new Point(997, 360);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(339, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // PasswordInput
            // 
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordInput.ForeColor = Color.DarkGray;
            PasswordInput.Location = new Point(1047, 401);
            PasswordInput.Margin = new Padding(3, 4, 3, 4);
            PasswordInput.Multiline = true;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(254, 27);
            PasswordInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1057, 191);
            label1.Name = "label1";
            label1.Size = new Size(211, 24);
            label1.TabIndex = 10;
            label1.Text = "Get Started Login Below";
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.AutoSize = true;
            ShowPasswordBtn.Location = new Point(1267, 459);
            ShowPasswordBtn.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordBtn.MinimumSize = new Size(51, 29);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.OffBackColor = Color.Gray;
            ShowPasswordBtn.OffToggleColor = Color.Gainsboro;
            ShowPasswordBtn.OnBackColor = Color.MediumSlateBlue;
            ShowPasswordBtn.OnToggleColor = Color.WhiteSmoke;
            ShowPasswordBtn.Size = new Size(51, 29);
            ShowPasswordBtn.TabIndex = 15;
            ShowPasswordBtn.UseVisualStyleBackColor = true;
            ShowPasswordBtn.CheckedChanged += ShowPasswordBtn_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1013, 465);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 16;
            label2.Text = "Show Password";
            // 
            // PassengerRBtn
            // 
            PassengerRBtn.AutoSize = true;
            PassengerRBtn.CheckedColor = Color.MediumSlateBlue;
            PassengerRBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassengerRBtn.Location = new Point(32, 13);
            PassengerRBtn.Margin = new Padding(3, 4, 3, 4);
            PassengerRBtn.MinimumSize = new Size(0, 28);
            PassengerRBtn.Name = "PassengerRBtn";
            PassengerRBtn.Padding = new Padding(11, 0, 0, 0);
            PassengerRBtn.Size = new Size(126, 28);
            PassengerRBtn.TabIndex = 17;
            PassengerRBtn.TabStop = true;
            PassengerRBtn.Text = "Passenger ";
            PassengerRBtn.UnCheckedColor = Color.Gray;
            PassengerRBtn.UseVisualStyleBackColor = true;
            PassengerRBtn.CheckedChanged += PassengerRBtn_CheckedChanged;
            // 
            // StaffRBtn
            // 
            StaffRBtn.AutoSize = true;
            StaffRBtn.CheckedColor = Color.MediumSlateBlue;
            StaffRBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StaffRBtn.Location = new Point(231, 13);
            StaffRBtn.Margin = new Padding(3, 4, 3, 4);
            StaffRBtn.MinimumSize = new Size(0, 28);
            StaffRBtn.Name = "StaffRBtn";
            StaffRBtn.Padding = new Padding(11, 0, 0, 0);
            StaffRBtn.Size = new Size(76, 28);
            StaffRBtn.TabIndex = 18;
            StaffRBtn.TabStop = true;
            StaffRBtn.Text = "Staff";
            StaffRBtn.UnCheckedColor = Color.Gray;
            StaffRBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(PassengerRBtn);
            panel1.Controls.Add(StaffRBtn);
            panel1.Location = new Point(997, 507);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 55);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // LoginBtnPic
            // 
            LoginBtnPic.Cursor = Cursors.Hand;
            LoginBtnPic.Image = Properties.Resources.RegisterBtn;
            LoginBtnPic.Location = new Point(998, 593);
            LoginBtnPic.Margin = new Padding(3, 4, 3, 4);
            LoginBtnPic.Name = "LoginBtnPic";
            LoginBtnPic.Size = new Size(339, 87);
            LoginBtnPic.SizeMode = PictureBoxSizeMode.Zoom;
            LoginBtnPic.TabIndex = 9;
            LoginBtnPic.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(156, 39, 176);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(1013, 607);
            LoginBtn.Margin = new Padding(3, 4, 3, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(306, 53);
            LoginBtn.TabIndex = 11;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegisterBtnPic
            // 
            RegisterBtnPic.Cursor = Cursors.Hand;
            RegisterBtnPic.Image = Properties.Resources.RegisterBtn;
            RegisterBtnPic.Location = new Point(998, 688);
            RegisterBtnPic.Margin = new Padding(3, 4, 3, 4);
            RegisterBtnPic.Name = "RegisterBtnPic";
            RegisterBtnPic.Size = new Size(339, 87);
            RegisterBtnPic.SizeMode = PictureBoxSizeMode.Zoom;
            RegisterBtnPic.TabIndex = 12;
            RegisterBtnPic.TabStop = false;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(156, 39, 176);
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            RegisterBtn.FlatAppearance.BorderSize = 0;
            RegisterBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            RegisterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(1013, 701);
            RegisterBtn.Margin = new Padding(3, 4, 3, 4);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(306, 53);
            RegisterBtn.TabIndex = 13;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1361, 859);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(ShowPasswordBtn);
            Controls.Add(RegisterBtn);
            Controls.Add(RegisterBtnPic);
            Controls.Add(LoginBtn);
            Controls.Add(label1);
            Controls.Add(LoginBtnPic);
            Controls.Add(PasswordInput);
            Controls.Add(pictureBox4);
            Controls.Add(EmailInput);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlDarkDark;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1379, 906);
            MinimumSize = new Size(260, 906);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Activated += FrmLogin_Activated;
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginBtnPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)RegisterBtnPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox EmailInput;
        private PictureBox pictureBox4;
        private TextBox PasswordInput;
        private Label label1;
        private CustomControls.RJControls.RJToggleButton ShowPasswordBtn;
        private Label label2;
        private CustomControls.RJControls.RJRadioButton PassengerRBtn;
        private CustomControls.RJControls.RJRadioButton StaffRBtn;
        private Panel panel1;
        private PictureBox LoginBtnPic;
        private Button LoginBtn;
        private PictureBox RegisterBtnPic;
        private Button RegisterBtn;
    }
}
