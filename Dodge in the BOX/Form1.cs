using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dodge_in_the_BOX
{
    public partial class Form1 : Form
    {
        //countdown
        int countDown = 100;
        int resetcount = 3;
        int startcount = 0;
        string game = "start";
        Rectangle reset = new Rectangle(0, 0, 600, 637);

        //Player
        Rectangle player = new Rectangle(280, 447, 45, 24);
        int playerHPvalue;
        int playerSpeed = 6;
        int jumpHeight = 90;
        int gravity = 4;
        int playerHP = 100;
        int damage = 1;


        //Gimmick1
        int gimmick1Speed = 15;
        int gimmick1aWidth = 15;
        int gimmick1aHeight = 55;
        int gimmick1bWidth = 15;
        int gimmick1bHeight = 220;
        int gimmick1count = 0;
        List <Rectangle> gimmick1aListL= new List <Rectangle> ();
        List <Rectangle> gimmick1bListL = new List<Rectangle>();
        List<Rectangle> gimmick1aListR = new List<Rectangle>();
        List<Rectangle> gimmick1bListR = new List<Rectangle>();

        //Gimmick2
        Rectangle gimmick2ball1 = new Rectangle(280, 280, 40, 40);
        Rectangle gimmick2ball2 = new Rectangle(280, 280, 70, 70);
        Rectangle gimmick2ball3 = new Rectangle(280, 280, 50, 50);
        int ball1SpeedX = 20;
        int ball1SpeedY = 10;
        int ball2SpeedX = 10;
        int ball2SpeedY = 5;
        int ball3SpeedX = -15;
        int ball3SpeedY = 10;

        //Gimmick3
        int gimmick3aSpeed = 15;
        int gimmick3bSpeed = -15;
        int gimmick3aWidth = 25;
        int gimmick3aHeight = 50;
        int gimmick3bWidth = 25;
        int gimmick3bHeight = 290;
        int gimmick3counta = 0;
        int gimmick3countb = 10;
        List<Rectangle> gimmick3aList = new List<Rectangle>();
        List<Rectangle> gimmick3bList = new List<Rectangle>();

        //Gimmick4
        double gimmick4count = 0;
        Rectangle gimmick4lineB = new Rectangle(125, 360, 350, 5);
        Rectangle gimmick4B = new Rectangle(125, 360, 350, 110);
        Rectangle gimmick4lineT = new Rectangle(125, 235, 350, 5);
        Rectangle gimmick4T = new Rectangle(125, 125, 350, 110);
        Rectangle gimmick4lineL = new Rectangle(235, 125, 5, 350);
        Rectangle gimmick4L = new Rectangle(125, 125, 110, 350);
        Rectangle gimmick4lineR = new Rectangle(365, 125, 5, 350);
        Rectangle gimmick4R = new Rectangle(365, 125, 110, 350);

        //Gemmick5
        int gimmick5aSpeed = -10;
        int gimmick5bSpeed = 10;
        int gimmick5cSpeed = -10;
        int gimmick5dSpeed = 10;
        int gimmick5Width = 15;
        int gimmick5Height = 85;
        int gimmick5counta = 0;
        int gimmick5countb = 10;
        List<Rectangle> gimmick5aList = new List<Rectangle>();
        List<Rectangle> gimmick5bList = new List<Rectangle>();
        List<Rectangle> gimmick5cList = new List<Rectangle>();
        List<Rectangle> gimmick5dList = new List<Rectangle>();

        //Gimmick6
        int gimmick6count = 0;
        int gimmick6aSize = 600;
        int gimmick6aLocation = 0;
        int gimmick6bSize = 600;
        int gimmick6bLocation = 0;
        int gimmick6cSize = 600;
        int gimmick6cLocation = 0;
        Rectangle gimmick6areaa = new Rectangle(380, 130, 90, 140);
        Rectangle gimmick6areab = new Rectangle(200, 130, 180, 90);
        Rectangle gimmick6areac = new Rectangle(130, 130, 90, 140);

        //Gimmick7
        int gimmick7count = 0;
        int cx = 300, cy = 300, rx = 30, ry = 490;
        float angle1 = 45;
        float angle2 = 135;
        int gimmick7systemaX = 130;
        int gimmick7systemaY = 130;
        int gimmick7systembX = 445;
        int gimmick7systembY = 130;
        int gimmick7systemcX = 445;
        int gimmick7systemcY = 445;
        int gimmick7systemdX = 130;
        int gimmick7systemdY = 445;

        //Gimic8
        int gimmick8count = 0;
        int gimmick8Size = 30;
        int gimmick8aX = 130;
        int gimmick8aY = 130;
        int gimmick8bX = 440;
        int gimmick8bY = 130;
        int gimmick8cX = 440;
        int gimmick8cY = 440;
        int gimmick8dX = 130;
        int gimmick8dY = 440;

        //Gimmick9
        int gimmick9count = 0;

        //Gimmick10
        int gimmick10Speed = 20;

        //Box
        Rectangle boxbottom = new Rectangle(125, 470, 350, 5);
        Rectangle boxtop = new Rectangle(125, 125, 350, 5);
        Rectangle boxleft = new Rectangle(125, 125, 5, 350);
        Rectangle boxright = new Rectangle(470, 125, 5, 350);
        //Paint
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush transparentBrush = new SolidBrush(Color.Transparent);
        Pen whitePen = new Pen(Color.White,40);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.IndianRed);

        //Sound
        SoundPlayer damageSound = new SoundPlayer(Properties.Resources.damageSound);
        SoundPlayer selectSound = new SoundPlayer(Properties.Resources.selectionSound);
        SoundPlayer jumpSound = new SoundPlayer(Properties.Resources.jumpSound);
        SoundPlayer gimmick2 = new SoundPlayer(Properties.Resources.gimmick2);
        SoundPlayer gimmick4 = new SoundPlayer(Properties.Resources.gimmick4);
        WindowsMediaPlayer playing = new WindowsMediaPlayer();
        WindowsMediaPlayer menu = new WindowsMediaPlayer();
        WindowsMediaPlayer gameclear = new WindowsMediaPlayer();
        WindowsMediaPlayer gameover = new WindowsMediaPlayer();

        //Key
        bool Jump = false;
        bool MoveLeft = false;
        bool MoveRight = false;
        bool MoveUp = false;
        bool MoveDown = false;
        bool Start = false;

        //Jump
        string jump = "false";
        string location = "bottom";

        //Situation
        int Gimmick;

        public Form1()
        {
            InitializeComponent();
            playerPic.BackgroundImage = Properties.Resources.character_B;
            menu.URL = "C:\\Users\\tathi\\OneDrive\\Desktop\\menuSound.wav";
            playing.URL = "C:\\Users\\tathi\\OneDrive\\Desktop\\playingSound.wav";
            gameclear.URL = "C:\\Users\\tathi\\OneDrive\\Desktop\\gameclearSound.mp4";
            gameover.URL = "C:\\Users\\tathi\\OneDrive\\Desktop\\gameoverSound.wav";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            switch (game)
            {
                case "start":
                    e.Graphics.FillRectangle(whiteBrush, boxbottom);
                    break;

                case "startpre":
                    e.Graphics.FillRectangle(whiteBrush, boxbottom);
                    e.Graphics.FillRectangle(whiteBrush, boxtop);
                    e.Graphics.FillRectangle(whiteBrush, boxleft);
                    e.Graphics.FillRectangle(whiteBrush, boxright);
                    e.Graphics.FillRectangle(transparentBrush, player);

                    playerHPvalue = playerHP * 3;
                    hpLabel.Visible = true;
                    Rectangle playerHPbar = new Rectangle(175, 580, playerHPvalue, 20);
                    Rectangle playerHPbarBG = new Rectangle(175, 580, 300, 20);
                    e.Graphics.FillRectangle(grayBrush, playerHPbarBG);
                    e.Graphics.FillRectangle(whiteBrush, playerHPbar);
                    break;

                case "test" :
                    e.Graphics.FillRectangle(whiteBrush, boxbottom);
                    e.Graphics.FillRectangle(whiteBrush, boxtop);
                    e.Graphics.FillRectangle(whiteBrush, boxleft);
                    e.Graphics.FillRectangle(whiteBrush, boxright);
                    e.Graphics.FillRectangle(transparentBrush, player);

                    playerHPvalue = playerHP * 3;
                    hpLabel.Visible = true;
                    playerHPbar = new Rectangle(175, 580, playerHPvalue, 20);
                    playerHPbarBG = new Rectangle(175, 580, 300, 20);
                    e.Graphics.FillRectangle(grayBrush, playerHPbarBG);
                    e.Graphics.FillRectangle(whiteBrush, playerHPbar);
                    break;

                case "playing":
                    e.Graphics.FillRectangle(whiteBrush, boxbottom);
                    e.Graphics.FillRectangle(whiteBrush, boxtop);
                    e.Graphics.FillRectangle(whiteBrush, boxleft);
                    e.Graphics.FillRectangle(whiteBrush, boxright);
                    e.Graphics.FillRectangle(transparentBrush, player);

                    playerHPvalue = playerHP * 3;
                    hpLabel.Visible = true;
                    playerHPbar = new Rectangle(175, 580, playerHPvalue, 20);
                    playerHPbarBG = new Rectangle(175, 580, 300, 20);
                    e.Graphics.FillRectangle(grayBrush, playerHPbarBG);
                    e.Graphics.FillRectangle(whiteBrush, playerHPbar);

                    if (countDown > 90)
                    {
                        for (int i = 0; i < gimmick1aListL.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1aListL[i]);
                        }

                        for (int i = 0; i < gimmick1bListL.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1bListL[i]);
                        }

                        for (int i = 0; i < gimmick1aListR.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1aListR[i]);
                        }

                        for (int i = 0; i < gimmick1bListR.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1bListR[i]);
                        }
                    }
                    else if (countDown > 80)
                    {
                        e.Graphics.FillEllipse(whiteBrush, gimmick2ball1);
                        e.Graphics.FillEllipse(whiteBrush, gimmick2ball2);
                        e.Graphics.FillEllipse(whiteBrush, gimmick2ball3);
                    }
                    else if (countDown > 70)
                    {
                        for (int i = 0; i < gimmick3aList.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick3aList[i]);
                        }

                        for (int i = 0; i < gimmick3bList.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick3bList[i]);
                        }
                    }
                    else if (countDown > 60)
                    {
                        if (gimmick4count < 100)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineB);
                        }
                        else if (gimmick4count < 110)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4B);
                        }
                        else if (gimmick4count < 210)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineR);
                        }
                        else if (gimmick4count < 220)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4R);
                        }
                        else if (gimmick4count < 320)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineT);
                            e.Graphics.FillRectangle(redBrush, gimmick4lineL);
                        }
                        else if (gimmick4count < 330)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4T);
                            e.Graphics.FillRectangle(whiteBrush, gimmick4L);
                        }
                        else if (gimmick4count < 430)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineB);
                            e.Graphics.FillRectangle(redBrush, gimmick4lineL);
                            e.Graphics.FillRectangle(redBrush, gimmick4lineT);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4B);
                            e.Graphics.FillRectangle(whiteBrush, gimmick4L);
                            e.Graphics.FillRectangle(whiteBrush, gimmick4T);
                        }
                    }
                    else if (countDown > 50)
                    {
                        for (int i = 0; i < gimmick5aList.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick5aList[i]);
                        }
                        for (int i = 0; i < gimmick5bList.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick5bList[i]);
                        }
                        for (int i = 0; i < gimmick5cList.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick5cList[i]);
                        }
                        for (int i = 0; i < gimmick5dList.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick5dList[i]);
                        }
                    }
                    else if (countDown > 40)
                    {
                        if (gimmick6count < 75)
                        {
                            e.Graphics.DrawArc(whitePen, gimmick6aLocation, gimmick6aLocation, gimmick6aSize, gimmick6aSize, -10, 310);
                        }
                        else if (gimmick6count < 150)
                        {
                            e.Graphics.DrawArc(whitePen, gimmick6bLocation, gimmick6bLocation, gimmick6bSize, gimmick6bSize, -70, 310);
                        }
                        else if (gimmick6count < 225)
                        {
                            e.Graphics.DrawArc(whitePen, gimmick6cLocation, gimmick6cLocation, gimmick6cSize, gimmick6cSize, -120, 310);
                        }

                        if (countDown == 49)
                        {
                            e.Graphics.FillRectangle(transparentBrush, gimmick6areaa);
                        }
                        else if (countDown == 46)
                        {
                            e.Graphics.FillRectangle(transparentBrush, gimmick6areab);
                        }
                        else if (countDown == 42)
                        {
                            e.Graphics.FillRectangle(transparentBrush, gimmick6areac);
                        }
                    }
                    else if (countDown > 30)
                    {
                        Rectangle gimmick7 = new Rectangle(-rx / 2, -ry / 2, rx, ry);
                        Graphics g = e.Graphics;
                        g.RotateTransform(angle1, MatrixOrder.Append);
                        g.TranslateTransform(cx, cy, MatrixOrder.Append);
                        g.FillRectangle(whiteBrush, gimmick7);
                        g.ResetTransform();
                        g.RotateTransform(angle2, MatrixOrder.Append);
                        g.TranslateTransform(cx, cy, MatrixOrder.Append);
                        g.FillRectangle(whiteBrush, gimmick7);
                        g.ResetTransform();

                        Rectangle gimmick7systema = new Rectangle(gimmick7systemaX, gimmick7systemaY, 25, 25);
                        Rectangle gimmick7systemb = new Rectangle(gimmick7systembX, gimmick7systembY, 25, 25);
                        Rectangle gimmick7systemc = new Rectangle(gimmick7systemcX, gimmick7systemcY, 25, 25);
                        Rectangle gimmick7systemd = new Rectangle(gimmick7systemdX, gimmick7systemdY, 25, 25);
                        g.FillRectangle(transparentBrush, gimmick7systema);
                        g.FillRectangle(transparentBrush, gimmick7systemb);
                        g.FillRectangle(transparentBrush, gimmick7systemc);
                        g.FillRectangle(transparentBrush, gimmick7systemd);
                        gimmick7Timer.Enabled = true;
                    }
                    else if (countDown > 20)
                    {
                        Rectangle gimmick8a = new Rectangle(gimmick8aX, gimmick8aY, gimmick8Size, gimmick8Size);
                        Rectangle gimmick8b = new Rectangle(gimmick8bX, gimmick8bY, gimmick8Size, gimmick8Size);
                        Rectangle gimmick8c = new Rectangle(gimmick8cX, gimmick8cY, gimmick8Size, gimmick8Size);
                        Rectangle gimmick8d = new Rectangle(gimmick8dX, gimmick8dY, gimmick8Size, gimmick8Size);
                        e.Graphics.FillRectangle(whiteBrush, gimmick8a);
                        e.Graphics.FillRectangle(whiteBrush, gimmick8b);
                        e.Graphics.FillRectangle(whiteBrush, gimmick8c);
                        e.Graphics.FillRectangle(whiteBrush, gimmick8d);
                    }
                    else if (countDown > 10)
                    {
                        if (gimmick9count < 90)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineL);
                        }
                        else if (gimmick9count < 100)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4L);
                            if (player.IntersectsWith(gimmick4L))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                        else if (gimmick9count < 200)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineB);
                        }
                        else if (gimmick9count < 210)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4B);
                            if (player.IntersectsWith(gimmick4B))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                        else if (gimmick9count < 310)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineL);
                            e.Graphics.FillRectangle(redBrush, gimmick4lineR);
                        }
                        else if (gimmick9count < 320)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4L);
                            e.Graphics.FillRectangle(whiteBrush, gimmick4R);
                            if (player.IntersectsWith(gimmick4L))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                            if (player.IntersectsWith(gimmick4R))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                        else if (gimmick9count < 420)
                        {
                            e.Graphics.FillRectangle(redBrush, gimmick4lineT);
                            e.Graphics.FillRectangle(redBrush, gimmick4lineR);
                            e.Graphics.FillRectangle(redBrush, gimmick4lineL);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick4T);
                            e.Graphics.FillRectangle(whiteBrush, gimmick4R);
                            e.Graphics.FillRectangle(whiteBrush, gimmick4L);
                            if (player.IntersectsWith(gimmick4T))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                            if (player.IntersectsWith(gimmick4L))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                            if (player.IntersectsWith(gimmick4R))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                    }
                    else if (countDown > 0)
                    {
                        for (int i = 0; i < gimmick1aListL.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1aListL[i]);
                        }

                        for (int i = 0; i < gimmick1bListL.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1bListL[i]);
                        }

                        for (int i = 0; i < gimmick1aListR.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1aListR[i]);
                        }

                        for (int i = 0; i < gimmick1bListR.Count; i++)
                        {
                            e.Graphics.FillRectangle(whiteBrush, gimmick1bListR[i]);
                        }
                    }
                    else if (countDown == 0)
                    {
                        playerPic.Location = new Point(280, 447);
                        playerPic.Size = new Size(45, 24);
                    }

                    break;

                case "reset":
                    break;

                case "gameover":
                    e.Graphics.FillRectangle(whiteBrush, boxbottom);
                    e.Graphics.FillRectangle(whiteBrush, boxtop);
                    e.Graphics.FillRectangle(whiteBrush, boxleft);
                    e.Graphics.FillRectangle(whiteBrush, boxright);
                    e.Graphics.FillRectangle(transparentBrush, player);
                    playerHPbar = new Rectangle(175, 580, 0, 20);
                    playerHPbarBG = new Rectangle(175, 580, 300, 20);
                    e.Graphics.FillRectangle(grayBrush, playerHPbarBG);
                    e.Graphics.FillRectangle(whiteBrush, playerHPbar);
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    MoveRight= true;
                    break;
                case Keys.A:
                    MoveLeft = true;
                    break;
                case Keys.W:
                    MoveUp = true;
                    break;
                case Keys.S:
                    MoveDown = true;
                    break;
                case Keys.Space:
                    Jump = true;
                    Start = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    MoveRight = false;
                    break;
                case Keys.A:
                    MoveLeft = false;
                    break;
                case Keys.W:
                    MoveUp = false;
                    break;
                case Keys.S:
                    MoveDown = false;
                    break;
                case Keys.Space:
                    Jump = false; 
                    Start = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            switch (game)
            {
                case "start":
                    //Music
                    location = "bottom";
                    player.Location = new Point(280, 447);
                    menu.controls.play();

                    startcount++;
                    countDownLabel.Visible = true;
                    countDownLabel.Text = "";
                    playerPic.BackgroundImage = Properties.Resources.character_B;
                    playerPic.Visible = true;
                    gameMenuPIc.Visible = true;
                    if (startcount % 20 == 1)
                    {
                        menuLabel.Visible = false;
                        Refresh();
                        Thread.Sleep(100);
                    }
                    else
                    {
                        menuLabel.Visible = true;
                    }

                    if (Start == true)
                    {
                        menu.controls.stop();
                        selectSound.Play();
                        gameMenuPIc.Visible = false;
                        menuLabel.Visible = false;
                        hpLabel.Visible = true;
                        game = "startpre";
                    }
                    break;

                case "startpre":

                    startCountDonwLabel.Visible = true;
                    startCountDonwLabel.Text = "3";
                    Refresh();
                    Thread.Sleep(1000);
                    startCountDonwLabel.Visible = true;
                    startCountDonwLabel.Text = "2";
                    Refresh();
                    Thread.Sleep(1000);
                    startCountDonwLabel.Visible = true;
                    startCountDonwLabel.Text = "1";
                    Refresh();
                    Thread.Sleep(1000);
                    startCountDonwLabel.Visible = false;
                    game = "playing";
                    break;

                case "test":
                    if (location == "bottom")
                    {
                        if (MoveRight == true && player.X <= 425)
                        {
                            int X = playerPic.Location.X + playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_B;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                            }
                        }

                        if (player.IntersectsWith(boxright))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_R;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(447, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(447, 425);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "right";
                        }

                        if (MoveLeft == true && player.X >= 130)
                        {
                            int X = playerPic.Location.X - playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_B;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                            }
                        }

                        else if (player.IntersectsWith(boxleft))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_L;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(130, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(130, 425);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "left";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.Y == 447)
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                                playerPic.Top -= jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }

                    else if (location == "top")
                    {
                        if (MoveRight == true && player.X <= 425)
                        {
                            int X = playerPic.Location.X + playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_T;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_T;
                            }
                        }

                        if (player.IntersectsWith(boxright))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_R;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(447, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(447, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "right";
                        }

                        if (MoveLeft == true && player.X >= 130)
                        {
                            int X = playerPic.Location.X - playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_T;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_T;
                            }
                        }

                        else if (player.IntersectsWith(boxleft))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_L;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(130, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(130, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "left";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.Y == 130)
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                                playerPic.Top += jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }

                    else if (location == "right")
                    {
                        if (MoveUp == true && playerPic.Location.Y >= 130)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y - playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_R;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                            }
                        }

                        if (player.IntersectsWith(boxtop))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_T;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 130);
                            }
                            else
                            {
                                playerPic.Location = new Point(425, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "top";
                        }

                        if (MoveDown == true && playerPic.Location.Y <= 425)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y + playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_R;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                            }
                        }

                        else if (player.IntersectsWith(boxbottom))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_B;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 447);
                            }
                            else
                            {
                                playerPic.Location = new Point(425, 447);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "bottom";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.X == 447)
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                                playerPic.Left -= jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }

                    else if (location == "left")
                    {
                        if (MoveUp == true && playerPic.Location.Y >= 130)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y - playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_L;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_L;
                            }
                        }

                        if (player.IntersectsWith(boxtop))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_T;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 130);

                            }
                            else
                            {
                                playerPic.Location = new Point(130, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "top";
                        }

                        if (MoveDown == true && playerPic.Location.Y <= 425)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y + playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_L;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_L;
                            }
                        }

                        else if (player.IntersectsWith(boxbottom))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_B;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 447);
                            }
                            else
                            {
                                playerPic.Location = new Point(130, 447);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "bottom";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.X == 130)
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                                playerPic.Left += jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }
                    break;

                case "playing":
                    //Music
                    playing.controls.play();

                    //countdown
                    if (countDown < -1)
                    {
                        countDownTimer.Enabled = false;
                    }
                    else
                    {
                        countDownTimer.Enabled = true;
                    }

                    //Move player
                    if (location == "bottom")
                    {
                        if (MoveRight == true && player.X <= 425)
                        {
                            int X = playerPic.Location.X + playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_B;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                            }
                        }

                        if (player.IntersectsWith(boxright))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_R;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(447, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(447, 425);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "right";
                        }

                        if (MoveLeft == true && player.X >= 130)
                        {
                            int X = playerPic.Location.X - playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_B;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                            }
                        }

                        else if (player.IntersectsWith(boxleft))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_L;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(130, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(130, 425);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "left";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.Y == 447)
                            {
                                jumpSound.Play();
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                                playerPic.Top -= jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }

                    else if (location == "top")
                    {
                        if (MoveRight == true && player.X <= 425)
                        {
                            int X = playerPic.Location.X + playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_T;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_T;
                            }
                        }

                        if (player.IntersectsWith(boxright))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_R;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(447, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(447, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "right";
                        }

                        if (MoveLeft == true && player.X >= 130)
                        {
                            int X = playerPic.Location.X - playerSpeed;
                            int Y = playerPic.Location.Y;
                            playerPic.Location = new Point(X, Y);
                            player.X = playerPic.Location.X;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_T;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_T;
                            }
                        }

                        else if (player.IntersectsWith(boxleft))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_L;
                            Size size = new Size(24, 45);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int Y = player.Y;
                                playerPic.Location = new Point(130, Y);
                            }
                            else
                            {
                                playerPic.Location = new Point(130, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "left";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.Y == 130)
                            {
                                jumpSound.Play();
                                playerPic.BackgroundImage = Properties.Resources.characterjump_B;
                                playerPic.Top += jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }

                    else if (location == "right")
                    {
                        if (MoveUp == true && playerPic.Location.Y >= 130)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y - playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_R;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                            }
                        }

                        if (player.IntersectsWith(boxtop))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_T;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 130);
                            }
                            else
                            {
                                playerPic.Location = new Point(425, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "top";
                        }

                        if (MoveDown == true && playerPic.Location.Y <= 425)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y + playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_R;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                            }
                        }

                        else if (player.IntersectsWith(boxbottom))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_B;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 447);
                            }
                            else
                            {
                                playerPic.Location = new Point(425, 447);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "bottom";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.X == 447)
                            {
                                jumpSound.Play();
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                                playerPic.Left -= jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }

                    else if (location == "left")
                    {
                        if (MoveUp == true && playerPic.Location.Y >= 130)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y - playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterleft_L;
                            }
                            else if (jump == "true")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_L;
                            }
                        }

                        if (player.IntersectsWith(boxtop))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_T;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 130);

                            }
                            else
                            {
                                playerPic.Location = new Point(130, 130);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "top";
                        }

                        if (MoveDown == true && playerPic.Location.Y <= 425)
                        {
                            int X = playerPic.Location.X;
                            int Y = playerPic.Location.Y + playerSpeed;
                            playerPic.Location = new Point(X, Y);
                            player.Y = playerPic.Location.Y;

                            if (jump == "false")
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterright_L;
                            }
                            else if (jump == "true")
                            {
                                jumpSound.Play();
                                playerPic.BackgroundImage = Properties.Resources.characterjump_L;
                            }
                        }

                        else if (player.IntersectsWith(boxbottom))
                        {
                            playerPic.BackgroundImage = Properties.Resources.character_B;
                            Size size = new Size(45, 24);
                            playerPic.Size = size;
                            player.Size = size;
                            if (jump == "true")
                            {
                                int X = player.X;
                                playerPic.Location = new Point(X, 447);
                            }
                            else
                            {
                                playerPic.Location = new Point(130, 447);
                            }
                            player.X = playerPic.Location.X;
                            player.Y = playerPic.Location.Y;
                            location = "bottom";
                        }

                        if (Jump == true)
                        {
                            if (playerPic.Location.X == 130)
                            {
                                playerPic.BackgroundImage = Properties.Resources.characterjump_R;
                                playerPic.Left += jumpHeight;
                                player.X = playerPic.Location.X;
                                player.Y = playerPic.Location.Y;
                                jumpTimer.Enabled = true;
                            }
                        }
                    }

                    //Gimmick
                    if (countDown > 90)
                    {
                        Gimmick = 1;

                        //Gimmick count
                        gimmick1count++;

                        //Gimmick list
                        for (int i = 0; i < gimmick1aListL.Count; i++)
                        {
                            int X = gimmick1aListL[i].X + gimmick1Speed;
                            gimmick1aListL[i] = new Rectangle(X, gimmick1aListL[i].Y, gimmick1aWidth, gimmick1aHeight);

                            if (gimmick1aListL[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1aListL[i].X == this.Width)
                            {
                                gimmick1aListL.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < gimmick1bListL.Count; i++)
                        {
                            int X = gimmick1bListL[i].X + gimmick1Speed;
                            gimmick1bListL[i] = new Rectangle(X, gimmick1bListL[i].Y, gimmick1bWidth, gimmick1bHeight);

                            if (gimmick1bListL[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1bListL[i].X == this.Width)
                            {
                                gimmick1bListL.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < gimmick1aListR.Count; i++)
                        {
                            int X = gimmick1aListR[i].X - gimmick1Speed;
                            gimmick1aListR[i] = new Rectangle(X, gimmick1aListR[i].Y, gimmick1aWidth, gimmick1aHeight);

                            if (gimmick1aListR[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1aListR[i].X == 0)
                            {
                                gimmick1aListR.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < gimmick1bListR.Count; i++)
                        {
                            int X = gimmick1bListR[i].X - gimmick1Speed;
                            gimmick1bListR[i] = new Rectangle(X, gimmick1bListR[i].Y, gimmick1bWidth, gimmick1bHeight);

                            if (gimmick1bListR[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1bListR[i].X == 0)
                            {
                                gimmick1bListR.RemoveAt(i);
                            }
                        }

                        //Add new object to gimmick list
                        if (gimmick1count % 20 == 1)
                        {
                            Rectangle gimmick1_aL = new Rectangle(0, 420, gimmick1aWidth, gimmick1aHeight);
                            gimmick1aListL.Add(gimmick1_aL);
                            Rectangle gimmick1_bL = new Rectangle(0, 125, gimmick1bWidth, gimmick1bHeight);
                            gimmick1bListL.Add(gimmick1_bL);
                            Rectangle gimmick1_aR = new Rectangle(600, 420, gimmick1aWidth, gimmick1aHeight);
                            gimmick1aListR.Add(gimmick1_aR);
                            Rectangle gimmick1_bR = new Rectangle(600, 125, gimmick1bWidth, gimmick1bHeight);
                            gimmick1bListR.Add(gimmick1_bR);
                        }
                    }
                    else if (countDown > 80)
                    {
                        Gimmick = 2;
                        //Reset Gimmick1
                        if (countDown == 90)
                        {
                            gimmick1count = 0;
                            gimmick1aListL.Clear();
                            gimmick1bListL.Clear();
                            gimmick1aListR.Clear();
                            gimmick1bListR.Clear();
                        }

                        //limit the ball move
                        if (gimmick2ball1.X >= 130 && gimmick2ball1.X <= 445)
                        {
                            gimmick2ball1.X += ball1SpeedX;
                        }
                        if (gimmick2ball1.Y >= 130 && gimmick2ball1.Y <= 445)
                        {
                            gimmick2ball1.Y += ball1SpeedY;
                        }
                        if (gimmick2ball2.X >= 130 && gimmick2ball2.X <= 445)
                        {
                            gimmick2ball2.X += ball2SpeedX;
                        }
                        if (gimmick2ball2.Y >= 130 && gimmick2ball2.Y <= 445)
                        {
                            gimmick2ball2.Y += ball2SpeedY;
                        }
                        if (gimmick2ball3.X >= 130 && gimmick2ball3.X <= 445)
                        {
                            gimmick2ball3.X += ball3SpeedX;
                        }
                        if (gimmick2ball3.Y >= 130 && gimmick2ball3.Y <= 445)
                        {
                            gimmick2ball3.Y += ball3SpeedY;
                        }

                        //if ball1 intersects with wall
                        if (gimmick2ball1.IntersectsWith(boxright))
                        {
                            gimmick2.Play();
                            ball1SpeedX *= -1;
                            gimmick2ball1.X -= boxright.Width;
                        }
                        else if (gimmick2ball1.IntersectsWith(boxleft))
                        {
                            gimmick2.Play();
                            ball1SpeedX *= -1;
                            gimmick2ball1.X += boxleft.Width;
                        }
                        else if (gimmick2ball1.IntersectsWith(boxbottom))
                        {
                            gimmick2.Play();
                            ball1SpeedY *= -1;
                            gimmick2ball1.Y -= boxbottom.Height;
                        }
                        else if (gimmick2ball1.IntersectsWith(boxtop))
                        {
                            gimmick2.Play();
                            ball1SpeedY *= -1;
                            gimmick2ball1.Y += boxbottom.Height;
                        }

                        //if ball2 intersect with wall
                        if (gimmick2ball2.IntersectsWith(boxright))
                        {
                            gimmick2.Play();
                            ball2SpeedX *= -1;
                            gimmick2ball2.X -= boxright.Width;
                        }
                        else if (gimmick2ball2.IntersectsWith(boxleft))
                        {
                            gimmick2.Play();
                            ball2SpeedX *= -1;
                            gimmick2ball2.X += boxleft.Width;
                        }
                        else if (gimmick2ball2.IntersectsWith(boxbottom))
                        {
                            gimmick2.Play();
                            ball2SpeedY *= -1;
                            gimmick2ball2.Y -= boxbottom.Height;
                        }
                        else if (gimmick2ball2.IntersectsWith(boxtop))
                        {
                            gimmick2.Play();
                            ball2SpeedY *= -1;
                            gimmick2ball2.Y += boxbottom.Height;
                        }

                        //if ball3 intersect with wall
                        if (gimmick2ball3.IntersectsWith(boxright))
                        {
                            gimmick2.Play();
                            ball3SpeedX *= -1;
                            gimmick2ball3.X -= boxright.Width;
                        }
                        else if (gimmick2ball3.IntersectsWith(boxleft))
                        {
                            gimmick2.Play();
                            ball3SpeedX *= -1;
                            gimmick2ball3.X += boxleft.Width;
                        }
                        else if (gimmick2ball3.IntersectsWith(boxbottom))
                        {
                            gimmick2.Play();
                            ball3SpeedY *= -1;
                            gimmick2ball3.Y -= boxbottom.Height;
                        }
                        else if (gimmick2ball3.IntersectsWith(boxtop))
                        {
                            gimmick2.Play();
                            ball3SpeedY *= -1;
                            gimmick2ball3.Y += boxbottom.Height;
                        }

                        //if ball intersect with player
                        if (player.IntersectsWith(gimmick2ball1) || player.IntersectsWith(gimmick2ball2) || player.IntersectsWith(gimmick2ball3))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                    }
                    else if (countDown > 70)
                    {
                        Gimmick = 3;

                        //Reset gimmick 2
                        ball1SpeedX = 20;
                        ball1SpeedY = 10;
                        ball2SpeedX = 10;
                        ball2SpeedY = 5;
                        ball3SpeedX = -15;
                        ball3SpeedY = 10;
                        gimmick2ball1.Location = new Point(280,280);
                        gimmick2ball2.Location = new Point(280, 280);
                        gimmick2ball3.Location = new Point(280, 280);

                        //Gimmick count
                        gimmick3counta++;
                        gimmick3countb++;

                        //Gimmick list
                        for (int i = 0; i < gimmick3aList.Count; i++)
                        {
                            int X = gimmick3aList[i].X + gimmick3aSpeed;
                            gimmick3aList[i] = new Rectangle(X, gimmick3aList[i].Y, gimmick3aWidth, gimmick3aHeight);

                            if (gimmick3aList[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick3aList[i].X == this.Width)
                            {
                                gimmick3aList.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < gimmick3bList.Count; i++)
                        {
                            int X = gimmick3bList[i].X + gimmick3bSpeed;
                            gimmick3bList[i] = new Rectangle(X, gimmick3bList[i].Y, gimmick3bWidth, gimmick3bHeight);

                            if (gimmick3bList[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick3bList[i].X == 0)
                            {
                                gimmick3bList.RemoveAt(i);
                            }
                        }

                        //Add new object to gimmick list
                        if (gimmick3counta % 20 == 1)
                        {
                            Rectangle gimmick3_a = new Rectangle(0, 420, gimmick3aWidth, gimmick3aHeight);
                            gimmick3aList.Add(gimmick3_a);
                        }

                        if (gimmick3countb % 20 == 1)
                        {
                            Rectangle gimmick3_b = new Rectangle(600, 130, gimmick3bWidth, gimmick3bHeight);
                            gimmick3bList.Add(gimmick3_b);
                        }
                    }
                    else if (countDown > 60)
                    {
                        Gimmick = 4;

                        //Reset gimmick 3
                        if (countDown == 70)
                        {
                            gimmick3aList.Clear();
                            gimmick3bList.Clear();
                        }

                        //Gimmick count
                        gimmick4count += 2.2;

                        //Gimmick system
                        if (gimmick4count > 100 && gimmick4count < 110)
                        {
                            if (player.IntersectsWith(gimmick4B))
                            {
                                playerHP -= damage * 5;
                                damageSound.Play();
                            }
                        }
                        else if (gimmick4count > 210 && gimmick4count < 220)
                        {
                            if (player.IntersectsWith(gimmick4R))
                            {
                                playerHP -= damage * 5;
                                damageSound.Play();
                            }
                        }
                        else if (gimmick4count > 320 && gimmick4count < 330)
                        {
                            if (player.IntersectsWith(gimmick4L) || player.IntersectsWith(gimmick4T))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                        else if (gimmick4count > 430)
                        {
                            if (player.IntersectsWith(gimmick4L) || player.IntersectsWith(gimmick4T) || player.IntersectsWith(gimmick4B))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }

                        //gimmick sound
                        if (countDown == 69)
                        {
                            gimmick4.Play();
                        }

                        else if (countDown == 67)
                        {
                            gimmick4.Play();
                        }

                        else if (countDown == 64)
                        {
                            gimmick4.Play();
                        }

                        else if (countDown == 62)
                        {
                            gimmick4.Play();
                        }


                    }
                    else if (countDown > 50)
                    {
                        Gimmick = 5;

                        //Reset gimmick4
                        if (countDown == 60)
                        {
                            gimmick4count = 0;
                        }

                        //Gimmick count
                        gimmick5counta++;
                        gimmick5countb++;

                        //Gimmick list
                        for (int i = 0; i < gimmick5aList.Count; i++)
                        {
                            int X = gimmick5aList[i].X + gimmick5aSpeed;
                            gimmick5aList[i] = new Rectangle(X, gimmick5aList[i].Y, gimmick5Width, gimmick5Height);

                            if (gimmick5aList[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick5aList[i].X == 0)
                            {
                                gimmick5aList.RemoveAt(i);
                            }
                        }
                        for (int i = 0; i < gimmick5bList.Count; i++)
                        {
                            int X = gimmick5bList[i].X + gimmick5bSpeed;
                            gimmick5bList[i] = new Rectangle(X, gimmick5bList[i].Y, gimmick5Width, gimmick5Height);

                            if (gimmick5bList[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick5bList[i].X == this.Width)
                            {
                                gimmick5bList.RemoveAt(i);
                            }
                        }
                        for (int i = 0; i < gimmick5cList.Count; i++)
                        {
                            int X = gimmick5cList[i].X + gimmick5cSpeed;
                            gimmick5cList[i] = new Rectangle(X, gimmick5cList[i].Y, gimmick5Width, gimmick5Height);

                            if (gimmick5cList[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick5cList[i].X == 0)
                            {
                                gimmick5cList.RemoveAt(i);
                            }
                        }
                        for (int i = 0; i < gimmick5dList.Count; i++)
                        {
                            int X = gimmick5dList[i].X + gimmick5dSpeed;
                            gimmick5dList[i] = new Rectangle(X, gimmick5dList[i].Y, gimmick5Width, gimmick5Height);

                            if (gimmick5dList[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick5dList[i].X == this.Width)
                            {
                                gimmick5dList.RemoveAt(i);
                            }
                        }

                        //Add new object to gimmick list
                        if (gimmick5counta % 25 == 1)
                        {
                            Rectangle gimmick5_a = new Rectangle(600, 130, gimmick5Width, gimmick5Height);
                            gimmick5aList.Add(gimmick5_a);
                            Rectangle gimmick5_c = new Rectangle(600, 300, gimmick5Width, gimmick5Height);
                            gimmick5cList.Add(gimmick5_c);
                        }
                        if (gimmick5countb % 25 == 1)
                        {
                            Rectangle gimmick5_b = new Rectangle(0, 215, gimmick5Width, gimmick5Height);
                            gimmick5bList.Add(gimmick5_b);
                            Rectangle gimmick5_d = new Rectangle(0, 385, gimmick5Width, gimmick5Height);
                            gimmick5bList.Add(gimmick5_d);
                        }
                    }
                    else if (countDown > 40)
                    {
                        Gimmick = 6; 

                        //Reset gimmic5
                        if (countDown == 50)
                        {
                            gimmick5aSpeed = -10;
                            gimmick5bSpeed = 10;
                            gimmick5cSpeed = -10;
                            gimmick5dSpeed = 10;
                            gimmick5counta = 0;
                            gimmick5countb = 10;
                            gimmick5aList.Clear();
                            gimmick5bList.Clear();
                            gimmick5cList.Clear();
                            gimmick5dList.Clear();
                        }

                        //Gimmick count
                        gimmick6count++;
                        gimmick6Timer.Enabled = true;

                        //Gimmick system
                        if (countDown == 49)
                        {
                            if (player.IntersectsWith(gimmick6areaa)) { }
                            else
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                        else if (countDown == 45)
                        {
                            if (player.IntersectsWith(gimmick6areab)) { }
                            else
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                        else if (countDown == 42)
                        {
                            if (player.IntersectsWith(gimmick6areac)) { }
                            else
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }
                        }
                    }
                    else if (countDown > 30)
                    {
                        Gimmick = 7;

                        //Change player speed
                        playerSpeed = 9;

                        //Reset gimmick6
                        if (countDown == 40)
                        {
                            gimmick6Timer.Enabled = false;
                            gimmick6count = 0;
                            gimmick6aSize = 600;
                            gimmick6aLocation = 0;
                            gimmick6bSize = 600;
                            gimmick6bLocation = 0;
                            gimmick6cSize = 600;
                            gimmick6cLocation = 0;
                        }

                        //Gimmick system
                        Rectangle gimmick7systema = new Rectangle(gimmick7systemaX, gimmick7systemaY, 25, 25);
                        Rectangle gimmick7systemb = new Rectangle(gimmick7systembX, gimmick7systembY, 25, 25);
                        Rectangle gimmick7systemc = new Rectangle(gimmick7systemcX, gimmick7systemcY, 25, 25);
                        Rectangle gimmick7systemd = new Rectangle(gimmick7systemdX, gimmick7systemdY, 25, 25);
                        if (player.IntersectsWith(gimmick7systema))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                        else if (player.IntersectsWith(gimmick7systemb))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                        else if (player.IntersectsWith(gimmick7systemc))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                        else if (player.IntersectsWith(gimmick7systemd))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                    }
                    else if (countDown > 20)
                    {
                        Gimmick = 8;

                        //Reset gimmick7
                        if (countDown == 30)
                        {
                            gimmick7Timer.Enabled = false;
                            gimmick7count = 0;
                            playerSpeed = 6;
                            cx = 300;
                            cy = 300;
                            rx = 30;
                            ry = 490;
                            angle1 = 45;
                            angle2 = 135;
                            gimmick7systemaX = 130;
                            gimmick7systemaY = 130;
                            gimmick7systembX = 445;
                            gimmick7systembY = 130;
                            gimmick7systemcX = 445;
                            gimmick7systemcY = 445;
                            gimmick7systemdX = 130;
                            gimmick7systemdY = 445;
                        }                        

                        //Gimmick count
                        gimmick8count += 4;

                        //Gimmick system
                        Rectangle gemic8a = new Rectangle(gimmick8aX, gimmick8aY, gimmick8Size, gimmick8Size);
                        Rectangle gemic8b = new Rectangle(gimmick8bX, gimmick8bY, gimmick8Size, gimmick8Size);
                        Rectangle gemic8c = new Rectangle(gimmick8cX, gimmick8cY, gimmick8Size, gimmick8Size);
                        Rectangle gemic8d = new Rectangle(gimmick8dX, gimmick8dY, gimmick8Size, gimmick8Size);

                        if (gimmick8count <= 86)
                        {
                            gimmick8aX += 12;
                            gimmick8bY += 12;
                            gimmick8cX -= 12;
                            gimmick8dY -= 12;
                        }
                        else if (gimmick8count <= 172)
                        {
                            gimmick8aY += 10;
                            gimmick8bX -= 10;
                            gimmick8cY -= 10;
                            gimmick8dX += 10;
                        }
                        else if (gimmick8count <= 258)
                        {
                            gimmick8aX -= 11;
                            gimmick8bY -= 11;
                            gimmick8cX += 11;
                            gimmick8dY += 11;
                        }
                        else if (gimmick8count <= 344)
                        {
                            gimmick8aY -= 10;
                            gimmick8bX += 10;
                            gimmick8cY += 10;
                            gimmick8dX -= 10;
                        }
                        else if (gimmick8count <= 430)
                        {
                            gimmick8aX += 10;
                            gimmick8bY += 10;
                            gimmick8cX -= 10;
                            gimmick8dY -= 10;
                        }
                        else if (gimmick8count <= 516)
                        {
                            gimmick8aY += 13;
                            gimmick8bX -= 13;
                            gimmick8cY -= 13;
                            gimmick8dX += 13;
                        }
                        else if (gimmick8count <= 516)
                        {
                            gimmick8aX -= 12;
                            gimmick8bY -= 12;
                            gimmick8cX += 12;
                            gimmick8dY += 12;
                        }
                        else if (gimmick8count <= 602)
                        {
                            gimmick8aY -= 13;
                            gimmick8bX += 13;
                            gimmick8cY += 13;
                            gimmick8dX -= 13;
                        }
                        else if (gimmick8count <= 690)
                        {
                            gimmick8aX += 3;
                            gimmick8bY += 3;
                            gimmick8cX -= 3;
                            gimmick8dY -= 3;
                        }
                        else if (gimmick8count <= 776)
                        {
                            gimmick8aY += 13;
                            gimmick8bX -= 13;
                            gimmick8cY -= 13;
                            gimmick8dX += 13;
                        }
                        else if (gimmick8count <= 862)
                        {
                            gimmick8aY += 15;
                            gimmick8bX -= 15;
                            gimmick8cY -= 15;
                            gimmick8dX += 15;
                        }

                        if (player.IntersectsWith(gemic8a))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                        if (player.IntersectsWith(gemic8b))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                        if (player.IntersectsWith(gemic8c))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                        if (player.IntersectsWith(gemic8d))
                        {
                            playerHP -= damage;
                            damageSound.Play();
                        }
                    }
                    else if (countDown > 10)
                    {
                        Gimmick = 9;

                        //Reset gimmic8
                        gimmick8count = 0;
                        gimmick8Size = 30;
                        gimmick8aX = 130;
                        gimmick8aY = 130;
                        gimmick8bX = 440;
                        gimmick8bY = 130;
                        gimmick8cX = 440;
                        gimmick8cY = 440;
                        gimmick8dX = 130;
                        gimmick8dY = 440;

                        //Gimmick count
                        gimmick9count += 2;

                        if (countDown == 19)
                        {
                            gimmick4.Play();
                        }

                        else if (countDown == 17)
                        {
                            gimmick4.Play();
                        }

                        else if (countDown == 14)
                        {
                            gimmick4.Play();
                        }

                        else if (countDown == 12)
                        {
                            gimmick4.Play();
                        }
                    }
                    else if (countDown > 0)
                    {
                        Gimmick = 10;

                        //Reset gimmick9 
                        if (countDown == 10)
                        {
                            gimmick9count = 0;
                        }

                        //Gimmick count
                        gimmick1count++;

                        //Gimmick list
                        for (int i = 0; i < gimmick1aListL.Count; i++)
                        {
                            int X = gimmick1aListL[i].X + gimmick10Speed;
                            gimmick1aListL[i] = new Rectangle(X, gimmick1aListL[i].Y, gimmick1aWidth, gimmick1aHeight);

                            if (gimmick1aListL[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1aListL[i].X == this.Width)
                            {
                                gimmick1aListL.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < gimmick1bListL.Count; i++)
                        {
                            int X = gimmick1bListL[i].X + gimmick10Speed;
                            gimmick1bListL[i] = new Rectangle(X, gimmick1bListL[i].Y, gimmick1bWidth, gimmick1bHeight);

                            if (gimmick1bListL[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1bListL[i].X == this.Width)
                            {
                                gimmick1bListL.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < gimmick1aListR.Count; i++)
                        {
                            int X = gimmick1aListR[i].X - gimmick10Speed;
                            gimmick1aListR[i] = new Rectangle(X, gimmick1aListL[i].Y, gimmick1aWidth, gimmick1aHeight);

                            if (gimmick1aListR[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1aListR[i].X == 0)
                            {
                                gimmick1aListR.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < gimmick1bListR.Count; i++)
                        {
                            int X = gimmick1bListR[i].X - gimmick10Speed;
                            gimmick1bListR[i] = new Rectangle(X, gimmick1bListL[i].Y, gimmick1bWidth, gimmick1bHeight);

                            if (gimmick1bListR[i].IntersectsWith(player))
                            {
                                playerHP -= damage;
                                damageSound.Play();
                            }

                            if (gimmick1bListR[i].X == 0)
                            {
                                gimmick1bListR.RemoveAt(i);
                            }
                        }

                        //Add new object to gimmick list 
                        if (gimmick1count % 20 == 1)
                        {
                            Rectangle gimmick1_aL = new Rectangle(0, 420, gimmick1aWidth, gimmick1aHeight);
                            gimmick1aListL.Add(gimmick1_aL);
                            Rectangle gimmick1_bL = new Rectangle(0, 125, gimmick1bWidth, gimmick1bHeight);
                            gimmick1bListL.Add(gimmick1_bL);
                            Rectangle gimmick1_aR = new Rectangle(600, 420, gimmick1aWidth, gimmick1aHeight);
                            gimmick1aListR.Add(gimmick1_aR);
                            Rectangle gimmick1_bR = new Rectangle(600, 125, gimmick1bWidth, gimmick1bHeight);
                            gimmick1bListR.Add(gimmick1_bR);
                        }
                    }
                    else if (countDown == 0)
                    {
                        //Reset gimmick10
                        gimmick1count = 0;
                        gimmick1aListL.Clear();
                        gimmick1bListL.Clear();
                        gimmick1aListR.Clear();
                        gimmick1bListR.Clear();

                        //Move the box edge away
                        boxtop.Y -= 10;
                        boxright.X += 10;
                        boxleft.X -= 10;

                        playerPic.BackgroundImage = Properties.Resources.character_B;
                    }
                    else if (countDown < 0)
                    {
                        //Music
                        playing.controls.stop();
                        gameclear.controls.play();

                        //Game clear
                        gameResultLabel.Visible = true;
                        gameResultLabel.Text = "Game Clear";
                        characterLabelPic.BackgroundImage = Properties.Resources.characterLabel;
                        characterLabelPic.Visible = true;
                        int X = playerPic.Location.X - 90;
                        int Y = playerPic.Location.Y - 65;
                        characterLabelPic.Location = new Point(X, Y);
                        endLabel.Visible = true;
                        endLabel.Text = "Lock him in a BOX again?";
                        yesButton.Visible = true;
                        yesButton.Enabled = true;
                        noButton.Visible = true;
                        noButton.Enabled = true;
                    }

                    //countDown label system
                    if (countDown > 0)
                    {
                        countDownLabel.Text = $"{countDown}";
                    }
                    else
                    {
                        countDownLabel.Text = "0";
                    }

                    break;

                case "reset":
                    playerHP = 100;
                    countDown = 100;
                    countDownTimer.Enabled = true;
                    hpLabel.Visible = false;
                    countDownLabel.Visible = false;
                    playerPic.Visible = false;
                    characterLabelPic.Visible = false;
                    playerPic.Location = new Point(280, 447);
                    boxtop.Location = new Point(125, 125);
                    boxleft.Location = new Point(125, 125);
                    boxright.Location = new Point(470, 125);
                    game = "start";
                    break;

                case "gameover":
                    gameResultLabel.Visible = true;
                    gameResultLabel.Text = "Game Over";
                    playerPic.BackgroundImage = Properties.Resources.gameover_Character;
                    playerPic.Location = new Point(280, 447);
                    playerPic.Size = new Size(45, 24);
                    characterLabelPic.BackgroundImage = Properties.Resources.gameover_Label;
                    characterLabelPic.Visible = true;
                    int x = playerPic.Location.X - 90;
                    int y = playerPic.Location.Y - 65;
                    characterLabelPic.Location = new Point(x, y);
                    playagainLabel.Visible = true;
                    noButton.Location = new Point(406, 511);
                    yesButton.Location = new Point(300, 511);
                    yesButton.Visible = true;
                    yesButton.Enabled = true;
                    noButton.Visible = true;
                    noButton.Enabled = true;
                    break;
            }

            switch (Gimmick)
            {
                case 1:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick1count = 0;
                        gimmick1aListL.Clear();
                        gimmick1bListL.Clear();
                        gimmick1aListR.Clear();
                        gimmick1bListR.Clear();
                        game = "gameover";
                    }
                    break;
                case 2:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        ball1SpeedX = 20;
                        ball1SpeedY = 10;
                        ball2SpeedX = 10;
                        ball2SpeedY = 5;
                        ball3SpeedX = -15;
                        ball3SpeedY = 10;
                        gimmick2ball1.Location = new Point(280, 280);
                        gimmick2ball2.Location = new Point(280, 280);
                        gimmick2ball3.Location = new Point(280, 280);
                        game = "gameover";
                    }
                    break;
                case 3:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick3aList.Clear();
                        gimmick3bList.Clear();
                        game = "gameover";
                    }
                    break;
                case 4:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick4count = 0;
                        game = "gameover";
                    }
                    break;
                case 5:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick5aSpeed = -10;
                        gimmick5bSpeed = 10;
                        gimmick5cSpeed = -10;
                        gimmick5dSpeed = 10;
                        gimmick5counta = 0;
                        gimmick5countb = 10;
                        gimmick5aList.Clear();
                        gimmick5bList.Clear();
                        gimmick5cList.Clear();
                        gimmick5dList.Clear();
                        game = "gameover";
                    }
                    break;
                case 6:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick6Timer.Enabled = false;
                        gimmick6count = 0;
                        gimmick6aSize = 600;
                        gimmick6aLocation = 0;
                        gimmick6bSize = 600;
                        gimmick6bLocation = 0;
                        gimmick6cSize = 600;
                        gimmick6cLocation = 0;
                        game = "gameover";
                    }
                    break;
                case 7:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick7Timer.Enabled = false;
                        gimmick7count = 0;
                        playerSpeed = 6;
                        cx = 300;
                        cy = 300;
                        rx = 30;
                        ry = 490;
                        angle1 = 45;
                        angle2 = 135;
                        gimmick7systemaX = 130;
                        gimmick7systemaY = 130;
                        gimmick7systembX = 445;
                        gimmick7systembY = 130;
                        gimmick7systemcX = 445;
                        gimmick7systemcY = 445;
                        gimmick7systemdX = 130;
                        gimmick7systemdY = 445;
                        game = "gameover";
                    }
                    break;
                case 8:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick8count = 0;
                        gimmick8Size = 30;
                        gimmick8aX = 130;
                        gimmick8aY = 130;
                        gimmick8bX = 440;
                        gimmick8bY = 130;
                        gimmick8cX = 440;
                        gimmick8cY = 440;
                        gimmick8dX = 130;
                        gimmick8dY = 440;
                        game = "gameover";
                    }
                    break;
                case 9:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick9count = 0;
                        game = "gameover";
                    }
                    break;
                case 10:
                    if (playerHP <= 0)
                    {
                        playing.controls.stop();
                        gameover.controls.play();
                        gimmick1count = 0;
                        gimmick1aListL.Clear();
                        gimmick1bListL.Clear();
                        gimmick1aListR.Clear();
                        gimmick1bListR.Clear();
                        game = "gameover";
                    }
                    break;
            }

            Refresh();
        }

        private void jumpTimer_Tick(object sender, EventArgs e)
        {
            jump = "true";

            if (location == "bottom")
            {
                if (playerPic.Top >= 447)
                {
                    playerPic.BackgroundImage = Properties.Resources.character_B;
                    playerPic.Top = 447;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                    jump = "false";
                    jumpTimer.Enabled = false;
                }

                else
                {
                    playerPic.Top += gravity;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                }
            }

            else if (location == "top")
            {
                if (playerPic.Top <= 130)
                {
                    playerPic.BackgroundImage = Properties.Resources.character_T;
                    playerPic.Top = 130;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                    jump = "false";
                    jumpTimer.Enabled = false;
                }

                else
                {
                    playerPic.Top -= gravity;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                }
            }

            else if (location == "right")
            {
                if (playerPic.Left >= 447)
                {
                    playerPic.BackgroundImage = Properties.Resources.character_R;
                    playerPic.Left = 447;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                    jump = "false";
                    jumpTimer.Enabled = false;
                }
                
                else
                {
                    playerPic.Left += gravity;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                }
            }

            else if (location == "left")
            {
                if (playerPic.Left <= 130)
                {
                    playerPic.BackgroundImage = Properties.Resources.character_L;
                    playerPic.Left = 130;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                    jump = "false";
                    jumpTimer.Enabled = false;
                }

                else
                {
                    playerPic.Left -= gravity;
                    player.X = playerPic.Location.X;
                    player.Y = playerPic.Location.Y;
                }
            }

            Refresh();
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            switch (game)
            {
                case "start":
                    break;
                case "startpre":
                    break;
                case "test":
                    break;
                case "playing":
                    countDown--;
                    break;
                case "reset":
                    break;
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            gameclear.controls.stop();
            gameover.controls.stop();
            selectSound.Play();

            gameResultLabel.Visible = false;
            endLabel.Visible = false;
            playagainLabel.Visible = false;
            yesButton.Visible = false;
            yesButton.Enabled = false;
            noButton.Visible = false;
            noButton.Enabled = false;
            if (game == "playing")
            {
                characterLabelPic.BackgroundImage = Properties.Resources.characterLabel3;
                Refresh();
                Thread.Sleep(2000);
            }
            game = "reset";
            gameTimer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playing.controls.stop();
            gameclear.controls.stop();
            gameover.controls.stop();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            selectSound.Play();

            gameTimer.Enabled = false;
            characterLabelPic.BackgroundImage = Properties.Resources.characterLabel2;
            gameResultLabel.Visible = false;
            endLabel.Visible = false;
            yesButton.Visible = false;
            yesButton.Enabled = false;
            noButton.Visible = false;
            noButton.Enabled = false;
            Refresh();
            Thread.Sleep(3000);
            this.Close();
        }

        private void gimmick6Timer_Tick(object sender, EventArgs e)
        {
            if (gimmick6count < 75)
            {
                gimmick6aSize -= 10;
                gimmick6aLocation += 5;
            }
            else if (gimmick6count < 150)
            {
                gimmick6bSize -= 10;
                gimmick6bLocation += 5;
            }
            else if (gimmick6count < 225)
            {
                gimmick6cSize -= 10;
                gimmick6cLocation += 5;
            }
            Refresh();
        }

        private void gimmick7Timer_Tick(object sender, EventArgs e)
        {
            gimmick7count++;

            if (gimmick7count <= 180)
            {
                angle1 += 2;
                angle2 += 2;
                Invalidate();
            }

            else if (gimmick7count <= 360)
            {
                angle1 -= 2;
                angle2 -= 2;
                Invalidate();
            }

            Rectangle gemic7systema = new Rectangle(gimmick7systemaX, gimmick7systemaY, 25, 25);
            Rectangle gemic7systemb = new Rectangle(gimmick7systembX, gimmick7systembY, 25, 25);
            Rectangle gemic7systemc = new Rectangle(gimmick7systemcX, gimmick7systemcY, 25, 25);
            Rectangle gemic7systemd = new Rectangle(gimmick7systemdX, gimmick7systemdY, 25, 25);

            if (gimmick7count <= 45)
            {
                gimmick7systemaX += 7;
                gimmick7systembY += 7;
                gimmick7systemcX -= 7;
                gimmick7systemdY -= 7;
            }
            else if (gimmick7count <= 90)
            {
                gimmick7systemaY += 7;
                gimmick7systembX -= 7;
                gimmick7systemcY -= 7;
                gimmick7systemdX += 7;
            }
            else if (gimmick7count <= 135)
            {
                gimmick7systemaX -= 7;
                gimmick7systembY -= 7;
                gimmick7systemcX += 7;
                gimmick7systemdY += 7;
            }
            else if (gimmick7count <= 180)
            {
                gimmick7systemaY -= 7;
                gimmick7systembX += 7;
                gimmick7systemcY += 7;
                gimmick7systemdX -= 7;
            }
            else if (gimmick7count <= 225)
            {
                gimmick7systemaY += 7;
                gimmick7systembX -= 7;
                gimmick7systemcY -= 7;
                gimmick7systemdX += 7;
            }
            else if (gimmick7count <= 270)
            {
                gimmick7systemaX += 7;
                gimmick7systembY += 7;
                gimmick7systemcX -= 7;
                gimmick7systemdY -= 7;
            }
            else if (gimmick7count <= 315)
            {
                gimmick7systemaY -= 7;
                gimmick7systembX += 7;
                gimmick7systemcY += 7;
                gimmick7systemdX -= 7;
            }
            else if (gimmick7count <= 360)
            {
                gimmick7systemaX -= 7;
                gimmick7systembY -= 7;
                gimmick7systemcX += 7;
                gimmick7systemdY += 7;
            }
        }
        public class HighScore
        {
            public string name;
            public int score;

            public HighScore(string _name, int _score)
            {
                name = _name;
                score = _score;
            }
        }
    }
}
