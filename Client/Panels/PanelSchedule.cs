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
            try
            {
                Program.Send(new SchedulePacket(new Schedule(Program.employee.id, txtTitle.Text, dtpStart.Value, dtpEnd.Value,
                    cmbScope.SelectedItem as string, txtContent.Text)));
            }
            catch (FormatException) { }
        }
    }
}