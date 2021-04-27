using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wii.cs_Tools;
using ShowMiiWads;
using UltimateU8;

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
            DolMii_Main dolMii_Main = new DolMii_Main();
            dolMii_Main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lz77Mii_Main lz77Mii_Main = new Lz77Mii_Main();
            lz77Mii_Main.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMiiWads_Main showMiiWads_Main = new ShowMiiWads_Main();
            showMiiWads_Main.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TplMii_Main tplMii_Main = new TplMii_Main();
            tplMii_Main.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            U8Mii_Main u8Mii_Main = new U8Mii_Main();
            u8Mii_Main.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UltimateU8_Main ultimateU8_Main = new UltimateU8_Main();
            ultimateU8_Main.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WadMii_Main wadMii_Main = new WadMii_Main();
            wadMii_Main.ShowDialog();
        }
    }
}
