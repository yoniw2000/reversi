using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Reversi
{
    class Board1
    {
        private Cell[,] arr;
        private int black;
        private int white;
        public Board1()
        {
            //0 no color , 1 black , -1 white 
            this.arr = new Cell[8, 8];
            int x = 60;//x התחלתי
            int y = 60;//y  התחלתי
            this.black = 2;
            this.white = 2;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    arr[i, j] = new Cell(x, y, 0);
                    x += 99;//משפיע על ה x :)
                }
                x = 60;
                y += 99;// y משפיע על ה :)
            }
            arr[3, 3].setcolor(1); // the first 4 
            arr[4, 4].setcolor(1);
            arr[4, 3].setcolor(-1);
            arr[3, 4].setcolor(-1);

        }

        //אם ריק שולח לבדיקה את כל הכיוונים
        //מהלך חוקי הוא מהלך שבוא שמת דיסק במקום ריק והפכת לפחות יריב אחד
        public bool IsLigalMove(int i, int j, int color)
        {
            if (arr[i, j].getcolor() != 0)
                return false;
            for (int ai = -1; ai <= 1; ai++)//קינון לולאות עובר על כל הכיוונים 
                for (int aj = -1; aj <= 1; aj++)
                    if (!(ai == 0 && aj == 0) && IsEaten(color, i, j, ai, aj))//מצאת לפחות דיסק אחד שיתהפך אז תחזיר אמת
                        return true;// גילה שיש מהלך חוקי
            return false;
        }

        // עד שמגיעים לאותו צבע זז על כל הלוח לפי הכיוונים שקיבל ובודק אם חוקי 
        //לא מבצע באמת את המהלך, אלא מקבל צבע , מיקום על הלוח, וכיוון ובודק האם יהיו בדרך איזשהו דיסקים יריבים שהתהפכו
        public bool IsEaten(int color, int i, int j, int ai, int aj)
        {
            int si, sj;
            si = i + ai;
            sj = j + aj;
            //זז על הלוח כל עוד אנחנו נמצאים על הלוח, נוחת על דיסק מהצבע הנגדי
            while (si >= 0 && si < 8 && sj >= 0 && sj < 8 && arr[si, sj].getcolor() == -color)
            {
                si += ai;
                sj += aj;
            }
            //במקרה שזזנו בסך הכל מקום אחד בלוחת או שיצאנו מגבולות הלוח תחזיר פולס
            //arr[si, sj].getcolor() != color על פי הקוד תמיד אם לא ריק 
            //(si - ai == i && sj - aj == j) כאשר עושים קינון לולאות יש 0 ו0 ואז נשארים באותו מקום
            if (si < 0 || si > 7 || sj < 0 || sj > 7 || (si - ai == i && sj - aj == j) || arr[si, sj].getcolor() != color)
                return false;
            return true;
        }

        public void MakeMove(int i, int j, int color)//מבצע הפיחות
        {
            this.arr[i, j].setcolor(color);//משנה במקום בו לחצתי 
            int ai, aj;
            int si, sj;
            for (ai = -1; ai <= 1; ai++)//בודק על כל הכיוונים
                for (aj = -1; aj <= 1; aj++)
                    if (!(ai == 0 && aj == 0) && IsEaten(color, i, j, ai, aj))//יש בכלל כאלה בהמשך?
                    {
                        si = i + ai;
                        sj = j + aj;
                        while (this.arr[si, sj].getcolor() == -color)//הופך אותם
                        {
                            this.arr[si, sj].setcolor(color);
                            si += ai;
                            sj += aj;
                        }
                    }
            Update_count();
        }

        public void DrawBoard(Graphics g)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (arr[i, j].getcolor() != 0)
                    {
                        arr[i, j].drowpic(g);
                    }
                }
            }
        }
        public Cell getcell(int i, int j)
        {
            if (i >= 0 && j >= 0 && i <= 7 && j <= 7)
            {
                return arr[i, j];
            }
            return null;
        }
        public void PutCoin(int i, int j, int color)
        {
            if (color == 1)
            {
                black++;
                arr[i, j].setimage(Image.FromFile("pic_black.png"));
            }
            if (color == -1)
            {
                white++;
                arr[i, j].setimage(Image.FromFile("pic_white.png"));
            }
            if (arr[i, j].getcolor() == 0)
                arr[i, j].setcolor(color);
            Update_count();
        }
                
        public int getblacks()
        {
            Update_count();
            return this.black;
        }
        public int getwhites()
        {
            Update_count();
            return this.white;
        }

        public void Update_count()
        {
            int black1 = 0;
            int white1 = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (arr[i, k].getcolor() == 1)
                        black1++;
                    if (arr[i, k].getcolor() == -1)
                        white1++;
                }
            }
            this.black = black1;
            this.white = white1;
        }
        
        public int CountIsLigalMove(int color)//סופר כמה מהלכים חוקיים יש
        {
            int num1 = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (IsLigalMove(i, j, color))
                        num1++;
                }
            }
            return num1;
        }

        public bool HasAnyLigalMove(int color)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (IsLigalMove(i, j, color) == true)
                        return true;
                }
            }
            return false;
        }

    }
}
