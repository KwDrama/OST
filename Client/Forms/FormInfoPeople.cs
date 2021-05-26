using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Client.Forms
{
    public partial class FormInfoPeople : MetroForm
    {
        public FormInfoPeople()
        {
            InitializeComponent();
        }

        private void FormInfoPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if((Keys)e.KeyValue == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormInfoPeople_Shown(object sender, EventArgs e)
        {
            picProfile.Image = Program.employee.profile;
            lblName.Text = "이름: " + Program.employee.name;
            lblRank.Text = "직급: " + Program.employee.rank;
            lblTeam.Text = "부서: " + Program.employee.team;
            lblPhoneNum.Text = "연락처: " + Program.employee.phone;
        }
    }
}
