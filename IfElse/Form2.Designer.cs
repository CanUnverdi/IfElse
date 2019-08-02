namespace IfElse
{
    partial class Form2
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
            this.txtBirinciDeger = new System.Windows.Forms.TextBox();
            this.txtIkinciDeger = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnSatıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBirinciDeger
            // 
            this.txtBirinciDeger.Location = new System.Drawing.Point(61, 34);
            this.txtBirinciDeger.Margin = new System.Windows.Forms.Padding(6);
            this.txtBirinciDeger.Name = "txtBirinciDeger";
            this.txtBirinciDeger.Size = new System.Drawing.Size(196, 29);
            this.txtBirinciDeger.TabIndex = 0;
            // 
            // txtIkinciDeger
            // 
            this.txtIkinciDeger.Location = new System.Drawing.Point(61, 82);
            this.txtIkinciDeger.Margin = new System.Windows.Forms.Padding(6);
            this.txtIkinciDeger.Name = "txtIkinciDeger";
            this.txtIkinciDeger.Size = new System.Drawing.Size(196, 29);
            this.txtIkinciDeger.TabIndex = 0;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(61, 130);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(6);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(200, 42);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş Bilgi Kontrolü";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(61, 184);
            this.btnNot.Margin = new System.Windows.Forms.Padding(6);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(200, 42);
            this.btnNot.TabIndex = 1;
            this.btnNot.Text = "Not Kontrolü";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(61, 237);
            this.btnMarket.Margin = new System.Windows.Forms.Padding(6);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(200, 42);
            this.btnMarket.TabIndex = 1;
            this.btnMarket.Text = "Market Kontrolü";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnSatıs
            // 
            this.btnSatıs.Location = new System.Drawing.Point(61, 291);
            this.btnSatıs.Margin = new System.Windows.Forms.Padding(6);
            this.btnSatıs.Name = "btnSatıs";
            this.btnSatıs.Size = new System.Drawing.Size(200, 42);
            this.btnSatıs.TabIndex = 1;
            this.btnSatıs.Text = "Satış İşlemi";
            this.btnSatıs.UseVisualStyleBackColor = true;
            this.btnSatıs.Click += new System.EventHandler(this.btnSatıs_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 398);
            this.Controls.Add(this.btnSatıs);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtIkinciDeger);
            this.Controls.Add(this.txtBirinciDeger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirinciDeger;
        private System.Windows.Forms.TextBox txtIkinciDeger;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnSatıs;
    }
}