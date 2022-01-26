
namespace Destrin_Visual_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ip_text_box = new System.Windows.Forms.ComboBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.username = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.IP_Label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lang_label = new System.Windows.Forms.Label();
            this.closingstate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ip_text_box
            // 
            this.ip_text_box.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.ip_text_box, "ip_text_box");
            this.ip_text_box.FormattingEnabled = true;
            this.ip_text_box.Name = "ip_text_box";
            this.ip_text_box.SelectedIndexChanged += new System.EventHandler(this.ip_text_box_SelectedIndexChanged);
            // 
            // clock
            // 
            this.clock.Interval = 200000;
            this.clock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            this.username.Click += new System.EventHandler(this.label3_Click);
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            // 
            // IP_Label
            // 
            resources.ApplyResources(this.IP_Label, "IP_Label");
            this.IP_Label.Name = "IP_Label";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // lang_label
            // 
            resources.ApplyResources(this.lang_label, "lang_label");
            this.lang_label.Name = "lang_label";
            // 
            // closingstate
            // 
            resources.ApplyResources(this.closingstate, "closingstate");
            this.closingstate.Name = "closingstate";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.closingstate);
            this.Controls.Add(this.lang_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.IP_Label);
            this.Controls.Add(this.date);
            this.Controls.Add(this.username);
            this.Controls.Add(this.ip_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label IP_Label;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lang_label;
        private System.Windows.Forms.Label closingstate;
        public System.Windows.Forms.ComboBox ip_text_box;
    }
}

