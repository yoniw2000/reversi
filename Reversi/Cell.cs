using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Reversi
{
    class Cell
    {
        private int x;
        private int y;
        private int color;//0 no color , 1 black , -1 white 
        private Image pic;


        public Cell(int x, int y, int color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            if (color == -1)
            {
                pic = Image.FromFile("pic_white.jpg");
            }
            if (color == 1)
            {
                pic = Image.FromFile("pic_black.png");
            }
        }
        public int getx()
        {
            return this.x;
        }
        public int gety()
        {
            return this.y;
        }
        public int getcolor()
        {
            return this.color;
        }
        public Image getpic()
        {
            return this.pic;
        }
        public void setcolor(int color) //-1 no color , 0 black , 1 white 
        {
            this.color = color;
            if (color == 1)
            {
                pic = Image.FromFile("pic_black.png");
            }
            if (color == -1)
            {
                pic = Image.FromFile("pic_white.png");
            }
        }
        public bool opsitecolor(int color)
        {
            return (this.color != color && color != 0 && this.color!=0);
        }
        public void setimage(Image pic2)
        {
            this.pic = pic2;
        }
        public void setx(int x)
        {
            this.x = x;
        }
        public void sety(int y)
        {
            this.y = y;
        }
        public void drowpic(Graphics g)
        {
            if (color == -1|| color==1)
            {
                Point p = new Point(x, y);
                g.DrawImage(pic, p);
            }
        }
       
    }
}
