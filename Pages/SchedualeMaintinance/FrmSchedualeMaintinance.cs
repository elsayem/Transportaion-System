using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FrmSchedualeMaintinance : Form
    {
        ApplicaitonDbContext context = new ApplicaitonDbContext();
        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();

        ScheduleMaintence SchadualeMnt = new ScheduleMaintence();
        public static FrmSchedualeMaintinance intstanceMnt;

        public FrmSchedualeMaintinance()
        {
            InitializeComponent();
        }

        private void FrmSchedualeMaintinance_Load(object sender, EventArgs e)
        {

            UpdateGridView();
        }

        private void AddSchedule_MaintinaceBtn_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(OpenNewSch_maintinance);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();


            UpdateGridView();

        }

        private void OpenNewSch_maintinance()
        {
            Application.Run(new FrmSchedualeMaintinanceCrud());
        }

        //FunctionColumn to Update gridView
        private void UpdateGridView()
        {
            var sch_Maintinance = context.ScheduleMaintences.Where(m => m.IsDeleted == false).Select(m => new
            {
                Id = m.Id,
                Vehicle = (context.Vehicles.Where(v => v.Id == m.VechieId).Select(v => v.Brand + "-" + v.Model).FirstOrDefault()),
                MainteneceStartDate = m.MainteneceDateStart,
                MainteneceEndDate = m.MainteneceDateEnd,
            }).ToList();

            Sch_MaintinacesGridView.DataSource = sch_Maintinance;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //int Schedule_Maintinance_Id = Convert.ToInt32(Sch_MaintinacesGridView.CurrentRow.Cells["Id"].Value);

            //var Sch_Maintinance = context.ScheduleMaintences.Where(m => m.Id == Schedule_Maintinance_Id).FirstOrDefault();


            // Check if a maintenance is selected in the DataGridView
            if (Sch_MaintinacesGridView.CurrentRow != null)
            {
                // Get the maintenance ID from the selected row
                int Schedule_Maintinance_Id = Convert.ToInt32(Sch_MaintinacesGridView.CurrentRow.Cells["Id"].Value);
                var Sch_Maintinance = context.ScheduleMaintences.Where(m => m.Id == Schedule_Maintinance_Id).FirstOrDefault();


                FrmUpdateSchedualeMaintinance updateMntform = new FrmUpdateSchedualeMaintinance();
                updateMntform.Sch_maintenanceId = Schedule_Maintinance_Id;
                updateMntform.FormClosed += referesh_Click;

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

        private void referesh_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Sch_MaintinacesGridView.CurrentRow == null)
            {
                // Display a message or handle the case where no maintenance is selected
                frmValidationDialog.showAlert("No Maintinace to be Deleted", FrmValidationDialog.enmType.Warning);
                return;
            }
            int? Sch_maintinanaceID = Convert.ToInt32(Sch_MaintinacesGridView.CurrentRow.Cells["Id"].Value);
            var Sch_maintinance = context.ScheduleMaintences.Where(d => d.Id == Sch_maintinanaceID).FirstOrDefault();
            Sch_maintinance.IsDeleted = true;
            
            context.ScheduleMaintences.Update(Sch_maintinance);
            context.SaveChanges();

            UpdateGridView();

        }
    }
}
