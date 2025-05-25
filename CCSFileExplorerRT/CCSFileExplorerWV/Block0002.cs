using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000007 RID: 7
	public class Block0002 : Block
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000274C File Offset: 0x0000094C
		public override byte[] FullBlockData
		{
			get
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(BitConverter.GetBytes(BlockID), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(Size), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(FileCount + 1U), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(ObjCount + 1U), 0, 4);
				memoryStream.Write(Data, 0, Data.Length);
				return memoryStream.ToArray();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000027C8 File Offset: 0x000009C8
		public Block0002(Stream s)
		{
			ID = uint.MaxValue;
			Size = Block.ReadUInt32(s);
			FileCount = Block.ReadUInt32(s);
			ObjCount = Block.ReadUInt32(s);
			Data = new byte[Size * 4U];
            s.Read(Data, 0, (int)(Size * 4U));
            BinaryReader dStream = new BinaryReader(new MemoryStream(Data));
            filenames = new List<string>();
			for(int i = 0; i < FileCount; i++)
			{
				filenames.Add(ReadFixedLenString(dStream, 0x20));
			}
			objnames = new List<string>();
			indexes = new List<ushort>();
			for(int i = 0; i <  ObjCount; i++)
			{
				objnames.Add(ReadFixedLenString(dStream, 0x1E));
				indexes.Add(dStream.ReadUInt16());
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000028D4 File Offset: 0x00000AD4
		public override TreeNode ToNode()
		{
			return new TreeNode(string.Concat(new string[]
			{
				BlockID.ToString("X8"),
				"ID:0x",
				ID.ToString("X"),
				" Size: 0x",
				Data.Length.ToString("X")
			}));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002940 File Offset: 0x00000B40
		public override void WriteBlock(Stream s)
		{
			Block.WriteUInt32(s, BlockID);
			MemoryStream i = new MemoryStream();
			foreach (string name in filenames)
			{
				Block.WriteString(i, name, 32);
			}
			int j = 0;
			while ((long)j < (long)((ulong)ObjCount))
			{
				Block.WriteString(i, objnames[j], 30);
				i.Write(BitConverter.GetBytes(indexes[j]), 0, 2);
				j++;
			}
			Block.WriteUInt32(i, 3U);
			Block.WriteUInt32(i, 0U);
			Block.WriteUInt32(s, (uint)(i.Length / 4L));
			Block.WriteUInt32(s, FileCount);
			Block.WriteUInt32(s, ObjCount);
			s.Write(i.ToArray(), 0, (int)i.Length);
		}

		// Token: 0x0400000E RID: 14
		public uint FileCount;

		// Token: 0x0400000F RID: 15
		public uint ObjCount;

		// Token: 0x04000010 RID: 16
		public List<string> filenames;

		// Token: 0x04000011 RID: 17
		public List<string> objnames;

		// Token: 0x04000012 RID: 18
		public List<ushort> indexes;
	}
}
