using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi
{
    public partial class mayinFrm : Form
    {
        Button[,] butonlar = new Button[5, 5];
        int[,] oyunalani = new int[5, 5];
        public mayinFrm()
        {
            InitializeComponent();
        }

        public int mayinvarmi(int x,int y)
        {
            int sayac = 0;
            if (x < 4)
            {
                if (oyunalani[x + 1, y] == 1)
                {
                    sayac++;
                }
            }
            if (x < 4 && y < 4)
            {
                if (oyunalani[x + 1, y + 1] == 1)
                {
                    sayac++;
                }
            }
            if (y < 4)
            {
                if (oyunalani[x, y + 1] == 1)
                {
                    sayac++;
                }
            }
            if (x > 0 && y < 4)
            {
                if (oyunalani[x - 1, y + 1] == 1)
                {
                    sayac++;
                }
            }
            if (x > 0)
            {
                if (oyunalani[x - 1, y] == 1)
                {
                    sayac++;
                }
            }
            if (x > 0 && y > 0)
            {
                if (oyunalani[x - 1, y - 1] == 1)
                {
                    sayac++;
                }
            }
            if (y > 0)
            {
                if (oyunalani[x, y - 1] == 1)
                {
                    sayac++;
                }
            }
            if (x < 4 && y > 0)
            {
                if (oyunalani[x + 1, y - 1] == 1)
                {
                    sayac++;
                }
            }
            return sayac;
        }

        private void baslabtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (butonlar[i, j] != null)
                    {
                        butonlar[i, j].BackgroundImage = null;
                        butonlar[i, j].Parent = null;
                        butonlar[i,j]=null;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    oyunalani[i,j] = 0;
                }
            }
            Random r=new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r.Next(5);
                int y = r.Next(5);
                oyunalani[x, y] = 1;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {                          
                    Button b = new Button();
                    b.Width = 40;
                    b.Height = 40;
                    b.Left = 10+j*40;
                    b.Top = 10+i*40;
                    b.Name = i + "," + j;
                    b.Click += oyunbtn_Click;
                    b.Font = new Font("Arial", 14);
                    b.Parent = groupBox1;
                    butonlar[i,j] = b;
                }
            }            
        }
        private void oyunbtn_Click(object sender, EventArgs e)
        {            
            Button m=(Button)sender;
            String[]dizi=m.Name.Split(',');
            int x =int.Parse( dizi[0]);
            int y = int.Parse(dizi[1]);
            butonlar[x,y].BackColor=Color.Blue;
            if (oyunalani[x,y]==1)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if(oyunalani[i, j] == 1)
                        {
                            butonlar[i,j].BackgroundImageLayout = ImageLayout.Stretch;
                            butonlar[i, j].BackgroundImage = Image.FromFile("mine.png");
                        }
                    }
                }
            }
            else
            {
                butonlar[x, y].Text = mayinvarmi(x, y).ToString();
            }
        }
    }
}
