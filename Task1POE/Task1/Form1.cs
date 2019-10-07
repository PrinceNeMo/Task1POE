using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        List<Unit> units = new List<Unit>();
        Random rm = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Map map = new Map(20);
            map.Generatenits(5);
            map.Populate(groupBox1);
        }

        private void StrtBtn1_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        private void PSBtn1_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
        }
    }
}
