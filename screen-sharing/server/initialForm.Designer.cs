namespace server
{
    partial class initialForm
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
            this.btnShare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(12, 176);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(249, 37);
            this.btnShare.TabIndex = 1;
            this.btnShare.Text = "Compartilhar";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::server.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nPort
            // 
            this.nPort.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nPort.Location = new System.Drawing.Point(12, 149);
            this.nPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nPort.Minimum = new decimal(new int[] {
            22555,
            0,
            0,
            0});
            this.nPort.Name = "nPort";
            this.nPort.Size = new System.Drawing.Size(249, 20);
            this.nPort.TabIndex = 0;
            this.nPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nPort.Value = new decimal(new int[] {
            22555,
            0,
            0,
            0});
            // 
            // initialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 225);
            this.Controls.Add(this.nPort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "initialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espelha Aí - Servidor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nPort;
    }
}

