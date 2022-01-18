using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;
using PS3ManagerAPI;
using DiscordRPC;
using DiscordRPC.Logging;
using MaterialSkin;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class Mods : Form
    {

        System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();

        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();
        public Mods()
        {
            InitializeComponent();

        }

        public DiscordRpcClient client;
        bool initalized = false;
        private void Mods_Load(object sender, EventArgs e)
        {
           
            if (PS3M_API.IsConnected == false)
            {
                #region Default Event
                con_label.Text = "Not connected";
                desconectarToolStripMenuItem.Enabled = false;
                this.pictureBox1.Image = global::Destrin_Visual_Tool.Properties.Resources.skinGraphicsInGame_141;
                #endregion

                #region custom notification 
                ntw.Visible = true;
                ntw.Icon = SystemIcons.Information;
                ntw.BalloonTipTitle = "PS3 Manager API";

                ntw.BalloonTipText = "No se conectó a ninguna consola. Las modificaciones no estan disponibles.";
                ntw.Text = "Con_text";
                ntw.ShowBalloonTip(500);
                #endregion

                #region Mods
                {
                    fov_.Enabled = false;
                    fov_.Visible = false;
                    mods_groupbox.Hide();
                    mess_box.Visible = true;
                    mess_box.Enabled = true;
                    mess_box.BringToFront();
                }
                #endregion
            }
            else if (PS3M_API.IsConnected == true)
            {
                con_label.Text = "Connected";
                desconectarToolStripMenuItem.Enabled = true;
                this.pictureBox1.Image = global::Destrin_Visual_Tool.Properties.Resources.skinGraphicsInGame_1291;
                ntw.Visible = false;
                ntw.Icon = SystemIcons.Information;
                ntw.BalloonTipTitle = "PS3 Manager API";
                ntw.BalloonTipText = "Se conecto y vinculó correctamente.";
                ntw.Text = "Con_text";
                ntw.ShowBalloonTip(500);
                mess_box.Hide();
                loc.Text = PS3M_API.Log;
                fov_.Enabled = true;
                loc.Enabled = true;
                

            }
            else if (PS3M_API.IsConnected == false)
            {
                try
                {
                  
                    initalized = true;
                    client = new DiscordRpcClient("929438860386140190");
                    client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                    client.Initialize();
                    client.SetPresence(new DiscordRPC.RichPresence()
                    {
                        Details = $"No conectado",
                        State = $"En la pantalla de Mods",
                        Timestamps = Timestamps.Now,
                        Assets = new Assets()
                        {
                            LargeImageKey = $"largeico",
                            LargeImageText = "Dedition Visual Effects Tool For MC PS3 ",
                            ///SmallImageKey = $"{textBox5.Text}"


                        }
                    });
                }
                catch
                {
                    MessageBox.Show("Se produjo un error al iniciar la RPC de Discord", "Error", MessageBoxButtons.RetryCancel);
                }
            
            }
            
            functions_timer.Start();

        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;


        }

        private void materialSlider1_Click(object sender, EventArgs e)
        {
           
        }
        private void materialSlider1_Scroll(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarTodosLosModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

            }


            {

            }
        }
        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /// Conecction Form
            ///   DialogResult = DialogResult.OK;
            ///   Form1 Con_diag = new Form1();
            ///   Con_diag.ShowDialog();
            Application.Restart(); Environment.Exit(0);
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCinKPxoqVHoZwpIWJ3zppdw");
        }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/ZHDfyuJmcv");
        }

        private void revincularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PS3M_API.DisconnectTarget();
                desconectarToolStripMenuItem.Enabled = false;
                ntw.Icon = SystemIcons.Information;
                ntw.Text = "Destrin Visual Tool";
                ntw.BalloonTipText = "Desconectado correctamente";
                ntw.BalloonTipTitle = "Conexión";
            }
            catch
            {
                MessageBox.Show("Se produjo una excepción. No se desconectó.");
            }
        }

        private void materialCheckbox5_CheckedChanged(object sender, EventArgs e)
        {
            {




            }
        }

        private void fov_slider_Scroll(object sender, EventArgs e)
        {

        }

        private void fov_slider_Click(object sender, EventArgs e)
        {



        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            ///  byte[] On = { 0x3F, 0x80 }; ///FOV X1///
            //  byte[] Off = { 0x3F, 0x80 };
            //   progressBar1.Value = 100;
            //   PS3.SetMemory(0x014C670C, materialRadioButton1.Checked ? On : Off);
            //   progressBar1.Value = 0;


        }
        ///   private void materialradioButton2_CheckedChanged(object sender, EventArgs e)
        ///   {
        ///       byte[] On = { 0x3F, 0x60 }; ///FOV X2///
        ///       byte[] Off = { 0x3F, 0x80 };
        ///        progressBar1.Value = 100;
        ///         PS3.SetMemory(0x014C670C, materialRadioButton2.Checked ? On : Off);
        ///        PS3M_API.PS3.Notify("main.cs_fov.bedrockfov");
        ///       progressBar1.Value = 0;
        ///  }

        ///  private void materialradioButton4_CheckedChanged(object sender, EventArgs e)
        ///  {
        ///       byte[] On = { 0x3F, 0x50 }; ///FOV X3///
        ///       byte[] Off = { 0x3F, 0x80 };
        ///       PS3.SetMemory(0x014C670C, materialRadioButton3.Checked ? On : Off);
        ///        PS3M_API.PS3.Notify("main.cs_fov.3");
        /// }

        ///  private void materialradioButton3_CheckedChanged(object sender, EventArgs e)
        ///  {
        ///      byte[] On = { 0x3F, 0x40 }; ///FOV X4///
        ///      byte[] Off = { 0x3F, 0x80 };
        ///      PS3.SetMemory(0x014C670C, materialRadioButton4.Checked ? On : Off);
        ///      PS3M_API.PS3.Notify("main.cs_fov.4");
        ///  }

        /// private void materialradioButton5_CheckedChanged(object sender, EventArgs e)
        ///{
        /// byte[] On = { 0x3F, 0x30 }; ///FOV X5///
        ///byte[] Off = { 0x3F, 0x80 };
        //PS3.SetMemory(0x014C670C, materialRadioButton5.Checked ? On : Off);
        //PS3M_API.PS3.Notify("main.cs_fov.5");
        ///}

        ///  private void materialradioButton6_CheckedChanged(object sender, EventArgs e)
        ///  {
        ///      byte[] On = { 0x3F, 0x25 }; ///FOV X6///
        ///      byte[] Off = { 0x3F, 0x80 };
        ///      PS3.SetMemory(0x014C670C, materialRadioButton6.Checked ? On : Off);
        ///      PS3M_API.PS3.Notify("main.cs_fov.max");
        ///    }

        private void materialRadioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialradioButton8_CheckedChanged(object sender, EventArgs e)
        {


        }

        ///private void materialButton1_Click(object sender, EventArgs e)
        /// {
        ///   byte[] On = { 0x3F, 0xFF, 0xFF }; ///reset///
        ///    byte[] Off = { 0x3F, 0xFF, 0xFF };
        ///     PS3.SetMemory(0x014C670C, materialButton1. ? On : Off);
        /// {


        ///}

        /// }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Value = 0;
            progressBar1.Value = 0;
            progressBar1.Value = 0;
            progressBar1.Value = 0;
            progressBar1.Value = 0;
            progressBar1.Value = 0;
            progressBar1.Value = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                progressBar1.Value = 0;

                progressBar1.Value = 1;
                #region Estado
                {
                    if (progressBar1.Value == 1)
                    {
                        label1.Text = "Inyectando:" + this.materialCheckbox1.Text;
                    }

                }
                #endregion
                this.progressBar1.Value = 100;
                byte[] On = { 0x41 }; /// Lock Weather/// 
                byte[] Off = { 0x40 };
                PS3.SetMemory(0x00393E84, materialCheckbox1.Checked ? On : Off);
                PS3M_API.PS3.Notify("Mantener Clima");
            }

            progressBar1.Value = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ///  PS3M_API.PS3.Notify("Activaste la casilla FOV, ahora puedes inyectarte un campo de vision modificado. ");
        }


        ///    private void materialRadioButton6_CheckedChanged_1(object sender, EventArgs e)
        ///    {
        ///        byte[] On = { 0x3F, 0xFF, 0xFF }; ///ZOOM///
        ///        byte[] Off = { 0x3F, 0xFF, 0xFF };
        ///        PS3.SetMemory(0x014C670C, materialRadioButton6.Checked ? On : Off);
        ///        PS3M_API.PS3.Notify("main.cs_fov.javazoom");
        ///    }




        private void materialCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;
            #region Estado
            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando:" + this.materialCheckbox2.Text;
                }

            }
            #endregion
            this.progressBar1.Value = 100;

            ///AutoSave
            byte[] On = { 0x40 };
            byte[] Off = { 0x41 };
            PS3.SetMemory(0x00AEEE54, materialCheckbox2.Checked ? On : Off);

        }

        private void materialCheckbox3_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Value = 1;
            {
                #region Estado
                {
                    if (progressBar1.Value == 1)
                    {
                        label1.Text = "Inyectando:" + this.materialCheckbox3.Text;
                    }

                }
                #endregion
            }
            progressBar1.Value = 100;



            /// No dissapears entitys while killing
            byte[] Checked = { 0x00 };
            byte[] Unchecked = { 0x14 };
            PS3.SetMemory(0x0039F587, materialCheckbox3.Checked ? Checked : Unchecked);

        }

        private void notificarALaConsolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            this.progressBar1.Value = 100;
            Ded.forms.ps3message ps3noti = new Ded.forms.ps3message();
            ps3noti.ShowDialog();

        }

        private void materialCheckbox4_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;
            #region Estado
            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando:" + this.materialCheckbox4.Text;
                }

            }
            #endregion
            this.progressBar1.Value = 100;
            /// Hit Delay
            byte[] Checked = { 0x20 };
            byte[] Unchecked = { 0x00 };
            PS3.SetMemory(0x003A3FF0, materialCheckbox3.Checked ? Checked : Unchecked);

        }

        private void materialCheckbox7_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;
            #region Estado
            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando:" + this.materialCheckbox7.Text;
                }

            }
            #endregion
            this.progressBar1.Value = 100;
            ///Lock Gamemode
            byte[] Checked = { 0x41 };
            byte[] Unchecked = { 0x40 };
            PS3.SetMemory(0x002F03D0, materialCheckbox7.Checked ? Checked : Unchecked);
        }

        private void materialCheckbox8_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;
            #region Estado
            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando:" + this.materialCheckbox8.Text;
                }

            }
            #endregion
            this.progressBar1.Value = 100;
            /// minigame Hud
            byte[] Checked = { 0x41, 0x82 };
            byte[] Unchecked = { 0x40, 0x82 };
            PS3.SetMemory(0x00AD8480, materialCheckbox8.Checked ? Checked : Unchecked);

        }



        private void materialCheckbox6_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;
            #region Estado
            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando:" + this.materialCheckbox6.Text;
                }

            }
            #endregion
            this.progressBar1.Value = 100;
            /// Ids 
            byte[] On = { 0x40 };
            byte[] Off = { 0x41 };
            PS3.SetMemory(0x003097C8, materialCheckbox6.Checked ? On : Off);

        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///

            ///   Ded.forms.settings Sets = new Ded.forms.settings();
            ///    Sets.ShowDialog();
            ///
        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bgmus.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgmus.SoundLocation = "mus/The Eyes Of Truth.mus";
            bgmus.Play();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgmus.SoundLocation = "mus/Subwoofer Lullaby.mus";
            bgmus.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bgmus.SoundLocation = "mus/Aria Math.mus";
            bgmus.Play();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            bgmus.Stop();
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                label1.Text = "Listo";
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)

        {
            progressBar1.Value = 0;
            progressBar1.Value = 100;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            bgmus.SoundLocation = "mus/haiku3sm.mus";
            bgmus.Play();
        }

        private void listaDeAcrónimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ded.forms.acc acc = new Ded.forms.acc();
            acc.ShowDialog();
        }

        private void verCapturadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// capturecard_viewer ccv = new capturecard_viewer();
            ///ccv.ShowDialog();
        }

        private void visorDeCapturadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// capturecard_viewer ccv = new capturecard_viewer();
            /// ccv.ShowDialog();
        }

        private void visorDeCapturadorasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            this.progressBar1.Value = 100;
            capturecard_viewer ccv = new capturecard_viewer();
            ccv.Show();
        }

        private void notificacionALaConsolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            this.progressBar1.Value = 100;
            Ded.forms.ps3message ps3noti = new Ded.forms.ps3message();
            ps3noti.ShowDialog();
        }

        private void materialCheckbox5_CheckedChanged_1(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;

            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando: " + this.materialCheckbox5.Text;
                }

            }
            byte[] On = { 0x40 };
            byte[] Off = { 0x41 };
            PS3.SetMemory(0x003097B8, materialCheckbox5.Checked ? On : Off);
            this.progressBar1.Value = 100;
        }

        private void materialCheckbox9_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;

            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando: " + this.materialCheckbox9.Text;
                }

            }
            byte[] On = { 0x38, 0x80, 0x00, 0x01 };
            byte[] Off = { 0x38, 0x80, 0x00, 0x00 };
            PS3.SetMemory(0x003097B8, materialCheckbox9.Checked ? On : Off);
            this.progressBar1.Value = 100;
        }

        private void materialCheckbox10_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;

            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando: " + this.materialCheckbox10.Text;
                }

            }

            this.progressBar1.Value = 100;
        }

        private void materialCheckbox11_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;

            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando: " + this.materialCheckbox11.Text;
                }

                //
                byte[] On = { 0x40 };
                byte[] Off = { 0x41 };
                PS3.SetMemory(0x00245E58, materialCheckbox9.Checked ? On : Off);
                //
            }

            this.progressBar1.Value = 100;
        }

        private void materialCheckbox12_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            progressBar1.Value = 1;

            {
                if (progressBar1.Value == 1)
                {
                    label1.Text = "Inyectando: " + this.materialCheckbox12.Text;
                }

            }

            this.progressBar1.Value = 100;
        }

        private void materialSlider1_Click_1(object sender, EventArgs e)
        {
            
        }




        private void personalizarRichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.MatchRich rpc = new forms.MatchRich();
            rpc.ShowDialog();
            client.Dispose();
        }
        DiscordRPC.RichPresence RPC = new DiscordRPC.RichPresence();

        private void button1_Click_1(object sender, EventArgs e)
        {




            { 
              
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        

            
        }

        private void enviarALaConsolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.Dispose();
            PS3_Sender_AddOn PSFA = new PS3_Sender_AddOn();
            PSFA.ShowDialog();
           
            //__//
            /// try
            /// {

            ///initalized = true;
            /// client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
             ///   client.Initialize();
                ////client.SetPresence(new DiscordRPC.RichPresence()
               /// {
                  ///  Details = $"Herramientas",
                  ///  State = $"PSFA 1.0",
                  ///  Timestamps = Timestamps.Now,
                  ///  Assets = new Assets()
                  ///  {
                     ///   LargeImageKey = $"largeico",
                        ///LargeImageText = "Dedition Visual Effects Tool For MC PS3 ",
                     


               //     }
             //   });
            //}
           /// catch
           // {
             ///   MessageBox.Show("Se produjo un error al iniciar la RPC de Discord", "Error", MessageBoxButtons.RetryCancel);
           // }

        }
        private void músicaDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mus mus = new mus();
            mus.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Click(object sender, EventArgs e)
        {
            //// VALUES ///
            #region reset
            if (trackBar1.Value == 1)
            {
                progressBar1.Value = 0;

                progressBar1.Value = 1;
                #region Estado
                {
                    if (progressBar1.Value == 1)
                    {
                        label1.Text = "Reiniciando: FOV";
                    }

                }
                #endregion
                this.progressBar1.Value = 100;
                byte[] A = { 0x3F, 0x80 }; ///RESET///
                byte[] B = { 0x3F, 0x80 };
                PS3.SetMemory(0x014C670C, fov_.Checked ? A : B);
                this.progressBar1.Value = 0;
                #endregion
            }
            #region Value X2
            if (trackBar1.Value == 2)
            {
                progressBar1.Value = 0;

                progressBar1.Value = 1;
                #region Estado
                {
                    if (progressBar1.Value == 1)
                    {
                        label1.Text = "Inyectando: FOV X2";
                    }

                }
                #endregion
                this.progressBar1.Value = 100;
                byte[] On = { 0x3F, 0x60 }; ///FOV X2///
                byte[] Off = { 0x3F, 0x80 };
                PS3.SetMemory(0x014C670C, fov_.Checked ? On : Off);
                PS3M_API.PS3.Notify("MAIN.deep_of_field.x2");
                #endregion
            }
            #region Value X3
            if (trackBar1.Value == 3)
            {
                progressBar1.Value = 0;

                progressBar1.Value = 1;
                #region Estado
                {
                    if (progressBar1.Value == 1)
                    {
                        label1.Text = "Inyectando: FOV X3";
                    }

                }
                #endregion
                this.progressBar1.Value = 100;
                byte[] On = { 0x3F, 0x50 }; ///FOV X3///
                byte[] Off = { 0x3F, 0x80 };
                PS3.SetMemory(0x014C670C, fov_.Checked ? On : Off);
                PS3M_API.PS3.Notify("MAIN.deep_of_field.x3");
                #endregion 
            }
            #region Value X4
            if (trackBar1.Value == 4)
            {
                progressBar1.Value = 0;

                progressBar1.Value = 1;
                #region Estado
                {
                    if (progressBar1.Value == 1)
                    {
                        label1.Text = "Inyectando FOV X4";

                    }
                    #endregion
                    this.progressBar1.Value = 100;
                    byte[] On = { 0x3F, 0x40 }; ///FOV X4///
                    byte[] Off = { 0x3F, 0x80 };
                    PS3.SetMemory(0x014C670C, fov_.Checked ? On : Off);
                    PS3M_API.PS3.Notify("MAIN.deep_of_field.x4");

                }
                #endregion
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fov_.Checked == true)
                this.trackBar1.Enabled = true;
            //////// ON - OFF
            if (fov_.Checked == false)
                this.trackBar1.Enabled = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
     
           
        }

        private void notificarALaPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC_Notify pcn = new PC_Notify();
            pcn.ShowDialog();

        }

        private void Mods_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (PS3M_API.IsConnected == true)
            {
                PS3M_API.DisconnectTarget();
            }

            functions_timer.Stop();
            ntw.Icon = SystemIcons.Information;
            ntw.Text = "Cerrando y desconectando de la consola.";
            ntw.BalloonTipText = "Se desconectó de: " + PS3M_API.Process;
            ntw.BalloonTipTitle = "Cerrando";
            ntw.ShowBalloonTip(1000);
          //  Environment.Exit(001);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Application.Restart(); Environment.Exit(0);
        }

        private void cCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            

        }

        private void label12_Click(object sender, EventArgs e)
        {
           
           /// forms.capturecard_viewer ccv = new forms.capturecard_viewer();
           /// ccv.Activate();
          ///  ccv.Show();
         ///   ccv.BringToFront();
        ////    forms.Mods md = new forms.Mods();
      ////     md.Close();


        }

        private void kTXMBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] Unable = { 0x40 };
            byte[] Able = { 0x41 };
            PS3.SetMemory(0x00785DBC, kTXMBToolStripMenuItem.Checked ? Unable : Able);
        }
    }
}







    



