using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

using DiscordRPC;
using DiscordRPC.Logging;


namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class capturecard_viewer : Form
    {
        public capturecard_viewer()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        public DiscordRpcClient client;
        bool initalized = false;

        private void capturecard_viewer_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                toolStripComboBox1.Items.Add(filterInfo.Name);
            toolStripComboBox1.SelectedIndex = 0;
            VideoCaptureDevice = new VideoCaptureDevice();
            button1.Hide();
            sdown_button.Enabled = false;


            initalized = true;
            client = new DiscordRpcClient($"929438860386140190");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{"Observando: " + toolStripComboBox1.Text}",
                    State = $"Visor de Capturadora de la consola",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"largeico",
                        LargeImageText = "Dedition Visual Effects Tool For MC PS3 ",
                        ///SmallImageKey = $"{textBox5.Text}"
                        ///


                    }
                });
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[toolStripComboBox1.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic.BackgroundImage = (Bitmap)eventArgs.Frame.Clone();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            shutIn_button.Enabled = false;
            sdown_button.Enabled = true;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[toolStripComboBox1.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
            this.FormBorderStyle = FormBorderStyle.None;
            button1.Show();
            sdown_button.Enabled = true;
            shutIn_button.Enabled = false;

            this.Text = "Observando: " + toolStripComboBox1.Text;
            this.label3.Text = "Encendido";
            this.label2.Text = "Observando: " + toolStripComboBox1.Text;
         ///   this.ShowInTaskbar = true;
         
            ///this.pic.Size = new System.Drawing.Size(1280, 720);
            ///this.Size = new System.Drawing.Size(1280, 720);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice.Stop();
            this.label3.Text = "Apagado";
            sdown_button.Enabled = false;
            shutIn_button.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VideoCaptureDevice.Stop();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0x00);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
