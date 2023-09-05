namespace Funcionarios_Farmacia.Telas
{
    partial class TelaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicio));
            this.bt_cadastro = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_cadastro.Location = new System.Drawing.Point(424, 177);
            this.bt_cadastro.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(135, 26);
            this.bt_cadastro.TabIndex = 0;
            this.bt_cadastro.Text = "Cadastrar-se";
            this.bt_cadastro.UseVisualStyleBackColor = true;
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(424, 245);
            this.bt_login.Margin = new System.Windows.Forms.Padding(2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(135, 27);
            this.bt_login.TabIndex = 1;
            this.bt_login.Text = "Iniciar sessão";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Funcionarios_Farmacia.Properties.Resources.nomeLogan_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(-123, -34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(707, 489);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_cadastro);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastro;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}