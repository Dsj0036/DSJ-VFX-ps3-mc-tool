using System;
using System.Drawing;
using System.Windows.Forms;

namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class PC_Notify : Form
    {
        public PC_Notify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ntw_custom.Text = "Prueba de notificación.";
            ntw_custom.BalloonTipText = this.text.Text;
            ntw_custom.BalloonTipTitle = this.tittle.Text;
            ntw_custom.ShowBalloonTip(1000);
            if (comboBox1.SelectedIndex == 0)
            {
                ntw_custom.Icon = SystemIcons.Error;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ntw_custom.Icon = SystemIcons.Exclamation;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ntw_custom.Icon = SystemIcons.Information;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ntw_custom.Icon = SystemIcons.Warning;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                ntw_custom.Icon = SystemIcons.Application;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                ntw_custom.Icon = SystemIcons.Question;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                ntw_custom.Icon = SystemIcons.Asterisk;
            }
        }

        private void PC_Notify_Load(object sender, EventArgs e)
        {
            verifier.Start();
            comboBox1.Items.Add("Error"); /// 0 
            comboBox1.Items.Add("Exclamation");
            comboBox1.Items.Add("Information");
            comboBox1.Items.Add("Warning");
            comboBox1.Items.Add("Application");
            comboBox1.Items.Add("Question");
            comboBox1.Items.Add("Asterisk"); /// 6



        }

        private void verifier_Tick(object sender, EventArgs e)
        {

            button1.Enabled = true;

            if (text.Text == "")
            {
                button1.Enabled = false;
            }

        }
    }
}
