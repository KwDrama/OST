using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Properties;
using MetroFramework.Controls;
using OSTLibrary.Classes;

namespace Client.Forms
{
    public partial class ControlSchedule : MetroUserControl
    {
        public ControlSchedule(Schedule schedule)
        {
            InitializeComponent();

            if (schedule.range == "회사 전체")
                picRangeColor.Image = Resources.lavendar;
            else if (schedule.range == "본부 전체")
                picRangeColor.Image = Resources.light_blue;
            else if (schedule.range == "팀 전체")
                picRangeColor.Image = Resources.light_green;
            else if (schedule.range == "개인")
                picRangeColor.Image = Resources.gold;

            lblSche_Name.Text = schedule.title;
            lblStart.Text = schedule.start.ToString("MM-dd");
            lblEnd.Text = schedule.end.ToString("MM-dd");

        }
        

        private void picContent_Click(object sender, EventArgs e)
        {
            //'+' 아이콘 클릭 시 일정 내용 메세지박스로 출력
            //MessageBox.Show();

        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            //클릭 시 스케줄 수동 삭제
        }
    }
}
