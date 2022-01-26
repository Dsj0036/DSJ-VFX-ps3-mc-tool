using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using PS3Lib;
using PS3ManagerAPI;

namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class AppRegistry : Form
    {
        Timer Timer = new Timer();
        public AppRegistry()
        {
            InitializeComponent();

        }
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();
    
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ConseguirInfo()
        {

            this.richTextBox1.Text = PS3M_API.Log;
            datedata_label.Text = DateTime.Now.ToString();
            var culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            cult_lang.Text = culture;
            namelabel.Text = Environment.UserName;

            {
                ps3ip.Text = Properties.Settings.Default.CurrentConsoleIP;
            }
            GetCurrentIP();

        }
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
                    this.pcip.Text = LocalIP.ToString();
                }
            }
        }
        private void AppRegistry_Load(object sender, EventArgs e)
        {
            if (ps3ip.Text == "192.168.0.")
            {
                ps3ip.Text = "No conectado.";
            }
            ConseguirInfo();
        }


        private void datedata_label_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro?", "Se requiere Confirmar", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                #region indexes
                Properties.Settings.Default.List.RemoveAt(10);
                Properties.Settings.Default.List.RemoveAt(9);
                Properties.Settings.Default.List.RemoveAt(8);
                Properties.Settings.Default.List.RemoveAt(7);
                Properties.Settings.Default.List.RemoveAt(6);
                Properties.Settings.Default.List.RemoveAt(5);
                Properties.Settings.Default.List.RemoveAt(4);
                Properties.Settings.Default.List.RemoveAt(3);
                Properties.Settings.Default.List.RemoveAt(2);
                Properties.Settings.Default.List.RemoveAt(1);
                Properties.Settings.Default.Save();
                #endregion
            }
        }
    }
}

