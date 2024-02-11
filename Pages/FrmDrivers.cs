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
using TransportReservationSystem.Pages;

namespace TransportReservationSystem
{
    public partial class FrmDrivers : Form
    {
        //public DataGridView DriversGrid {
        //    get => DriversGridView;
        //    set => DriversGridView = value;
        //}

        public FrmDrivers()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddDriverBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenNewDriver);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            var driver = context.Drivers.ToList();
            DriversGridView.DataSource = driver;
        }

        private void OpenNewDriver()
        {
            Application.Run(new NewDriver());


        }
        ApplicaitonDbContext context = new ApplicaitonDbContext();
        private void FrmDrivers_Load(object sender, EventArgs e)
        {
            var driver = context.Drivers.ToList();
            DriversGridView.DataSource = driver;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var driver = context.Drivers.ToList();
            DriversGridView.DataSource = driver;


            //DriversGrid.DataSource = driver;
            //DriversGridView.DataSource = DriversGrid.DataSource;
        }

        //private void UpdateBtn_Click(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow updatedRow = DriversGridView.Rows[e.RowIndex];
        //    int DriverId = Convert.ToInt32(updatedRow.Cells["Id"].Value);

        //    //DriversGridView.Rows[e.RowIndx]
        //}

        //private void UpdateBtn_Click(object sender, DataGridViewCellEventArgs e)
        //{
        //    //DataGridViewRow updatedRow = DriversGridView.Rows[e.RowIndex];
        //    DataGri
        //    //int DriverId = int.Parse(ViewState["Id"].ToString());
        //    int DriverId = Convert.ToInt32(updatedRow.Cells["Id"].Value);
        //    var driver = context.Drivers.Where(d => d.Id == DriverId).FirstOrDefault();

        //}

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int DriverId = Convert.ToInt32(DriversGridView.CurrentRow.Cells["Id"].Value);
            var driver = context.Drivers.Where(d => d.Id == DriverId).FirstOrDefault();

            if (driver != null)
            {
                driver.Email = Convert.ToString(DriversGridView.CurrentRow.Cells["Email"].Value);
                driver.License = Convert.ToDecimal(DriversGridView.CurrentRow.Cells["License"].Value);
                driver.Salary = Convert.ToDecimal(DriversGridView.CurrentRow.Cells["Salary"].Value);
                driver.Username = Convert.ToString(DriversGridView.CurrentRow.Cells["Email"].Value);
                driver.Phone = Convert.ToString(DriversGridView.CurrentRow.Cells["Phone"].Value);
                driver.UpdatedAt = DateTime.Now;
            }

            context.Drivers.Update(driver);
            context.SaveChanges();
            var FinalDrivers = context.Drivers.ToList();
            DriversGridView.DataSource = FinalDrivers;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            int DriverId = Convert.ToInt32(DriversGridView.CurrentRow.Cells["Id"].Value);
            var driver = context.Drivers.Where(d => d.Id == DriverId).FirstOrDefault();
            context.Drivers.Remove(driver);
            context.SaveChanges();
            var FinalDrivers = context.Drivers.ToList();
            DriversGridView.DataSource = FinalDrivers;
        }
    }
}
