namespace MVC_IMDb
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            CriarContaButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            Titulo = new System.Windows.Forms.Panel();
            btnEncerrar = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            _passwordTextBox = new System.Windows.Forms.TextBox();
            _emailTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            _utilizadorTextBox = new System.Windows.Forms.TextBox();
            Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CriarContaButton
            // 
            CriarContaButton.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            CriarContaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CriarContaButton.ForeColor = System.Drawing.Color.Gainsboro;
            CriarContaButton.Location = new System.Drawing.Point(277, 390);
            CriarContaButton.Name = "CriarContaButton";
            CriarContaButton.Size = new System.Drawing.Size(147, 50);
            CriarContaButton.TabIndex = 16;
            CriarContaButton.Text = "Criar Conta";
            CriarContaButton.UseVisualStyleBackColor = false;
            CriarContaButton.Click += CriarContaButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(106, 309);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 15;
            label1.Text = "Password";
            // 
            // label
            // 
            label.AutoSize = true;
            label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label.Location = new System.Drawing.Point(33, 227);
            label.Name = "label";
            label.Size = new System.Drawing.Size(139, 20);
            label.TabIndex = 14;
            label.Text = "Endereço de e-mail";
            // 
            // Titulo
            // 
            Titulo.BackColor = System.Drawing.Color.FromArgb(20, 70, 180);
            Titulo.Controls.Add(btnEncerrar);
            Titulo.Controls.Add(label2);
            Titulo.Controls.Add(pictureBox2);
            Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            Titulo.Location = new System.Drawing.Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new System.Drawing.Size(710, 45);
            Titulo.TabIndex = 13;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Image = (System.Drawing.Image)resources.GetObject("btnEncerrar.Image");
            btnEncerrar.Location = new System.Drawing.Point(657, -9);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new System.Drawing.Size(55, 64);
            btnEncerrar.TabIndex = 7;
            btnEncerrar.TabStop = false;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Gainsboro;
            label2.Location = new System.Drawing.Point(277, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 35);
            label2.TabIndex = 4;
            label2.Text = "Criar Conta";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(936, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(48, 45);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // _passwordTextBox
            // 
            _passwordTextBox.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            _passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _passwordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            _passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            _passwordTextBox.Location = new System.Drawing.Point(178, 302);
            _passwordTextBox.Name = "_passwordTextBox";
            _passwordTextBox.PasswordChar = '*';
            _passwordTextBox.Size = new System.Drawing.Size(357, 32);
            _passwordTextBox.TabIndex = 11;
            // 
            // _emailTextBox
            // 
            _emailTextBox.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            _emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _emailTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            _emailTextBox.ForeColor = System.Drawing.Color.DarkGray;
            _emailTextBox.Location = new System.Drawing.Point(178, 221);
            _emailTextBox.Name = "_emailTextBox";
            _emailTextBox.Size = new System.Drawing.Size(357, 32);
            _emailTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(33, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 20);
            label3.TabIndex = 18;
            label3.Text = "Nome de Utilizador";
            // 
            // _utilizadorTextBox
            // 
            _utilizadorTextBox.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            _utilizadorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _utilizadorTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            _utilizadorTextBox.ForeColor = System.Drawing.Color.DarkGray;
            _utilizadorTextBox.Location = new System.Drawing.Point(178, 134);
            _utilizadorTextBox.Name = "_utilizadorTextBox";
            _utilizadorTextBox.Size = new System.Drawing.Size(357, 32);
            _utilizadorTextBox.TabIndex = 17;
            // 
            // FormCreateAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(16, 6, 50);
            ClientSize = new System.Drawing.Size(710, 500);
            Controls.Add(label3);
            Controls.Add(_utilizadorTextBox);
            Controls.Add(CriarContaButton);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(Titulo);
            Controls.Add(_passwordTextBox);
            Controls.Add(_emailTextBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormCreateAccount";
            Text = "Form1";
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnEncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CriarContaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel Titulo;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.TextBox _emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _utilizadorTextBox;
    }
}