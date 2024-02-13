using Microsoft.EntityFrameworkCore;
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
using TransportReservationSystem.Pages;

namespace TransportReservationSystem
{
    public partial class FrmPassengers : Form
    {
        public FrmPassengers()
        {
            InitializeComponent();
        }
        ApplicaitonDbContext context = new ApplicaitonDbContext();

        private void FrmMain_Load(object sender, EventArgs e)
        {

            var finalPassengers = context.Passengers.Where(d => d.IsDeleted == false).ToList();
            PassengersGridView.DataSource = finalPassengers;

        }

        //Open the add passneger Form
        private void AddPassngerBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenNewPassenger);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();


            var finalPassengers = context.Passengers.Where(d => d.IsDeleted == false).ToList();
            PassengersGridView.DataSource = finalPassengers;
        }

        private void OpenNewPassenger()
        {
            Application.Run(new FrmPassengerCrud());
        }

        private void PassengersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int PassengerID = Convert.ToInt32(PassengersGridView.CurrentRow.Cells["Id"].Value);
            var passenger = context.Passengers.Where(d => d.Id == PassengerID).FirstOrDefault();

            if (passenger != null)
            {
                passenger.Email = Convert.ToString(PassengersGridView.CurrentRow.Cells["Email"].Value);
                passenger.Username = Convert.ToString(PassengersGridView.CurrentRow.Cells["Email"].Value);
                passenger.Phone = Convert.ToString(PassengersGridView.CurrentRow.Cells["Phone"].Value);
                passenger.Address = Convert.ToString(PassengersGridView.CurrentRow.Cells["Address"].Value);
                passenger.UpdatedAt = DateTime.Now;


            }

            context.Passengers.Update(passenger);
            context.SaveChanges();

            var finalPassengers = context.Passengers.Where(d => d.IsDeleted == false).ToList();
            PassengersGridView.DataSource = finalPassengers;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            int PassengerID = Convert.ToInt32(PassengersGridView.CurrentRow.Cells["Id"].Value);
            var Passenger = context.Passengers.Where(d => d.Id == PassengerID).FirstOrDefault();
            Passenger.IsDeleted = true;

            context.Passengers.Update(Passenger);
            context.SaveChanges();

            var finalPassengers = context.Passengers.Where(d => d.IsDeleted == false).ToList();
            PassengersGridView.DataSource = finalPassengers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var finalPassengers = context.Passengers.Where(d => d.IsDeleted == false).ToList();
            PassengersGridView.DataSource = finalPassengers;
        }
    }
}

