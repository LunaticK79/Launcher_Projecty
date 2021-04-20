namespace ProjectY___Launcher
{
    partial class AlterEGO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterEGO));
            this.Logotipo_PY = new System.Windows.Forms.PictureBox();
            this.py_jogar = new System.Windows.Forms.PictureBox();
            this.py_tokovoip = new System.Windows.Forms.PictureBox();
            this.py_nomesv = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo_PY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.py_jogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.py_tokovoip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.py_nomesv)).BeginInit();
            this.SuspendLayout();
            // 
            // Logotipo_PY
            // 
            resources.ApplyResources(this.Logotipo_PY, "Logotipo_PY");
            this.Logotipo_PY.BackColor = System.Drawing.Color.Transparent;
            this.Logotipo_PY.Name = "Logotipo_PY";
            this.Logotipo_PY.TabStop = false;
            this.Logotipo_PY.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // py_jogar
            // 
            resources.ApplyResources(this.py_jogar, "py_jogar");
            this.py_jogar.BackColor = System.Drawing.Color.Transparent;
            this.py_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.py_jogar.Name = "py_jogar";
            this.py_jogar.TabStop = false;
            this.py_jogar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // py_tokovoip
            // 
            resources.ApplyResources(this.py_tokovoip, "py_tokovoip");
            this.py_tokovoip.BackColor = System.Drawing.Color.Transparent;
            this.py_tokovoip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.py_tokovoip.Name = "py_tokovoip";
            this.py_tokovoip.TabStop = false;
            this.py_tokovoip.Click += new System.EventHandler(this.py_tokovoip_Click);
            // 
            // py_nomesv
            // 
            resources.ApplyResources(this.py_nomesv, "py_nomesv");
            this.py_nomesv.BackColor = System.Drawing.Color.Transparent;
            this.py_nomesv.Name = "py_nomesv";
            this.py_nomesv.TabStop = false;
            // 
            // AlterEGO
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.py_nomesv);
            this.Controls.Add(this.py_tokovoip);
            this.Controls.Add(this.py_jogar);
            this.Controls.Add(this.Logotipo_PY);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlterEGO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo_PY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.py_jogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.py_tokovoip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.py_nomesv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logotipo_PY;
        private System.Windows.Forms.PictureBox py_jogar;
        private System.Windows.Forms.PictureBox py_tokovoip;
        private System.Windows.Forms.PictureBox py_nomesv;
    }
}

