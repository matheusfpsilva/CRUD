﻿namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btnPesquisar = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            lblID = new Label();
            label5 = new Label();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            btnLimpar = new Button();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedBoxCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(474, 263);
            button1.Name = "button1";
            button1.Size = new Size(151, 44);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 71);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 109);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 146);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(395, 23);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(394, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(173, 263);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(119, 44);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(105, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 23);
            textBox1.TabIndex = 9;
            textBox1.Text = "Id Aluno";
            // 
            // label4
            // 
            label4.AccessibleName = "txtId";
            label4.AutoSize = true;
            label4.Location = new Point(207, 209);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(210, 208);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 215);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 12;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(315, 263);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(133, 44);
            btnAtualizar.TabIndex = 13;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Brown;
            btnDeletar.Location = new Point(37, 263);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(119, 44);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(550, 12);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(0, 0);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(100, 23);
            maskedTextBoxCpf.TabIndex = 0;
            // 
            // maskedBoxCpf
            // 
            maskedBoxCpf.Location = new Point(173, 101);
            maskedBoxCpf.Mask = "000,000,000-00";
            maskedBoxCpf.Name = "maskedBoxCpf";
            maskedBoxCpf.Size = new Size(393, 23);
            maskedBoxCpf.TabIndex = 16;
            maskedBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 333);
            Controls.Add(maskedBoxCpf);
            Controls.Add(btnLimpar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(label5);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(btnPesquisar);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnPesquisar;
        private TextBox textBox1;
        private Label label4;
        private Label lblID;
        private Label label5;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Button btnLimpar;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedBoxCpf;
    }
}
