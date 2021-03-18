using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wii.cs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs_Tools.DolMii_Main dolMii_Main = new cs_Tools.DolMii_Main();
            dolMii_Main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs_Tools.Lz77Mii_Main lz77Mii_Main = new cs_Tools.Lz77Mii_Main();
            lz77Mii_Main.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMiiWads.ShowMiiWads_Main showMiiWads_Main = new ShowMiiWads.ShowMiiWads_Main();
            showMiiWads_Main.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cs_Tools.TplMii_Main tplMii_Main = new cs_Tools.TplMii_Main();
            tplMii_Main.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cs_Tools.U8Mii_Main u8Mii_Main = new cs_Tools.U8Mii_Main();
            u8Mii_Main.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UltimateU8.UltimateU8_Main ultimateU8_Main = new UltimateU8.UltimateU8_Main();
            ultimateU8_Main.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cs_Tools.WadMii_Main wadMii_Main = new cs_Tools.WadMii_Main();
            wadMii_Main.ShowDialog();
        }
    }
}
