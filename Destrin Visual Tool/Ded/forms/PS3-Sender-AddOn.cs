using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class PS3_Sender_AddOn : Form
    {
        public PS3_Sender_AddOn()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;
        bool initalized = true;
        struct FtpSetting
        {
            public string Servidor { get; set; }
            public string Nombre { get; set; }
            public string Contraseña { get; set; }
            public string FileInfo { get; set; }
            public string NC { get; set; }
        }
        /// <summary>
        /// nombre
        /// </summary>
        FtpSetting _InputParameter;
        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TB_PASS.UseSystemPasswordChar = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filename = ((FtpSetting)e.Argument).FileInfo;
            string fullname = ((FtpSetting)e.Argument).NC;
            string userName = ((FtpSetting)e.Argument).Nombre;
            string password = ((FtpSetting)e.Argument).Contraseña;
            string server = ((FtpSetting)e.Argument).Servidor;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, filename)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(userName, password);
            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(fullname);
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;

            do
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    byteRead = fs.Read(buffer, 0, 1024);
                    ftpStream.Write(buffer, 0, byteRead);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorker1.ReportProgress((int)percentage);
                }

            }
            while (byteRead != 0);
            fs.Close();
            ftpStream.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label5.Text = $"Subiendo [ %{e.ProgressPercentage} ]...";
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Update();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label5.Text = "Subida completada correctamente.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Archivos | *.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    _InputParameter.Nombre = TB_NAME.Text;
                    _InputParameter.Servidor = TB_IP.Text;
                    _InputParameter.Contraseña = TB_PASS.Text;
                    _InputParameter.NC = fi.FullName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PS3_Sender_AddOn_Load(object sender, EventArgs e)
        {

            //__//
            try
            {

                initalized = true;
                client = new DiscordRpcClient("929438860386140190");
                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                client.Initialize();
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"Herramientas",
                    State = $"PSFA 1.0",
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
        }
    }
}
