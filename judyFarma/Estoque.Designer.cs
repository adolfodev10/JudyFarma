namespace judyFarma
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.label4 = new System.Windows.Forms.Label();
            this.dados = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.funcionario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(591, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Controle Financeiro (Estoque)";
            // 
            // dados
            // 
            this.dados.BackgroundColor = System.Drawing.Color.White;
            this.dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados.Location = new System.Drawing.Point(35, 373);
            this.dados.Name = "dados";
            this.dados.RowTemplate.Height = 33;
            this.dados.Size = new System.Drawing.Size(1071, 234);
            this.dados.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(71, 667);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // funcionario
            // 
            this.funcionario.AutoSize = true;
            this.funcionario.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionario.ForeColor = System.Drawing.Color.Silver;
            this.funcionario.Location = new System.Drawing.Point(35, 38);
            this.funcionario.Name = "funcionario";
            this.funcionario.Size = new System.Drawing.Size(30, 26);
            this.funcionario.TabIndex = 21;
            this.funcionario.Text = "...";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 773);
            this.Controls.Add(this.funcionario);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dados);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dados;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label funcionario;
    }
}