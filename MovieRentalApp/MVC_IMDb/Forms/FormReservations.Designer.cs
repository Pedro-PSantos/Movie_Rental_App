using System.Drawing;
using System.Windows.Forms;

namespace MVC_IMDb.Forms
{
    partial class FormReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservations));
            VoltarButton = new Button();
            dataGridView = new DataGridView();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Titulo = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // VoltarButton
            // 
            VoltarButton.BackColor = Color.FromArgb(0, 105, 200);
            VoltarButton.FlatAppearance.BorderSize = 0;
            VoltarButton.FlatStyle = FlatStyle.Flat;
            VoltarButton.ForeColor = Color.LightGray;
            VoltarButton.Location = new Point(290, 395);
            VoltarButton.Name = "VoltarButton";
            VoltarButton.Size = new Size(98, 39);
            VoltarButton.TabIndex = 12;
            VoltarButton.Text = "Voltar";
            VoltarButton.UseVisualStyleBackColor = false;
            VoltarButton.Click += VoltarButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.FromArgb(45, 70, 90);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(16, 63);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(667, 309);
            dataGridView.TabIndex = 8;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(264, 7);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 4;
            label1.Text = "Requisicoes";
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
            Titulo.Controls.Add(label1);
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
            // FormReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 6, 50);
            ClientSize = new Size(697, 448);
            Controls.Add(Titulo);
            Controls.Add(VoltarButton);
            Controls.Add(dataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReservations";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button VoltarButton;
        private DataGridView dataGridView;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel Titulo;
        private PictureBox pictureBox1;
    }
}