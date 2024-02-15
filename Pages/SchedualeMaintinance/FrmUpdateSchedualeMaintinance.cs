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

namespace TransportReservationSystem.Pages.SchedualeMaintinance
{
    public partial class FrmUpdateSchedualeMaintinance : Form
    {

        ApplicaitonDbContext context = new ApplicaitonDbContext();
        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
        public int Sch_maintenanceId { get; set; }
        public FrmUpdateSchedualeMaintinance()
        {
            InitializeComponent();
        }

        private void FrmUpdateSchedualeMaintinance_Load(object sender, EventArgs e)
        {
            VehicleComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            VehicleComboBox.Items.Add("Select Vehicle");

            // Add the vehicle the data source

            foreach (var vehicle in context.Vehicles)
            {
                string vehicleDetails = $"No:{vehicle.VehicleNo} - {vehicle.Model} - {vehicle.Brand}";
                VehicleComboBox.Items.Add(vehicleDetails);
            }
            var Sch_Maintinance = context.ScheduleMaintences.Where(s => s.Id == Sch_maintenanceId).FirstOrDefault();

            if (Sch_maintenanceId != null)
            {
                int vehicleIndex = VehicleComboBox.FindStringExact($"No:{Sch_Maintinance.Vehicle.VehicleNo} - {Sch_Maintinance.Vehicle.Model} - {Sch_Maintinance.Vehicle.Brand}");

                // Set the SelectedIndex of each ComboBox
                if (vehicleIndex != -1)
                    VehicleComboBox.SelectedIndex = vehicleIndex;


                startDate.Value = context.ScheduleMaintences.Where(s => s.Id == Sch_maintenanceId).Select(s => s.MainteneceDateStart).FirstOrDefault();
                endDate.Value = context.ScheduleMaintences.Where(s => s.Id == Sch_maintenanceId).Select(s => s.MainteneceDateEnd).FirstOrDefault();
            }

        }

        private void UpdateMaintinanceBtn_Click(object sender, EventArgs e)
        {
            if (VehicleComboBox.SelectedIndex == 0)
            {
                frmValidationDialog.showAlert("No Selected Vehicle.", FrmValidationDialog.enmType.Warning);
                //to return to the form without checking the comming driver combobox.
                return;

            }



            //get the id from seleted Vehicle
            string selectedVehicle = VehicleComboBox.SelectedItem.ToString();
            int startVehicle = selectedVehicle.IndexOf("No:") + 3;
            int endVehicle = selectedVehicle.IndexOf(" - ", startVehicle);
            int vehileNo = int.Parse(selectedVehicle.Substring(startVehicle, endVehicle - startVehicle).Trim());


            //int vehileNo = int.Parse(selectedTrip.Substring(selectedTrip.IndexOf("NO:") + 3).Trim()); // Extract TripNo from the string
            int vehicleId = context.Vehicles
                           .Where(t => t.VehicleNo == vehileNo)
                           .Select(t => t.Id)
                           .FirstOrDefault();


            //ScheduleMaintence Sch_Mnt = new ScheduleMaintence()
            //{
            //    VechieId = vehicleId,
            //    MainteneceDateStart = startDate.Value,
            //    MainteneceDateEnd = endDate.Value,
            //    CreatedAt = DateTime.Now,

            //};
            var Sch_Maintinance = context.ScheduleMaintences.Where(s => s.Id == Sch_maintenanceId).FirstOrDefault();
            Sch_Maintinance.VechieId = vehicleId;
            Sch_Maintinance.MainteneceDateStart = startDate.Value;
            Sch_Maintinance.MainteneceDateEnd = endDate.Value;
            Sch_Maintinance.UpdatedAt = DateTime.Now;

            if (Sch_Maintinance.MainteneceDateEnd <= DateTime.Now)
            {
                Sch_Maintinance.IsMainteneceDone = true;
            }


            if (Sch_Maintinance.MainteneceDateEnd <= Sch_Maintinance.MainteneceDateStart)
            {
                frmValidationDialog.showAlert("Enter Valid Date", FrmValidationDialog.enmType.Warning);
                //to return to the form without checking the comming driver combobox.
                return;
            }
            context.ScheduleMaintences.Update(Sch_Maintinance);
            
            context.SaveChanges();
            this.Close();
        }
    }
}
    