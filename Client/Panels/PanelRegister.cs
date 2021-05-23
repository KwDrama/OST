﻿using Client.Forms;
using OSTNetwork;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Panels
{
    public partial class PanelRegister : PanelSlider
    {
        public PanelRegister(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();
            
            foreach (string central in FormMain.organization.Keys)
                cmbCentral.Items.Add(central);
            cmbCentral.SelectedIndex = 0;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Swipe(false);
        }
        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            EnterShadow(sender, e);
        }
        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            LeaveShadow(sender, e);
        }
        private void picProfile_MouseEnter(object sender, EventArgs e)
        {
            EnterShadow(sender, e);
        }
        private void picProfile_MouseLeave(object sender, EventArgs e)
        {
            LeaveShadow(sender, e);
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
            cmbTeam.Items.AddRange(FormMain.organization[cmbCentral.SelectedItem as string]);
            cmbTeam.SelectedIndex = 0;
        }
        private void tleSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Send(new RegisterPacket(picProfile.Image, int.Parse(txtempId.Text),
                    txtPassword.Text, txtName.Text, txtPhone.Text, cmbCentral.SelectedItem as string,
                    cmbTeam.SelectedItem as string, txtRank.Text));
            }
            catch (FormatException) { }
        }
    }
}
