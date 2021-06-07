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
        public static string[] target1 = { "자원본부", "철강본부", "섬유본부", "영업본부" };
        public static string[] target2 = { "자원1팀", "자원2팀", "자원3팀" };
        public static string[] target3 = { "철강1팀", "철강2팀", "철강3팀" };
        public static string[] target4 = { "섬유1팀", "섬유2팀", "섬유3팀" };
        public static string[] target5 = { "영업1팀", "영업2팀", "영업3팀" };
        public static string[] target6 = { "회사 전체" };
        public static string[] target7 = { "개인" };

        FormMain owner;
        public PanelSchedule(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();

            this.owner = owner as FormMain;
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
                    cmbScope.SelectedItem as string, txtContent.Text, cmbTarget.SelectedItem as string)));
            }
            catch (FormatException) { }
            Swipe(false);
        }

        //scope에 따라 다음 콤보박스 item 항목 바꾸기
        private void cmbScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScope.SelectedItem.ToString() == "본부 전체")
            {
                cmbTarget.Items.AddRange(target1);
            }
            else if (cmbScope.SelectedItem.ToString() == "팀 전체")
            {
                if (Program.employee.central == "자원본부")
                    cmbTarget.Items.AddRange(target2);
                else if (Program.employee.central == "철강본부")
                    cmbTarget.Items.AddRange(target3);
                else if (Program.employee.central == "섬유본부")
                    cmbTarget.Items.AddRange(target4);
                else if (Program.employee.central == "영업본부")
                    cmbTarget.Items.AddRange(target5);
            }
            else if (cmbScope.SelectedItem.ToString() == "회사 전체")
                cmbTarget.Items.AddRange(target6);
            else
                cmbTarget.Items.AddRange(target7);
        }
    }
}