using System.Drawing;
using System.Windows.Forms;

namespace MVC_IMDb.Forms
{
    partial class FormSelectedMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectedMovie));
            RequisitarFilmeButton = new Button();
            FilmeLabel = new Label();
            pictureBox2 = new PictureBox();
            Titulo = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ComentarioTextBox = new RichTextBox();
            ComentariosListBox = new ListBox();
            ComentarioButton = new Button();
            TituloLabel = new Label();
            DuracaoLabel = new Label();
            AnoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // RequisitarFilmeButton
            // 
            RequisitarFilmeButton.BackColor = Color.FromArgb(0, 105, 200);
            RequisitarFilmeButton.FlatAppearance.BorderSize = 0;
            RequisitarFilmeButton.FlatStyle = FlatStyle.Flat;
            RequisitarFilmeButton.ForeColor = Color.LightGray;
            RequisitarFilmeButton.Location = new Point(110, 395);
            RequisitarFilmeButton.Name = "RequisitarFilmeButton";
            RequisitarFilmeButton.Size = new Size(98, 39);
            RequisitarFilmeButton.TabIndex = 9;
            RequisitarFilmeButton.Text = "Requisitar";
            RequisitarFilmeButton.UseVisualStyleBackColor = false;
            RequisitarFilmeButton.Click += RequisitarFilmeButton_Click;
            // 
            // FilmeLabel
            // 
            FilmeLabel.AutoSize = true;
            FilmeLabel.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FilmeLabel.ForeColor = Color.Gainsboro;
            FilmeLabel.Location = new Point(310, 4);
            FilmeLabel.Name = "FilmeLabel";
            FilmeLabel.Size = new Size(83, 35);
            FilmeLabel.TabIndex = 4;
            FilmeLabel.Text = "Filme";
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
            // Titulo
            // 
            Titulo.BackColor = Color.FromArgb(20, 70, 180);
            Titulo.Controls.Add(pictureBox1);
            Titulo.Controls.Add(FilmeLabel);
            Titulo.Controls.Add(pictureBox2);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(697, 45);
            Titulo.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(657, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(110, 68);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // ComentarioTextBox
            // 
            ComentarioTextBox.Location = new Point(390, 300);
            ComentarioTextBox.Margin = new Padding(3, 4, 3, 4);
            ComentarioTextBox.Name = "ComentarioTextBox";
            ComentarioTextBox.Size = new Size(293, 73);
            ComentarioTextBox.TabIndex = 16;
            ComentarioTextBox.Text = "Adicione um comentário...";
            ComentarioTextBox.Click += ComentarioTextBox_Click;
            ComentarioTextBox.KeyDown += ComentarioTextBox_KeyDown;
            // 
            // ComentariosListBox
            // 
            ComentariosListBox.FormattingEnabled = true;
            ComentariosListBox.ItemHeight = 20;
            ComentariosListBox.Location = new Point(390, 68);
            ComentariosListBox.Margin = new Padding(3, 4, 3, 4);
            ComentariosListBox.Name = "ComentariosListBox";
            ComentariosListBox.SelectionMode = SelectionMode.None;
            ComentariosListBox.Size = new Size(293, 224);
            ComentariosListBox.TabIndex = 17;
            // 
            // ComentarioButton
            // 
            ComentarioButton.BackColor = Color.FromArgb(0, 105, 200);
            ComentarioButton.FlatAppearance.BorderSize = 0;
            ComentarioButton.FlatStyle = FlatStyle.Flat;
            ComentarioButton.ForeColor = Color.LightGray;
            ComentarioButton.Location = new Point(470, 395);
            ComentarioButton.Name = "ComentarioButton";
            ComentarioButton.Size = new Size(135, 39);
            ComentarioButton.TabIndex = 18;
            ComentarioButton.Text = "Enviar Comentário";
            ComentarioButton.UseVisualStyleBackColor = false;
            ComentarioButton.Click += ComentarioButton_Click;
            // 
            // TituloLabel
            // 
            TituloLabel.AutoSize = true;
            TituloLabel.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TituloLabel.ForeColor = Color.Gainsboro;
            TituloLabel.Location = new Point(25, 221);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(103, 35);
            TituloLabel.TabIndex = 20;
            TituloLabel.Text = "Titulo: ";
            // 
            // DuracaoLabel
            // 
            DuracaoLabel.AutoSize = true;
            DuracaoLabel.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DuracaoLabel.ForeColor = Color.Gainsboro;
            DuracaoLabel.Location = new Point(25, 277);
            DuracaoLabel.Name = "DuracaoLabel";
            DuracaoLabel.Size = new Size(131, 35);
            DuracaoLabel.TabIndex = 21;
            DuracaoLabel.Text = "Duração: ";
            // 
            // AnoLabel
            // 
            AnoLabel.AutoSize = true;
            AnoLabel.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AnoLabel.ForeColor = Color.Gainsboro;
            AnoLabel.Location = new Point(25, 339);
            AnoLabel.Name = "AnoLabel";
            AnoLabel.Size = new Size(79, 35);
            AnoLabel.TabIndex = 22;
            AnoLabel.Text = "Ano: ";
            // 
            // FormSelectedMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 6, 50);
            ClientSize = new Size(697, 448);
            Controls.Add(AnoLabel);
            Controls.Add(DuracaoLabel);
            Controls.Add(TituloLabel);
            Controls.Add(ComentarioButton);
            Controls.Add(ComentariosListBox);
            Controls.Add(ComentarioTextBox);
            Controls.Add(pictureBox3);
            Controls.Add(Titulo);
            Controls.Add(RequisitarFilmeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSelectedMovie";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button RequisitarFilmeButton;
        private Label FilmeLabel;
        private PictureBox pictureBox2;
        private Panel Titulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private RichTextBox ComentarioTextBox;
        private ListBox ComentariosListBox;
        private Button ComentarioButton;
        private Label TituloLabel;
        private Label DuracaoLabel;
        private Label AnoLabel;
    }
}