using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Reversi
{
    public partial class PC : Form
    {
        public PC()
        {
            InitializeComponent();
        }       
        Board1 b;
        Graphics g;
        Point p;
        Image pic;
        int turn, i, j;
        private void משחקחדשToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label5.Text = 2.ToString();
            label6.Text = 2.ToString();
            g = CreateGraphics();
            p = new Point(50, 50);
            pic = Image.FromFile("55.png");
            g.DrawImage(pic, p);//מצייר לוח  
            b = new Board1();
            b.DrawBoard(g);
            turn = 1;// שחור
            i = 0; j = 0;
        }
        private void mmm(object sender, MouseEventArgs e)
        {
            int bcount = b.getblacks();
            int wcount = b.getwhites();
            j = (e.X - 60) / 99;
            i = (e.Y - 60) / 99;
            if (turn == 1) // שחור
            {
                if (i <= 7 && j <= 7 && b.getcell(i, j).getcolor() == 0 && i >= 0 && j >= 0)
                {
                    illigal_player_turn();
                    if (b.IsLigalMove(i, j, turn))
                    {
                        b.MakeMove(i, j, turn);                        
                        b.DrawBoard(g);                       
                        label5.Text = b.getblacks().ToString();
                        label6.Text = b.getwhites().ToString();
                        
                        if (b.getwhites() + b.getblacks() < 64) // לא נגמר המשחק
                        {  
                            computermove();                         
                            b.DrawBoard(g);                          
                            label5.Text = b.getblacks().ToString();
                            label6.Text = b.getwhites().ToString();
                        }
                        else
                        {
                            EndGame();//משחק ניגמר
                        }
                    }
                    else
                    { MessageBox.Show("מהלך לא חוקי"); }
                }
            }          
        }

    
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void הוראותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instructions s = new instructions();
            s.Show();
        }

        private void יציאהToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            DialogResult dialog = MessageBox.Show("do u want 2 exsit", "exsit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (dialog == DialogResult.No)
            {

            }
        }


        public void illigal_player_turn() 
        {
            if (b.CountIsLigalMove(turn) == 0)
            {
                //במקרה שאני תקוע מעביר טור למחשב
                Console.WriteLine("מעביר תור למחשב כי אני תקוע");
                computermove();
                b.DrawBoard(g);
                label5.Text = b.getblacks().ToString();
                label6.Text = b.getwhites().ToString();
            }
        }
        
        
        public bool computermove()
        {
            turn = -1;
            MessageBox.Show("תור מחשב");
            if (b.IsLigalMove(0, 0, turn))//4 פינות
            {
                b.MakeMove(0, 0, turn);
                turn = 1;
                
                b.DrawBoard(g);
                EndGame();
                return true;
            }
            if (b.IsLigalMove(0, 7, turn))//4 פינות
            {
                b.MakeMove(0, 7, turn);
                turn = 1;               
                b.DrawBoard(g);
                EndGame();
                return true;
            }
            if (b.IsLigalMove(7, 0, turn))//4 פינות
            {
                b.MakeMove(7, 0, turn);
                turn = 1;                
                b.DrawBoard(g);
                EndGame();
                return true;
            }
            if (b.IsLigalMove(7, 7, turn))//4 פינות
            {
                b.MakeMove(7, 7, turn);
                turn = 1;                
                b.DrawBoard(g);
                EndGame();
                return true;
            }

            for (int i = 0; i < 8; i++)//זז על המסגרת 
            {
                if (b.IsLigalMove(i, 0, turn))
                {
                    b.MakeMove(i, 0, turn);
                    turn = 1;                  
                    b.DrawBoard(g);
                    EndGame();
                    return true;
                }
            }
            for (int i = 0; i < 8; i++)//זז על המסגרת 
            {
                if (b.IsLigalMove(i, 7, turn))
                {
                    b.MakeMove(i, 7, turn);
                    turn = 1;                  
                    b.DrawBoard(g);
                    EndGame();
                    return true;
                }
            }
            for (int j = 0; j < 8; j++)//זז על המסגרת 
            {
                if (b.IsLigalMove(0, j, turn))
                {
                    b.MakeMove(0, j, turn);
                    turn = 1;                   
                    b.DrawBoard(g);
                    EndGame();
                    return true;
                }
            }
            for (int j = 0; j < 8; j++)//זז על המסגרת 
            {
                if (b.IsLigalMove(7, j, turn))
                {
                    b.MakeMove(7, j, turn);
                    turn = 1;                    
                    b.DrawBoard(g);
                    EndGame();
                    return true;
                }
            }
            int x = b.CountIsLigalMove(turn);// אם יש מהלך 1 או 2 הראשון שאתה מוצא
            if (x == 1 || x == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (b.IsLigalMove(i, j, turn))
                        {
                            b.MakeMove(i, j, turn);
                            turn = 1;                          
                            b.DrawBoard(g);
                            EndGame();
                            return true;
                        }
                    }
                }
            }
            while (b.HasAnyLigalMove(turn))//אם אין בכלל אז תעביר תור אם יותר מ-2 רנדום
            {
                Random rnd = new Random();
                int i, j;
                i = rnd.Next(0, 8);
                j = rnd.Next(0, 8);
                if (b.IsLigalMove(i, j, turn))
                {
                    b.MakeMove(i, j, turn);
                    turn = 1;                   
                    b.DrawBoard(g);
                    EndGame();
                    return true;
                }
            }            
            turn = 1;
            MessageBox.Show("לא היה למחשב מהלך חוקי לעשות מעביר טור לשחקן");
            return false;
        }
        public void EndGame()
        {
            label5.Text = b.getblacks().ToString();
            label6.Text = b.getwhites().ToString();
            if (b.getblacks() + b.getwhites() == 64)
            {
                if (b.getblacks() > b.getwhites())
                {
                    MessageBox.Show("השחור ניצח");
                    Win w = new Win();
                    w.Show();
                }
                if (b.getblacks() < b.getwhites())
                {
                    MessageBox.Show("הלבן ניצח");
                    Lose l = new Lose();
                    l.Show();
                }
                if (b.getblacks() == b.getwhites())
                {
                    MessageBox.Show("תיקו");
                }
                
                // אסטרטגית מחשב ,4 פינות, מסגרת,אם יש 1 או 2 מהלכים אפשריים הראשון שמוצא,אם אין מעביר טור ,אחרת רנדום
            }
        }

        private void ניצחוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b.Update_count();
            if (b.CountIsLigalMove(1) == 0 && b.CountIsLigalMove(-1) == 0)
            {
                MessageBox.Show("the game was ended");
                if (b.getblacks() > b.getwhites())
                {
                    MessageBox.Show("השחור ניצח");
                }
                if (b.getblacks() < b.getwhites())
                {
                    MessageBox.Show("הלבן ניצח");
                }
                if (b.getblacks() == b.getwhites())
                {
                    MessageBox.Show("תיקו");
                }
                SystemSounds.Asterisk.Play();
            }
            else { MessageBox.Show("לאחד השחקנים יש עוד מהלך חוקי "); }  
        }
    }
}
