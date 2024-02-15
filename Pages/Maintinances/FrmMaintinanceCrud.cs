using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransportReservationSystem.Pages
{
    public partial class FrmMaintinanceCrud : Form
    {
        ApplicaitonDbContext context = new ApplicaitonDbContext();
        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();

        public FrmMaintinanceCrud()
        {
            InitializeComponent();
        }

        private void FrmMaintinanceCrud_Load(object sender, EventArgs e)
        {

            //Vehicle Combo Box:
            VehicleComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            VehicleComboBox.Items.Add("Select Vehicle");

            // Add the vehicle the data source
            foreach (var item in context.Vehicles.Select(v => "NO:" + v.VehicleNo + v.Model + " - " + v.Brand).ToList())
            {
                VehicleComboBox.Items.Add(item);
            }

            // set the default selected index to the text "Select Vehicle"
            VehicleComboBox.SelectedIndex = 0;
            //
            //VehicleComboBox.DataSource = (context.Vehicles.Select(v => v.Model + " - " + v.Brand + " - NO:" + v.VehicleNo).ToList());

            //Driver Combo Box
            DriverComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            DriverComboBox.Items.Add("Select Driver Name");

            // Add the vehicle the data source
            foreach (var item in context.Drivers.Select(v => v.Username).ToList())
            {
                DriverComboBox.Items.Add(item);
            }

            // set the default selected index to the text "Select Driver"
            DriverComboBox.SelectedIndex = 0;

            //Trip Combo Box
            TripComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            TripComboBox.Items.Add("Select Trip");

            // Add the vehicle the data source
            foreach (var item in context.Trips.Select(v => "NO:" + v.TripNo + " - " + v.Source + " - " + v.Destination).ToList())
            {
                TripComboBox.Items.Add(item);
            }

            // set the default selected index to the text "Select Trip"
            TripComboBox.SelectedIndex = 0;

        }

        private void VehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //to make textbox of cost maintnace accept only Numbers
        private void CostMaintinance_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddMaintinanceBtn_Click(object sender, EventArgs e)
        {
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
            int startVehicle = selectedVehicle.IndexOf("No:") + 3;
            int endVehicle = selectedVehicle.IndexOf(" -", startVehicle);
            int vehileNo = int.Parse(selectedTrip.Substring(startVehicle, endVehicle - startVehicle).Trim());


            //int vehileNo = int.Parse(selectedTrip.Substring(selectedTrip.IndexOf("NO:") + 3).Trim()); // Extract TripNo from the string
            int vehicleId = context.Vehicles
                           .Where(t => t.VehicleNo == vehileNo)
                           .Select(t => t.Id)
                           .FirstOrDefault();




            Maintenance maintinace = new Maintenance()
            {
                TripId = tripid,
                DriverId = driverId,
                VechieId = vehicleId,
                CostOfMaintenece = decimal.Parse(CostMaintinance.Text),

            };
            context.Maintenances.Add(maintinace);

            context.SaveChanges();

            this.Close();

        }
    }
}
