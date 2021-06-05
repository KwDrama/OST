using OSTLibrary.Chats;
using OSTLibrary.Classes;
using OSTLibrary.Networks;
using OSTLibrary.Securities;
using Client.Forms;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Client.Panels
{
    public partial class PanelSchedule : PanelSlider
    {
        public PanelSchedule(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();
        }
        private void PanelSchedule_Load(object sender, EventArgs e)
        {
            cmbScope.Items.AddRange(Room.Scope);
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            EnterShadow(sender, e);
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {
            LeaveShadow(sender, e);
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            Swipe(false);
        }

        private void tleSubmit_Click(object sender, EventArgs e)
        {
            // Panel -> Client.cs(Server)
            if(dtpStart.Value < DateTime.Now || dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("잘못된 날짜 형식입니다. 날짜를 올바르게 다시 설정해주십시오.",
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Program.Send(new SchedulePacket(new Schedule(Program.employee.id, txtTitle.Text, dtpStart.Value, dtpEnd.Value,
                    cmbScope.SelectedItem as string, txtContent.Text)));
            }
            catch (FormatException) { }
            Swipe(false);
        }
    }
}