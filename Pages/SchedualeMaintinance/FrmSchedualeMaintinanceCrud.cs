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
    public partial class FrmSchedualeMaintinanceCrud : Form
    {
        ApplicaitonDbContext context = new ApplicaitonDbContext();
        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
        public FrmSchedualeMaintinanceCrud()
        {
            InitializeComponent();
        }

        private void FrmSchedualeMaintinanceCrud_Load(object sender, EventArgs e)
        {
            VehicleComboBox.Items.Clear();

            // Add Select Vehicle item as the first item
            VehicleComboBox.Items.Add("Select Vehicle");

            // Add the vehicle the data source
            foreach (var item in context.Vehicles.Select(v => "No:"  + v.VehicleNo + " - " + v.Model + " - " + v.Brand).ToList())
            {
                VehicleComboBox.Items.Add(item);
            }

            // set the default selected index to the text "Select Vehicle"
            VehicleComboBox.SelectedIndex = 0;



        }

        private void AddMaintinanceBtn_Click(object sender, EventArgs e)
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


            ScheduleMaintence Sch_Mnt = new ScheduleMaintence()
            {
                VechieId = vehicleId,
                MainteneceDateStart = startDate.Value,
                MainteneceDateEnd = endDate.Value,
                CreatedAt= DateTime.Now,
                
            };

            if (Sch_Mnt.MainteneceDateEnd <= Sch_Mnt.MainteneceDateStart)
            {
                frmValidationDialog.showAlert("Enter Valid Date", FrmValidationDialog.enmType.Warning);
                //to return to the form without checking the comming driver combobox.
                return;
            }
            if (Sch_Mnt.MainteneceDateEnd <= DateTime.Now)
            {
                Sch_Mnt.IsMainteneceDone = true;
            }
            context.ScheduleMaintences.Add(Sch_Mnt);
            context.SaveChanges();
            this.Close();
        }

       

    }
}
