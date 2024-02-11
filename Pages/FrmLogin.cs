using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using TransportReservationSystem.Pages;

namespace TransportReservationSystem
{

    public partial class FrmLogin : Form
    {
        List<User> users = Repository.LoadUsers();

        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SeedingAdmin.SeedingAdminWithLoginFormStart(); //seeding admin if not found
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            ApplicaitonDbContext applicationDbContext = new ApplicaitonDbContext();
            string email = EmailInput.Text.ToString().Trim();
            string password = PasswordInput.Text.ToString().Trim();
            bool isPassenger = PassengerRBtn.Checked;
            bool isStaff = StaffRBtn.Checked;

            if (string.IsNullOrEmpty(email))
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Email must be required ..!!", FrmValidationDialog.enmType.Warning);
            }
            else if (string.IsNullOrEmpty(password))
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Password must be required ..!!", FrmValidationDialog.enmType.Warning);
            }

            else if (!isPassenger && !isStaff)
            {
                // If not checked, show error message and return
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Please select a role.", FrmValidationDialog.enmType.Warning);

            }

            if (isPassenger)
            {
                Passenger existingPassenger = applicationDbContext.Passengers.FirstOrDefault(p => p.Email == email);
                if (existingPassenger == null)
                {
                    // No passenger found with the provided email
                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert("Incorrect email.", FrmValidationDialog.enmType.Warning);
                    return;
                }
                // Check if the password matches for the found passenger
                if (existingPassenger.Password != password)
                {
                    // Password does not match
                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert("Incorrect password.", FrmValidationDialog.enmType.Warning);
                    return;
                }
                Thread thread = new Thread(OpenDashboard);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();

            }




        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenRegister);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void ShowPasswordBtn_CheckedChanged(object sender, EventArgs e)
        {
            PasswordInput.PasswordChar = ShowPasswordBtn.Checked ? '\0' : '*';
        }

        private void OpenDashboard()
        {
            Application.Run(new FrmDashboard());
        }

        private void OpenRegister()
        {
            Application.Run(new FrmRegister());
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            SeedingAdmin.SeedingAdminWithLoginFormStart(); //seeding admin if not found

        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassengerRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


    }
}
