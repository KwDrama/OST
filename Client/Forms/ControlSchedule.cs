using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Client.Forms
{
    public partial class ControlSchedule : MetroUserControl
    {
        public ControlSchedule()
        {
            InitializeComponent();

            determine_Color();
        }
        
        private void determine_Color()
        {
            //경우에 따라 imagelist color 설정
        }

        private void picContent_Click(object sender, EventArgs e)
        {
            //'+' 아이콘 클릭 시 일정 내용 메세지박스로 출력

        }
    }
}
