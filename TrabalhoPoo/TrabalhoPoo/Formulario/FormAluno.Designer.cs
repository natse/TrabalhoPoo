namespace TrabalhoPoo.Formulario
{
    partial class FormAlunoRua
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
            this.labCidade = new System.Windows.Forms.Label();
            this.labOrgaoExpedidor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDataNacimento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.dateTimeDataNacimento = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOrgaoExpedidor = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSexoM = new System.Windows.Forms.RadioButton();
            this.radioButtonSexoF = new System.Windows.Forms.RadioButton();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labNomeAluno = new System.Windows.Forms.Label();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.labCpfAluno = new System.Windows.Forms.Label();
            this.maskedTextBoxCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastarAluno = new System.Windows.Forms.Button();
            this.groupBoxAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCidade
            // 
            this.labCidade.AutoSize = true;
            this.labCidade.Location = new System.Drawing.Point(9, 103);
            this.labCidade.Name = "labCidade";
            this.labCidade.Size = new System.Drawing.Size(43, 13);
            this.labCidade.TabIndex = 0;
            this.labCidade.Text = "Cidade ";
            // 
            // labOrgaoExpedidor
            // 
            this.labOrgaoExpedidor.AutoSize = true;
            this.labOrgaoExpedidor.Location = new System.Drawing.Point(28, 175);
            this.labOrgaoExpedidor.Name = "labOrgaoExpedidor";
            this.labOrgaoExpedidor.Size = new System.Drawing.Size(86, 13);
            this.labOrgaoExpedidor.TabIndex = 1;
            this.labOrgaoExpedidor.Text = "Orgao Expedidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            // 
            // labDataNacimento
            // 
            this.labDataNacimento.AutoSize = true;
            this.labDataNacimento.Location = new System.Drawing.Point(7, 141);
            this.labDataNacimento.Name = "labDataNacimento";
            this.labDataNacimento.Size = new System.Drawing.Size(99, 13);
            this.labDataNacimento.TabIndex = 3;
            this.labDataNacimento.Text = "Data de Nacimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(122, 103);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidade.TabIndex = 6;
            // 
            // dateTimeDataNacimento
            // 
            this.dateTimeDataNacimento.Location = new System.Drawing.Point(122, 141);
            this.dateTimeDataNacimento.Name = "dateTimeDataNacimento";
            this.dateTimeDataNacimento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDataNacimento.TabIndex = 7;
            // 
            // maskedTextBoxNumero
            // 
            this.maskedTextBoxNumero.Location = new System.Drawing.Point(122, 178);
            this.maskedTextBoxNumero.Mask = "00000-9999";
            this.maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            this.maskedTextBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNumero.TabIndex = 10;
            // 
            // comboBoxOrgaoExpedidor
            // 
            this.comboBoxOrgaoExpedidor.FormattingEnabled = true;
            this.comboBoxOrgaoExpedidor.Location = new System.Drawing.Point(143, 167);
            this.comboBoxOrgaoExpedidor.Name = "comboBoxOrgaoExpedidor";
            this.comboBoxOrgaoExpedidor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrgaoExpedidor.TabIndex = 11;
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(122, 224);
            this.maskedTextBoxRg.Mask = "000-00-0000";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRg.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rua";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sexo";
            // 
            // radioButtonSexoM
            // 
            this.radioButtonSexoM.AutoSize = true;
            this.radioButtonSexoM.Location = new System.Drawing.Point(452, 29);
            this.radioButtonSexoM.Name = "radioButtonSexoM";
            this.radioButtonSexoM.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSexoM.TabIndex = 16;
            this.radioButtonSexoM.TabStop = true;
            this.radioButtonSexoM.Text = "Maculino";
            this.radioButtonSexoM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexoF
            // 
            this.radioButtonSexoF.AutoSize = true;
            this.radioButtonSexoF.Location = new System.Drawing.Point(547, 29);
            this.radioButtonSexoF.Name = "radioButtonSexoF";
            this.radioButtonSexoF.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSexoF.TabIndex = 17;
            this.radioButtonSexoF.TabStop = true;
            this.radioButtonSexoF.Text = "Feminino";
            this.radioButtonSexoF.UseVisualStyleBackColor = true;
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.btnCadastarAluno);
            this.groupBoxAluno.Controls.Add(this.maskedTextBoxCpfAluno);
            this.groupBoxAluno.Controls.Add(this.labCpfAluno);
            this.groupBoxAluno.Controls.Add(this.textBoxNomeAluno);
            this.groupBoxAluno.Controls.Add(this.labNomeAluno);
            this.groupBoxAluno.Controls.Add(this.comboBox1);
            this.groupBoxAluno.Controls.Add(this.label4);
            this.groupBoxAluno.Controls.Add(this.labCidade);
            this.groupBoxAluno.Controls.Add(this.radioButtonSexoF);
            this.groupBoxAluno.Controls.Add(this.labDataNacimento);
            this.groupBoxAluno.Controls.Add(this.radioButtonSexoM);
            this.groupBoxAluno.Controls.Add(this.label5);
            this.groupBoxAluno.Controls.Add(this.label2);
            this.groupBoxAluno.Controls.Add(this.comboBoxCidade);
            this.groupBoxAluno.Controls.Add(this.textBox1);
            this.groupBoxAluno.Controls.Add(this.dateTimeDataNacimento);
            this.groupBoxAluno.Controls.Add(this.label1);
            this.groupBoxAluno.Controls.Add(this.maskedTextBoxNumero);
            this.groupBoxAluno.Controls.Add(this.maskedTextBoxRg);
            this.groupBoxAluno.Controls.Add(this.label3);
            this.groupBoxAluno.Location = new System.Drawing.Point(-1, 4);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(616, 387);
            this.groupBoxAluno.TabIndex = 18;
            this.groupBoxAluno.TabStop = false;
            this.groupBoxAluno.Text = "Dados Pessoais";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(452, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Uf";
            // 
            // labNomeAluno
            // 
            this.labNomeAluno.AutoSize = true;
            this.labNomeAluno.Location = new System.Drawing.Point(7, 26);
            this.labNomeAluno.Name = "labNomeAluno";
            this.labNomeAluno.Size = new System.Drawing.Size(35, 13);
            this.labNomeAluno.TabIndex = 20;
            this.labNomeAluno.Text = "Nome";
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Location = new System.Drawing.Point(122, 26);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeAluno.TabIndex = 21;
            // 
            // labCpfAluno
            // 
            this.labCpfAluno.AutoSize = true;
            this.labCpfAluno.Location = new System.Drawing.Point(9, 63);
            this.labCpfAluno.Name = "labCpfAluno";
            this.labCpfAluno.Size = new System.Drawing.Size(27, 13);
            this.labCpfAluno.TabIndex = 22;
            this.labCpfAluno.Text = "CPF";
            // 
            // maskedTextBoxCpfAluno
            // 
            this.maskedTextBoxCpfAluno.Location = new System.Drawing.Point(122, 63);
            this.maskedTextBoxCpfAluno.Mask = "000-00-0000";
            this.maskedTextBoxCpfAluno.Name = "maskedTextBoxCpfAluno";
            this.maskedTextBoxCpfAluno.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCpfAluno.TabIndex = 23;
            // 
            // btnCadastarAluno
            // 
            this.btnCadastarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastarAluno.Location = new System.Drawing.Point(0, 296);
            this.btnCadastarAluno.Name = "btnCadastarAluno";
            this.btnCadastarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastarAluno.TabIndex = 24;
            this.btnCadastarAluno.Text = "Cadastrar";
            this.btnCadastarAluno.UseVisualStyleBackColor = false;
            // 
            // FormAlunoRua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.groupBoxAluno);
            this.Controls.Add(this.comboBoxOrgaoExpedidor);
            this.Controls.Add(this.labOrgaoExpedidor);
            this.Name = "FormAlunoRua";
            this.Text = "FormAluno";
            this.groupBoxAluno.ResumeLayout(false);
            this.groupBoxAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCidade;
        private System.Windows.Forms.Label labOrgaoExpedidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDataNacimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.DateTimePicker dateTimeDataNacimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumero;
        private System.Windows.Forms.ComboBox comboBoxOrgaoExpedidor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSexoM;
        private System.Windows.Forms.RadioButton radioButtonSexoF;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeAluno;
        private System.Windows.Forms.Label labNomeAluno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpfAluno;
        private System.Windows.Forms.Label labCpfAluno;
        private System.Windows.Forms.Button btnCadastarAluno;
    }
}