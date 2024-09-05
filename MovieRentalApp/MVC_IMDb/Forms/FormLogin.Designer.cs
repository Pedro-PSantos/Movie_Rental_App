using System.Drawing;
using System.Windows.Forms;

namespace MVC_IMDb.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            _utilizadorTextBox = new TextBox();
            _passwordTextBox = new TextBox();
            loginButton = new Button();
            Titulo = new Panel();
            btnEncerrar = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label = new Label();
            label1 = new Label();
            CriarContaButton = new Button();
            Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // _utilizadorTextBox
            // 
            _utilizadorTextBox.BackColor = Color.FromArgb(15, 15, 15);
            _utilizadorTextBox.BorderStyle = BorderStyle.FixedSingle;
            _utilizadorTextBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            _utilizadorTextBox.ForeColor = Color.DarkGray;
            _utilizadorTextBox.Location = new Point(178, 163);
            _utilizadorTextBox.Name = "_utilizadorTextBox";
            _utilizadorTextBox.Size = new Size(357, 32);
            _utilizadorTextBox.TabIndex = 1;
            // 
            // _passwordTextBox
            // 
            _passwordTextBox.BackColor = Color.FromArgb(15, 15, 15);
            _passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            _passwordTextBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            _passwordTextBox.ForeColor = Color.DarkGray;
            _passwordTextBox.Location = new Point(178, 244);
            _passwordTextBox.Name = "_passwordTextBox";
            _passwordTextBox.PasswordChar = '*';
            _passwordTextBox.Size = new Size(357, 32);
            _passwordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(40, 40, 40);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.Gainsboro;
            loginButton.Location = new Point(178, 335);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(147, 50);
            loginButton.TabIndex = 4;
            loginButton.Text = "Entrar";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.FromArgb(20, 70, 180);
            Titulo.Controls.Add(btnEncerrar);
            Titulo.Controls.Add(label2);
            Titulo.Controls.Add(pictureBox2);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(710, 45);
            Titulo.TabIndex = 6;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Image = (Image)resources.GetObject("btnEncerrar.Image");
            btnEncerrar.Location = new Point(657, -9);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(55, 64);
            btnEncerrar.TabIndex = 7;
            btnEncerrar.TabStop = false;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(319, 3);
            label2.Name = "label2";
            label2.Size = new Size(84, 35);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(936, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.ForeColor = SystemColors.ButtonFace;
            label.Location = new Point(102, 169);
            label.Name = "label";
            label.Size = new Size(74, 20);
            label.TabIndex = 7;
            label.Text = "Utilizador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(106, 251);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 8;
            label1.Text = "Password";
            // 
            // CriarContaButton
            // 
            CriarContaButton.BackColor = Color.FromArgb(40, 40, 40);
            CriarContaButton.FlatStyle = FlatStyle.Flat;
            CriarContaButton.ForeColor = Color.Gainsboro;
            CriarContaButton.Location = new Point(388, 335);
            CriarContaButton.Name = "CriarContaButton";
            CriarContaButton.Size = new Size(147, 50);
            CriarContaButton.TabIndex = 9;
            CriarContaButton.Text = "Criar Conta";
            CriarContaButton.UseVisualStyleBackColor = false;
            CriarContaButton.Click += CriarContaButton_Click;
            // 
            // FormLogin
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 6, 50);
            ClientSize = new Size(710, 500);
            Controls.Add(CriarContaButton);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(Titulo);
            Controls.Add(loginButton);
            Controls.Add(_passwordTextBox);
            Controls.Add(_utilizadorTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.96D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormLogin_Load;
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnEncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox _utilizadorTextBox;
        private TextBox _passwordTextBox;
        private Button loginButton;
        private Panel Titulo;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox btnEncerrar;
        private Label label;
        private Label label1;
        private Button CriarContaButton;
    }
}