using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransportReservationSystem.Pages
{
    public partial class FrmUpdateMaintinance : Form
    {
        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
        ApplicaitonDbContext context = new ApplicaitonDbContext();

        public int maintenanceId { get; set; }



        public FrmUpdateMaintinance()
        {
            InitializeComponent();
        }
        public FrmUpdateMaintinance(int maintenanceid)
        {
            this.maintenanceId = maintenanceid;
        }
        private void UpdateMaintinance_Load(object sender, EventArgs e)
        {

            //Vehicle Combo Box:
            VehicleComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            VehicleComboBox.Items.Add("Select Vehicle");


            foreach (var vehicle in context.Vehicles)
            {
                string vehicleDetails = $"NO:{vehicle.VehicleNo} {vehicle.Model} - {vehicle.Brand}";
                VehicleComboBox.Items.Add(vehicleDetails);
            }

           

            //Driver Combo Box
            DriverComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            DriverComboBox.Items.Add("Select Driver Name");

            // Add the vehicle the data source
            foreach (var item in context.Drivers.Select(v => v.Username).ToList())
            {
                DriverComboBox.Items.Add(item);
            }

          

            //Trip Combo Box
            TripComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            TripComboBox.Items.Add("Select Trip");

            // Add the vehicle the data source
            foreach (var item in context.Trips.Select(v => "NO:" + v.TripNo + " - " + v.Source + " - " + v.Destination).ToList())
            {
                TripComboBox.Items.Add(item);
            }

           

            var TargetsMaintinace = context.Maintenances.Where(m => m.Id == maintenanceId).FirstOrDefault();
            PopulateFormData(TargetsMaintinace);


            //to disable vehicle and trip combo box and make them just showing the data:
            VehicleComboBox.DropDownStyle= ComboBoxStyle.Simple;
            VehicleComboBox.Enabled = false;

            TripComboBox.DropDownStyle = ComboBoxStyle.Simple;
            TripComboBox.Enabled = false;



        }

        private void UpdateMaintinanceBtn_Click(object sender, EventArgs e)
        {
            #region Validations popup
            //Validations popup
            if (VehicleComboBox.SelectedIndex == 0)
            {
                frmValidationDialog.showAlert("No Selected Vehicle.", FrmValidationDialog.enmType.Warning);
                //to return to the form without checking the comming driver combobox.
                return;

            }
            if (DriverComboBox.SelectedIndex == 0)
            {
                frmValidationDialog.showAlert("No Selected Driver.", FrmValidationDialog.enmType.Warning);
                return;

            }
            if (TripComboBox.SelectedIndex == 0)
            {
                frmValidationDialog.showAlert("No Selected Trip.", FrmValidationDialog.enmType.Warning);
                return;

            }

            if (string.IsNullOrWhiteSpace(CostMaintinance.Text))
            {
                frmValidationDialog.showAlert("Enter The Cost of Maintinance.", FrmValidationDialog.enmType.Warning);
                return;
            }




            #endregion

            //get the id from seleted trip
            string selectedTrip = TripComboBox.SelectedItem.ToString();

            int startIndex = selectedTrip.IndexOf("NO:") + 3;
            int endIndex = selectedTrip.IndexOf(" -", startIndex);
            int tripNo = int.Parse(selectedTrip.Substring(startIndex, endIndex - startIndex).Trim());

            //int tripNo = int.Parse(selectedTrip.Substring(selectedTrip.IndexOf("NO:") + 3).Trim()); // Extract TripNo from the string
            int tripid = context.Trips
                           .Where(t => t.TripNo == tripNo)
                           .Select(t => t.Id)
                           .FirstOrDefault();

            //get the id from seleted driver
            string selecteddriver = DriverComboBox.SelectedItem.ToString();
            //int driver = int.Parse(selectedTrip.Substring(selectedTrip.IndexOf("NO:") + 3).Trim()); // Extract TripNo from the string
            int driverId = context.Drivers
                           .Where(t => t.Username == selecteddriver)
                           .Select(t => t.Id)
                           .FirstOrDefault();


            //get the id from seleted Vehicle
            string selectedVehicle = VehicleComboBox.SelectedItem.ToString();
            int startVehicle = selectedTrip.IndexOf("NO:") + 3;
            int endVehicle = selectedTrip.IndexOf(" -", startVehicle);
            int vehileNo = int.Parse(selectedTrip.Substring(startVehicle, endVehicle - startVehicle).Trim());


            //int vehileNo = int.Parse(selectedTrip.Substring(selectedTrip.IndexOf("NO:") + 3).Trim()); // Extract TripNo from the string
            int vehicleId = context.Vehicles
                           .Where(t => t.VehicleNo == vehileNo)
                           .Select(t => t.Id)
                           .FirstOrDefault();





            var maintinanceUpdated = context.Maintenances.Where(m => m.Id == maintenanceId).FirstOrDefault();
            maintinanceUpdated.VechieId = vehicleId;
            maintinanceUpdated.DriverId = driverId;
            maintinanceUpdated.TripId = tripid;

            maintinanceUpdated.CostOfMaintenece = decimal.Parse(CostMaintinance.Text);
            context.Maintenances.Update(maintinanceUpdated);


            try
            {
                context.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                frmValidationDialog.showAlert("Error updating maintenance.", FrmValidationDialog.enmType.Warning);

            }

        }


        private void PopulateFormData(Maintenance maintenance)
        {
            // Populate form controls with maintenance data
            if (maintenance != null)
            {
                int vehicleIndex = VehicleComboBox.FindStringExact($"NO:{maintenance.Vehicle.VehicleNo} {maintenance.Vehicle.Model} - {maintenance.Vehicle.Brand}");
                int driverIndex = DriverComboBox.FindStringExact(maintenance.Driver.Username);
                int tripIndex = TripComboBox.FindStringExact($"NO:{maintenance.Trip.TripNo} - {maintenance.Trip.Source} - {maintenance.Trip.Destination}");

                // Set the SelectedIndex of each ComboBox
                if (vehicleIndex != -1)
                    VehicleComboBox.SelectedIndex = vehicleIndex;

                if (driverIndex != -1)
                    DriverComboBox.SelectedIndex = driverIndex;

                if (tripIndex != -1)
                    TripComboBox.SelectedIndex = tripIndex;

                CostMaintinance.Text = context.Maintenances.Where(m => m.Id == maintenanceId).Select(m => m.CostOfMaintenece.ToString()).FirstOrDefault();
            }


        }

        private void VehicleComboBox_TabIndexChanged(object sender, EventArgs e)
        {
            VehicleComboBox.Enabled = false;
        }

    }
}
