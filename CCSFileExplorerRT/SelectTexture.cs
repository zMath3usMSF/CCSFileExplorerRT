using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCSFileExplorerRT
{
    public partial class SelectTexture : Form
    {
        public SelectTexture()
        {
            InitializeComponent();
        }
        private void AddToComboBox(List<string> objNames)
        {
            for(int i =  0; i < objNames.Count; i++)
            {
                if(objNames[i].Contains("TEX_") == true)
                {
                    comboBox1.Items.Add(objNames[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
