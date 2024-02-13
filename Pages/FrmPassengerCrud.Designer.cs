namespace TransportReservationSystem.Pages
{
    partial class FrmPassengerCrud
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            usernameBox = new TextBox();
            label8 = new Label();
            addressBox = new TextBox();
            phoneBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            GenderComboBox = new ComboBox();
            AddPassengerBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(64, 34);
            label2.Name = "label2";
            label2.Size = new Size(390, 59);
            label2.TabIndex = 3;
            label2.Text = "Add Passenger";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 232);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 185);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 141);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 11;
            label4.Text = "Username";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(179, 225);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(213, 27);
            passwordBox.TabIndex = 6;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(179, 178);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(213, 27);
            emailBox.TabIndex = 7;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(180, 138);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(213, 27);
            usernameBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(526, 178);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "Phone";
            // 
            // addressBox
            // 
            addressBox.Location = new Point(642, 130);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(213, 27);
            addressBox.TabIndex = 12;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(642, 178);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(213, 27);
            phoneBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 130);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 16;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 287);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 17;
            label6.Text = "Gender";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderComboBox.Location = new Point(179, 287);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(138, 28);
            GenderComboBox.TabIndex = 18;
            // 
            // AddPassengerBtn
            // 
            AddPassengerBtn.BackColor = Color.FromArgb(156, 39, 176);
            AddPassengerBtn.Cursor = Cursors.Hand;
            AddPassengerBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            AddPassengerBtn.FlatAppearance.BorderSize = 0;
            AddPassengerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            AddPassengerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            AddPassengerBtn.FlatStyle = FlatStyle.Flat;
            AddPassengerBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddPassengerBtn.ForeColor = Color.White;
            AddPassengerBtn.Location = new Point(696, 388);
            AddPassengerBtn.Margin = new Padding(3, 4, 3, 4);
            AddPassengerBtn.Name = "AddPassengerBtn";
            AddPassengerBtn.Size = new Size(159, 46);
            AddPassengerBtn.TabIndex = 36;
            AddPassengerBtn.Text = "Add Passenger";
            AddPassengerBtn.UseVisualStyleBackColor = false;
            AddPassengerBtn.Click += AddPassengerBtn_Click;
            // 
            // FrmPassengerCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 494);
            Controls.Add(AddPassengerBtn);
            Controls.Add(GenderComboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(addressBox);
            Controls.Add(phoneBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(usernameBox);
            Controls.Add(label2);
            Name = "FrmPassengerCrud";
            Text = "FrmPassengerCrud";
            Load += FrmPassengerCrud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox passwordBox;
        private TextBox emailBox;
        private TextBox usernameBox;
        private Label label8;
        private TextBox addressBox;
        private TextBox phoneBox;
        private Label label5;
        private Label label6;
        private ComboBox GenderComboBox;
        private Button AddPassengerBtn;
    }
}