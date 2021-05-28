using System.Windows.Forms;
using MetroFramework.Forms;
using OSTLibrary.Classes;

namespace Client.Forms
{
    public partial class FormInfo : MetroForm
    {
        public FormInfo(Employee employee)
        {
            InitializeComponent();

            picProfile.Image = employee.profile;
            lblName.Text = employee.name;
            lblPhone.Text = employee.phone;
            lblRank.Text = employee.rank;
            lblTeam.Text = employee.team;
        }

        private void FormInfoPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
