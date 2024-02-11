using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using ValidationResult = TransportReservationSystem.Core.Constants.ValidationResult;

namespace TransportReservationSystem.Pages
{

    public partial class FrmRegister : Form
    {
        private static ApplicaitonDbContext context = new ApplicaitonDbContext();

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            
        }




        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            ApplicaitonDbContext applicationDbContext = new ApplicaitonDbContext();

            string email = EmailInput.Text.ToString().Trim();
            string password = PasswordInput.Text.ToString().Trim();
            string gender = comboBox1?.SelectedItem?.ToString();
            string phone = PhoneInput.Text;
            string username = email?.Split('@')?.FirstOrDefault();
            string address = AddressInput.Text;

            PassengerVm passengerVm = new PassengerVm()
            {
                Username = username,
                Email = email,
                Password = password,
                Gender = gender,
                Phone = phone,
                Address = address
            };
            // Check if passenger with the same email already exists
            Passenger existingPassenger = applicationDbContext.Passengers.FirstOrDefault(p => p.Email == email);
            if (existingPassenger != null)
            {
                // Passenger with the same email already exists
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("User with the same email already exist.", FrmValidationDialog.enmType.Warning);
                return;
            }

            ValidationResult validationResult = Validation.PassengerValidation(passengerVm);

            if (validationResult.IsValid)
            {
                Passenger passenger = new Passenger()
                {
                    Username = passengerVm.Username,
                    Email = passengerVm.Email,
                    Password = passengerVm.Password,
                    Gender = passengerVm.Gender,
                    Phone = passengerVm.Phone,
                    Address = passengerVm.Address,
                    Role = Role.PASSENGER.ToString()

                };

                applicationDbContext.Passengers.Add(passenger);
                applicationDbContext.SaveChanges();



                Thread thread = new Thread(OpenLogin);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            else
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert(validationResult.MessageError, FrmValidationDialog.enmType.Warning);
            }

        }

        //**************************************************************************


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void OpenLogin()
        {
            Application.Run(new FrmLogin());
        }
        
    }
}
