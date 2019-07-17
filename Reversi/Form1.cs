using System;
using Unit4.CollectionsLib;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace Reversi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        Board1 b;
        Graphics g;
        Point p;
        Image pic;
        int turn, i, j;
        
        private void משחקחדשToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            g = CreateGraphics();
            p = new Point(50, 50);
            pic = Image.FromFile("55.png");
            g.DrawImage(pic, p);
            b = new Board1();
            b.DrawBoard(g);// g עבור כל תא אם לא ריק מצייר  
            turn = 1;// שחור
            i = 0; j = 0;
            label5.Text = "2";
            label6.Text = "2";
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
                    if (b.IsLigalMove(i, j, turn))//מצא שיש לפחות דיסק אחד שמתהפך 
                    {
                        b.MakeMove(i, j, turn);//הופך אותם                       
                        label1.Text = "לבן";
                        b.DrawBoard(g);
                        turn = -turn;
                        b.Update_count();
                        label5.Text = b.getblacks().ToString();
                        label6.Text = b.getwhites().ToString();
                        if (b.getwhites() + b.getblacks() < 64) // לא נגמר המשחק
                        {
                            MessageBox.Show("תור לבן");
                            label1.Text = "לבן";
                            b.DrawBoard(g);
                        }
                        else
                        { EndGame(); }    //משחק ניגמר                                                
                    }
                    else
                    { MessageBox.Show("מהלך לא חוקי"); }
                }
                else { MessageBox.Show("מהלך לא חוקי"); }
            }
            else  // תור הלבן
            {
                if (i <= 7 && j <= 7 && b.getcell(i, j).getcolor() == 0 && i >= 0 && j >= 0)
                {
                    if (b.IsLigalMove(i, j, turn))//מצא שיש לפחות דיסק אחד שמתהפך
                    {
                        b.MakeMove(i, j, turn);                       
                        label1.Text = "שחור";
                        b.DrawBoard(g);
                        turn = -turn;
                        b.Update_count();
                        label5.Text = b.getblacks().ToString();
                        label6.Text = b.getwhites().ToString();                       
                        if (b.getwhites() + b.getblacks() < 64) // לא נגמר המשחק
                        {                           
                            MessageBox.Show("תור שחור");                          
                            b.DrawBoard(g);                                                       
                        }
                        else
                        {
                            EndGame();//משחק ניגמר
                        }
                    }
                    else
                    { MessageBox.Show("מהלך לא חוקי"); }
                }
                else
                { MessageBox.Show("מהלך לא חוקי"); }
            }          
        }

        private void הוראותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instructions in1 = new instructions();
            in1.Show();
            SystemSounds.Beep.Play();
        }

        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ניצחוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b.Update_count();
            if (b.CountIsLigalMove(1) == 0 && b.CountIsLigalMove(-1) == 0)
            {MessageBox.Show("the game was ended");
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
            else { MessageBox.Show("לאחד השחקנים יש עוד מהלך חוקי ");}  
        }

        private void הפסדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lose l = new Lose();
            l.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
                     
        }

        private void b_move_turn_Click(object sender, EventArgs e)
        {   turn = -turn;
              if (turn == 1)
              {
                label1.Text = "שחור";
              }
              else
              {
                label1.Text = "לבן";
              }
            if (label5.Text == "0" )
            {
                MessageBox.Show("לבן ניצח");
            }
            if (label6.Text == "0")
            {
                MessageBox.Show("שחור ניצח");
            }
        }

        private void משחקמולמחשבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC PC = new PC();
            PC.Show();
        }
        
        public void EndGame()
        {
            MessageBox.Show("the game was ended");
            b.Update_count();
            if (b.getblacks() +b.getwhites() == 64)
            {             
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
        }        
    }
}
