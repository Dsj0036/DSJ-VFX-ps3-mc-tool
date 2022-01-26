using System;
using System.Windows.Forms;

namespace Destrin_Visual_Tool.Ded.forms
{
    public partial class mus : Form
    {
        public mus()
        {
            InitializeComponent();
            System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == false)

            {
                button5.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = false;
                System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
                bgmus.Stop();
            }
            if (materialSwitch1.Checked == true)
            {
                button5.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button1.Enabled = true;
                System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
                bgmus.Play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
            bgmus.SoundLocation = "mus/haiku3sm.mus";
            bgmus.Play();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
            bgmus.SoundLocation = "mus/The Eyes Of Truth.mus";
            bgmus.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
            bgmus.SoundLocation = "mus/Subwoofer Lullaby.mus";
            bgmus.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
            bgmus.SoundLocation = "mus/Aria Math.mus";
            bgmus.Play();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
            bgmus.Play();

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer bgmus = new System.Media.SoundPlayer();
            bgmus.Stop();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;


        }

        private void mus_Load(object sender, EventArgs e)
        {

        }
    }
}
