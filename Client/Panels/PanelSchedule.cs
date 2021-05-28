using OSTLibrary.Chats;
using System;
using System.Windows.Forms;

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
    }
}