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
using RichPresenceClient;

namespace Destrin_Visual_Tool
{
    public partial class Form1 : Form
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();
        public Form1()
        {
            InitializeComponent();

        }
        public DiscordRpcClient client;
        bool initalized = true;
      
        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           initalized = true;
            client = new DiscordRpcClient($"929438860386140190");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                   Details = $"Inactivo.",
                   State = $"Esperando una conexión",

                    Assets = new Assets()
                   {
                        LargeImageKey = $"largeico",
                        LargeImageText = "Dedition Visual Effects Tool For MC PS3 ",
                        ///SmallImageKey = $"{textBox5.Text}"
                        

                   }
                });
            }


        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    initalized = false;
                    PS3M_API.ConnectTarget(ip_text_box.Text, Convert.ToInt32(7887));
                    DialogResult = DialogResult.OK;
                    //Declare Attach Dialog
                    Ded.forms.att_process_dialog Attachdiag = new Ded.forms.att_process_dialog();
                    //Show Attach Dialog
             
                    



                    Attachdiag.ShowDialog();

                    // if (materialCheckbox1.Checked);
                    {
                        ///    Ded.debug.Form1 dev = new Ded.debug.Form1();
                        ///    dev.ShowDialog();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Host Desconocido (00x6), No se pudo conectar.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    DialogResult = DialogResult.Abort;

                    /// if (materialCheckbox1.Checked);
                    {
                        ///   Ded.debug.Form1 dev = new Ded.debug.Form1();
                        ///   MessageBox.Show("Only For Testing Purposes💀");

                        ///   dev.ShowDialog();
                    }
                }

            }
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
           
         
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

            Ded.forms.mus mus = new Ded.forms.mus();
            mus.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                try
                {

                    PS3M_API.ConnectTarget(ip_text_box.Text, Convert.ToInt32(7887));
                    DialogResult = DialogResult.OK;
                    //Declare Attach Dialog
                    Ded.forms.att_process_dialog Attachdiag = new Ded.forms.att_process_dialog();
                    //Show Attach Dialog

                   #region rpc
                    try
                    {

                        initalized = true;
                        client.SetPresence(new DiscordRPC.RichPresence()
                        {
                            Details = $"Conectado a " + this.ip_text_box.Text,
                            State = $"Agregando Modificaciones",
                            Timestamps = Timestamps.Now,
                            Assets = new Assets()
                            {
                                LargeImageKey = $"largeico",
                                LargeImageText = "Dedition Visual Effects Tool For MC PS3 ",

                            }
                        });
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al iniciar la RPC de Discord", "Error", MessageBoxButtons.RetryCancel);
                    }
                    #endregion 


                    Attachdiag.ShowDialog();

                    // if (materialCheckbox1.Checked);
                    {
                        ///    Ded.debug.Form1 dev = new Ded.debug.Form1();
                        ///    dev.ShowDialog();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Host Desconocido (00x6), No se pudo conectar.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    DialogResult = DialogResult.Abort;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ded.forms.mus mus = new Ded.forms.mus();
            mus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string userName2 = Environment.UserName;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            client.Dispose();

            if (userName2 == "JP")
            {
                MessageBox.Show("Autorization: Success", "Access Granted, loaded as " + userName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ded.debug.debugloader DBGLOADER = new Ded.debug.debugloader();
                DBGLOADER.ShowDialog();
              

            }

            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = $"Texto de prueba",
                State = $"Secreto Oculto",
                Assets = new Assets()
                {
                    LargeImageKey = $"largeico",
                    LargeImageText = "Dedition Visual Effects Tool For MC PS3 ",

                }
            });
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Ded.forms.Mods psm = new Ded.forms.Mods();
            psm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(01);
        }
    }
}




