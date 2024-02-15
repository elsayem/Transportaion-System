namespace TransportReservationSystem.Pages.SchedualeMaintinance
{
    partial class FrmSchedualeMaintinanceCrud
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
            VehicleComboBox = new ComboBox();
            AddMaintinanceBtn = new Button();
            VehicleName = new Label();
            label2 = new Label();
            startDate = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            endDate = new DateTimePicker();
            SuspendLayout();
            // 
            // VehicleComboBox
            // 
            VehicleComboBox.FormattingEnabled = true;
            VehicleComboBox.Location = new Point(263, 190);
            VehicleComboBox.Name = "VehicleComboBox";
            VehicleComboBox.Size = new Size(250, 28);
            VehicleComboBox.TabIndex = 61;
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
            AddMaintinanceBtn.Location = new Point(913, 453);
            AddMaintinanceBtn.Margin = new Padding(3, 4, 3, 4);
            AddMaintinanceBtn.Name = "AddMaintinanceBtn";
            AddMaintinanceBtn.Size = new Size(282, 65);
            AddMaintinanceBtn.TabIndex = 58;
            AddMaintinanceBtn.Text = "Add Schedule Maintinace";
            AddMaintinanceBtn.UseVisualStyleBackColor = false;
            AddMaintinanceBtn.Click += AddMaintinanceBtn_Click;
            // 
            // VehicleName
            // 
            VehicleName.AutoSize = true;
            VehicleName.Location = new Point(96, 198);
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
            label2.Location = new Point(122, 70);
            label2.Name = "label2";
            label2.Size = new Size(657, 59);
            label2.TabIndex = 53;
            label2.Text = "Add Schedule Maintinace";
            // 
            // startDate
            // 
            startDate.CustomFormat = "hh:mm:ss  -  dd-MM-yyyy";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(263, 250);
            startDate.Name = "startDate";
            startDate.Size = new Size(250, 27);
            startDate.TabIndex = 62;
            startDate.Value = new DateTime(2024, 2, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 255);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 57;
            label1.Text = "Maintinance Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 316);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 57;
            label3.Text = "Maintinance End Date";
            // 
            // endDate
            // 
            endDate.CustomFormat = "hh:mm:ss  -  dd-MM-yyyy";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(263, 311);
            endDate.Name = "endDate";
            endDate.Size = new Size(250, 27);
            endDate.TabIndex = 62;
            // 
            // FrmSchedualeMaintinanceCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 563);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(VehicleComboBox);
            Controls.Add(label3);
            Controls.Add(AddMaintinanceBtn);
            Controls.Add(label1);
            Controls.Add(VehicleName);
            Controls.Add(label2);
            Name = "FrmSchedualeMaintinanceCrud";
            Text = "FrmSchedualeMaintinanceCrud";
            Load += FrmSchedualeMaintinanceCrud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox VehicleComboBox;
        private Button AddMaintinanceBtn;
        private Label VehicleName;
        private Label label2;
        private DateTimePicker startDate;
        private Label label1;
        private Label label3;
        private DateTimePicker endDate;
    }
}