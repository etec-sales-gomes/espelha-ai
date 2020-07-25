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
            this.lblPorta = new System.Windows.Forms.Label();
            this.nQuality = new System.Windows.Forms.NumericUpDown();
            this.lblQualidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(14, 235);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(234, 37);
            this.btnShare.TabIndex = 1;
            this.btnShare.Text = "Compartilhar";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::server.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 140);
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
            this.nPort.Location = new System.Drawing.Point(73, 160);
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
            this.nPort.Size = new System.Drawing.Size(176, 20);
            this.nPort.TabIndex = 0;
            this.nPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nPort.Value = new decimal(new int[] {
            22555,
            0,
            0,
            0});
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(12, 162);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(35, 13);
            this.lblPorta.TabIndex = 2;
            this.lblPorta.Text = "Porta:";
            // 
            // nQuality
            // 
            this.nQuality.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nQuality.Location = new System.Drawing.Point(73, 200);
            this.nQuality.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nQuality.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nQuality.Name = "nQuality";
            this.nQuality.Size = new System.Drawing.Size(176, 20);
            this.nQuality.TabIndex = 3;
            this.nQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nQuality.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nQuality.ValueChanged += new System.EventHandler(this.nQuality_ValueChanged);
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Location = new System.Drawing.Point(12, 202);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(58, 13);
            this.lblQualidade.TabIndex = 4;
            this.lblQualidade.Text = "Qualidade:";
            // 
            // initialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 284);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.nQuality);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.nPort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "initialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espelha Aí - Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.initialForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nPort;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.NumericUpDown nQuality;
        private System.Windows.Forms.Label lblQualidade;
    }
}

