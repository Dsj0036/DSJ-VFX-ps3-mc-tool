using PS3Lib;
using System;
using System.Windows.Forms;


namespace DED_RTM_VER._2._0_restored.AdditionalForms
{
    public partial class AttachToProcessConfirmForm : Form
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();
        public AttachToProcessConfirmForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            PS3.ChangeAPI(SelectAPI.PS3Manager);
            if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.AttachMethod.SelectedIndex]))
            {

                int num = (int)MessageBox.Show("No se pudo vincular.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                PS3M_API.DisconnectTarget();
            }
            PS3M_API.PS3.Notify("DEPR 5.0 Vinculado a el proceso. NO SELECIONE OTRO PROCESO ADEMAS DE MAIN_EBOOT");
            MessageBox.Show("Se vinculó correctamente.");
            DialogResult = DialogResult.OK;
            {

            }
        }

        private void AttachToProcessConfirmForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.AttachMethod.Items.Clear();
                foreach (uint num in PS3M_API.Process.GetPidProcesses())
                {
                    if (num == 0u)
                    {
                        break;
                    }
                    this.AttachMethod.Items.Add(PS3M_API.Process.GetName(num));
                }
                this.AttachMethod.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se ha producido un error (00x1)", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult = DialogResult.Cancel;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

