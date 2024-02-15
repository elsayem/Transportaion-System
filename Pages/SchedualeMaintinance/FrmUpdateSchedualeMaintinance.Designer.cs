namespace TransportReservationSystem.Pages.SchedualeMaintinance
{
    partial class FrmUpdateSchedualeMaintinance
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
            UpdateMaintinanceBtn = new Button();
            label2 = new Label();
            endDate = new DateTimePicker();
            startDate = new DateTimePicker();
            VehicleComboBox = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            VehicleName = new Label();
            SuspendLayout();
            // 
            // UpdateMaintinanceBtn
            // 
            UpdateMaintinanceBtn.BackColor = Color.FromArgb(156, 39, 176);
            UpdateMaintinanceBtn.Cursor = Cursors.Hand;
            UpdateMaintinanceBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            UpdateMaintinanceBtn.FlatAppearance.BorderSize = 0;
            UpdateMaintinanceBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            UpdateMaintinanceBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            UpdateMaintinanceBtn.FlatStyle = FlatStyle.Flat;
            UpdateMaintinanceBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMaintinanceBtn.ForeColor = Color.White;
            UpdateMaintinanceBtn.Location = new Point(693, 476);
            UpdateMaintinanceBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateMaintinanceBtn.Name = "UpdateMaintinanceBtn";
            UpdateMaintinanceBtn.Size = new Size(329, 56);
            UpdateMaintinanceBtn.TabIndex = 68;
            UpdateMaintinanceBtn.Text = "Update Schedule Maintinace";
            UpdateMaintinanceBtn.UseVisualStyleBackColor = false;
            UpdateMaintinanceBtn.Click += UpdateMaintinanceBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(31, 46);
            label2.Name = "label2";
            label2.Size = new Size(732, 59);
            label2.TabIndex = 63;
            label2.Text = "Update Schedule Maintinace";
            // 
            // endDate
            // 
            endDate.CustomFormat = "hh:mm:ss  -  dd-MM-yyyy";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(272, 328);
            endDate.Name = "endDate";
            endDate.Size = new Size(250, 27);
            endDate.TabIndex = 73;
            endDate.Value = new DateTime(2024, 2, 10, 0, 0, 0, 0);
            // 
            // startDate
            // 
            startDate.CustomFormat = "hh:mm:ss  -  dd-MM-yyyy";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(272, 267);
            startDate.Name = "startDate";
            startDate.Size = new Size(250, 27);
            startDate.TabIndex = 74;
            startDate.Value = new DateTime(2024, 2, 1, 0, 0, 0, 0);
            // 
            // VehicleComboBox
            // 
            VehicleComboBox.FormattingEnabled = true;
            VehicleComboBox.Location = new Point(272, 207);
            VehicleComboBox.Name = "VehicleComboBox";
            VehicleComboBox.Size = new Size(250, 28);
            VehicleComboBox.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 333);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 69;
            label3.Text = "Maintinance End Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 272);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 70;
            label1.Text = "Maintinance Start Date";
            // 
            // VehicleName
            // 
            VehicleName.AutoSize = true;
            VehicleName.Location = new Point(105, 215);
            VehicleName.Name = "VehicleName";
            VehicleName.Size = new Size(56, 20);
            VehicleName.TabIndex = 71;
            VehicleName.Text = "Vehicle";
            // 
            // FrmUpdateSchedualeMaintinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 581);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(VehicleComboBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(VehicleName);
            Controls.Add(UpdateMaintinanceBtn);
            Controls.Add(label2);
            Name = "FrmUpdateSchedualeMaintinance";
            Text = "FrmUpdateSchedualeMaintinance";
            Load += FrmUpdateSchedualeMaintinance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UpdateMaintinanceBtn;
        private Label label2;
        private DateTimePicker endDate;
        private DateTimePicker startDate;
        private ComboBox VehicleComboBox;
        private Label label3;
        private Label label1;
        private Label VehicleName;
    }
}