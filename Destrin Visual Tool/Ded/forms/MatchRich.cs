using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Windows.Forms;


namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class MatchRich : Form
    {
        public MatchRich()
        {
            InitializeComponent();
        }
        public DiscordRpcClient customclient;
        bool initalized;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            initalized = true;
            customclient = new DiscordRpcClient("929438860386140190");
            customclient.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            customclient.Initialize();
            customclient.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = $"{Details.Text}",
                State = $"{Status.Text}",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"largeico",
                    LargeImageText = $"Dedition VFX Rich Customizer",

                }
            });
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            initalized = true;
            customclient = new DiscordRpcClient("929438860386140190");
            customclient.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            customclient.Initialize();
            customclient.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = $"Conectado",
                State = $"En la pantalla de Mods",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"largeico",
                    LargeImageText = "Dedition Visual Effects Tool For MC PS3 ",
                }
            });
        }

        private void MatchRich_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            customclient.ClearPresence();
            customclient.Dispose();
        }
    }
}
