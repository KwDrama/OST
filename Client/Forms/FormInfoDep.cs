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
    public partial class FormInfoDep : MetroForm
    {
        public FormInfoDep()
        {
            InitializeComponent();
        }

        private void FormInfoDep_Shown(object sender, EventArgs e)
        {
            //DB에 부서명 업무 추가한 후 불러오기
            //picDepartment.Image = ;
            //lblName.Text = "부서명: " + ;
            //lblContent.Text = "업무" + ;
        }

        private void FormInfoDep_KeyDown(object sender, KeyEventArgs e)
        {
            if((Keys)e.KeyValue == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
