using System.Drawing;
using System.Windows.Forms;

namespace MVC_IMDb.Forms
{
    partial class FormMoviesList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoviesList));
            EscolherFilmeButton = new Button();
            RecolherFilmeButton = new Button();
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
            // EscolherFilmeButton
            // 
            EscolherFilmeButton.BackColor = Color.FromArgb(0, 105, 200);
            EscolherFilmeButton.FlatAppearance.BorderSize = 0;
            EscolherFilmeButton.FlatStyle = FlatStyle.Flat;
            EscolherFilmeButton.ForeColor = Color.LightGray;
            EscolherFilmeButton.Location = new Point(142, 292);
            EscolherFilmeButton.Margin = new Padding(3, 2, 3, 2);
            EscolherFilmeButton.Name = "EscolherFilmeButton";
            EscolherFilmeButton.Size = new Size(86, 29);
            EscolherFilmeButton.TabIndex = 12;
            EscolherFilmeButton.Text = "Escolher";
            EscolherFilmeButton.UseVisualStyleBackColor = false;
            EscolherFilmeButton.Click += EscolherFilmeButton_Click;
            // 
            // RecolherFilmeButton
            // 
            RecolherFilmeButton.BackColor = Color.FromArgb(0, 105, 200);
            RecolherFilmeButton.FlatAppearance.BorderSize = 0;
            RecolherFilmeButton.FlatStyle = FlatStyle.Flat;
            RecolherFilmeButton.ForeColor = Color.LightGray;
            RecolherFilmeButton.Location = new Point(407, 292);
            RecolherFilmeButton.Margin = new Padding(3, 2, 3, 2);
            RecolherFilmeButton.Name = "RecolherFilmeButton";
            RecolherFilmeButton.Size = new Size(86, 29);
            RecolherFilmeButton.TabIndex = 9;
            RecolherFilmeButton.Text = "Requisitar";
            RecolherFilmeButton.UseVisualStyleBackColor = false;
            RecolherFilmeButton.Click += RecolherFilmeButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(45, 70, 90);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Location = new Point(14, 47);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowTemplate.Height = 100;
            dataGridView.Size = new Size(584, 232);
            dataGridView.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(271, 3);
            label1.Name = "label1";
            label1.Size = new Size(58, 27);
            label1.TabIndex = 4;
            label1.Text = "Lista";
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
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.FromArgb(20, 70, 180);
            Titulo.Controls.Add(pictureBox1);
            Titulo.Controls.Add(label1);
            Titulo.Controls.Add(pictureBox2);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(3, 2, 3, 2);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(610, 34);
            Titulo.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(575, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormMoviesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 6, 50);
            ClientSize = new Size(610, 336);
            Controls.Add(Titulo);
            Controls.Add(EscolherFilmeButton);
            Controls.Add(RecolherFilmeButton);
            Controls.Add(dataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMoviesList";
            Text = "Form3";
            Load += FormMoviesList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button EscolherFilmeButton;
        private Button RecolherFilmeButton;
        private DataGridView dataGridView;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel Titulo;
        private PictureBox pictureBox1;
    }
}