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
using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;

namespace TransportReservationSystem.Pages
{
    public partial class FrmPassengerCrud : Form
    {
        public FrmPassengerCrud()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmPassengerCrud_Load(object sender, EventArgs e)
        {

        }
        ApplicaitonDbContext context = new ApplicaitonDbContext();
        private void AddPassengerBtn_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger()
            {
                Username = usernameBox.Text,
                Email = emailBox.Text,
                Password = passwordBox.Text,
                Phone = phoneBox.Text,
                Role = Role.PASSENGER.ToString(),
                Address = addressBox.Text,
                Gender = GenderComboBox.SelectedItem.ToString(),
                IsDeleted = false,
                

            };

            context.Passengers.Add(passenger);
            context.SaveChanges();

            this.Close();
        }
    }
}
