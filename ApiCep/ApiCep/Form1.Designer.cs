
namespace ApiCep
{
    partial class FrmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogradouro = new System.Windows.Forms.Button();
            this.btnIbge = new System.Windows.Forms.Button();
            this.btnCEP = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnLogradouro);
            this.pnlMenu.Controls.Add(this.btnIbge);
            this.pnlMenu.Controls.Add(this.btnCEP);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(279, 594);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogradouro
            // 
            this.btnLogradouro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogradouro.FlatAppearance.BorderSize = 0;
            this.btnLogradouro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogradouro.Font = new System.Drawing.Font("Ruda", 18F);
            this.btnLogradouro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.btnLogradouro.Location = new System.Drawing.Point(0, 281);
            this.btnLogradouro.Name = "btnLogradouro";
            this.btnLogradouro.Size = new System.Drawing.Size(279, 90);
            this.btnLogradouro.TabIndex = 5;
            this.btnLogradouro.Text = "LOGRADOURO";
            this.btnLogradouro.UseVisualStyleBackColor = true;
            this.btnLogradouro.Click += new System.EventHandler(this.btnLogradouro_Click_1);
            // 
            // btnIbge
            // 
            this.btnIbge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIbge.FlatAppearance.BorderSize = 0;
            this.btnIbge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIbge.Font = new System.Drawing.Font("Ruda", 18F);
            this.btnIbge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.btnIbge.Location = new System.Drawing.Point(0, 191);
            this.btnIbge.Name = "btnIbge";
            this.btnIbge.Size = new System.Drawing.Size(279, 90);
            this.btnIbge.TabIndex = 3;
            this.btnIbge.Text = "CÓDIGO IBGE";
            this.btnIbge.UseVisualStyleBackColor = true;
            this.btnIbge.Click += new System.EventHandler(this.btnIbge_Click_1);
            // 
            // btnCEP
            // 
            this.btnCEP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCEP.FlatAppearance.BorderSize = 0;
            this.btnCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEP.Font = new System.Drawing.Font("Ruda", 18F);
            this.btnCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.btnCEP.Location = new System.Drawing.Point(0, 101);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(279, 90);
            this.btnCEP.TabIndex = 1;
            this.btnCEP.Text = "CEP";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click_1);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(279, 101);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Ruda", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.lblLogo.Location = new System.Drawing.Point(68, 26);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(141, 54);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "GitHub\n@RenanLima7";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(96)))), ((int)(((byte)(228)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(279, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(770, 101);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ruda", 25F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.lblTitle.Location = new System.Drawing.Point(319, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Principal";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 594);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.Button btnLogradouro;
        private System.Windows.Forms.Button btnIbge;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
    }
}

