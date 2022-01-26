using PS3Lib;
using System;
using System.Windows.Forms;

namespace DED_RTM_VER._2._0_restored.AdditionalForms
{
    public partial class FOV : Form
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();
        public FOV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FOV_Modifier_Track_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para utilizar este modal, debe volver a especificar el proceso.");
            AdditionalForms.AttachToProcessConfirmForm ReAttach2 = new AdditionalForms.AttachToProcessConfirmForm();
            {
                ReAttach2.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x80 }; ///FOV X1///
            byte[] Off = { 0x3F, 0x80 };
            PS3.SetMemory(0x014C670C, radioButton1.Checked ? On : Off);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x60 }; ///FOV X2///
            byte[] Off = { 0x3F, 0x80 };
            PS3.SetMemory(0x014C670C, radioButton2.Checked ? On : Off);
            PS3M_API.PS3.Notify("Cool FOV");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x50 }; ///FOV X3///
            byte[] Off = { 0x3F, 0x80 };
            PS3.SetMemory(0x014C670C, radioButton4.Checked ? On : Off);
            PS3M_API.PS3.Notify("FOV x3");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x40 }; ///FOV X4///
            byte[] Off = { 0x3F, 0x80 };
            PS3.SetMemory(0x014C670C, radioButton3.Checked ? On : Off);
            PS3M_API.PS3.Notify("FOV x4");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x30 }; ///FOV X5///
            byte[] Off = { 0x3F, 0x80 };
            PS3.SetMemory(0x014C670C, radioButton5.Checked ? On : Off);
            PS3M_API.PS3.Notify("FOV x5");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x25 }; ///FOV X6///
            byte[] Off = { 0x3F, 0x80 };
            PS3.SetMemory(0x014C670C, radioButton6.Checked ? On : Off);
            PS3M_API.PS3.Notify("FOV MAXIMO");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x60 }; ///ZOOM///
            byte[] Off = { 0x3F, 0xFF, 0xFF };
            PS3.SetMemory(0x014C670C, radioButton7.Checked ? On : Off);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x3F, 0x80 }; ///FOV X1///
            byte[] Off = { 0x3F, 0x80 };
            PS3.SetMemory(0x014C670C, radioButton8.Checked ? On : Off);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;

        }
    }
}
