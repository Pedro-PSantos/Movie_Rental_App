using System.Drawing;
using System.Windows.Forms;

namespace MVC_IMDb.Forms
{
    public partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            Titulo = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Menu = new Panel();
            panel4 = new Panel();
            SairButton = new Button();
            panel2 = new Panel();
            RequisicoesButton = new Button();
            panel1 = new Panel();
            FilmesButton = new Button();
            Conteudo = new Panel();
            Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.FromArgb(20, 70, 180);
            Titulo.Controls.Add(label1);
            Titulo.Controls.Add(pictureBox2);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(3, 2, 3, 2);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(861, 34);
            Titulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(397, 4);
            label1.Name = "label1";
            label1.Size = new Size(69, 27);
            label1.TabIndex = 4;
            label1.Text = "Menu";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(819, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(16, 6, 51);
            Menu.Controls.Add(panel4);
            Menu.Controls.Add(SairButton);
            Menu.Controls.Add(panel2);
            Menu.Controls.Add(RequisicoesButton);
            Menu.Controls.Add(panel1);
            Menu.Controls.Add(FilmesButton);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 34);
            Menu.Margin = new Padding(3, 2, 3, 2);
            Menu.Name = "Menu";
            Menu.Size = new Size(159, 466);
            Menu.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 70, 180);
            panel4.Location = new Point(0, 398);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 30);
            panel4.TabIndex = 6;
            // 
            // SairButton
            // 
            SairButton.BackColor = Color.FromArgb(16, 6, 51);
            SairButton.FlatAppearance.BorderSize = 0;
            SairButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 70, 180);
            SairButton.FlatStyle = FlatStyle.Flat;
            SairButton.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            SairButton.ForeColor = Color.White;
            SairButton.Image = (Image)resources.GetObject("SairButton.Image");
            SairButton.ImageAlign = ContentAlignment.MiddleLeft;
            SairButton.Location = new Point(3, 393);
            SairButton.Margin = new Padding(3, 2, 3, 2);
            SairButton.Name = "SairButton";
            SairButton.Size = new Size(159, 30);
            SairButton.TabIndex = 7;
            SairButton.Text = "Sair";
            SairButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SairButton.UseVisualStyleBackColor = false;
            SairButton.Click += SairButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 70, 180);
            panel2.Location = new Point(0, 112);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 30);
            panel2.TabIndex = 2;
            // 
            // RequisicoesButton
            // 
            RequisicoesButton.BackColor = Color.FromArgb(16, 6, 51);
            RequisicoesButton.FlatAppearance.BorderSize = 0;
            RequisicoesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 70, 180);
            RequisicoesButton.FlatStyle = FlatStyle.Flat;
            RequisicoesButton.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            RequisicoesButton.ForeColor = Color.White;
            RequisicoesButton.Image = (Image)resources.GetObject("RequisicoesButton.Image");
            RequisicoesButton.ImageAlign = ContentAlignment.MiddleLeft;
            RequisicoesButton.Location = new Point(3, 111);
            RequisicoesButton.Margin = new Padding(3, 2, 3, 2);
            RequisicoesButton.Name = "RequisicoesButton";
            RequisicoesButton.Size = new Size(157, 30);
            RequisicoesButton.TabIndex = 3;
            RequisicoesButton.Text = "Requisições";
            RequisicoesButton.UseVisualStyleBackColor = false;
            RequisicoesButton.Click += RequisicoesButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 70, 180);
            panel1.Location = new Point(0, 60);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(4, 30);
            panel1.TabIndex = 0;
            // 
            // FilmesButton
            // 
            FilmesButton.BackColor = Color.FromArgb(16, 6, 51);
            FilmesButton.FlatAppearance.BorderSize = 0;
            FilmesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 70, 180);
            FilmesButton.FlatStyle = FlatStyle.Flat;
            FilmesButton.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            FilmesButton.ForeColor = Color.White;
            FilmesButton.Image = (Image)resources.GetObject("FilmesButton.Image");
            FilmesButton.ImageAlign = ContentAlignment.MiddleLeft;
            FilmesButton.Location = new Point(3, 60);
            FilmesButton.Margin = new Padding(3, 2, 3, 2);
            FilmesButton.Name = "FilmesButton";
            FilmesButton.Size = new Size(157, 30);
            FilmesButton.TabIndex = 1;
            FilmesButton.Text = "Filmes";
            FilmesButton.UseVisualStyleBackColor = false;
            FilmesButton.Click += FilmesButton_Click;
            // 
            // Conteudo
            // 
            Conteudo.BackColor = Color.FromArgb(48, 65, 80);
            Conteudo.Dock = DockStyle.Fill;
            Conteudo.Location = new Point(159, 34);
            Conteudo.Margin = new Padding(3, 2, 3, 2);
            Conteudo.Name = "Conteudo";
            Conteudo.Size = new Size(702, 466);
            Conteudo.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 500);
            Controls.Add(Conteudo);
            Controls.Add(Menu);
            Controls.Add(Titulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Titulo;
        private Panel Menu;
        private Button FilmesButton;
        private Panel Conteudo;
        private Panel panel1;
        private Panel panel2;
        private Button RequisicoesButton;
        private Panel panel4;
        private Button SairButton;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
