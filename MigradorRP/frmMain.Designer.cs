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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTabForn = new System.Windows.Forms.Label();
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
            this.lblTabProd = new System.Windows.Forms.Label();
            this.lblTabClient = new System.Windows.Forms.Label();
            this.pnlDadosImp = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnSetSystem = new FontAwesome.Sharp.IconButton();
            this.dtGridProdutos = new System.Windows.Forms.DataGridView();
            this.pnlDadosImp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopBar.ForeColor = System.Drawing.Color.White;
            this.lblTopBar.Location = new System.Drawing.Point(0, 0);
            this.lblTopBar.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTopBar.Size = new System.Drawing.Size(915, 30);
            this.lblTopBar.TabIndex = 0;
            this.lblTopBar.Text = "SISTEMA";
            this.lblTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTopBar_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(945, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 30);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblTabForn
            // 
            this.lblTabForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTabForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTabForn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabForn.ForeColor = System.Drawing.Color.White;
            this.lblTabForn.Location = new System.Drawing.Point(340, 10);
            this.lblTabForn.Name = "lblTabForn";
            this.lblTabForn.Size = new System.Drawing.Size(150, 30);
            this.lblTabForn.TabIndex = 8;
            this.lblTabForn.Text = "Fornecedores";
            this.lblTabForn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTabForn.Click += new System.EventHandler(this.lblTabForn_Click);
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
            this.btNeutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNeutro.ForeColor = System.Drawing.Color.White;
            this.btNeutro.Location = new System.Drawing.Point(440, 12);
            this.btNeutro.Name = "btNeutro";
            this.btNeutro.Size = new System.Drawing.Size(150, 40);
            this.btNeutro.TabIndex = 10;
            this.btNeutro.Text = "button1";
            this.btNeutro.UseVisualStyleBackColor = false;
            this.btNeutro.Click += new System.EventHandler(this.btNeutro_Click);
            // 
            // BtnFileProd
            // 
            this.BtnFileProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.BtnFileProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.BtnFileProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFileProd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFileProd.ForeColor = System.Drawing.Color.White;
            this.BtnFileProd.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.BtnFileProd.IconColor = System.Drawing.Color.White;
            this.BtnFileProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFileProd.IconSize = 20;
            this.BtnFileProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFileProd.Location = new System.Drawing.Point(15, 50);
            this.BtnFileProd.Name = "BtnFileProd";
            this.BtnFileProd.Size = new System.Drawing.Size(180, 40);
            this.BtnFileProd.TabIndex = 12;
            this.BtnFileProd.Text = "Produtos";
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
            this.btnValidateFiles.IconSize = 20;
            this.btnValidateFiles.Location = new System.Drawing.Point(570, 50);
            this.btnValidateFiles.Name = "btnValidateFiles";
            this.btnValidateFiles.Size = new System.Drawing.Size(40, 40);
            this.btnValidateFiles.TabIndex = 13;
            this.btnValidateFiles.UseVisualStyleBackColor = false;
            this.btnValidateFiles.Click += new System.EventHandler(this.btnValidateFiles_Click);
            // 
            // btnFileClient
            // 
            this.btnFileClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnFileClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnFileClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileClient.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileClient.ForeColor = System.Drawing.Color.White;
            this.btnFileClient.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnFileClient.IconColor = System.Drawing.Color.White;
            this.btnFileClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFileClient.IconSize = 20;
            this.btnFileClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileClient.Location = new System.Drawing.Point(200, 50);
            this.btnFileClient.Name = "btnFileClient";
            this.btnFileClient.Size = new System.Drawing.Size(180, 40);
            this.btnFileClient.TabIndex = 14;
            this.btnFileClient.Text = "Clientes";
            this.btnFileClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileClient.UseVisualStyleBackColor = false;
            this.btnFileClient.Click += new System.EventHandler(this.btnFileClient_Click);
            // 
            // btnFileFornecedor
            // 
            this.btnFileFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnFileFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnFileFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileFornecedor.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFileFornecedor.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnFileFornecedor.IconColor = System.Drawing.Color.White;
            this.btnFileFornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFileFornecedor.IconSize = 20;
            this.btnFileFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileFornecedor.Location = new System.Drawing.Point(385, 50);
            this.btnFileFornecedor.Name = "btnFileFornecedor";
            this.btnFileFornecedor.Size = new System.Drawing.Size(180, 40);
            this.btnFileFornecedor.TabIndex = 15;
            this.btnFileFornecedor.Text = "Fornecedores";
            this.btnFileFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileFornecedor.UseVisualStyleBackColor = false;
            this.btnFileFornecedor.Click += new System.EventHandler(this.btnFileFornecedor_Click);
            // 
            // tmrBorda
            // 
            this.tmrBorda.Interval = 1;
            // 
            // fileDialogProd
            // 
            this.fileDialogProd.Filter = "Arquivos Excel | *.xls; *.xlsx";
            this.fileDialogProd.Title = "Selecione uma planilha";
            // 
            // pnlBorda
            // 
            this.pnlBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(247)))), ((int)(((byte)(160)))));
            this.pnlBorda.Location = new System.Drawing.Point(10, 41);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(150, 3);
            this.pnlBorda.TabIndex = 16;
            // 
            // btnCancelFiles
            // 
            this.btnCancelFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnCancelFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
            this.btnCancelFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancelFiles.ForeColor = System.Drawing.Color.White;
            this.btnCancelFiles.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancelFiles.IconColor = System.Drawing.Color.White;
            this.btnCancelFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelFiles.IconSize = 20;
            this.btnCancelFiles.Location = new System.Drawing.Point(616, 50);
            this.btnCancelFiles.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelFiles.Name = "btnCancelFiles";
            this.btnCancelFiles.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.btnCancelFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelFiles.Size = new System.Drawing.Size(40, 40);
            this.btnCancelFiles.TabIndex = 17;
            this.btnCancelFiles.UseVisualStyleBackColor = false;
            this.btnCancelFiles.Click += new System.EventHandler(this.btnCancelFiles_Click);
            // 
            // lblTabProd
            // 
            this.lblTabProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTabProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTabProd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabProd.ForeColor = System.Drawing.Color.White;
            this.lblTabProd.Location = new System.Drawing.Point(10, 9);
            this.lblTabProd.Name = "lblTabProd";
            this.lblTabProd.Size = new System.Drawing.Size(150, 30);
            this.lblTabProd.TabIndex = 18;
            this.lblTabProd.Text = "Produtos";
            this.lblTabProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTabProd.Click += new System.EventHandler(this.lblTabProd_Click);
            // 
            // lblTabClient
            // 
            this.lblTabClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTabClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTabClient.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabClient.ForeColor = System.Drawing.Color.White;
            this.lblTabClient.Location = new System.Drawing.Point(175, 10);
            this.lblTabClient.Name = "lblTabClient";
            this.lblTabClient.Size = new System.Drawing.Size(150, 30);
            this.lblTabClient.TabIndex = 19;
            this.lblTabClient.Text = "Clientes";
            this.lblTabClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTabClient.Click += new System.EventHandler(this.lblTabClient_Click);
            // 
            // pnlDadosImp
            // 
            this.pnlDadosImp.Controls.Add(this.dtGridProdutos);
            this.pnlDadosImp.Controls.Add(this.lblTabProd);
            this.pnlDadosImp.Controls.Add(this.lblTabClient);
            this.pnlDadosImp.Controls.Add(this.lblTabForn);
            this.pnlDadosImp.Controls.Add(this.pnlBorda);
            this.pnlDadosImp.Location = new System.Drawing.Point(0, 102);
            this.pnlDadosImp.Name = "pnlDadosImp";
            this.pnlDadosImp.Size = new System.Drawing.Size(975, 593);
            this.pnlDadosImp.TabIndex = 20;
            this.pnlDadosImp.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDadosImp_Paint);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 20;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMin.Location = new System.Drawing.Point(914, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 21;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.lblMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // btnSetSystem
            // 
            this.btnSetSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSystem.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSetSystem.IconColor = System.Drawing.Color.Black;
            this.btnSetSystem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetSystem.IconSize = 28;
            this.btnSetSystem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetSystem.Location = new System.Drawing.Point(935, 50);
            this.btnSetSystem.Name = "btnSetSystem";
            this.btnSetSystem.Size = new System.Drawing.Size(40, 40);
            this.btnSetSystem.TabIndex = 22;
            this.btnSetSystem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetSystem.UseVisualStyleBackColor = false;
            this.btnSetSystem.Click += new System.EventHandler(this.btnSetSystem_Click);
            // 
            // dtGridProdutos
            // 
            this.dtGridProdutos.AllowUserToAddRows = false;
            this.dtGridProdutos.AllowUserToDeleteRows = false;
            this.dtGridProdutos.AllowUserToResizeRows = false;
            this.dtGridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdutos.Location = new System.Drawing.Point(0, 71);
            this.dtGridProdutos.MultiSelect = false;
            this.dtGridProdutos.Name = "dtGridProdutos";
            this.dtGridProdutos.ReadOnly = true;
            this.dtGridProdutos.Size = new System.Drawing.Size(975, 522);
            this.dtGridProdutos.TabIndex = 20;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(975, 700);
            this.Controls.Add(this.btnSetSystem);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.pnlDadosImp);
            this.Controls.Add(this.btnCancelFiles);
            this.Controls.Add(this.btnFileFornecedor);
            this.Controls.Add(this.btnFileClient);
            this.Controls.Add(this.btnValidateFiles);
            this.Controls.Add(this.BtnFileProd);
            this.Controls.Add(this.btNeutro);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatec Sistemas | MigradorRP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlDadosImp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btNeutro;
        private FontAwesome.Sharp.IconButton BtnFileProd;
        private FontAwesome.Sharp.IconButton btnValidateFiles;
        private FontAwesome.Sharp.IconButton btnFileClient;
        private FontAwesome.Sharp.IconButton btnFileFornecedor;
        private System.Windows.Forms.OpenFileDialog fileDialogProd;
        private System.Windows.Forms.OpenFileDialog fileDialogClient;
        private System.Windows.Forms.OpenFileDialog fileDialogForn;
        private System.Windows.Forms.Panel pnlBorda;
        private System.Windows.Forms.Panel pnlDadosImp;
        private System.Windows.Forms.Label lblTabForn;
        private System.Windows.Forms.Label lblTabProd;
        private System.Windows.Forms.Label lblTabClient;
        private System.Windows.Forms.Timer tmrBorda;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnCancelFiles;
        private FontAwesome.Sharp.IconButton btnSetSystem;
        private System.Windows.Forms.DataGridView dtGridProdutos;
    }
}

