namespace Funcionarios_Farmacia
{
    partial class TelaFuncionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.dtp_nasc = new System.Windows.Forms.DateTimePicker();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(63, 70);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(194, 20);
            this.tb_nome.TabIndex = 0;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(63, 118);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(194, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(325, 71);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(2);
            this.tb_senha.MaxLength = 8;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(199, 20);
            this.tb_senha.TabIndex = 2;
            // 
            // cb_sexo
            // 
            this.cb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não dizer"});
            this.cb_sexo.Location = new System.Drawing.Point(63, 175);
            this.cb_sexo.Margin = new System.Windows.Forms.Padding(2);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(194, 21);
            this.cb_sexo.TabIndex = 4;
            // 
            // dtp_nasc
            // 
            this.dtp_nasc.Location = new System.Drawing.Point(63, 239);
            this.dtp_nasc.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_nasc.Name = "dtp_nasc";
            this.dtp_nasc.Size = new System.Drawing.Size(250, 20);
            this.dtp_nasc.TabIndex = 5;
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_salvar.Location = new System.Drawing.Point(195, 297);
            this.button_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(62, 19);
            this.button_salvar.TabIndex = 6;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_excluir.Location = new System.Drawing.Point(310, 297);
            this.button_excluir.Margin = new System.Windows.Forms.Padding(2);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(65, 19);
            this.button_excluir.TabIndex = 7;
            this.button_excluir.Text = "Cancelar";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(11, 360);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(583, 86);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data de Nascimento:";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(325, 120);
            this.mtb_cpf.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_cpf.Mask = "000,000,000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(199, 20);
            this.mtb_cpf.TabIndex = 14;
            // 
            // cb_cargo
            // 
            this.cb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Médico Veterinário",
            "Auxiliar de Veterinário",
            "Recepcionista",
            "Atendente",
            "Administrador/Proprietário",
            "Técnico de Laborátorio",
            "Limpeza e Manutenção"});
            this.cb_cargo.Location = new System.Drawing.Point(325, 175);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(199, 21);
            this.cb_cargo.TabIndex = 16;
            this.cb_cargo.SelectedIndexChanged += new System.EventHandler(this.cb_cargo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cargo:";
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(604, 477);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.dtp_nasc);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.DateTimePicker dtp_nasc;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.Label label7;
    }
}

