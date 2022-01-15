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

namespace DED_RTM_VER._2._0_restored.AdditionalForms
{
    public partial class addit_mods : MetroFramework.Forms.MetroForm
    {
        PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public static PS3API PS3 = new PS3API();

        public addit_mods()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        { ///Desactivar efecto hurto al herir el jugador
            byte[] On = { 0x00, 0x00 };
            byte[] Off = { 0x40, 0x49 };
            PS3.SetMemory(0x00A972B0, checkBox5.Checked ? On : Off);
            PS3M_API.PS3.Notify("SIN SHAKE DE HURTO");

        }

        private void addit_mods_Load(object sender, EventArgs e)
        {
            AdditionalForms.AttachToProcessConfirmForm ReAttach2 = new AdditionalForms.AttachToProcessConfirmForm();
            ReAttach2.ShowDialog();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            ///Atmósfera Mejorada
            byte[] On = { 0x0F };
            byte[] Off = { 0x3F };
            PS3.SetMemory(0x00A9A6DC, checkBox3.Checked ? On : Off);
            PS3M_API.PS3.Notify("AFMÓSFERA MEJORADA");
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x40 };
            byte[] Off = { 0x41 };
            PS3.SetMemory(0x00AEEE54, checkBox1.Checked ? On : Off);
            PS3M_API.PS3.Notify("AUTO SALVADO");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Correr Agachado
            byte[] On = { 0x01 };
            byte[] Off = { 0x00 };
            PS3.SetMemory(0x00B0142B, checkBox2.Checked ? On : Off);
            PS3M_API.PS3.Notify("CORRER AGACHADO");
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            byte[] On = { 0x41 };///LOCK GAMEMODE
            byte[] Off = { 0x40 };
            PS3.SetMemory(0x002F03D0, checkBox8.Checked ? On : Off);
            PS3M_API.PS3.Notify("BLOQUEAR MODO DE JUEGO");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ///Anti jugadores no invitados
            byte[] On = { 0x01 };
            byte[] Off = { 0x00 };
            PS3.SetMemory(0x0098871F, checkBox7.Checked ? On : Off);
            PS3M_API.PS3.Notify("PARTIDA SOLITARIA");
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

            
    
                
