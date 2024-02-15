using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;

namespace TransportReservationSystem.Pages
{
    public partial class FrmMaintinance : Form
    {
        ApplicaitonDbContext context = new ApplicaitonDbContext();
        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
        Maintenance mnt = new Maintenance();
        public static FrmMaintinance intstanceMnt;


        public FrmMaintinance()
        {
            InitializeComponent();
            intstanceMnt = this;


        }
        //Load All Maintinance:
        private void FrmMaintinance_Load(object sender, EventArgs e)
        {
             //Display Maintinances which status is not soft deleted(IsDeleted == false)
            var finalMaintinance = context.Maintenances.Where(d => d.IsDeleted == false).Select(m => new
            {
                Id = m.Id,
                Vehicle = (context.Vehicles.Where(v => v.Id == m.VechieId).Select(v => v.Brand + "-" + v.Model).FirstOrDefault()),
                Driver = (context.Drivers.Where(v => v.Id == m.DriverId).Select(v => v.Username).FirstOrDefault()),
                Trip = (context.Trips.Where(v => v.Id == m.TripId).Select(v => v.TripNo + "-" + v.Source + '-' + v.Destination).FirstOrDefault()),
                Cost = m.CostOfMaintenece
            }).ToList();
            MaintinacesGridView.DataSource = finalMaintinance;

        }


        //Add Maintinance:
        private void AddReservationBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenNewReservation);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            //Display Maintinances which status is not soft deleted(IsDeleted == false)
            var finalMaintinance = context.Maintenances.Where(d => d.IsDeleted == false).Select(m => new
            {
                Id = m.Id,
                Vehicle = (context.Vehicles.Where(v => v.Id == m.VechieId).Select(v => v.Brand + "-" + v.Model).FirstOrDefault()),
                Driver = (context.Drivers.Where(v => v.Id == m.DriverId).Select(v => v.Username).FirstOrDefault()),
                Trip = (context.Trips.Where(v => v.Id == m.TripId).Select(v => v.TripNo + "-" + v.Source + '-' + v.Destination).FirstOrDefault()),
                Cost = m.CostOfMaintenece
            }).ToList();
            MaintinacesGridView.DataSource = finalMaintinance;

        }
        private void OpenNewReservation()
        {
            Application.Run(new FrmMaintinanceCrud());
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int MntId { get; set; }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Selected maintinance
            int maintinanaceId = Convert.ToInt32(MaintinacesGridView.CurrentRow.Cells["Id"].Value);
            mnt.Id = maintinanaceId;


            var maintinance = context.Maintenances.Where(d => d.CostOfMaintenece == maintinanaceId).FirstOrDefault();
            MntId = maintinanaceId;

            // Check if a maintenance is selected in the DataGridView
            if (MaintinacesGridView.CurrentRow != null)
            {
                // Get the maintenance ID from the selected row
                int maintenanceId = Convert.ToInt32(MaintinacesGridView.CurrentRow.Cells["Id"].Value);


                FrmUpdateMaintinance updateMntform = new FrmUpdateMaintinance();
                updateMntform.maintenanceId = maintenanceId;
                updateMntform.FormClosed += button1_Click;

                updateMntform.Show();

                context.SaveChanges();

            }
            else
            {
                // Display a message or handle the case where no maintenance is selected
                frmValidationDialog.showAlert("Select Maintinance to Update.", FrmValidationDialog.enmType.Warning);
                return;
            }
          




            
        }



        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(MaintinacesGridView.CurrentRow == null)
            {
                // Display a message or handle the case where no maintenance is selected
                frmValidationDialog.showAlert("No Maintinace to be Deleted", FrmValidationDialog.enmType.Warning);
                return;
            }
            int? maintinanaceID = Convert.ToInt32(MaintinacesGridView.CurrentRow.Cells["Id"].Value);
            var maintinance = context.Maintenances.Where(d => d.Id == maintinanaceID).FirstOrDefault();
            maintinance.IsDeleted = true;

            context.Maintenances.Update(maintinance);
            context.SaveChanges();


            //Display Maintinances which status is not soft deleted(IsDeleted == false)
            var finalMaintinance = context.Maintenances.Where(d => d.IsDeleted == false).Select(m => new
            {
                Id = m.Id,
                Vehicle = (context.Vehicles.Where(v => v.Id == m.VechieId).Select(v => v.Brand + "-" + v.Model).FirstOrDefault()),
                Driver = (context.Drivers.Where(v => v.Id == m.DriverId).Select(v => v.Username).FirstOrDefault()),
                Trip = (context.Trips.Where(v => v.Id == m.TripId).Select(v => v.TripNo + "-" + v.Source + '-' + v.Destination).FirstOrDefault()),
                Cost = m.CostOfMaintenece
            }).ToList();
            MaintinacesGridView.DataSource = finalMaintinance;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Display Maintinances which status is not soft deleted(IsDeleted == false)
            var finalMaintinance = context.Maintenances.Where(d => d.IsDeleted == false).Select(m => new
            {
                Id = m.Id,
                Vehicle = (context.Vehicles.Where(v => v.Id == m.VechieId).Select(v => v.Brand + "-" + v.Model).FirstOrDefault()),
                Driver = (context.Drivers.Where(v => v.Id == m.DriverId).Select(v => v.Username).FirstOrDefault()),
                Trip = (context.Trips.Where(v => v.Id == m.TripId).Select(v => v.TripNo + "-" + v.Source + '-' + v.Destination).FirstOrDefault()),
                Cost = m.CostOfMaintenece
            }).ToList();
            MaintinacesGridView.DataSource = finalMaintinance;
        }


        //private void OpenUpdateMaintiance()
        //{
        //    Application.Run(new UpdateMaintinance());
        //}


        //private void openUpdateForm()
        //{
        //    Application.Run(new UpdateFrom());
        //}

    }

}
