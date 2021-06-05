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
            ctent = schedule.contents;
        }

        private void picContent_Click(object sender, EventArgs e)
        {
            //'+' 아이콘 클릭 시 일정 내용 메세지박스로 출력
            MessageBox.Show(ctent, "스케줄 내용", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            //클릭 시 스케줄 수동 삭제
            //기간 만기 시 자동삭제는 어디서해야할까?
            var result = MessageBox.Show(
                "일정을 삭제하시겠습니까?",
                "Caption",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.OK)
            {
                //컨트롤 삭제 코드
            }
        }
    }
}
