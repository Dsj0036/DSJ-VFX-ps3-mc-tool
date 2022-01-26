using PS3Lib;
using System;
using System.Windows.Forms;

namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class att_process_dialog : Form
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();
        public att_process_dialog()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Ded.forms.Mods modspage = new Ded.forms.Mods();

            PS3.ChangeAPI(SelectAPI.PS3Manager);
            if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.ProcessList.SelectedIndex]))
            {

                int num = (int)MessageBox.Show("No se pudo vincular.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                PS3M_API.DisconnectTarget();
            }
            /// PS3 SUCCESFULLY CONNECTED AND ATTACHED MESSAGES.
            /// PS3M_API.PS3.Notify("DED Edition Visual Mod TOOL connected succesfully");
            /// PS3M_API.PS3.Notify("VERSION: 5.5");
            /// PS3M_API.PS3.Notify("Attached to process");
            ///

            ///PC SUCCESFULLY CONNECTED AND ATTACHED MESSAGES.

            MessageBox.Show("Se vinculó correctamente.", ProcessList.Text);
            DialogResult = DialogResult.OK;
            modspage.ShowDialog();


        }

        private void att_process_dialog_Load(object sender, EventArgs e)
        {

            try
            {
                this.ProcessList.Items.Clear();
                foreach (uint num in PS3M_API.Process.GetPidProcesses())
                {
                    if (num == 0u)
                    {
                        break;
                    }
                    this.ProcessList.Items.Add(PS3M_API.Process.GetName(num));
                }
                this.ProcessList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se produjo una excepción al conseguir los PID de procesos de la consola", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;

            /// bait
            ///Form1 Main = new Form1();
            ///Main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    this.ProcessList.Items.Clear();
                    foreach (uint num in PS3M_API.Process.GetPidProcesses())
                    {
                        if (num == 0u)
                        {
                            break;
                        }
                        this.ProcessList.Items.Add(PS3M_API.Process.GetName(num));
                    }
                    this.ProcessList.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Se produjo una excepción al conseguir los PID de procesos de la consola", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}


