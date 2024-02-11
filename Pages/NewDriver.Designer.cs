namespace TransportReservationSystem.Pages
{
    partial class NewDriver
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
            New = new Label();
            usernameBox = new TextBox();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            licenseBox = new TextBox();
            salaryBox = new TextBox();
            stationBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            AddDriverBtn = new Button();
            phoneBox = new TextBox();
            label8 = new Label();
            hasBonusCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // New
            // 
            New.AutoSize = true;
            New.FlatStyle = FlatStyle.Flat;
            New.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            New.ForeColor = Color.DarkViolet;
            New.Location = new Point(87, 21);
            New.Name = "New";
            New.Size = new Size(380, 56);
            New.TabIndex = 3;
            New.Text = "Add New Driver";
            New.Click += label2_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(165, 135);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(213, 27);
            usernameBox.TabIndex = 4;
            usernameBox.TextChanged += textBox1_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(165, 179);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(213, 27);
            emailBox.TabIndex = 4;
            emailBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(165, 226);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(213, 27);
            passwordBox.TabIndex = 4;
            passwordBox.TextChanged += textBox1_TextChanged;
            // 
            // licenseBox
            // 
            licenseBox.Location = new Point(165, 276);
            licenseBox.Name = "licenseBox";
            licenseBox.Size = new Size(213, 27);
            licenseBox.TabIndex = 4;
            licenseBox.TextChanged += textBox1_TextChanged;
            // 
            // salaryBox
            // 
            salaryBox.Location = new Point(165, 369);
            salaryBox.Name = "salaryBox";
            salaryBox.Size = new Size(213, 27);
            salaryBox.TabIndex = 4;
            salaryBox.TextChanged += textBox1_TextChanged;
            // 
            // stationBox
            // 
            stationBox.Location = new Point(782, 164);
            stationBox.Name = "stationBox";
            stationBox.Size = new Size(213, 27);
            stationBox.TabIndex = 4;
            stationBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 142);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 186);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 233);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 287);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "License";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 373);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 5;
            label5.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(666, 167);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 5;
            label7.Text = "Current Station";
            // 
            // AddDriverBtn
            // 
            AddDriverBtn.BackColor = Color.FromArgb(156, 39, 176);
            AddDriverBtn.Cursor = Cursors.Hand;
            AddDriverBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            AddDriverBtn.FlatAppearance.BorderSize = 0;
            AddDriverBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            AddDriverBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            AddDriverBtn.FlatStyle = FlatStyle.Flat;
            AddDriverBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddDriverBtn.ForeColor = Color.White;
            AddDriverBtn.Location = new Point(901, 400);
            AddDriverBtn.Margin = new Padding(3, 4, 3, 4);
            AddDriverBtn.Name = "AddDriverBtn";
            AddDriverBtn.Size = new Size(159, 46);
            AddDriverBtn.TabIndex = 35;
            AddDriverBtn.Text = "Add Driver";
            AddDriverBtn.UseVisualStyleBackColor = false;
            AddDriverBtn.Click += AddDriverBtn_Click;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(782, 212);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(213, 27);
            phoneBox.TabIndex = 4;
            phoneBox.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(666, 212);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 5;
            label8.Text = "Phone";
            // 
            // hasBonusCheckBox
            // 
            hasBonusCheckBox.AutoSize = true;
            hasBonusCheckBox.Location = new Point(165, 416);
            hasBonusCheckBox.Name = "hasBonusCheckBox";
            hasBonusCheckBox.Size = new Size(100, 24);
            hasBonusCheckBox.TabIndex = 36;
            hasBonusCheckBox.Text = "Has Bonus";
            hasBonusCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 483);
            Controls.Add(hasBonusCheckBox);
            Controls.Add(AddDriverBtn);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stationBox);
            Controls.Add(salaryBox);
            Controls.Add(phoneBox);
            Controls.Add(licenseBox);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(usernameBox);
            Controls.Add(New);
            Name = "NewDriver";
            Text = "NewDriver";
            Load += NewDriver_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label New;
        private TextBox usernameBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private TextBox licenseBox;
        private TextBox salaryBox;
        private TextBox stationBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button AddDriverBtn;
        private TextBox phoneBox;
        private Label label8;
        private CheckBox hasBonusCheckBox;
    }
}