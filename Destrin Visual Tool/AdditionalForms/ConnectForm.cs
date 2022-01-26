using PS3Lib;
using System;
using System.Windows.Forms;
///using MaterialDesignThemes;
///using MaterialDesignColors;

namespace DED_RTM_VER._2._0_restored.AdditionalForms
{
    public partial class ConnectForm : Form
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void ipcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            {
                try
                {
                    PS3M_API.ConnectTarget(ipcon.Text, Convert.ToInt32(7887));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Host Desconocido (00x6)", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    DialogResult = DialogResult.Abort;
                }
            }
            {
                ///ATTACH MODAL
                AdditionalForms.AttachToProcessConfirmForm AttachModal = new AttachToProcessConfirmForm();
                ///MAPI
                AttachModal.ShowDialog();
            }
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}



