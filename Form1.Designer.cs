namespace AVALIAÇÃO_N2_OFICIAL
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.formataçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcadorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbox = new System.Windows.Forms.RichTextBox();
            this.btpage = new System.Windows.Forms.Button();
            this.PageSetup = new System.Windows.Forms.PageSetupDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.esconderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.btnprevia = new System.Windows.Forms.Button();
            this.btimp = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnProcurar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventárioToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.informaçõesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(596, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripSeparator3,
            this.sairToolStripMenuItem});
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.novoToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_novo_26;
            this.novoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.NovoClick);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_abrir_pasta_24;
            this.abrirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirClick);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_salvar_24;
            this.salvarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar ";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_sair_26;
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairClick);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.formataçãoToolStripMenuItem,
            this.selecionarTudoToolStripMenuItem,
            this.dataTempoToolStripMenuItem,
            this.toolStripSeparator4});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_desfazer_26;
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.DesfazerClick);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_refazer_26;
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            this.refazerToolStripMenuItem.Click += new System.EventHandler(this.RefazerClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_copiar_26;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarClick);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_colar_26;
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.ColarClick);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_cortar_24;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.CortarClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // formataçãoToolStripMenuItem
            // 
            this.formataçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.coloraçãoToolStripMenuItem,
            this.marcadorDeTextoToolStripMenuItem});
            this.formataçãoToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_limpar_formatação_30;
            this.formataçãoToolStripMenuItem.Name = "formataçãoToolStripMenuItem";
            this.formataçãoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.formataçãoToolStripMenuItem.Text = "Formatação";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.FonteClick);
            // 
            // coloraçãoToolStripMenuItem
            // 
            this.coloraçãoToolStripMenuItem.Name = "coloraçãoToolStripMenuItem";
            this.coloraçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coloraçãoToolStripMenuItem.Text = "Coloração";
            this.coloraçãoToolStripMenuItem.Click += new System.EventHandler(this.Colores);
            // 
            // marcadorDeTextoToolStripMenuItem
            // 
            this.marcadorDeTextoToolStripMenuItem.Name = "marcadorDeTextoToolStripMenuItem";
            this.marcadorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcadorDeTextoToolStripMenuItem.Text = "Marcador de Texto";
            this.marcadorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.marcadorDeTextoToolStripMenuItem_Click);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_selecionar_tudo_26;
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar Tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.AllSelect);
            // 
            // dataTempoToolStripMenuItem
            // 
            this.dataTempoToolStripMenuItem.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_hora_extra_26;
            this.dataTempoToolStripMenuItem.Name = "dataTempoToolStripMenuItem";
            this.dataTempoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.dataTempoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.dataTempoToolStripMenuItem.Text = "Data/Tempo";
            this.dataTempoToolStripMenuItem.Click += new System.EventHandler(this.DataTempo);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informaçõesToolStripMenuItem.Text = "Informações";
            this.informaçõesToolStripMenuItem.Click += new System.EventHandler(this.informaçõesToolStripMenuItem_Click);
            // 
            // txtbox
            // 
            this.txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtbox.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox.Location = new System.Drawing.Point(13, 51);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(571, 517);
            this.txtbox.TabIndex = 1;
            this.txtbox.Text = "";
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // btpage
            // 
            this.btpage.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btpage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpage.Location = new System.Drawing.Point(13, 27);
            this.btpage.Name = "btpage";
            this.btpage.Size = new System.Drawing.Size(75, 23);
            this.btpage.TabIndex = 2;
            this.btpage.Text = "Pagina";
            this.btpage.UseVisualStyleBackColor = true;
            this.btpage.Click += new System.EventHandler(this.PageClick);
            // 
            // PageSetup
            // 
            this.PageSetup.Document = this.PrintDocument;
            // 
            // PrintDocument
            // 
            this.PrintDocument.OriginAtMargins = true;
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PrintDialog
            // 
            this.PrintDialog.Document = this.PrintDocument;
            this.PrintDialog.UseEXDialog = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esconderToolStripMenuItem1,
            this.mostrarToolStripMenuItem1,
            this.fecharToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(123, 70);
            // 
            // esconderToolStripMenuItem1
            // 
            this.esconderToolStripMenuItem1.Name = "esconderToolStripMenuItem1";
            this.esconderToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.esconderToolStripMenuItem1.Text = "Esconder";
            this.esconderToolStripMenuItem1.Click += new System.EventHandler(this.esconderToolStripMenuItem1_Click);
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            this.mostrarToolStripMenuItem1.Click += new System.EventHandler(this.mostrarToolStripMenuItem1_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.PrintDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.MainMenuStrip = this.menuStrip;
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.UseAntiAlias = true;
            this.printPreviewDialog.Visible = false;
            this.printPreviewDialog.Load += new System.EventHandler(this.printPreviewDialog_Load);
            // 
            // btnprevia
            // 
            this.btnprevia.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevia.Location = new System.Drawing.Point(94, 27);
            this.btnprevia.Name = "btnprevia";
            this.btnprevia.Size = new System.Drawing.Size(75, 23);
            this.btnprevia.TabIndex = 8;
            this.btnprevia.Text = "Previa";
            this.btnprevia.UseVisualStyleBackColor = true;
            this.btnprevia.Click += new System.EventHandler(this.btnprevia_Click);
            // 
            // btimp
            // 
            this.btimp.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btimp.Location = new System.Drawing.Point(175, 27);
            this.btimp.Name = "btimp";
            this.btimp.Size = new System.Drawing.Size(75, 23);
            this.btimp.TabIndex = 3;
            this.btimp.Text = "Imprimir";
            this.btimp.UseVisualStyleBackColor = true;
            this.btimp.Click += new System.EventHandler(this.btimp_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusdata});
            this.StatusStrip.Location = new System.Drawing.Point(0, 571);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(596, 22);
            this.StatusStrip.TabIndex = 9;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // statusdata
            // 
            this.statusdata.Image = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.icons8_hora_extra_26;
            this.statusdata.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.statusdata.Name = "statusdata";
            this.statusdata.Size = new System.Drawing.Size(88, 17);
            this.statusdata.Text = "Data e Hora:";
            this.statusdata.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(403, 27);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 10;
            this.btnProcurar.Text = "Procurar:";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(322, 27);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::AVALIAÇÃO_N2_OFICIAL.Properties.Resources.s17Qi;
            this.ClientSize = new System.Drawing.Size(596, 593);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.btnprevia);
            this.Controls.Add(this.btimp);
            this.Controls.Add(this.btpage);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formataçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTempoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.Button btpage;
        private System.Windows.Forms.PageSetupDialog PageSetup;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.Button btimp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem esconderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button btnprevia;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusdata;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem marcadorDeTextoToolStripMenuItem;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnLimpar;
    }
}

