
namespace Destrin_Visual_Tool.Ded.forms
{
    partial class AppRegistry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cult_lang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ps3ip = new System.Windows.Forms.Label();
            this.pcip = new System.Windows.Forms.Label();
            this.datedata_label = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 234);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 186);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección IP:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP de la consola:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cult_lang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ps3ip);
            this.groupBox1.Controls.Add(this.pcip);
            this.groupBox1.Controls.Add(this.datedata_label);
            this.groupBox1.Controls.Add(this.namelabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info del usuario";
            // 
            // cult_lang
            // 
            this.cult_lang.AutoSize = true;
            this.cult_lang.Location = new System.Drawing.Point(141, 125);
            this.cult_lang.Name = "cult_lang";
            this.cult_lang.Size = new System.Drawing.Size(39, 13);
            this.cult_lang.TabIndex = 10;
            this.cult_lang.Text = "culture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Idioma de la Aplicación:\r\n";
            // 
            // ps3ip
            // 
            this.ps3ip.AutoSize = true;
            this.ps3ip.Location = new System.Drawing.Point(108, 99);
            this.ps3ip.Name = "ps3ip";
            this.ps3ip.Size = new System.Drawing.Size(32, 13);
            this.ps3ip.TabIndex = 8;
            this.ps3ip.Text = "ps3ip";
            // 
            // pcip
            // 
            this.pcip.AutoSize = true;
            this.pcip.Location = new System.Drawing.Point(90, 75);
            this.pcip.Name = "pcip";
            this.pcip.Size = new System.Drawing.Size(36, 13);
            this.pcip.TabIndex = 7;
            this.pcip.Text = "ConIP";
            // 
            // datedata_label
            // 
            this.datedata_label.AutoSize = true;
            this.datedata_label.Location = new System.Drawing.Point(95, 53);
            this.datedata_label.Name = "datedata_label";
            this.datedata_label.Size = new System.Drawing.Size(49, 13);
            this.datedata_label.TabIndex = 6;
            this.datedata_label.Text = "datedata";
            this.datedata_label.Click += new System.EventHandler(this.datedata_label_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(124, 27);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(54, 13);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "namedata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Registro del PSMAPI de la consola";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(325, 426);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Ok";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(169, 426);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(150, 23);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Borrar las IPs Guardadas";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // AppRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 458);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AppRegistry";
            this.Text = "Registro de la Aplicación";
            this.Load += new System.EventHandler(this.AppRegistry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ps3ip;
        private System.Windows.Forms.Label pcip;
        private System.Windows.Forms.Label datedata_label;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cult_lang;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}