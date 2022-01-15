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

namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class ps3message : Form
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();
        public ps3message()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PS3M_API.PS3.Notify(this.richTextBox1.Text);
        }

        private void ps3message_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
