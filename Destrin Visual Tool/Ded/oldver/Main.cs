using PS3Lib;
using System;
using System.Windows.Forms;


namespace DED_RTM_VER._2._0_restored
{
    public partial class DED_RTM : MetroFramework.Forms.MetroForm
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();

        public DED_RTM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdditionalForms.FOV Fov = new AdditionalForms.FOV();
            AdditionalForms.addit_mods Ad_mods = new AdditionalForms.addit_mods();
            AdditionalForms.ConnectForm con = new AdditionalForms.ConnectForm();
            AdditionalForms.AttachToProcessConfirmForm Att = new AdditionalForms.AttachToProcessConfirmForm();
            AdditionalForms.ManyThanks grax = new AdditionalForms.ManyThanks();


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0xFF, 0x60, 0x88, 0x90 }; ///bug///
            byte[] Off = { 0xFF, 0x60, 0x08, 0x90 };
            PS3.SetMemory(0x003ABE28, checkBox6.Checked ? On : Off);

        }

        private void IPConnect_Click(object sender, EventArgs e)
        {   /// Conecction Form
            AdditionalForms.ConnectForm connection = new AdditionalForms.ConnectForm();

            connection.ShowDialog();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            PS3M_API.PS3.Notify("Tags de los jugadores");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {///Debug IDS
            byte[] On = { 0x41 };
            byte[] Off = { 0x40 };
            PS3.SetMemory(0x003097C8, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("IDs de los items");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {///Durabilidad y offset
            byte[] On = { 0x38, 0x80, 0x00, 0x01 };
            byte[] Off = { 0x40, 0x82 };
            PS3.SetMemory(0x0090B5F0, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("Armadura en la pantalla");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        { ///Bytes de flechas espectrales
            byte[] On = { 0x32, 0x20, 0x8D, 0xA0 };
            byte[] Off = { 0x32, 0x1E, 0xAD, 0xA0 };
            PS3.SetMemory(0x014C90D4, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("Flechas Espectrales");
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        { /// Modo espectador codigo
            byte[] On = { 0x32, 0x3A, 0x84, 0xC0 };
            byte[] Off = { 0x32, 0x39, 0x4B, 0xD0 };
            PS3.SetMemory(0x014C9048, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("Modo Espectador");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {///Bypass Stack Limit
            byte[] On = { 0x41 };
            byte[] Off = { 0x40 };
            PS3.SetMemory(0x00310AFC, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("Traspasar el limite comun de objetos x64, a +64.");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {///Suicide
            byte[] On = { 0x3F, 0xFF };
            byte[] Off = { 0x3F, 0xEF };
            PS3.SetMemory(0x003ABDD0, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("Suicidio de gravedad");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart(); Environment.Exit(0);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                try
                {
                    VisitLink();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            void VisitLink()
            {

                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://youtube.com/c/DESTRUCTORRPYGAMING");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                {
                    try
                    {
                        VisitLink();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to open link that was clicked.");
                    }
                }

                void VisitLink()
                {

                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("https://youtube.com/c/DESTRUCTORRPYGAMING");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        VisitLink();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to open link that was clicked.");
                    }
                }

                void VisitLink()
                {

                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("https://youtube.com/c/DESTRUCTORRPYGAMING");
                }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        VisitLink();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to open link that was clicked.");
                    }
                }

                void VisitLink()
                {

                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("https://discord.gg/e263WXzCnQ");
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void VisitLink()
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://discord.com/e263WXzCnQ");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">:3");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {


        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            // SIN ASIGNAR
            PS3M_API.PS3.Notify("Activaste la casilla FOV, ahora puedes inyectarte un campo de vision modificado. ");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x41 }; /// Lock Weather/// 
            byte[] Off = { 0x40 };
            PS3.SetMemory(0x00393E84, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("Mantener Clima");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            byte[] On = { 0x3E }; /// LITTLE RAIN/// 
            byte[] Off = { 0x3F };
            PS3.SetMemory(0x00393E34, checkBox6.Checked ? On : Off);
            PS3M_API.PS3.Notify("Llovizna");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AdditionalForms.addit_mods addit_mods_modal = new AdditionalForms.addit_mods();
            addit_mods_modal.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AdditionalForms.ManyThanks manythanks = new AdditionalForms.ManyThanks();
            manythanks.ShowDialog();
        }

        private void ipcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            AdditionalForms.AttachToProcessConfirmForm ReconnectForm = new AdditionalForms.AttachToProcessConfirmForm();
            ReconnectForm.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PS3M_API.DisconnectTarget();

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void VisitLink()
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("        https://www.youtube.com/redirect?event=video_description&redir_token=QUFFLUhqbXZTWl9ONHBFU1hTS2xudEo5SHdLTDk3UUNMUXxBQ3Jtc0ttbDkzVEZkSUVvYzFSUXR4WWhVc2RiNENMVVdnVDUxWENhY2pmZmlTMTZLZlZMdnRlR0hnbEV4QzJUVm9sNzVwdUg1N3hhNV9RbWVMdi1lRTBHXzRBYjRFSHFPZGg4Q0ZiM2pvVEhqaWkyaFhFTXhscw&q=https%3A%2F%2Fdiscord.gg%2FNDUAgBDXHa");
            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AdditionalForms.FOV Fov = new AdditionalForms.FOV();
            {

                Fov.ShowDialog();

            }
        }

        private void materialSlider1_Click(object sender, EventArgs e)
        {

        }


        private void DED_RTM_Load(object sender, EventArgs e)
        {

        }
    }
}


