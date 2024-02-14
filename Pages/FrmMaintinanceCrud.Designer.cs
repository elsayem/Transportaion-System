namespace TransportReservationSystem.Pages
{
    partial class FrmMaintinanceCrud
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
            components = new System.ComponentModel.Container();
            AddMaintinanceBtn = new Button();
            VehicleName = new Label();
            label2 = new Label();
            VehicleComboBox = new ComboBox();
            DriverComboBox = new ComboBox();
            TripComboBox = new ComboBox();
            Driver = new Label();
            Trip = new Label();
            driverBindingSource = new BindingSource(components);
            CostMaintinance = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddMaintinanceBtn
            // 
            AddMaintinanceBtn.BackColor = Color.FromArgb(156, 39, 176);
            AddMaintinanceBtn.Cursor = Cursors.Hand;
            AddMaintinanceBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            AddMaintinanceBtn.FlatAppearance.BorderSize = 0;
            AddMaintinanceBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(156, 39, 160);
            AddMaintinanceBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 39, 170);
            AddMaintinanceBtn.FlatStyle = FlatStyle.Flat;
            AddMaintinanceBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMaintinanceBtn.ForeColor = Color.White;
            AddMaintinanceBtn.Location = new Point(874, 418);
            AddMaintinanceBtn.Margin = new Padding(3, 4, 3, 4);
            AddMaintinanceBtn.Name = "AddMaintinanceBtn";
            AddMaintinanceBtn.Size = new Size(225, 44);
            AddMaintinanceBtn.TabIndex = 50;
            AddMaintinanceBtn.Text = "Add Maintinance";
            AddMaintinanceBtn.UseVisualStyleBackColor = false;
            AddMaintinanceBtn.Click += AddMaintinanceBtn_Click;
            // 
            // VehicleName
            // 
            VehicleName.AutoSize = true;
            VehicleName.Location = new Point(91, 159);
            VehicleName.Name = "VehicleName";
            VehicleName.Size = new Size(56, 20);
            VehicleName.TabIndex = 43;
            VehicleName.Text = "Vehicle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(79, 39);
            label2.Name = "label2";
            label2.Size = new Size(416, 59);
            label2.TabIndex = 37;
            label2.Text = "Add Maintinace";
            // 
            // VehicleComboBox
            // 
            VehicleComboBox.FormattingEnabled = true;
            VehicleComboBox.Location = new Point(220, 159);
            VehicleComboBox.Name = "VehicleComboBox";
            VehicleComboBox.Size = new Size(234, 28);
            VehicleComboBox.TabIndex = 51;
            VehicleComboBox.SelectedIndexChanged += VehicleComboBox_SelectedIndexChanged;
            // 
            // DriverComboBox
            // 
            DriverComboBox.FormattingEnabled = true;
            DriverComboBox.Location = new Point(220, 214);
            DriverComboBox.Name = "DriverComboBox";
            DriverComboBox.Size = new Size(234, 28);
            DriverComboBox.TabIndex = 51;
            // 
            // TripComboBox
            // 
            TripComboBox.FormattingEnabled = true;
            TripComboBox.Location = new Point(220, 275);
            TripComboBox.Name = "TripComboBox";
            TripComboBox.Size = new Size(234, 28);
            TripComboBox.TabIndex = 51;
            // 
            // Driver
            // 
            Driver.AutoSize = true;
            Driver.Location = new Point(91, 214);
            Driver.Name = "Driver";
            Driver.Size = new Size(49, 20);
            Driver.TabIndex = 43;
            Driver.Text = "Driver";
            // 
            // Trip
            // 
            Trip.AutoSize = true;
            Trip.Location = new Point(91, 278);
            Trip.Name = "Trip";
            Trip.Size = new Size(34, 20);
            Trip.TabIndex = 43;
            Trip.Text = "Trip";
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Core.Models.Driver);
            // 
            // CostMaintinance
            // 
            CostMaintinance.Location = new Point(220, 327);
            CostMaintinance.Name = "CostMaintinance";
            CostMaintinance.Size = new Size(234, 27);
            CostMaintinance.TabIndex = 52;
            CostMaintinance.KeyPress += CostMaintinance_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 330);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 43;
            label1.Text = "Maintinance Cost (LE)";
            label1.Click += label1_Click;
            // 
            // FrmMaintinanceCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 536);
            Controls.Add(CostMaintinance);
            Controls.Add(TripComboBox);
            Controls.Add(DriverComboBox);
            Controls.Add(VehicleComboBox);
            Controls.Add(AddMaintinanceBtn);
            Controls.Add(label1);
            Controls.Add(Trip);
            Controls.Add(Driver);
            Controls.Add(VehicleName);
            Controls.Add(label2);
            Name = "FrmMaintinanceCrud";
            Text = "FrmMaintinanceCrud";
            Load += FrmMaintinanceCrud_Load;
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddMaintinanceBtn;
        private Label VehicleName;
        private Label label2;
        private ComboBox VehicleComboBox;
        private ComboBox DriverComboBox;
        private ComboBox TripComboBox;
        private Label Driver;
        private Label Trip;
        private BindingSource driverBindingSource;
        private TextBox CostMaintinance;
        private Label label1;
    }
}