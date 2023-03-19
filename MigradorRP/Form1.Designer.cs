namespace MigradorRP
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.rdSetStore = new System.Windows.Forms.RadioButton();
            this.rdSetCheff = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTopBar
            // 
            this.lblTopBar.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopBar.ForeColor = System.Drawing.Color.White;
            this.lblTopBar.Location = new System.Drawing.Point(0, 0);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTopBar.Size = new System.Drawing.Size(730, 40);
            this.lblTopBar.TabIndex = 0;
            this.lblTopBar.Text = "SISTEMA";
            this.lblTopBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTopBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(794, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(40, 40);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblMin
            // 
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(749, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMin.Size = new System.Drawing.Size(40, 40);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "-";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            this.lblMin.MouseEnter += new System.EventHandler(this.lblMin_MouseEnter);
            this.lblMin.MouseLeave += new System.EventHandler(this.lblMin_MouseLeave);
            // 
            // rdSetStore
            // 
            this.rdSetStore.AutoSize = true;
            this.rdSetStore.Checked = true;
            this.rdSetStore.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSetStore.ForeColor = System.Drawing.Color.White;
            this.rdSetStore.Location = new System.Drawing.Point(12, 62);
            this.rdSetStore.Name = "rdSetStore";
            this.rdSetStore.Size = new System.Drawing.Size(88, 32);
            this.rdSetStore.TabIndex = 3;
            this.rdSetStore.TabStop = true;
            this.rdSetStore.Text = "LeStore";
            this.rdSetStore.UseVisualStyleBackColor = true;
            // 
            // rdSetCheff
            // 
            this.rdSetCheff.AutoSize = true;
            this.rdSetCheff.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSetCheff.ForeColor = System.Drawing.Color.White;
            this.rdSetCheff.Location = new System.Drawing.Point(115, 62);
            this.rdSetCheff.Name = "rdSetCheff";
            this.rdSetCheff.Size = new System.Drawing.Size(89, 32);
            this.rdSetCheff.TabIndex = 4;
            this.rdSetCheff.Text = "LeCheff";
            this.rdSetCheff.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(373, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSetSystem
            // 
            this.btnSetSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnSetSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSystem.ForeColor = System.Drawing.Color.Black;
            this.btnSetSystem.Location = new System.Drawing.Point(224, 64);
            this.btnSetSystem.Name = "btnSetSystem";
            this.btnSetSystem.Size = new System.Drawing.Size(100, 30);
            this.btnSetSystem.TabIndex = 6;
            this.btnSetSystem.Text = "Definir";
            this.btnSetSystem.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.btnSetSystem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdSetCheff);
            this.Controls.Add(this.rdSetStore);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatec Sistemas | MigradorRP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.RadioButton rdSetStore;
        private System.Windows.Forms.RadioButton rdSetCheff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetSystem;
    }
}

