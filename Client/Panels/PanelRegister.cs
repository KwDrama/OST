using Client.Forms;
using OSTLibrary.Classes;
using OSTLibrary.Networks;
using OSTLibrary.Securities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Panels
{
    public partial class PanelRegister : PanelSlider
    {
        Dictionary<string, string[]> organization;

        public PanelRegister(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();

            organization = new Dictionary<string, string[]>();
            organization.Add("지원본부", new string[] { "지원1팀", "지원2팀", "지원3팀" });
            organization.Add("철강본부", new string[] { "철강1팀", "철강2팀", "철강3팀" });
            organization.Add("섬유본부", new string[] { "섬유1팀", "섬유2팀", "섬유3팀" });
            organization.Add("영업본부", new string[] { "영업1팀", "영업2팀", "영업3팀" });

            foreach (string central in organization.Keys)
                cmbCentral.Items.Add(central);
            cmbCentral.SelectedIndex = 0;
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
        private void picProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp |" +
                "All Files (*.*) | *.*";
            ofd.Title = "프로필 사진 선택";
            if (ofd.ShowDialog() == DialogResult.OK)
                picProfile.Image = Image.FromFile(ofd.FileName);
        }

        private void cmbCentral_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTeam.Items.Clear();
            cmbTeam.Items.AddRange(organization[cmbCentral.SelectedItem as string]);
            cmbTeam.SelectedIndex = 0;
        }
        private void tleSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Send(new RegisterPacket(new Employee(picProfile.Image, int.Parse(txtempId.Text),
                    SHA512.Encrypt(txtPassword.Text), txtName.Text, txtPhone.Text,
                    cmbCentral.SelectedItem as string, cmbTeam.SelectedItem as string, txtRank.Text)));
            }
            catch (FormatException) { }
        }
    }
}
