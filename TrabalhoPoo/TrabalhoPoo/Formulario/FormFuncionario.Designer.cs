namespace TrabalhoPoo.Formulario
{
    partial class FormFuncionario
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
            this.maskedTextBoxCpfFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.labCpfFuncionario = new System.Windows.Forms.Label();
            this.textBoxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.labNomeFuncionario = new System.Windows.Forms.Label();
            this.groupBoxDadoFuncionario = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSalario = new System.Windows.Forms.MaskedTextBox();
            this.labSalario = new System.Windows.Forms.Label();
            this.labPis = new System.Windows.Forms.Label();
            this.comboBoxPis = new System.Windows.Forms.ComboBox();
            this.labMatricula = new System.Windows.Forms.Label();
            this.comboBoxMatricula = new System.Windows.Forms.ComboBox();
            this.labDataNacimentoFuncionario = new System.Windows.Forms.Label();
            this.dateTimeDataNacimentoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDadoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxCpfFuncionario
            // 
            this.maskedTextBoxCpfFuncionario.Location = new System.Drawing.Point(122, 78);
            this.maskedTextBoxCpfFuncionario.Mask = "000-00-0000";
            this.maskedTextBoxCpfFuncionario.Name = "maskedTextBoxCpfFuncionario";
            this.maskedTextBoxCpfFuncionario.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCpfFuncionario.TabIndex = 27;
            // 
            // labCpfFuncionario
            // 
            this.labCpfFuncionario.AutoSize = true;
            this.labCpfFuncionario.Location = new System.Drawing.Point(9, 78);
            this.labCpfFuncionario.Name = "labCpfFuncionario";
            this.labCpfFuncionario.Size = new System.Drawing.Size(27, 13);
            this.labCpfFuncionario.TabIndex = 26;
            this.labCpfFuncionario.Text = "CPF";
            // 
            // textBoxNomeFuncionario
            // 
            this.textBoxNomeFuncionario.Location = new System.Drawing.Point(122, 32);
            this.textBoxNomeFuncionario.Name = "textBoxNomeFuncionario";
            this.textBoxNomeFuncionario.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeFuncionario.TabIndex = 25;
            // 
            // labNomeFuncionario
            // 
            this.labNomeFuncionario.AutoSize = true;
            this.labNomeFuncionario.Location = new System.Drawing.Point(7, 32);
            this.labNomeFuncionario.Name = "labNomeFuncionario";
            this.labNomeFuncionario.Size = new System.Drawing.Size(35, 13);
            this.labNomeFuncionario.TabIndex = 24;
            this.labNomeFuncionario.Text = "Nome";
            // 
            // groupBoxDadoFuncionario
            // 
            this.groupBoxDadoFuncionario.Controls.Add(this.maskedTextBoxSalario);
            this.groupBoxDadoFuncionario.Controls.Add(this.labSalario);
            this.groupBoxDadoFuncionario.Controls.Add(this.labPis);
            this.groupBoxDadoFuncionario.Controls.Add(this.comboBoxPis);
            this.groupBoxDadoFuncionario.Controls.Add(this.labMatricula);
            this.groupBoxDadoFuncionario.Controls.Add(this.comboBoxMatricula);
            this.groupBoxDadoFuncionario.Controls.Add(this.labDataNacimentoFuncionario);
            this.groupBoxDadoFuncionario.Controls.Add(this.dateTimeDataNacimentoFuncionario);
            this.groupBoxDadoFuncionario.Controls.Add(this.textBoxNomeFuncionario);
            this.groupBoxDadoFuncionario.Controls.Add(this.maskedTextBoxCpfFuncionario);
            this.groupBoxDadoFuncionario.Controls.Add(this.labNomeFuncionario);
            this.groupBoxDadoFuncionario.Controls.Add(this.labCpfFuncionario);
            this.groupBoxDadoFuncionario.Location = new System.Drawing.Point(-4, 2);
            this.groupBoxDadoFuncionario.Name = "groupBoxDadoFuncionario";
            this.groupBoxDadoFuncionario.Size = new System.Drawing.Size(347, 448);
            this.groupBoxDadoFuncionario.TabIndex = 28;
            this.groupBoxDadoFuncionario.TabStop = false;
            this.groupBoxDadoFuncionario.Text = "Dados de Pessoais";
            // 
            // maskedTextBoxSalario
            // 
            this.maskedTextBoxSalario.Location = new System.Drawing.Point(122, 264);
            this.maskedTextBoxSalario.Mask = "000-00-0000";
            this.maskedTextBoxSalario.Name = "maskedTextBoxSalario";
            this.maskedTextBoxSalario.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSalario.TabIndex = 35;
            // 
            // labSalario
            // 
            this.labSalario.AutoSize = true;
            this.labSalario.Location = new System.Drawing.Point(9, 264);
            this.labSalario.Name = "labSalario";
            this.labSalario.Size = new System.Drawing.Size(39, 13);
            this.labSalario.TabIndex = 34;
            this.labSalario.Text = "Salário";
            // 
            // labPis
            // 
            this.labPis.AutoSize = true;
            this.labPis.Location = new System.Drawing.Point(6, 213);
            this.labPis.Name = "labPis";
            this.labPis.Size = new System.Drawing.Size(24, 13);
            this.labPis.TabIndex = 32;
            this.labPis.Text = "PIS";
            // 
            // comboBoxPis
            // 
            this.comboBoxPis.FormattingEnabled = true;
            this.comboBoxPis.Location = new System.Drawing.Point(122, 205);
            this.comboBoxPis.Name = "comboBoxPis";
            this.comboBoxPis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPis.TabIndex = 33;
            // 
            // labMatricula
            // 
            this.labMatricula.AutoSize = true;
            this.labMatricula.Location = new System.Drawing.Point(9, 118);
            this.labMatricula.Name = "labMatricula";
            this.labMatricula.Size = new System.Drawing.Size(50, 13);
            this.labMatricula.TabIndex = 30;
            this.labMatricula.Text = "Matricula";
            // 
            // comboBoxMatricula
            // 
            this.comboBoxMatricula.FormattingEnabled = true;
            this.comboBoxMatricula.Location = new System.Drawing.Point(122, 118);
            this.comboBoxMatricula.Name = "comboBoxMatricula";
            this.comboBoxMatricula.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMatricula.TabIndex = 31;
            // 
            // labDataNacimentoFuncionario
            // 
            this.labDataNacimentoFuncionario.AutoSize = true;
            this.labDataNacimentoFuncionario.Location = new System.Drawing.Point(6, 165);
            this.labDataNacimentoFuncionario.Name = "labDataNacimentoFuncionario";
            this.labDataNacimentoFuncionario.Size = new System.Drawing.Size(78, 13);
            this.labDataNacimentoFuncionario.TabIndex = 28;
            this.labDataNacimentoFuncionario.Text = "Data Admissão";
            // 
            // dateTimeDataNacimentoFuncionario
            // 
            this.dateTimeDataNacimentoFuncionario.Location = new System.Drawing.Point(122, 159);
            this.dateTimeDataNacimentoFuncionario.Name = "dateTimeDataNacimentoFuncionario";
            this.dateTimeDataNacimentoFuncionario.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDataNacimentoFuncionario.TabIndex = 29;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.groupBoxDadoFuncionario);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.groupBoxDadoFuncionario.ResumeLayout(false);
            this.groupBoxDadoFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpfFuncionario;
        private System.Windows.Forms.Label labCpfFuncionario;
        private System.Windows.Forms.TextBox textBoxNomeFuncionario;
        private System.Windows.Forms.Label labNomeFuncionario;
        private System.Windows.Forms.GroupBox groupBoxDadoFuncionario;
        private System.Windows.Forms.Label labDataNacimentoFuncionario;
        private System.Windows.Forms.DateTimePicker dateTimeDataNacimentoFuncionario;
        private System.Windows.Forms.Label labMatricula;
        private System.Windows.Forms.ComboBox comboBoxMatricula;
        private System.Windows.Forms.Label labPis;
        private System.Windows.Forms.ComboBox comboBoxPis;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSalario;
        private System.Windows.Forms.Label labSalario;
    }
}