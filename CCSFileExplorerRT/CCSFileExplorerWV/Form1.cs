﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Be.Windows.Forms;
using CCSFileExplorerRT;
using Microsoft.VisualBasic;
using OpenTK.Graphics.OpenGL;
using static System.Net.Mime.MediaTypeNames;

namespace CCSFileExplorerWV
{
	// Token: 0x02000014 RID: 20
	public partial class Form1 : Form
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00004688 File Offset: 0x00002888
		public Form1()
		{
			this.InitializeComponent();
			this.language();
			this.SelectedFileFormat = CCSFile.FileVersionEnum.HACK_GU;
			if (this.tabControl1.TabPages.Contains(this.tabPage2))
			{
				this.tabControl1.TabPages.Remove(this.tabPage2);
			}
            treeView1.MouseClick += treeView1_MouseClick;
            base.SetStyle(ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint, true);
		}
		public int countName = 0;
        public int previousID = 0;
		public int previousIDdif = 0;
		public List<List<int>> skipID = new List<List<int>>();

        // Token: 0x0600005B RID: 91 RVA: 0x000046F4 File Offset: 0x000028F4
        private void unpackBINToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Filter = "*.ccs|*.ccs|*.bin|*.bin";
			if (d.ShowDialog() == DialogResult.OK)
			{
				this.fbd.SelectedPath = this.lastfolder;
				if (this.fbd.ShowDialog() == DialogResult.OK)
				{
					this.lastfolder = this.fbd.SelectedPath + "\\";
					string fileName = d.FileName;
					base.Enabled = false;
					BINHelper.UnpackToFolder(d.FileName, this.lastfolder, this.pb1, this.status);
					base.Enabled = true;
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004788 File Offset: 0x00002988
		private void language()
		{
			if (this.inglêsToolStripMenuItem.Checked)
			{
				this.fileToolStripMenuItem.Text = "Archive";
				this.abrirCCSPACKEDToolStripMenuItem.Text = "Open CCS (PACKED)";
				this.openCCSFileToolStripMenuItem.Text = "Open CCS/TMP (UNPACKED)";
				this.saveCCSFileToolStripMenuItem.Text = "Save";
				this.salvarECompactarEmCCSToolStripMenuItem.Text = "Save Packed to CCS";
				this.fecharToolStripMenuItem.Text = "Close";
				this.unpackBINToolStripMenuItem.Text = "Unpack BIN";
				this.repackBINToolStripMenuItem.Text = "Repack BIN";
				this.recentToolStripMenuItem.Text = "Recently";
				this.sairToolStripMenuItem.Text = "Exit";
				this.selectedBlobToolStripMenuItem.Text = "Accion";
				this.exportRawToolStripMenuItem.Text = "Export Data";
				this.importRawToolStripMenuItem.Text = "Import Data";
				this.exportAsBitmapToolStripMenuItem.Text = "Export Texture";
				this.openInImageImporterToolStripMenuItem.Text = "Open in Importer";
				this.exportToObjToolStripMenuItem.Text = "Export to obj...";
				this.extractParentNodeToolStripMenuItem.Text = "Extract";
				this.extractAllModelsToolStripMenuItem.Text = "Extract Models";
				this.extractAllTexturesToolStripMenuItem.Text = "Extrair Texturas";
				this.fileFormatToolStripMenuItem.Text = "Format";
				this.hackGUToolStripMenuItem.Text = "Naruto";
				this.viewToolStripMenuItem.Text = "Show";
				this.autoRotationOnToolStripMenuItem.Text = "Auto Rotate";
				this.wireframeToolStripMenuItem.Text = "Wireframe";
				this.tabPage1.Text = "Raw View";
				this.tabPage2.Text = "Texture View";
				this.tabPage3.Text = "Model View";
				this.línguaToolStripMenuItem.Text = "Language";
				this.inglêsToolStripMenuItem.Text = "English";
				this.portuguêsToolStripMenuItem.Text = "Portuguese";
				this.Text = "CCSFile Explorer  / Modified by Raiden and zMath3usMSF";
				this.sobreToolStripMenuItem.Text = "About";
                this.exportarArquivoToolStripMenuItem.Text = "Export Archive (Experimental)";
                this.importarArquivoToolStripMenuItem.Text = "Import Archive (Experimental)";
                return;
			}
			if (this.portuguêsToolStripMenuItem.Checked)
			{
				this.fileToolStripMenuItem.Text = "Arquivo";
				this.abrirCCSPACKEDToolStripMenuItem.Text = "Abrir CCS (PACKED)";
				this.openCCSFileToolStripMenuItem.Text = "Abrir CCS/TMP (UNPACKED)";
				this.saveCCSFileToolStripMenuItem.Text = "Salvar";
				this.salvarECompactarEmCCSToolStripMenuItem.Text = "Salvar Packed to CCS";
				this.fecharToolStripMenuItem.Text = "Fechar";
				this.unpackBINToolStripMenuItem.Text = "Descompactar BIN";
				this.repackBINToolStripMenuItem.Text = "Recompactar BIN";
				this.recentToolStripMenuItem.Text = "Recente";
				this.sairToolStripMenuItem.Text = "Sair";
				this.selectedBlobToolStripMenuItem.Text = "Ação";
				this.exportRawToolStripMenuItem.Text = "Exportar Data";
				this.importRawToolStripMenuItem.Text = "Importar Data";
				this.exportAsBitmapToolStripMenuItem.Text = "Exportar Textura";
				this.openInImageImporterToolStripMenuItem.Text = "Abrir no Importador";
				this.exportToObjToolStripMenuItem.Text = "Exportar para obj...";
				this.extractParentNodeToolStripMenuItem.Text = "Extrair";
				this.extractAllModelsToolStripMenuItem.Text = "Extrair Modelos";
				this.extractAllTexturesToolStripMenuItem.Text = "Extrair Texturas";
				this.fileFormatToolStripMenuItem.Text = "Formato";
				this.hackGUToolStripMenuItem.Text = "Naruto";
				this.viewToolStripMenuItem.Text = "Ver";
				this.autoRotationOnToolStripMenuItem.Text = "Auto Rotacionar";
				this.wireframeToolStripMenuItem.Text = "Wireframe";
				this.tabPage1.Text = "Ver Dados";
				this.tabPage2.Text = "Ver Textura";
				this.tabPage3.Text = "Ver Modelo";
				this.línguaToolStripMenuItem.Text = "Língua";
				this.inglêsToolStripMenuItem.Text = "Inglês";
				this.portuguêsToolStripMenuItem.Text = "Português";
				this.Text = "CCSFile Explorer  / Modificado por Raiden e zMath3usMSF";
                this.sobreToolStripMenuItem.Text = "Sobre";
                this.exportarArquivoToolStripMenuItem.Text = "Exportar Arquivo (Experimental)";
                this.importarArquivoToolStripMenuItem.Text = "Importar Arquivo (Experimental)";
            }
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004B8C File Offset: 0x00002D8C
		private void repackBINToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.fbd.SelectedPath = this.lastfolder;
			if (this.fbd.ShowDialog() == DialogResult.OK)
			{
				this.lastfolder = this.fbd.SelectedPath + "\\";
				new List<string>(Directory.GetFiles(this.lastfolder, "*.ccs", SearchOption.TopDirectoryOnly)).Sort();
				SaveFileDialog d = new SaveFileDialog();
				d.Filter = "*.ccs|*.ccs|*.bin|*.bin";
				if (d.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("Salvar no formato Naruto?", "Como salvar", MessageBoxButtons.YesNo);
					base.Enabled = false;
					BINHelper.Repack(d.FileName, this.lastfolder);
					base.Enabled = true;
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004C3C File Offset: 0x00002E3C
		private void openCCSFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Filter = "*.tmp|*.tmp|*.ccs|*.ccs";
			if (d.ShowDialog() == DialogResult.OK)
			{
				lastExtension = Path.GetExtension(d.FileName);
				this.ccsfile = new CCSFile(File.ReadAllBytes(d.FileName), this.SelectedFileFormat);
				this.ccsFileName = d.SafeFileName.Remove(d.SafeFileName.Length - 4, 4);
				this.AddRecent(d.FileName);
				this.RefreshStuff();
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004CB0 File Offset: 0x00002EB0
		private void saveCCSFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Path.GetExtension(this.lastExtension) == ".tmp")
			{
                if (this.ccsfile == null)
                {
                    return;
                }
                if (!this.ccsfile.isvalid)
                {
                    MessageBox.Show("Você está tentando salvar esse arquivo como inválido.");
                    return;
                }
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "*.tmp|*.tmp";
                d.FileName = this.ccsfile.header.Name + ".tmp";
                if (d.ShowDialog() == DialogResult.OK)
                {
                    this.ccsfile.Save(d.FileName);
                    this.RefreshStuff();
                    MessageBox.Show("Feito.");
                }
            }
			else
			{
                if (this.ccsfile == null)
                {
                    return;
                }
                if (!this.ccsfile.isvalid)
                {
                    MessageBox.Show("Você está tentando salvar esse arquivo como inválido.");
                    return;
                }
                string ccsFilePath = Path.Combine(lastfolder, Path.GetFileNameWithoutExtension(this.ccsFileName.ToUpper()) + ".CCS");

                this.ccsfile.Rebuild();
                new FileInfo(ccsFilePath);
                BINHelper.Repackccs(ccsFilePath, this.ccsfile.raw, this.ccsfile.header.Name);
                this.RefreshStuff();
                MessageBox.Show("Feito.");
            }
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004D3C File Offset: 0x00002F3C
		private void exportAsBitmapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode sel = this.treeView1.SelectedNode;
			if (this.ccsfile == null || !this.ccsfile.isvalid || sel == null || this.pic1 == null)
			{
				return;
			}
			SaveFileDialog d = new SaveFileDialog();
			d.Filter = "*.png|*.png|*.bmp|*.bmp|*.jpg|*.jpg";
			d.FileName = Path.GetFileNameWithoutExtension(sel.Text);
			if (d.ShowDialog() == DialogResult.OK)
			{
				string text = Path.GetExtension(d.FileName).ToLower();
				if (text != null)
				{
					if (!(text == ".png"))
					{
						if (!(text == ".jpg"))
						{
							if (!(text == ".bmp"))
							{
								goto IL_F2;
							}
							this.pic1.Image.Save(d.FileName, ImageFormat.Bmp);
						}
						else
						{
							this.pic1.Image.Save(d.FileName, ImageFormat.Jpeg);
						}
					}
					else
					{
						this.pic1.Image.Save(d.FileName, ImageFormat.Png);
					}
					MessageBox.Show("Feito.");
					return;
				}
				IL_F2:
				MessageBox.Show("Unknown Format Extension!");
				return;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004E54 File Offset: 0x00003054
		private void exportRawToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode sel = this.treeView1.SelectedNode;
			if (this.ccsfile == null || !this.ccsfile.isvalid || sel == null)
			{
				return;
			}
			if (sel.Level == 3)
			{
				TreeNode obj = sel.Parent;
				TreeNode file = obj.Parent;
				ObjectEntry entryo = this.ccsfile.files[file.Index].objects[obj.Index];
				SaveFileDialog d = new SaveFileDialog();
				d.Filter = "*.bin|*.bin";
				d.FileName = entryo.name + ".bin";
				if (d.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllBytes(d.FileName, entryo.blocks[sel.Index].Data);
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004F20 File Offset: 0x00003120
		private void RefreshStuff()
		{
			this.rtb1.Text = this.ccsfile.Info();
			this.treeView1.Nodes.Clear();
			if (!this.ccsfile.isvalid)
			{
				return;
			}
			TreeNode t = new TreeNode(this.ccsfile.header.Name);
			foreach (FileEntry entry in this.ccsfile.files)
			{
				t.Nodes.Add(entry.ToNode());
			}
			t.Expand();
			this.treeView1.Nodes.Add(t);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004FE8 File Offset: 0x000031E8
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.tabControl1.TabPages.Contains(this.tabPage2))
			{
				this.tabControl1.TabPages.Remove(this.tabPage2);
			}
			if (this.tabControl1.TabPages.Contains(this.tabPage3))
			{
				this.tabControl1.TabPages.Remove(this.tabPage3);
			}
			this.hb1.ByteProvider = new DynamicByteProvider(new byte[0]);
			this.timer1.Enabled = false;
			this.pic1.Image = null;
			this.pic2.Image = null;
			if (this.ccsfile == null || !this.ccsfile.isvalid)
			{
				return;
			}
			TreeNode sel = e.Node;
			if (sel.Level == 3)
			{
				TreeNode obj = sel.Parent;
				TreeNode file = obj.Parent;
				ObjectEntry entryo = this.ccsfile.files[file.Index].objects[obj.Index];
				this.hb1.ByteProvider = new DynamicByteProvider(entryo.blocks[sel.Index].FullBlockData);
				if (entryo.blocks[sel.Index].BlockID == 3435923456U)
				{
					this.currModel = (Block0800)entryo.blocks[sel.Index];
					this.currModel.ProcessData();
					if (!SceneHelper.init)
					{
						SceneHelper.InitializeDevice(this.pic2);
					}
					this.comboBox2.Items.Clear();
					for (int i = 0; i < this.currModel.models.Count; i++)
					{
						this.comboBox2.Items.Add("Model " + (i + 1).ToString());
					}
					if (this.comboBox2.Items.Count > 0)
					{
						this.comboBox2.SelectedIndex = 0;
					}
					this.timer1.Enabled = true;
					this.tabControl1.TabPages.Add(this.tabPage3);
					this.tabControl1.SelectedTab = this.tabPage3;
				}
			}
			if (sel.Level == 1)
			{
				string ext = Path.GetExtension(sel.Text).ToLower();
				if (ext != null && ext == ".bmp")
				{
					this.comboBox1.Items.Clear();
					this.currPalettes = new List<Block>();
					this.currTexture = null;
					foreach (ObjectEntry obj2 in this.ccsfile.files[sel.Index].objects)
					{
						foreach (Block b in obj2.blocks)
						{
							if (b.BlockID == 3435922432U)
							{
								this.comboBox1.Items.Add(obj2.name);
								this.currPalettes.Add(b);
							}
							if (b.BlockID == 3435922176U)
							{
								this.currTexture = b;
							}
						}
					}
					if (this.comboBox1.Items.Count > 0)
					{
						this.tabControl1.TabPages.Add(this.tabPage2);
						this.comboBox1.SelectedIndex = 0;
						this.tabControl1.SelectedTab = this.tabPage2;
					}
				}
			}
			this.treeView1.Focus();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000053A0 File Offset: 0x000035A0
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = this.comboBox1.SelectedIndex;
			if (i == -1 || this.currTexture == null || this.currPalettes == null || this.currPalettes.Count == 0)
			{
				return;
			}
			this.pic1.Image = CCSFile.CreateImage(this.currPalettes[i].Data, this.currTexture.Data);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005408 File Offset: 0x00003608
		private void importRawToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode sel = this.treeView1.SelectedNode;
			if (this.ccsfile == null || !this.ccsfile.isvalid || sel == null)
			{
				return;
			}
			if (sel.Level == 3)
			{
				TreeNode obj = sel.Parent;
				TreeNode file = obj.Parent;
				ObjectEntry entryo = this.ccsfile.files[file.Index].objects[obj.Index];
				OpenFileDialog d = new OpenFileDialog();
				d.Filter = "*.bin|*.bin";
				if (d.ShowDialog() == DialogResult.OK)
				{
					entryo.blocks[sel.Index].Data = File.ReadAllBytes(d.FileName);
					this.ccsfile.Rebuild();
					this.ccsfile.Reload();
					this.RefreshStuff();
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000054D8 File Offset: 0x000036D8
		private void openInImageImporterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ccsfile == null || !this.ccsfile.isvalid || this.treeView1.SelectedNode == null)
			{
				return;
			}
			TreeNode sel = this.treeView1.SelectedNode;
			if (sel.Level == 1)
			{
				if (Path.GetExtension(sel.Text).ToLower() != ".bmp")
				{
					MessageBox.Show("Not a bmp file!");
					return;
				}
				ImageImporter f = new ImageImporter(this);
				f.index = sel.Index;
				f.ccsfile = this.ccsfile;
				f.selectedClut = comboBox1.SelectedIndex;
				f.countClut = comboBox1.Items.Count;
				f.ShowDialog();
				if (f.exitok)
				{
					this.ccsfile = f.ccsfile;
					f.Close();
					this.RefreshStuff();
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005588 File Offset: 0x00003788
		private void exportToObjToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ccsfile == null || !this.ccsfile.isvalid || this.treeView1.SelectedNode == null)
			{
				return;
			}
			TreeNode sel = this.treeView1.SelectedNode;
			if (sel.Level == 3)
			{
				TreeNode obj = sel.Parent;
				TreeNode file = obj.Parent;
				ObjectEntry entryo = this.ccsfile.files[file.Index].objects[obj.Index];
				this.hb1.ByteProvider = new DynamicByteProvider(entryo.blocks[sel.Index].FullBlockData);
				if (entryo.blocks[sel.Index].BlockID == 3435923456U)
				{
					Block0800 mdl = (Block0800)entryo.blocks[sel.Index];
					mdl.ProcessData();
					SaveFileDialog d = new SaveFileDialog();
					d.Filter = "*.obj|*.obj";
					d.FileName = obj.Text + ".obj";
					if (d.ShowDialog() == DialogResult.OK)
					{
						string input = Interaction.InputBox("Which Model to export? (1 - " + mdl.models.Count.ToString() + "). Input 0 to export all.", "Export Model", (this.comboBox2.SelectedIndex + 1).ToString(), -1, -1);
						if (input != "")
						{
							mdl.SaveModel(Convert.ToInt32(input) - 1, d.FileName);
							MessageBox.Show("Feito.");
							return;
						}
					}
				}
			}
			else
			{
				int level = sel.Level;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005723 File Offset: 0x00003923
		private void timer1_Tick(object sender, EventArgs e)
		{
			SceneHelper.Render();
			if (SceneHelper.doRotate)
			{
				this.viewRotation += 1f;
				SceneHelper.SetRotation360(this.viewRotation);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005750 File Offset: 0x00003950
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = this.comboBox2.SelectedIndex;
			if (i == -1 || this.currModel == null || !SceneHelper.init)
			{
				return;
			}
			this.currModel.CopyToScene(i);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000578C File Offset: 0x0000398C
		private void pic2_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				SceneHelper.SetHeight((float)e.Y / (float)this.pic2.Height - 0.5f);
				SceneHelper.doRotate = false;
				this.autoRotationOnToolStripMenuItem.Checked = false;
				SceneHelper.SetRotation360((float)e.X / (float)this.pic2.Width * 360f);
			}
			if (e.Button == MouseButtons.Right)
			{
				SceneHelper.SetZoomFactor(((float)e.Y / (float)this.pic2.Height + 0.001f) * 3f);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005828 File Offset: 0x00003A28
		private void pic2_Resize(object sender, EventArgs e)
		{
			SceneHelper.Resize();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000582F File Offset: 0x00003A2F
		private void autoRotationOnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SceneHelper.doRotate = this.autoRotationOnToolStripMenuItem.Checked;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005841 File Offset: 0x00003A41
		private void Form1_Load(object sender, EventArgs e)
		{
			this.CheckRecent();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000584C File Offset: 0x00003A4C
		public void CheckRecent()
		{
			this.recentToolStripMenuItem.Enabled = false;
			if (this.recentToolStripMenuItem.HasDropDownItems)
			{
				this.recentToolStripMenuItem.DropDownItems.Clear();
			}
			if (File.Exists("recent.txt"))
			{
				foreach (string line in File.ReadAllLines("recent.txt"))
				{
					if (line.Trim() != "")
					{
						ToolStripMenuItem item = new ToolStripMenuItem(line.Trim());
						item.Click += this.recentClick;
						this.recentToolStripMenuItem.DropDownItems.Add(item);
						this.recentToolStripMenuItem.Enabled = true;
					}
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000058F9 File Offset: 0x00003AF9
		public void recentClick(object sender, EventArgs e)
		{
			this.ccsfile = new CCSFile(File.ReadAllBytes(((ToolStripMenuItem)sender).Text), this.SelectedFileFormat);
			this.RefreshStuff();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005924 File Offset: 0x00003B24
		public void AddRecent(string path)
		{
			if (!File.Exists("recent.txt"))
			{
				File.WriteAllLines("recent.txt", new string[0]);
			}
			string[] lines = File.ReadAllLines("recent.txt");
			List<string> result = new List<string>();
			result.Add(path);
			int index = 0;
			while (result.Count < 10 && index < lines.Length && lines[index] != path)
			{
				result.Add(lines[index++]);
			}
			File.WriteAllLines("recent.txt", result.ToArray());
			this.CheckRecent();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000059A7 File Offset: 0x00003BA7
		private void wireframeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SceneHelper.wireframe = this.wireframeToolStripMenuItem.Checked;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000059B9 File Offset: 0x00003BB9
		private void hackGUToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.hackGUToolStripMenuItem.Checked = true;
			this.SelectedFileFormat = CCSFile.FileVersionEnum.HACK_GU;
			if (this.ccsfile != null)
			{
				this.ccsfile.FileVersion = this.SelectedFileFormat;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000059E8 File Offset: 0x00003BE8
		private void extractAllModelsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string gameName = "";
			if (this.hackGUToolStripMenuItem.Checked)
			{
				gameName = "Naruto";
			}
			foreach (object obj in this.treeView1.Nodes)
			{
				foreach (object obj2 in ((TreeNode)obj).Nodes)
				{
					TreeNode fileNode = (TreeNode)obj2;
					if (!fileNode.Text.Contains("anim") && fileNode.Text.Contains(".max"))
					{
						foreach (object obj3 in fileNode.Nodes)
						{
							TreeNode modelFileNode = (TreeNode)obj3;
							if (modelFileNode.Text.Contains("MDL") && modelFileNode.Nodes.Count != 0)
							{
								ObjectEntry entryo = this.ccsfile.files[fileNode.Index].objects[modelFileNode.Index];
								this.hb1.ByteProvider = new DynamicByteProvider(entryo.blocks[modelFileNode.FirstNode.Index].FullBlockData);
								if (entryo.blocks[modelFileNode.FirstNode.Index].BlockID == 3435923456U)
								{
									Directory.CreateDirectory(string.Concat(new string[]
									{
										"./",
										gameName,
										"/Models/",
										this.ccsFileName,
										"/",
										modelFileNode.Text
									}));
									this.currModel = (Block0800)entryo.blocks[modelFileNode.FirstNode.Index];
									this.currModel.ProcessData();
									for (int modelIndex = 1; modelIndex <= this.currModel.models.Count; modelIndex++)
									{
										string filePath = string.Concat(new string[]
										{
											"./",
											gameName,
											"/Models/",
											this.ccsFileName,
											"/",
											modelFileNode.Text,
											"/",
											modelFileNode.Text,
											"-",
											modelIndex.ToString(),
											".obj"
										});
										this.currModel.SaveModel(Convert.ToInt32(modelIndex) - 1, filePath);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005D00 File Offset: 0x00003F00
		private void extractAllTexturesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string gameName = "";
			PictureBox pct_Temp = new PictureBox();
			if (this.hackGUToolStripMenuItem.Checked)
			{
				gameName = "Naruto";
			}
			foreach (object obj in this.treeView1.Nodes)
			{
				foreach (object obj2 in ((TreeNode)obj).Nodes)
				{
					TreeNode fileNode = (TreeNode)obj2;
					if (fileNode.Text.Contains("tex"))
					{
						this.currPalettes = new List<Block>();
						this.currTexture = null;
						foreach (ObjectEntry objectEntry in this.ccsfile.files[fileNode.Index].objects)
						{
							foreach (Block b in objectEntry.blocks)
							{
								if (b.BlockID == 3435922432U)
								{
									this.currPalettes.Add(b);
								}
								if (b.BlockID == 3435922176U)
								{
									this.currTexture = b;
								}
							}
						}
						if (this.currPalettes.Count > 0)
						{
							for (int textureIndex = 0; textureIndex < this.currPalettes.Count; textureIndex++)
							{
								string[] array = fileNode.Text.ToString().Split(new char[]
								{
									'\\'
								});
								string textureName = array[array.Length - 1];
								textureName = textureName.Remove(textureName.Length - 4, 3);
								Directory.CreateDirectory(string.Concat(new string[]
								{
									"./",
									gameName,
									"/Textures/",
									this.ccsFileName,
									"/",
									textureName
								}));
								string filePath = string.Concat(new string[]
								{
									"./",
									gameName,
									"/Textures/",
									this.ccsFileName,
									"/",
									textureName,
									"/",
									textureName,
									"-",
									textureIndex.ToString(),
									".png"
								});
								pct_Temp.Image = CCSFile.CreateImage(this.currPalettes[textureIndex].Data, this.currTexture.Data);
								pct_Temp.Image.Save(filePath, ImageFormat.Png);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00006020 File Offset: 0x00004220
		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006028 File Offset: 0x00004228
		private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ccsfile.Reload();
			this.hb1.Refresh();
			this.treeView1.Nodes.Clear();
			this.rtb1.Clear();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000605C File Offset: 0x0000425C
		private void salvarECompactarEmCCSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ccsfile == null)
			{
				return;
			}
			if (!this.ccsfile.isvalid)
			{
				MessageBox.Show("Você está tentando salvar esse arquivo como inválido.");
				return;
			}
			SaveFileDialog d = new SaveFileDialog();
			d.Filter = "*.ccs|*.ccs";
			d.FileName = (this.ccsfile.header.Name + ".ccs").ToUpper();
			if (d.ShowDialog() == DialogResult.OK)
			{
				FileInfo f = new FileInfo(d.FileName);
				DirectoryInfo directory = f.Directory;
				this.lastfolder = ((directory != null) ? directory.ToString() : null) + "\\";
				this.ccsfile.Rebuild();
				new FileInfo(d.FileName);
				BINHelper.Repackccs(d.FileName, this.ccsfile.raw, this.ccsfile.header.Name);
				this.RefreshStuff();
				MessageBox.Show("Feito.");
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006146 File Offset: 0x00004346
		private void inglêsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.inglêsToolStripMenuItem.Checked = true;
			this.portuguêsToolStripMenuItem.Checked = false;
			this.language();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006166 File Offset: 0x00004366
		private void portuguêsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.portuguêsToolStripMenuItem.Checked = true;
			this.inglêsToolStripMenuItem.Checked = false;
			this.language();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006188 File Offset: 0x00004388
		private void abrirCCSPACKEDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Filter = "*.ccs|*.ccs";
			if (d.ShowDialog() == DialogResult.OK)
			{
				FileInfo f = new FileInfo(d.FileName);
				this.lastfolder = f.Directory.ToString() + "\\";
				/*BINHelper.UnpackToFolder(d.FileName, this.lastfolder, null, null);*/
				string tmpFilePath = Path.Combine(lastfolder, Path.GetFileNameWithoutExtension(d.FileName) + ".tmp");

                this.ccsfile = new CCSFile(BINHelper.UnpackTo(d.FileName, this.lastfolder, null, null), this.SelectedFileFormat);
                this.ccsFileName = d.SafeFileName.Remove(d.SafeFileName.Length - 4, 4);
                this.AddRecent("tmpFilePath");
                this.RefreshStuff();
            }
		}

		// Token: 0x0400003B RID: 59
		public CCSFile ccsfile;

		// Token: 0x0400003C RID: 60
		public CCSFile.FileVersionEnum SelectedFileFormat;

		// Token: 0x0400003D RID: 61
		public string lastfolder;

		public string lastExtension;

		// Token: 0x0400003E RID: 62
		public List<Block> currPalettes;

		// Token: 0x0400003F RID: 63
		public Block currTexture;

		// Token: 0x04000040 RID: 64
		public Block0800 currModel;

		// Token: 0x04000041 RID: 65
		public float viewRotation;

		// Token: 0x04000042 RID: 66
		public string ccsFileName = "";

		// Token: 0x04000043 RID: 67
		public string folder;

		// Token: 0x04000044 RID: 68
		public string infilename;

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.inglêsToolStripMenuItem.Checked)
			{
                MessageBox.Show("CCSFileExplorerRT version 3.0, a fork of CCSFileExplorerWV made by WarrantyVoider.\n\nFork by Bit.Raiden and zMath3usMSF.");
            }
			else
			{
				MessageBox.Show("CCSFileExplorerRT versão 3.0, um fork do CCSFileExplorerWV feito por WarrantyVoider.\n\nFork por Bit.Raiden e zMath3usMSF.");
			}
        }
        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                TreeNode selectedNode = treeView1.GetNodeAt(e.X, e.Y);

                if (selectedNode != null)
                {
                    treeView1.SelectedNode = selectedNode;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Parent == null) // Verifica se é um nó pai
                {
                    int selectedIndex = treeView1.SelectedNode.Index;

                    string selectedNodeText = treeView1.SelectedNode.Text;

                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    ToolStripMenuItem exportMenuItem = new ToolStripMenuItem("Exportar");
                    exportMenuItem.Click += (senderObj, args) =>
                    {
                        /*Exportar(selectedIndex, selectedNodeText);*/
                    };

                    contextMenu.Items.Add(exportMenuItem);

                    contextMenu.Show(treeView1, e.Location);
                }
                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Level == 2) // Verifica se é um nó
                {
                    int selectedFile = treeView1.SelectedNode.Parent.Index;

                    int selectedObject = treeView1.SelectedNode.Index;

                    string selectedNodeText = treeView1.SelectedNode.Text;

                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    ToolStripMenuItem deletMenuItem = new ToolStripMenuItem("Deletar");
                    deletMenuItem.Click += (senderObj, args) =>
                    {
                        Deletar(selectedFile, selectedObject);
                    };

                    contextMenu.Items.Add(deletMenuItem);

                    contextMenu.Show(treeView1, e.Location);
                }
            }
        }
		public void Deletar(int selectedFile, int selectedObject)
		{
            List<int> indicesToRemove = new List<int>();

            for (int i = 0; i < this.ccsfile.blocks.Count; i++)
            {
                if (this.ccsfile.blocks[i].ID == this.ccsfile.files[selectedFile].objects[selectedObject].blocks[0].ID)
                {
                    indicesToRemove.Add(i);
                }
            }

            for (int i = indicesToRemove.Count - 1; i >= 0; i--)
            {
                this.ccsfile.blocks.RemoveAt(indicesToRemove[i]);
            }
            this.ccsfile.files[selectedFile].objects[selectedObject].blocks.Clear();
        }

        private void exportarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int count = treeView1.SelectedNode.Nodes.Count;
			string fileName = treeView1.SelectedNode.Text;
			string[] folders = fileName.Split('\\');
			List<byte> bytes = new List<byte>();
            string init = "";
			string type = "";
			if(folders.Length > 1)
			{
                type = folders[folders.Length - 2];
            }

            switch (type)
			{
				case "tex":
					init = "TEX_";
					bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(0)));
					break;
				case "max":
					init = "MDL_";
					bool def = false;
					for(int i = 0; i < treeView1.SelectedNode.Nodes.Count; i++)
					{
						if(treeView1.SelectedNode.Nodes[i].Text.Contains("trall") == true)
						{
                            bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(3)));
							def = true;
                            break;
						}
					}
					if(def == false)
					{
                        bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(1)));
                    }
                    break;
				case "anm":
					init = "ANM_";
                    bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(2)));
                    break;
                case "anmmax":
					init = "ANM_";
                    bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(2)));
                    break;
                default:
                    bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(255)));
                    break;
			}
			bytes.AddRange(Encoding.GetEncoding("shift-jis").GetBytes(fileName));
			bytes.Add(0x0);
			bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(count)));
			if(type == "tex" && treeView1.SelectedNode.Nodes[0].Text.Contains("TEX_"))
			{
				List<string> strings = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    if(treeView1.SelectedNode.Nodes[i].Text.Contains("TEX_"))
					{
						strings.Add(treeView1.SelectedNode.Nodes[i].Text);
					}
					else
					{
                        strings.Insert(0, treeView1.SelectedNode.Nodes[i].Text);
                    }
                }
                for (int i = 0; i < count; i++)
                {
                    bytes.AddRange(Encoding.GetEncoding("shift-jis").GetBytes(strings[i]));
                    bytes.Add(0x0);
                }
            }
			else
			{
                for (int i = 0; i < count; i++)
                {
                    bytes.AddRange(Encoding.GetEncoding("shift-jis").GetBytes(treeView1.SelectedNode.Nodes[i].Text));
                    bytes.Add(0x0);
                }
            }
            int selectedFile = treeView1.SelectedNode.Index;
			int totalBlocks = 0;
			for (int i = 0; i < ccsfile.files[selectedFile].objects.Count; i++)
			{
				totalBlocks += ccsfile.files[selectedFile].objects[i].blocks.Count;
            }
			bytes.AddRange(BitConverter.GetBytes(Convert.ToUInt32(totalBlocks)));
			if (type == "tex" && ccsfile.files[selectedFile].objects[0].blocks[0].BlockID == 0xCCCC0300)
			{
				List<byte> bytes1 = new List<byte>();
                for (int i = 0; i < ccsfile.files[selectedFile].objects.Count; i++)
                {
                    for (int j = 0; j < ccsfile.files[selectedFile].objects[i].blocks.Count; j++)
                    {
						if(ccsfile.files[selectedFile].objects[i].blocks[j].BlockID == 0xCCCC0300)
						{
                            bytes1.AddRange(ccsfile.files[selectedFile].objects[i].blocks[j].FullBlockData);
                        }
                        else
						{
                            bytes1.InsertRange(0, ccsfile.files[selectedFile].objects[i].blocks[j].FullBlockData);

                        }
                    }
                }
				bytes.AddRange(bytes1.ToArray());
            }
			else
			{
                for (int i = 0; i < ccsfile.files[selectedFile].objects.Count; i++)
                {
                    for (int j = 0; j < ccsfile.files[selectedFile].objects[i].blocks.Count; j++)
                    {
                        bytes.AddRange(ccsfile.files[selectedFile].objects[i].blocks[j].FullBlockData);
                    }
                }
            }
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string lastPart = folders[folders.Length - 1];
			string filePath = "";
            if (folders.Length > 1)
            {
                filePath = Path.Combine(desktop, init + Path.GetFileNameWithoutExtension(lastPart) + ".pak");
            }
			else
			{
                filePath = Path.Combine(desktop, fileName + ".pak");
            }
            File.WriteAllBytes(filePath, bytes.ToArray());
        }

        private void importarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Bloco de Arquivo (*.pak)|*.pak";
			ofd.Multiselect = true;
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				string[] filePath = ofd.FileNames;
				ReadFileBlock(filePath);
			}
        }

		private void ReadFileBlock(string[] filePath)
		{
			for(int i = 0; i < filePath.Length; i++)
			{
                FileStream fileStream = new FileStream(filePath[i], (FileMode)FileAccess.ReadWrite);

                countName = 0;
                int initialCount = ccsfile.blocks.Count;

                byte[] typeBytes = new byte[4];
                fileStream.Read(typeBytes, 0, typeBytes.Length);
                int type = BitConverter.ToInt32(typeBytes, 0);

                string fileName = ReadString(fileStream);

                fileStream.Read(typeBytes, 0, typeBytes.Length);
                int objectsCount = BitConverter.ToInt32(typeBytes, 0);

                List<string> objectsNames = new List<string>();
                for (int j = 0; j < objectsCount; j++)
                {
                    string objectName = ReadString(fileStream);
                    objectsNames.Add(objectName);
                }
                treeView1.Nodes[0].Nodes.Add(fileName);
                TreeNode file = treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1];
                for (int j = 0; j < objectsCount; j++)
                {
                    TreeNode objectt = new TreeNode(objectsNames[j]);
                    file.Nodes.Add(objectt);
                }
                ccsfile.toc.filenames.Add(fileName);
                ccsfile.toc.FileCount++;
                for (int j = 0; j < objectsNames.Count; j++)
                {
                    ccsfile.toc.objnames.Add(objectsNames[j]);
                    ccsfile.toc.indexes.Add((ushort)ccsfile.toc.FileCount);
                }
                fileStream.Read(typeBytes, 0, typeBytes.Length);
                int blocksCount = BitConverter.ToInt32(typeBytes, 0);

                for (int j = 0; j < ccsfile.toc.ObjCount + objectsCount; j++)
                {
                    skipID.Add(new List<int> { 0 });
                }

                List<byte[]> blocks = new List<byte[]>();
                for (int j = 0; j < blocksCount; j++)
                {
                    List<byte> block = new List<byte>();
                    byte[] blockTypeBytes = new byte[4];
                    fileStream.Read(blockTypeBytes, 0, blockTypeBytes.Length);
                    int blockType = BitConverter.ToInt16(blockTypeBytes, 0);
                    block.AddRange(blockTypeBytes);

                    byte[] blockSizeBytes = new byte[4];
                    fileStream.Read(blockSizeBytes, 0, blockSizeBytes.Length);
                    block.AddRange(blockSizeBytes);
                    int blockSize = blockType == 0x0300 ? BitConverter.ToInt32(blockSizeBytes, 0) - 0x32 : BitConverter.ToInt32(blockSizeBytes, 0);

                    if (type == 3 && blockType == 0x0800)
                    {
                        byte[] buffer = new byte[4];
                        for (long k = fileStream.Position; k < fileStream.Length; k++)
                        {
                            fileStream.Read(buffer, 0, buffer.Length);
                            bool isBlockType = Block.issValidBlockType(buffer);
                            if (isBlockType == false)
                            {
                                block.AddRange(buffer);
                            }
                            else
                            {
                                fileStream.Seek(-4, SeekOrigin.Current);
                                break;
                            }
                        }
                    }
                    else
                    {
                        byte[] blockDataBytes = new byte[blockSize * 0x4];
                        fileStream.Read(blockDataBytes, 0, blockDataBytes.Length);
                        block.AddRange(blockDataBytes);
                    }

                    switch (blockType)
                    {
                        case 0x0100:
                            block = FixOBJMDL(block, j, blocksCount, objectsNames);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                        case 0x0200:
                            block = FixMAT(block, j, blocksCount, objectsNames);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                        case 0x0300:
                            block = FixTEX(block, j, blocksCount, objectsNames);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                        case 0x0700:
                            block = FixANM(block, j, blocksCount, objectsNames);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                        case 0x0800:
                            block = FixRigMDL(block, j, blocksCount, objectsNames);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                        case 0x0900:
                            block = FixCMP(block, j, blocksCount, objectsNames);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                        case 0x0A00:
                            block = FixANMBonne(block, j, blocksCount, objectsNames);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                        case 0x2000:
                            block = FixExternal(block, j, blocksCount);
                            break;
                        case 0x2300:
                            block = FixDefault(block, j, blocksCount);
                            break;
                        default:
                            block = FixDefault(block, j, blocksCount);
                            ccsfile.toc.ObjCount++;
                            countName++;
                            break;
                    }
                    blocks.Add(block.ToArray());
                }

                for (int j = 0; j < blocks.Count; j++)
                {
                    List<Block> endBlock = new List<Block>();
                    endBlock.Add(ccsfile.blocks[ccsfile.blocks.Count - 2]);
                    endBlock.Add(ccsfile.blocks[ccsfile.blocks.Count - 1]);
                    ccsfile.blocks.Remove(ccsfile.blocks[ccsfile.blocks.Count - 2]);
                    ccsfile.blocks.Remove(ccsfile.blocks[ccsfile.blocks.Count - 1]);

                    byte[] currentBlock = blocks[j];
                    MemoryStream m = new MemoryStream(currentBlock);
                    m.Seek(0L, SeekOrigin.Begin);
                    while (m.Position < (long)currentBlock.Length)
                    {
                        Block b = Block.ReadBlockFile(m);
                        ccsfile.blocks.Add(b);
                    }
                    ccsfile.blocks.AddRange(endBlock);
                }
                MemoryStream i2 = new MemoryStream();
                foreach (Block block in ccsfile.blocks)
                {
                    block.WriteBlock(i2);
                }
                ccsfile.raw = i2.ToArray();
                this.ccsfile = new CCSFile(ccsfile.raw, this.SelectedFileFormat);
                RefreshStuff();
                fileStream.Dispose();
            }
		}
        private List<byte> FixCMP(List<byte> block, int index, int count, List<string> objNames)
        {
            byte[] currentBlock = block.ToArray();
            MemoryStream memoryStream = new MemoryStream(currentBlock);

			memoryStream.Seek(0x8, SeekOrigin.Begin);
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1), 0, 4);
			byte[] objCountBytes = new byte[4];
			memoryStream.Read(objCountBytes, 0, 4);
			int objCount = BitConverter.ToInt32(objCountBytes, 0);
			int lastOBJID = 0;
			for(int i = 0; i < objCount; i++)
			{
				for(int j = 0; j < ccsfile.toc.objnames.Count; j++)
				{
					string searchOBJ = "OBJ_" + objNames[index].Split('_')[1];
					if (ccsfile.toc.objnames[j] == searchOBJ)
					{
                        lastOBJID = j;
                    }
				}
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(lastOBJID + i + 1)), 0, 4);
            }
            return memoryStream.ToArray().ToList();
        }
		private List<byte> FixOBJMDL(List<byte> block, int index, int count, List<string> objNames)
		{
            byte[] currentBlock = block.ToArray();
            MemoryStream memoryStream = new MemoryStream(currentBlock);
            byte[] oldIndexBytes = new byte[4];
            memoryStream.Seek(0x8, SeekOrigin.Begin);

            memoryStream.Read(oldIndexBytes, 0, 4);
            int oldIndex = BitConverter.ToInt32(oldIndexBytes, 0);
            memoryStream.Seek(-0x4, SeekOrigin.Current);
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1), 0, 4);

            byte[] fixBonneBytes = new byte[4];
            memoryStream.Read(fixBonneBytes, 0, 4);
            int fixBonne = BitConverter.ToInt32(fixBonneBytes, 0);

            if (fixBonne != 0)
            {
                memoryStream.Seek(-0x4, SeekOrigin.Current);
                uint newID = ccsfile.toc.ObjCount + 1;
                int sub = oldIndex - previousID - 1;
                int dif = oldIndex - fixBonne;
                uint newMDLOBJ = newID - (uint)dif;

                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(newMDLOBJ)), 0, 4);
            }
            int lastMDLID = 0;
            for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
            {
                string searchOBJ = "MDL_" + objNames[index].Split('_')[1];
                if (ccsfile.toc.objnames[i] == searchOBJ)
                {
                    lastMDLID = i;
                }
            }
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(lastMDLID) + 1), 0, 4);
            return memoryStream.ToArray().ToList();
        }
        private List<byte> FixRigMDL(List<byte> block, int index, int count, List<string> objNames)
        {
            byte[] currentBlock = block.ToArray();
            MemoryStream memoryStream = new MemoryStream(currentBlock);

            memoryStream.Seek(0x8, SeekOrigin.Begin);
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1), 0, 4);

            memoryStream.Seek(0x10, SeekOrigin.Begin);
			int type = memoryStream.ReadByte();
            int unk = memoryStream.ReadByte();

            if (type == 0 && unk != 0)
			{
                memoryStream.Seek(0x12, SeekOrigin.Begin);
                int lastMDLID = 0;
                for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
                {
                    string searchOBJ = "MDL_" + objNames[index].Split('_')[1] + "_0";
                    if (ccsfile.toc.objnames[i] == searchOBJ)
                    {
                        lastMDLID = i;
                    }
                }
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(lastMDLID) + 1), 0, 4);
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(lastMDLID) + 2), 0, 4);
                ccsfile.toc.ObjCount++;
            }
			if(type == 4)
			{
                byte[] buffer = new byte[4];
				int meshesCount = memoryStream.ReadByte();
                memoryStream.Seek(0x5, SeekOrigin.Current);
                int bonnesCount = memoryStream.ReadByte();
                memoryStream.Seek(0xA, SeekOrigin.Current);
				for(int i = 0; i <= bonnesCount; i++)
				{
					 memoryStream.Seek(1, SeekOrigin.Current);
				}
                while (memoryStream.Position % 4 != 0)
                {
                    memoryStream.Seek(1, SeekOrigin.Current);
                }
                byte[] newMaterial = BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount + 2));
				for (int i = 0; i < meshesCount; i++)
				{
					memoryStream.Write(newMaterial, 0, newMaterial.Length);
					if(i < meshesCount - 1)
					{
                        memoryStream.Read(buffer, 0, 4);
						memoryStream.Seek(8, SeekOrigin.Current);
						int vertexCount = BitConverter.ToInt32(buffer, 0);
						memoryStream.Seek(vertexCount * 0xE, SeekOrigin.Current);
                        while (memoryStream.Position % 4 != 0)
                        {
                            memoryStream.Seek(1, SeekOrigin.Current);
                        }
                    }
				}
            }
            return memoryStream.ToArray().ToList();
        }
        private List<byte> FixMAT(List<byte> block, int index, int count, List<string> objNames)
        {
            byte[] currentBlock = block.ToArray();
            MemoryStream memoryStream = new MemoryStream(currentBlock);

            memoryStream.Seek(0x8, SeekOrigin.Begin);
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1), 0, 4);
            memoryStream.Seek(0xC, SeekOrigin.Begin);
            int lastTEXID = 0;
            for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
            {
                string searchOBJ = "TEX_" + objNames[countName].Split('_')[1];
                if (ccsfile.toc.objnames[i] == searchOBJ)
                {
                    lastTEXID = i;
                }
            }
			if(lastTEXID == 0)
			{
                SelectTexture texForm = new SelectTexture();
                for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
                {
                    if (ccsfile.toc.objnames[i].Contains("TEX_") == true)
                    {
                        texForm.comboBox1.Items.Add(ccsfile.toc.objnames[i]);
                    }
                }
				texForm.comboBox1.SelectedIndex = 0;
				if(this.portuguêsToolStripMenuItem.Checked == true)
				{
                    MessageBox.Show($"Textura do Material: {objNames[countName]} não foi encontrada, escolha a Textura.");
                }
				else
				{
                    MessageBox.Show($"Material Texture: {objNames[countName]} not found, choose the texture.");
                }
                texForm.ShowDialog();
				string texName = texForm.comboBox1.SelectedItem.ToString();
				int texID = 0;
                for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
                {
                    if (ccsfile.toc.objnames[i] == texName)
                    {
						texID = i;
                    }
                }
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(texID) + 1), 0, 4);
            }
			else
			{
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(lastTEXID) + 1), 0, 4);
            }
            return memoryStream.ToArray().ToList();
        }
        private List<byte> FixANM(List<byte> block, int index, int count, List<string> objNames)
        {
			byte[] currentBlock = block.ToArray();
            MemoryStream memoryStream = new MemoryStream(currentBlock);

            memoryStream.Seek(0x8, SeekOrigin.Begin);
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1), 0, 4);
            uint position = Convert.ToUInt32(ccsfile.toc.ObjCount - objNames.Count + 2);
            memoryStream.Seek(0x20, SeekOrigin.Begin);
            for(int i = 0; i < objNames.Count - 1; i++)
			{
                byte[] blockTypeBytes = new byte[4];
				memoryStream.Read(blockTypeBytes, 0, 4);
				int blockType = BitConverter.ToInt32(blockTypeBytes, 0);

				byte[] sizeBytes = new byte[4];
				memoryStream.Read(sizeBytes, 0, 4);
				int size = BitConverter.ToInt32(sizeBytes, 0);
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(position + i)), 0, 4);

				memoryStream.Seek(-0x4, SeekOrigin.Current);
				byte[] data = new byte[size * 0x4];
                memoryStream.Read(data, 0, data.Length);
            }
            return memoryStream.ToArray().ToList();
        }
        private List<byte> FixANMBonne(List<byte> block, int index, int count, List<string> objNames)
        {
            byte[] currentBlock = block.ToArray();
            MemoryStream memoryStream = new MemoryStream(currentBlock);
            memoryStream.Seek(0x8, SeekOrigin.Begin);

			byte[] oldIndexBytes = new byte[4];
			memoryStream.Read(oldIndexBytes, 0, 4);
			int oldIndex = BitConverter.ToInt32(oldIndexBytes, 0);
            memoryStream.Seek(-0x4, SeekOrigin.Current);
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1), 0, 4);

			byte[] fixBonneBytes = new byte[4];
			memoryStream.Read(fixBonneBytes, 0, 4);
			int fixBonne = BitConverter.ToInt32(fixBonneBytes, 0);

            byte[] oldMDLOBJBytes = new byte[4];
            memoryStream.Read(oldMDLOBJBytes, 0, 4);
            int oldMDLOBJ = BitConverter.ToInt32(oldMDLOBJBytes, 0);
            memoryStream.Seek(-0x8, SeekOrigin.Current);

            if (fixBonne != 0)
			{
                uint newID = ccsfile.toc.ObjCount + 1;
                int sub = oldIndex - previousID - 1;
                int dif = oldIndex - fixBonne;
                uint newMDLOBJ = newID - (uint)dif;
                if(sub != 0)
				{
					skipID[(int)newID][0] = sub;
				}
				int newDif = dif;
				for(int i = 0; i != dif; i++)
				{
                    newDif -= skipID[(int)newID - i][0];
				}
                previousID = oldIndex;

                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(newID - newDif)), 0, 4);
            }
			else
			{
				if(index != 0)
				{
                    previousIDdif += oldIndex - previousID - 1;
                }
                previousID = oldIndex;
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(0)), 0, 4);
            }

            uint lastIndex = 0;
            for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
			{
				int objFileIndex = ccsfile.toc.indexes[i];
                if (ccsfile.toc.objnames[i] == objNames[countName] && ccsfile.toc.filenames[objFileIndex - 1].Contains("\\max\\") == true)
				{
					lastIndex = (uint)i;
					break;
                }
            }
            if (lastIndex == 0 && oldMDLOBJ != 0)
            {
				if(objNames[countName].Contains("cmn") == true)
				{
                    memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(0)), 0, 4);
                }
                else
				{
                    SelectTexture texForm = new SelectTexture();
                    for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
                    {
                        if (ccsfile.toc.objnames[i].Contains("OBJ_") == true)
                        {
                            int objIndex = ccsfile.toc.indexes[i];
                            if (ccsfile.toc.filenames[objIndex - 1].Contains("anm") == false)
                            {
                                texForm.comboBox1.Items.Add(ccsfile.toc.objnames[i]);
                            }
                        }
                    }
                    texForm.comboBox1.SelectedIndex = 0;
                    if (this.portuguêsToolStripMenuItem.Checked == true)
					{
                        MessageBox.Show($"Não foi possível encontrar o modelo associado ao: {objNames[countName]}, escolha o modelo.");
                    }
                    else
					{
                        MessageBox.Show($"Could not find the model associated with: {objNames[countName]}, choose the model.");
                    }
                    texForm.ShowDialog();
                    string texName = texForm.comboBox1.SelectedItem.ToString();
                    int texID = 0;
                    for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
                    {
                        if (ccsfile.toc.objnames[i] == texName)
                        {
                            int objIndex = ccsfile.toc.indexes[i];
                            if (ccsfile.toc.filenames[objIndex - 1].Contains("anm") == false)
                            {
                                texID = i;
                            }
                        }
                    }
                    memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(texID) + 1), 0, 4);
                }
            }
            else
            {
                memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(lastIndex) + 1), 0, 4);
            }
            return memoryStream.ToArray().ToList();
        }
        private List<byte> FixExternal(List<byte> block, int index, int count)
        {
            byte[] currentIndex = BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount));
            for (int i = 0; i < currentIndex.Length; i++)
            {
                block[8 + i] = currentIndex[i];
            }
            return block;
        }
        private List<byte> FixDefault(List<byte> block, int index, int count)
        {
            byte[] currentIndex = BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1);
            for (int i = 0; i < currentIndex.Length; i++)
            {
                block[8 + i] = currentIndex[i];
            }
            return block;
        }
        private List<byte> FixCLT(List<byte> block, int index, int count)
        {
            byte[] currentIndex = BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount));
            for (int i = 0; i < currentIndex.Length; i++)
            {
                block[8 + i] = currentIndex[i];
            }
            return block;
        }
        private List<byte> FixTEX(List<byte> block, int index, int count, List<string> objNames)
		{
            byte[] currentBlock = block.ToArray();
            MemoryStream memoryStream = new MemoryStream(currentBlock);

            memoryStream.Seek(0x8, SeekOrigin.Begin);
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(ccsfile.toc.ObjCount) + 1), 0, 4);
            memoryStream.Seek(0xC, SeekOrigin.Begin);
            int lastCLTID = 0;
            for (int i = 0; i < ccsfile.toc.objnames.Count; i++)
            {
                string searchOBJ = "CLT_" + objNames[index].Split('_')[1];
                if (ccsfile.toc.objnames[i] == searchOBJ)
                {
                    lastCLTID = i;
                }
            }
            memoryStream.Write(BitConverter.GetBytes(Convert.ToUInt32(lastCLTID) + 1), 0, 4);
            return memoryStream.ToArray().ToList();
		}

		private string ReadString(FileStream fileStream)
		{
			List<byte> byteList = new List<byte>();
            while (true)
            {
				byte currentByte = (byte)fileStream.ReadByte();
				if(currentByte == 0)
				{
					break;
				}
				else
				{
					byteList.Add(currentByte);
				}
            }
            return Encoding.GetEncoding("shift-jis").GetString(byteList.ToArray());
        }
    }
}
