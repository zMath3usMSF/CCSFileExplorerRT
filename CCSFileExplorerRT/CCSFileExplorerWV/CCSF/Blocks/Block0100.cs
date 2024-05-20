﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200001F RID: 31
	public class Block0100 : Block
	{
		// Token: 0x060000DB RID: 219 RVA: 0x0000A0B4 File Offset: 0x000082B4
		public Block0100(Stream s)
		{
			this.type = 3435921664U;
			uint size = StreamHelper.ReadUInt32(s) * 4U;
			byte[] buff = new byte[size];
			s.Read(buff, 0, (int)size);
			this.unknown = new List<uint>();
			int i = 0;
			while ((long)i < (long)((ulong)(size / 4U)))
			{
				this.unknown.Add(BitConverter.ToUInt32(buff, i * 4));
				i++;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000A11C File Offset: 0x0000831C
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000AE RID: 174
		public List<uint> unknown;
	}
}
