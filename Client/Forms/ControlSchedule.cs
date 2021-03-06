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
        string ctent;
        public ControlSchedule(Schedule schedule)
        {
            InitializeComponent();
            TimeSpan restTime = schedule.end - DateTime.Now;
            

            if (schedule.scope == "회사 전체")
                picRangeColor.Image = Resources.lavendar;
            else if (schedule.scope == "본부 전체")
                picRangeColor.Image = Resources.light_blue;
            else if (schedule.scope == "팀 전체")
                picRangeColor.Image = Resources.light_green;
            else if (schedule.scope == "개인")
                picRangeColor.Image = Resources.gold;

            lblSche_Name.Text = schedule.title;
            lblStart.Text = schedule.start.ToString("MM-dd");
            lblEnd.Text = schedule.end.ToString("MM-dd");
            lblDday.Text = "D - " + restTime.Days;
            ctent = schedule.contents;
        }

        private void picContent_Click(object sender, EventArgs e)
        {
            //'+' 아이콘 클릭 시 일정 내용 메세지박스로 출력
            MessageBox.Show(ctent, "스케줄 내용", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
