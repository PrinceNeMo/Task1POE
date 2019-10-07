using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    class Map
    {       
        Random rm = new Random();
        List<Unit> rangeu = new List<Unit>();
        List<Unit> meeleun = new List<Unit>();
        string[,] Maps = new string[20, 20];
        const string OPEN_SPACE = ".";
        int unNumbers;
        
        public void Generatenits(int uni)
        {
            int rX;
            int rY;
            for (int i=0;i<uni;i++)
            {
                rX = rm.Next(1, 20);
                rY = rm.Next(1, 20);
                MeleeUnit me = new MeleeUnit(rX, rY,50, 60, 50, 2, "P", "#", false); // constructor recivess.

                meeleun.Add(me);
            }
            for(int j=0;j<uni;j++)
            {
                rX = rm.Next(1, 20);
                rY = rm.Next(1, 20);
                RangeUnit ran = new RangeUnit(rX, rY,10, 60, 50, 5, "A", "@", false); // constructor recivess.
                rangeu.Add(ran);
            }
        }
        public Map(int tiles) // to create units.
        {
            
            this.unNumbers = tiles;
        }
        
        public void Populate(GroupBox groupBox1)
        {
            groupBox1.Controls.Clear();
            foreach (MeleeUnit me in meeleun)
            {
                Label lblmel = new Label();
                lblmel.Width = 20;
                lblmel.Height = 20;
                lblmel.Location = new System.Drawing.Point(me.XPos * 20, me.YPos * 20);
                lblmel.Text = me.Symbol;

                groupBox1.Controls.Add(lblmel);
            }
            foreach (RangeUnit ran in rangeu)
            {
                Label lblrang = new Label();
                lblrang.Width = 20;
                lblrang.Height = 20;
                lblrang.Location = new System.Drawing.Point(ran.XPos * 20, ran.YPos * 20);
                lblrang.Text = ran.Symbol;

                groupBox1.Controls.Add(lblrang);
            }
        }
        public void display()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Maps[i, j] = OPEN_SPACE;
                }

            }

        }

        public void Update()
        {

        }
    }
}
