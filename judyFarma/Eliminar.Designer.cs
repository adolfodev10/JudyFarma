namespace judyFarma
{
    partial class Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.iconDelete = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Preco = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveBorderThickness = 1;
            this.btnEliminar.ActiveCornerRadius = 30;
            this.btnEliminar.ActiveFillColor = System.Drawing.Color.OliveDrab;
            this.btnEliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminar.ActiveLineColor = System.Drawing.Color.OliveDrab;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleCornerRadius = 20;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.OliveDrab;
            this.btnEliminar.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminar.IdleLineColor = System.Drawing.Color.OliveDrab;
            this.btnEliminar.Location = new System.Drawing.Point(91, 297);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(287, 57);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconDelete
            // 
            this.iconDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDelete.Image = ((System.Drawing.Image)(resources.GetObject("iconDelete.Image")));
            this.iconDelete.Location = new System.Drawing.Point(191, 75);
            this.iconDelete.Name = "iconDelete";
            this.iconDelete.Size = new System.Drawing.Size(80, 85);
            this.iconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconDelete.TabIndex = 8;
            this.iconDelete.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(200, 182);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(70, 25);
            this.ID.TabIndex = 12;
            this.ID.Text = "label1";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(199, 218);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(70, 25);
            this.Nome.TabIndex = 13;
            this.Nome.Text = "label2";
            // 
            // Preco
            // 
            this.Preco.AutoSize = true;
            this.Preco.Location = new System.Drawing.Point(199, 253);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(70, 25);
            this.Preco.TabIndex = 14;
            this.Preco.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.iconDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
        private System.Windows.Forms.PictureBox iconDelete;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Preco;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}