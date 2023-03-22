namespace MigradorRP
{
    partial class frmConfigImportacao
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
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.cfgImpQtd = new System.Windows.Forms.CheckBox();
            this.btSaveConfig = new System.Windows.Forms.Button();
            this.btnCancelCLose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSistema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEntrada = new System.Windows.Forms.ComboBox();
            this.pnlConfigOptions = new System.Windows.Forms.Panel();
            this.pnlConfigOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(418, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopBar.ForeColor = System.Drawing.Color.White;
            this.lblTopBar.Location = new System.Drawing.Point(0, 2);
            this.lblTopBar.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTopBar.Size = new System.Drawing.Size(450, 30);
            this.lblTopBar.TabIndex = 23;
            this.lblTopBar.Text = "Configuraçao de importação";
            this.lblTopBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cfgImpQtd
            // 
            this.cfgImpQtd.AutoSize = true;
            this.cfgImpQtd.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgImpQtd.ForeColor = System.Drawing.Color.White;
            this.cfgImpQtd.Location = new System.Drawing.Point(5, 13);
            this.cfgImpQtd.Name = "cfgImpQtd";
            this.cfgImpQtd.Size = new System.Drawing.Size(174, 29);
            this.cfgImpQtd.TabIndex = 24;
            this.cfgImpQtd.Text = "importar quantidade";
            this.cfgImpQtd.UseVisualStyleBackColor = true;
            this.cfgImpQtd.CheckStateChanged += new System.EventHandler(this.cfgImpQtd_Change);
            // 
            // btSaveConfig
            // 
            this.btSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btSaveConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveConfig.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveConfig.ForeColor = System.Drawing.Color.White;
            this.btSaveConfig.Location = new System.Drawing.Point(298, 458);
            this.btSaveConfig.Name = "btSaveConfig";
            this.btSaveConfig.Size = new System.Drawing.Size(150, 40);
            this.btSaveConfig.TabIndex = 25;
            this.btSaveConfig.Text = "Salvar";
            this.btSaveConfig.UseVisualStyleBackColor = false;
            this.btSaveConfig.Click += new System.EventHandler(this.btSaveConfig_Click);
            // 
            // btnCancelCLose
            // 
            this.btnCancelCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelCLose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelCLose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnCancelCLose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelCLose.Location = new System.Drawing.Point(0, 458);
            this.btnCancelCLose.Name = "btnCancelCLose";
            this.btnCancelCLose.Size = new System.Drawing.Size(150, 40);
            this.btnCancelCLose.TabIndex = 26;
            this.btnCancelCLose.Text = "Cancelar";
            this.btnCancelCLose.UseVisualStyleBackColor = false;
            this.btnCancelCLose.Click += new System.EventHandler(this.btnCancelCLose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Sistema";
            // 
            // cboSistema
            // 
            this.cboSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSistema.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSistema.FormattingEnabled = true;
            this.cboSistema.ItemHeight = 23;
            this.cboSistema.Items.AddRange(new object[] {
            "LeCheff",
            "LeStore"});
            this.cboSistema.Location = new System.Drawing.Point(234, 81);
            this.cboSistema.Name = "cboSistema";
            this.cboSistema.Size = new System.Drawing.Size(150, 31);
            this.cboSistema.TabIndex = 29;
            this.cboSistema.SelectedValueChanged += new System.EventHandler(this.cboSistema_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Entrada de dados";
            // 
            // cboEntrada
            // 
            this.cboEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntrada.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntrada.FormattingEnabled = true;
            this.cboEntrada.ItemHeight = 23;
            this.cboEntrada.Items.AddRange(new object[] {
            "Excel",
            "Etrade(VrSystem)"});
            this.cboEntrada.Location = new System.Drawing.Point(51, 81);
            this.cboEntrada.Name = "cboEntrada";
            this.cboEntrada.Size = new System.Drawing.Size(150, 31);
            this.cboEntrada.TabIndex = 27;
            this.cboEntrada.SelectedValueChanged += new System.EventHandler(this.cboEntrada_SelectedValueChanged);
            // 
            // pnlConfigOptions
            // 
            this.pnlConfigOptions.Controls.Add(this.cfgImpQtd);
            this.pnlConfigOptions.Location = new System.Drawing.Point(1, 131);
            this.pnlConfigOptions.Name = "pnlConfigOptions";
            this.pnlConfigOptions.Size = new System.Drawing.Size(447, 367);
            this.pnlConfigOptions.TabIndex = 31;
            this.pnlConfigOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConfigOptions_Paint);
            // 
            // frmConfigImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(448, 498);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSistema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEntrada);
            this.Controls.Add(this.btnCancelCLose);
            this.Controls.Add(this.btSaveConfig);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.pnlConfigOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigImportacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfigImportacao_Load);
            this.pnlConfigOptions.ResumeLayout(false);
            this.pnlConfigOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.CheckBox cfgImpQtd;
        private System.Windows.Forms.Button btSaveConfig;
        private System.Windows.Forms.Button btnCancelCLose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEntrada;
        private System.Windows.Forms.Panel pnlConfigOptions;
    }
}