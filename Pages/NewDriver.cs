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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TransportReservationSystem.Pages
{
    public partial class NewDriver : Form
    {
        public NewDriver()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NewDriver_Load(object sender, EventArgs e)
        {

        }
        ApplicaitonDbContext context = new ApplicaitonDbContext();


        
        //ApplicaitonDbContext applicationDbContext = new ApplicaitonDbContext();

        private void AddDriverBtn_Click(object sender, EventArgs e)
        {
            //FrmDrivers fromGrid = new FrmDrivers();
            
            Driver driver = new Driver()
            {
                Username = usernameBox.Text,
                Email = emailBox.Text,
                Password = passwordBox.Text,
                License = decimal.Parse(licenseBox.Text),
                Phone = phoneBox.Text,
                Salary = decimal.Parse(salaryBox.Text),
                HasBouns = hasBonusCheckBox.Checked,
                CurrentStation = stationBox.Text,
                Role = Role.DRIVER.ToString(),



            };

            context.Drivers.Add(driver);
            context.SaveChanges();
            
            this.Close();
            //var drive = context.Drivers.ToList();
            //fromGrid.DriversGrid.DataSource = drive;

        }

    }
    
}
