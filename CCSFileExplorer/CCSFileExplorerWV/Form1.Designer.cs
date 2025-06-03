using CCSFileExplorer.Properties;

namespace CCSFileExplorerWV
{
	// Token: 0x02000014 RID: 20
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007B RID: 123 RVA: 0x0000627B File Offset: 0x0000447B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000629C File Offset: 0x0000449C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pb1 = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hb1 = new Be.Windows.Forms.HexBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCCSFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCCSFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.unpackBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repackBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInImageImporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToObjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractParentNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAllModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAllTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hackGUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRotationOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.línguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(242, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb1,
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 643);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pb1
            // 
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(300, 16);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(745, 619);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(745, 619);
            this.splitContainer2.SplitterDistance = 324;
            this.splitContainer2.TabIndex = 3;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CCSFileExplorer.Properties.Resources.bannerc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 619);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(745, 619);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(96, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hb1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(88, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hb1
            // 
            this.hb1.BackColorDisabled = System.Drawing.Color.Black;
            this.hb1.BoldFont = null;
            this.hb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hb1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb1.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hb1.LineInfoVisible = true;
            this.hb1.Location = new System.Drawing.Point(3, 3);
            this.hb1.Name = "hb1";
            this.hb1.ReadOnly = true;
            this.hb1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hb1.Size = new System.Drawing.Size(82, 68);
            this.hb1.StringViewVisible = true;
            this.hb1.TabIndex = 0;
            this.hb1.UseFixedBytesPerLine = true;
            this.hb1.VScrollBarVisible = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pic1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(88, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Textura";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pic1
            // 
            this.pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1.Location = new System.Drawing.Point(3, 24);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(82, 47);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pic2);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(88, 74);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ver Modelo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pic2
            // 
            this.pic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic2.Location = new System.Drawing.Point(3, 24);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(82, 47);
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseMove);
            this.pic2.Resize += new System.EventHandler(this.pic2_Resize);
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(88, 74);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver Puppet";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(88, 74);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.ZoomFactor = 2F;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCCSFileToolStripMenuItem,
            this.saveCCSFileToolStripMenuItem,
            this.fecharToolStripMenuItem,
            this.toolStripMenuItem1,
            this.unpackBINToolStripMenuItem,
            this.repackBINToolStripMenuItem,
            this.toolStripMenuItem3,
            this.recentToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Arquivo";
            // 
            // openCCSFileToolStripMenuItem
            // 
            this.openCCSFileToolStripMenuItem.Name = "openCCSFileToolStripMenuItem";
            this.openCCSFileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openCCSFileToolStripMenuItem.Text = "Abrir CCSF";
            this.openCCSFileToolStripMenuItem.Click += new System.EventHandler(this.openCCSFileToolStripMenuItem_Click);
            // 
            // saveCCSFileToolStripMenuItem
            // 
            this.saveCCSFileToolStripMenuItem.Name = "saveCCSFileToolStripMenuItem";
            this.saveCCSFileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveCCSFileToolStripMenuItem.Text = "Salvar CCSF";
            this.saveCCSFileToolStripMenuItem.Click += new System.EventHandler(this.saveCCSFileToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // unpackBINToolStripMenuItem
            // 
            this.unpackBINToolStripMenuItem.Name = "unpackBINToolStripMenuItem";
            this.unpackBINToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.unpackBINToolStripMenuItem.Text = "Descompactar BIN";
            this.unpackBINToolStripMenuItem.Click += new System.EventHandler(this.unpackBINToolStripMenuItem_Click);
            // 
            // repackBINToolStripMenuItem
            // 
            this.repackBINToolStripMenuItem.Name = "repackBINToolStripMenuItem";
            this.repackBINToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.repackBINToolStripMenuItem.Text = "Recompactar BIN";
            this.repackBINToolStripMenuItem.Click += new System.EventHandler(this.repackBINToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(169, 6);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Enabled = false;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.recentToolStripMenuItem.Text = "Recente";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // selectedBlobToolStripMenuItem
            // 
            this.selectedBlobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportRawToolStripMenuItem,
            this.importRawToolStripMenuItem,
            toolStripMenuItem2,
            this.exportAsBitmapToolStripMenuItem,
            this.openInImageImporterToolStripMenuItem,
            this.exportToObjToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportarArquivoToolStripMenuItem,
            this.importarArquivoToolStripMenuItem});
            this.selectedBlobToolStripMenuItem.Name = "selectedBlobToolStripMenuItem";
            this.selectedBlobToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.selectedBlobToolStripMenuItem.Text = "Ação";
            // 
            // exportRawToolStripMenuItem
            // 
            this.exportRawToolStripMenuItem.Name = "exportRawToolStripMenuItem";
            this.exportRawToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exportRawToolStripMenuItem.Text = "Exportar DADOS";
            this.exportRawToolStripMenuItem.Click += new System.EventHandler(this.exportRawToolStripMenuItem_Click);
            // 
            // importRawToolStripMenuItem
            // 
            this.importRawToolStripMenuItem.Name = "importRawToolStripMenuItem";
            this.importRawToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.importRawToolStripMenuItem.Text = "Importar DADOS";
            this.importRawToolStripMenuItem.Click += new System.EventHandler(this.importRawToolStripMenuItem_Click);
            // 
            // exportAsBitmapToolStripMenuItem
            // 
            this.exportAsBitmapToolStripMenuItem.Name = "exportAsBitmapToolStripMenuItem";
            this.exportAsBitmapToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exportAsBitmapToolStripMenuItem.Text = "Exportar Textura";
            this.exportAsBitmapToolStripMenuItem.Click += new System.EventHandler(this.exportAsBitmapToolStripMenuItem_Click);
            // 
            // openInImageImporterToolStripMenuItem
            // 
            this.openInImageImporterToolStripMenuItem.Name = "openInImageImporterToolStripMenuItem";
            this.openInImageImporterToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.openInImageImporterToolStripMenuItem.Text = "Abrir no Importador";
            this.openInImageImporterToolStripMenuItem.Click += new System.EventHandler(this.openInImageImporterToolStripMenuItem_Click);
            // 
            // exportToObjToolStripMenuItem
            // 
            this.exportToObjToolStripMenuItem.Name = "exportToObjToolStripMenuItem";
            this.exportToObjToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exportToObjToolStripMenuItem.Text = "Exportar para obj...";
            this.exportToObjToolStripMenuItem.Click += new System.EventHandler(this.exportToObjToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // exportarArquivoToolStripMenuItem
            // 
            this.exportarArquivoToolStripMenuItem.Name = "exportarArquivoToolStripMenuItem";
            this.exportarArquivoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exportarArquivoToolStripMenuItem.Text = "Exportar Arquivo (Experimental)";
            this.exportarArquivoToolStripMenuItem.Click += new System.EventHandler(this.exportarArquivoToolStripMenuItem_Click);
            // 
            // importarArquivoToolStripMenuItem
            // 
            this.importarArquivoToolStripMenuItem.Name = "importarArquivoToolStripMenuItem";
            this.importarArquivoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.importarArquivoToolStripMenuItem.Text = "Importar Arquivo (Experimental)";
            this.importarArquivoToolStripMenuItem.Click += new System.EventHandler(this.importarArquivoToolStripMenuItem_Click);
            // 
            // extractParentNodeToolStripMenuItem
            // 
            this.extractParentNodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractAllModelsToolStripMenuItem,
            this.extractAllTexturesToolStripMenuItem});
            this.extractParentNodeToolStripMenuItem.Name = "extractParentNodeToolStripMenuItem";
            this.extractParentNodeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.extractParentNodeToolStripMenuItem.Text = "Extrair";
            // 
            // extractAllModelsToolStripMenuItem
            // 
            this.extractAllModelsToolStripMenuItem.Name = "extractAllModelsToolStripMenuItem";
            this.extractAllModelsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.extractAllModelsToolStripMenuItem.Text = "Extrair Modelos";
            this.extractAllModelsToolStripMenuItem.Click += new System.EventHandler(this.extractAllModelsToolStripMenuItem_Click);
            // 
            // extractAllTexturesToolStripMenuItem
            // 
            this.extractAllTexturesToolStripMenuItem.Name = "extractAllTexturesToolStripMenuItem";
            this.extractAllTexturesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.extractAllTexturesToolStripMenuItem.Text = "Extrair Texturas";
            this.extractAllTexturesToolStripMenuItem.Click += new System.EventHandler(this.extractAllTexturesToolStripMenuItem_Click);
            // 
            // fileFormatToolStripMenuItem
            // 
            this.fileFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hackGUToolStripMenuItem});
            this.fileFormatToolStripMenuItem.Name = "fileFormatToolStripMenuItem";
            this.fileFormatToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fileFormatToolStripMenuItem.Text = "Formato";
            // 
            // hackGUToolStripMenuItem
            // 
            this.hackGUToolStripMenuItem.Checked = true;
            this.hackGUToolStripMenuItem.CheckOnClick = true;
            this.hackGUToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hackGUToolStripMenuItem.Name = "hackGUToolStripMenuItem";
            this.hackGUToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.hackGUToolStripMenuItem.Text = "Naruto";
            this.hackGUToolStripMenuItem.Click += new System.EventHandler(this.hackGUToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoRotationOnToolStripMenuItem,
            this.wireframeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.viewToolStripMenuItem.Text = "Ver";
            // 
            // autoRotationOnToolStripMenuItem
            // 
            this.autoRotationOnToolStripMenuItem.Checked = true;
            this.autoRotationOnToolStripMenuItem.CheckOnClick = true;
            this.autoRotationOnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRotationOnToolStripMenuItem.Name = "autoRotationOnToolStripMenuItem";
            this.autoRotationOnToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.autoRotationOnToolStripMenuItem.Text = "Auto Rotacionar";
            this.autoRotationOnToolStripMenuItem.Click += new System.EventHandler(this.autoRotationOnToolStripMenuItem_Click);
            // 
            // wireframeToolStripMenuItem
            // 
            this.wireframeToolStripMenuItem.CheckOnClick = true;
            this.wireframeToolStripMenuItem.Name = "wireframeToolStripMenuItem";
            this.wireframeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wireframeToolStripMenuItem.Text = "Wireframe";
            this.wireframeToolStripMenuItem.Click += new System.EventHandler(this.wireframeToolStripMenuItem_Click);
            // 
            // línguaToolStripMenuItem
            // 
            this.línguaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inglêsToolStripMenuItem,
            this.portuguêsToolStripMenuItem});
            this.línguaToolStripMenuItem.Name = "línguaToolStripMenuItem";
            this.línguaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.línguaToolStripMenuItem.Text = "Língua";
            // 
            // inglêsToolStripMenuItem
            // 
            this.inglêsToolStripMenuItem.Name = "inglêsToolStripMenuItem";
            this.inglêsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.inglêsToolStripMenuItem.Text = "Inglês";
            this.inglêsToolStripMenuItem.Click += new System.EventHandler(this.inglêsToolStripMenuItem_Click);
            // 
            // portuguêsToolStripMenuItem
            // 
            this.portuguêsToolStripMenuItem.Checked = true;
            this.portuguêsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.portuguêsToolStripMenuItem.Name = "portuguêsToolStripMenuItem";
            this.portuguêsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.portuguêsToolStripMenuItem.Text = "Português";
            this.portuguêsToolStripMenuItem.Click += new System.EventHandler(this.portuguêsToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.selectedBlobToolStripMenuItem,
            this.extractParentNodeToolStripMenuItem,
            this.fileFormatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.línguaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 665);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CCSFile Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000045 RID: 69
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripProgressBar pb1;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.FolderBrowserDialog fbd;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCCSFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCCSFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unpackBINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repackBINToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedBlobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importRawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInImageImporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToObjToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractParentNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractAllModelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractAllTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hackGUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRotationOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem línguaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem inglêsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem portuguêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Be.Windows.Forms.HexBox hb1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
