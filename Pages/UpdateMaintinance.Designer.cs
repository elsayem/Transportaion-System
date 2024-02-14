namespace TransportReservationSystem.Pages
{
    partial class UpdateMaintinance
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
            CostMaintinance = new TextBox();
            TripComboBox = new ComboBox();
            DriverComboBox = new ComboBox();
            VehicleComboBox = new ComboBox();
            UpdateMaintinanceBtn = new Button();
            label1 = new Label();
            Trip = new Label();
            Driver = new Label();
            VehicleName = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // CostMaintinance
            // 
            CostMaintinance.Location = new Point(313, 330);
            CostMaintinance.Name = "CostMaintinance";
            CostMaintinance.Size = new Size(234, 27);
            CostMaintinance.TabIndex = 62;
            // 
            // TripComboBox
            // 
            TripComboBox.FormattingEnabled = true;
            TripComboBox.Location = new Point(313, 278);
            TripComboBox.Name = "TripComboBox";
            TripComboBox.Size = new Size(234, 28);
            TripComboBox.TabIndex = 59;
            // 
            // DriverComboBox
            // 
            DriverComboBox.FormattingEnabled = true;
            DriverComboBox.Location = new Point(313, 217);
            DriverComboBox.Name = "DriverComboBox";
            DriverComboBox.Size = new Size(234, 28);
            DriverComboBox.TabIndex = 60;
            // 
            // VehicleComboBox
            // 
            VehicleComboBox.FormattingEnabled = true;
            VehicleComboBox.Location = new Point(313, 162);
            VehicleComboBox.Name = "VehicleComboBox";
            VehicleComboBox.Size = new Size(234, 28);
            VehicleComboBox.TabIndex = 61;
            VehicleComboBox.DropDown += UpdateMaintinance_Load;
            VehicleComboBox.TabIndexChanged += VehicleComboBox_TabIndexChanged;
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
            UpdateMaintinanceBtn.Location = new Point(967, 421);
            UpdateMaintinanceBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateMaintinanceBtn.Name = "UpdateMaintinanceBtn";
            UpdateMaintinanceBtn.Size = new Size(225, 44);
            UpdateMaintinanceBtn.TabIndex = 58;
            UpdateMaintinanceBtn.Text = "Update Maintinance";
            UpdateMaintinanceBtn.UseVisualStyleBackColor = false;
            UpdateMaintinanceBtn.Click += UpdateMaintinanceBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 333);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 54;
            label1.Text = "Maintinance Cost (LE)";
            // 
            // Trip
            // 
            Trip.AutoSize = true;
            Trip.Location = new Point(184, 281);
            Trip.Name = "Trip";
            Trip.Size = new Size(34, 20);
            Trip.TabIndex = 55;
            Trip.Text = "Trip";
            // 
            // Driver
            // 
            Driver.AutoSize = true;
            Driver.Location = new Point(184, 217);
            Driver.Name = "Driver";
            Driver.Size = new Size(49, 20);
            Driver.TabIndex = 56;
            Driver.Text = "Driver";
            // 
            // VehicleName
            // 
            VehicleName.AutoSize = true;
            VehicleName.Location = new Point(184, 162);
            VehicleName.Name = "VehicleName";
            VehicleName.Size = new Size(56, 20);
            VehicleName.TabIndex = 57;
            VehicleName.Text = "Vehicle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(172, 42);
            label2.Name = "label2";
            label2.Size = new Size(491, 59);
            label2.TabIndex = 53;
            label2.Text = "Update Maintinace";
            // 
            // UpdateMaintinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 507);
            Controls.Add(CostMaintinance);
            Controls.Add(TripComboBox);
            Controls.Add(DriverComboBox);
            Controls.Add(VehicleComboBox);
            Controls.Add(UpdateMaintinanceBtn);
            Controls.Add(label1);
            Controls.Add(Trip);
            Controls.Add(Driver);
            Controls.Add(VehicleName);
            Controls.Add(label2);
            Name = "UpdateMaintinance";
            Text = "UpdateMaintinance";
            Load += UpdateMaintinance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CostMaintinance;
        private ComboBox TripComboBox;
        private ComboBox DriverComboBox;
        private ComboBox VehicleComboBox;
        private Button UpdateMaintinanceBtn;
        private Label label1;
        private Label Trip;
        private Label Driver;
        private Label VehicleName;
        private Label label2;
    }
}