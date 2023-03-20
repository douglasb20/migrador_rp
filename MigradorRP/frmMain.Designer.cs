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
            this.components = new System.ComponentModel.Container();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnSetSystem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btNeutro = new System.Windows.Forms.Button();
            this.BtnFileProd = new FontAwesome.Sharp.IconButton();
            this.btnValidateFiles = new FontAwesome.Sharp.IconButton();
            this.btnFileClient = new FontAwesome.Sharp.IconButton();
            this.btnFileFornecedor = new FontAwesome.Sharp.IconButton();
            this.tmrBorda = new System.Windows.Forms.Timer(this.components);
            this.fileDialogProd = new System.Windows.Forms.OpenFileDialog();
            this.fileDialogClient = new System.Windows.Forms.OpenFileDialog();
            this.fileDialogForn = new System.Windows.Forms.OpenFileDialog();
            this.pnlBorda = new System.Windows.Forms.Panel();
            this.btnCancelFiles = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopBar.ForeColor = System.Drawing.Color.White;
            this.lblTopBar.Location = new System.Drawing.Point(4, 4);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTopBar.Size = new System.Drawing.Size(886, 40);
            this.lblTopBar.TabIndex = 0;
            this.lblTopBar.Text = "SISTEMA";
            this.lblTopBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTopBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(937, 0);
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
            this.lblMin.Location = new System.Drawing.Point(897, 0);
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
            // btnSetSystem
            // 
            this.btnSetSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnSetSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSystem.ForeColor = System.Drawing.Color.Black;
            this.btnSetSystem.Location = new System.Drawing.Point(622, 283);
            this.btnSetSystem.Name = "btnSetSystem";
            this.btnSetSystem.Size = new System.Drawing.Size(100, 30);
            this.btnSetSystem.TabIndex = 6;
            this.btnSetSystem.Text = "Definir";
            this.btnSetSystem.UseVisualStyleBackColor = false;
            this.btnSetSystem.Click += new System.EventHandler(this.btnSetSystem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(735, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entrada de dados";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(62, 263);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(321, 20);
            this.txtCaminho.TabIndex = 9;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btNeutro
            // 
            this.btNeutro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btNeutro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btNeutro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNeutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNeutro.ForeColor = System.Drawing.Color.White;
            this.btNeutro.Location = new System.Drawing.Point(757, 414);
            this.btNeutro.Name = "btNeutro";
            this.btNeutro.Size = new System.Drawing.Size(150, 50);
            this.btNeutro.TabIndex = 10;
            this.btNeutro.Text = "button1";
            this.btNeutro.UseVisualStyleBackColor = false;
            // 
            // BtnFileProd
            // 
            this.BtnFileProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.BtnFileProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.BtnFileProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFileProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnFileProd.ForeColor = System.Drawing.Color.White;
            this.BtnFileProd.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.BtnFileProd.IconColor = System.Drawing.Color.White;
            this.BtnFileProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFileProd.IconSize = 32;
            this.BtnFileProd.Location = new System.Drawing.Point(15, 85);
            this.BtnFileProd.Name = "BtnFileProd";
            this.BtnFileProd.Size = new System.Drawing.Size(190, 50);
            this.BtnFileProd.TabIndex = 12;
            this.BtnFileProd.Text = "Produtos...";
            this.BtnFileProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFileProd.UseVisualStyleBackColor = false;
            this.BtnFileProd.Click += new System.EventHandler(this.BtnFileProd_Click);
            // 
            // btnValidateFiles
            // 
            this.btnValidateFiles.AccessibleDescription = "Validar planilhas";
            this.btnValidateFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnValidateFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnValidateFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnValidateFiles.ForeColor = System.Drawing.Color.White;
            this.btnValidateFiles.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnValidateFiles.IconColor = System.Drawing.Color.White;
            this.btnValidateFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidateFiles.IconSize = 32;
            this.btnValidateFiles.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidateFiles.Location = new System.Drawing.Point(649, 85);
            this.btnValidateFiles.Name = "btnValidateFiles";
            this.btnValidateFiles.Size = new System.Drawing.Size(50, 50);
            this.btnValidateFiles.TabIndex = 13;
            this.btnValidateFiles.UseVisualStyleBackColor = false;
            this.btnValidateFiles.Click += new System.EventHandler(this.btnValidateFiles_Click);
            // 
            // btnFileClient
            // 
            this.btnFileClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnFileClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnFileClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFileClient.ForeColor = System.Drawing.Color.White;
            this.btnFileClient.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnFileClient.IconColor = System.Drawing.Color.White;
            this.btnFileClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFileClient.IconSize = 32;
            this.btnFileClient.Location = new System.Drawing.Point(225, 85);
            this.btnFileClient.Name = "btnFileClient";
            this.btnFileClient.Size = new System.Drawing.Size(190, 50);
            this.btnFileClient.TabIndex = 14;
            this.btnFileClient.Text = "Clientes...";
            this.btnFileClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileClient.UseVisualStyleBackColor = false;
            this.btnFileClient.Click += new System.EventHandler(this.btnFileClient_Click);
            // 
            // btnFileFornecedor
            // 
            this.btnFileFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnFileFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnFileFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFileFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFileFornecedor.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnFileFornecedor.IconColor = System.Drawing.Color.White;
            this.btnFileFornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFileFornecedor.IconSize = 32;
            this.btnFileFornecedor.Location = new System.Drawing.Point(435, 85);
            this.btnFileFornecedor.Name = "btnFileFornecedor";
            this.btnFileFornecedor.Size = new System.Drawing.Size(190, 50);
            this.btnFileFornecedor.TabIndex = 15;
            this.btnFileFornecedor.Text = "Fornecedores...";
            this.btnFileFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileFornecedor.UseVisualStyleBackColor = false;
            this.btnFileFornecedor.Click += new System.EventHandler(this.btnFileFornecedor_Click);
            // 
            // tmrBorda
            // 
            this.tmrBorda.Interval = 1;
            this.tmrBorda.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileDialogProd
            // 
            this.fileDialogProd.Filter = "Arquivos Excel | *.xls; *.xlsx";
            this.fileDialogProd.Title = "Selecione uma planilha";
            // 
            // pnlBorda
            // 
            this.pnlBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(247)))), ((int)(((byte)(160)))));
            this.pnlBorda.Location = new System.Drawing.Point(15, 140);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(190, 3);
            this.pnlBorda.TabIndex = 16;
            // 
            // btnCancelFiles
            // 
            this.btnCancelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnCancelFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnCancelFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancelFiles.ForeColor = System.Drawing.Color.White;
            this.btnCancelFiles.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancelFiles.IconColor = System.Drawing.Color.White;
            this.btnCancelFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelFiles.IconSize = 32;
            this.btnCancelFiles.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelFiles.Location = new System.Drawing.Point(709, 85);
            this.btnCancelFiles.Name = "btnCancelFiles";
            this.btnCancelFiles.Size = new System.Drawing.Size(50, 50);
            this.btnCancelFiles.TabIndex = 17;
            this.btnCancelFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelFiles.UseVisualStyleBackColor = false;
            this.btnCancelFiles.Click += new System.EventHandler(this.btnCancelFiles_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.btnCancelFiles);
            this.Controls.Add(this.pnlBorda);
            this.Controls.Add(this.btnFileFornecedor);
            this.Controls.Add(this.btnFileClient);
            this.Controls.Add(this.btnValidateFiles);
            this.Controls.Add(this.BtnFileProd);
            this.Controls.Add(this.btNeutro);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetSystem);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
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
        private System.Windows.Forms.Button btnSetSystem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btNeutro;
        private FontAwesome.Sharp.IconButton BtnFileProd;
        private FontAwesome.Sharp.IconButton btnValidateFiles;
        private FontAwesome.Sharp.IconButton btnFileClient;
        private FontAwesome.Sharp.IconButton btnFileFornecedor;
        private System.Windows.Forms.Timer tmrBorda;
        private System.Windows.Forms.OpenFileDialog fileDialogProd;
        private System.Windows.Forms.OpenFileDialog fileDialogClient;
        private System.Windows.Forms.OpenFileDialog fileDialogForn;
        private System.Windows.Forms.Panel pnlBorda;
        private FontAwesome.Sharp.IconButton btnCancelFiles;
    }
}

