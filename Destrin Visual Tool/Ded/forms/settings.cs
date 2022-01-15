using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Destrin_Visual_Tool.Properties;

namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void settings_Load(object sender, EventArgs e)
        {

           
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            settings sid = this;
            Ded.forms.Mods mods = new Ded.forms.Mods();
           

            { 
                ///BG
                mods.BackColor = Color.FromArgb(0, 0, 0);
                this.BackColor = Color.FromArgb(0, 0, 0);
            }

            { ///Fore
                this.ForeColor = Color.FromArgb(255, 255, 255);
                mods.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
