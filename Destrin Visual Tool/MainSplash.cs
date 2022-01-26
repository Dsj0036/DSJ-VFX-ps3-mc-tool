using DiscordRPC;
using DiscordRPC.Logging;
using PS3Lib;
using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections;
using System.Linq;
using System.Drawing;

namespace Destrin_Visual_Tool
{
    public partial class Form1 : Form
    {

        System.Timers.Timer T;
        System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();


        public static PS3API PS3 = new PS3API();
        public Form1()
        {
            InitializeComponent();
            var Ip = ip_text_box.Text;

        }


        public DiscordRpcClient client;
        bool initalized = true;
        public void GetCurrentIP()
        {
            IPHostEntry host;
            string LocalIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    LocalIP.ToString();
                    this.IP_Label.Text = LocalIP.ToString();
                }
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                Environment.Exit(00);
            }


            if (Properties.Settings.Default.List != null)
            {
                ip_text_box.Items.AddRange(Properties.Settings.Default.List.Cast<string>().ToArray());
            }
            var culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            lang_label.Text = culture;
            GetCurrentIP();
            ///IP_Label.Text = IPAddress.Any.ToString(); 
            username.Text = Environment.UserName;
            date.Text = DateTime.Now.ToString();
        
          
            clock.Start();
            {

            }

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
            this.Hide();
            Console.WriteLine(PS3M_API.Log);
            {
                if (PS3M_API.Log == string.Empty)
                {
                    Console.WriteLine("Nothing To See Here");
                }
            }
            string ps3ip = ip_text_box.Text;
            Properties.Settings.Default.CurrentConsoleIP = ip_text_box.Text;
            Properties.Settings.Default.Save();
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
                    this.Show();
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
            this.Hide();
            Console.WriteLine(PS3M_API.Log);
            {
                if (PS3M_API.Log == string.Empty)
                {
                    Console.WriteLine("Log: Nothing To See Here");
                    Console.Beep();
                }
            }
            Ded.forms.Mods psm = new Ded.forms.Mods();
            psm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            var items = new System.Collections.Specialized.StringCollection();

            items.AddRange(ip_text_box.Items.Cast<string>().ToArray());
            Properties.Settings.Default.List = items;

            Properties.Settings.Default.Save();
            {
                closingstate.Text = "Guardando y cerrando...";
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {


        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ip_text_box.Items.Add(ip_text_box.Text);
           
            
            
        }

        private void ip_text_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.ip_text_box.Items.Add(ip_text_box.Text);
        }
    }
}




