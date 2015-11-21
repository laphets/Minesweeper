using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form_Main : Form
    {
        const int MAX_WIDTH = 64;
        const int MAX_HEIGHT = 32;

        int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
        int[] dy = new int[] { 1, 1, 1, 0, 0, -1, -1, -1 };

        int[] px = new int[] { 1, -1, 0, 0 };
        int[] py = new int[] { 0, 0, 1, -1 };

        int[,] pMine = new int[MAX_WIDTH, MAX_HEIGHT];
        int[,] pState = new int[MAX_WIDTH, MAX_HEIGHT];

        public int nWidth, nHeight, nMineCnt;
        bool bMark, bAudio;

        bool bMouseLeft;
        bool bMouseRight;

        bool bGame;

        Point MouseFocus;

        public Form_Main()
        {
            InitializeComponent();

            //双缓冲
            this.DoubleBuffered = true;

            //初始化
            nWidth = Properties.Settings.Default.Width;
            nHeight = Properties.Settings.Default.Height;
            nMineCnt = Properties.Settings.Default.MineCnt;

            bMark = Properties.Settings.Default.Mark;
            bAudio = Properties.Settings.Default.Audio;

            UpdateSize();
            SelectLevel();
        }

        /// <summary>
        /// 自动更新窗口大小
        /// </summary>
        private void UpdateSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width;
            int nOffsetY = this.Height - this.ClientSize.Height;
            int nAdditionY = MenuStrip_Main.Height + TableLayoutPanel_Main.Height;
            this.Width = 12 + 34 * nWidth + nOffsetX;
            this.Height = 12 + 34 * nHeight + nAdditionY + nOffsetY;
            //PaintGame();
            newGameNToolStripMenuItem_Click(new object(), new EventArgs());
            this.Refresh();
        }

        private void SelectLevel()
        {
            if(nWidth==10&&nHeight==10&&nMineCnt==10)
            {
                beginnerBToolStripMenuItem.Checked = true;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = false;
                设置sToolStripMenuItem.Checked = false;
            }
            else if(nWidth==16&&nHeight==16&&nMineCnt==40)
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = true;
                expertEToolStripMenuItem.Checked = false;
                设置sToolStripMenuItem.Checked = false;
            }
            else if(nWidth==30&&nHeight==16&&nMineCnt==99)
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = true;
                设置sToolStripMenuItem.Checked = false;
            }
            else
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = false;
                设置sToolStripMenuItem.Checked = true;
            }
        }

        /// <summary>
        /// dfs
        /// </summary>
        /// <param name="sx">横坐标</param>
        /// <param name="sy">纵坐标</param>
        private void dfs(int sx,int sy)
        {
            pState[sx, sy] = 1;     //访问当前点
            for(int i=0;i<4;i++)
            {
                int x = sx + px[i];
                int y = sy + py[i];
                if (x < 1 || x > nWidth || y < 1 || y > nHeight)
                    continue;
                if (pMine[x, y] != -1 && pMine[sx, sy] == 0 && (pState[x, y] == 0 || pState[x, y] == 3))
                    dfs(x, y);
            }
        }

        /// <summary>
        /// 参数设置
        /// </summary>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="cnt">地雷数目</param>
        private void SetGame(int width,int height,int cnt)
        {
            nWidth = width;
            nHeight = height;
            nMineCnt = cnt;
            UpdateSize();
        }

        /// <summary>
        /// 初级
        /// </summary>
        private void SetGameBeginner()
        {
            SetGame(10, 10, 10);
        }
        /// <summary>
        /// 中级
        /// </summary>
        private void SetGameIntermediate()
        {
            SetGame(16, 16, 40);
        }
        /// <summary>
        /// 高级
        /// </summary>
        private void SetGameExpert()
        {
            SetGame(30, 16, 99);
        }
        /// <summary>
        /// 系统关于对话框
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="szApp">标题文本</param>
        /// <param name="szOtherStuff">内容文本</param>
        /// <param name="hIcon">图标句柄</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        public extern static int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //memset
            Array.Clear(pMine, 0, pMine.Length);
            Array.Clear(pState, 0, pState.Length);

            //重置高亮点
            MouseFocus.X = 0;
            MouseFocus.Y = 0;

            //显示地雷数目
            Label_Mine.Text = nMineCnt.ToString();

            //计时器清零并启动
            Label_Timer.Text = "0";
            Timer_Main.Enabled = true;

            //初始化游戏结束标志
            bGame = false;

            //初始化Mine
            Random Rand = new Random();
            for(int i=1;i<=nMineCnt;)
            {
                //随机产生Mine坐标(x,y)
                int x = Rand.Next(nWidth) + 1;
                int y = Rand.Next(nHeight) + 1;
                if(pMine[x,y]!=-1)
                {
                    pMine[x, y] = -1;
                    i++;
                }
            }
            for(int i=1;i<=nWidth;i++)
                for(int j=1;j<=nHeight;j++)
                    if(pMine[i,j]!=-1)      //不是Mine，显示周围Mine数
                    {
                        for (int d = 0; d < 8; d++)
                            if (pMine[i + dx[d], j + dy[d]] == -1)
                                pMine[i, j]++;
                    }
        }

        private void 初级ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 设置sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting Setting = new Form_Setting(this);      //本身传参
            Setting.ShowDialog();
            UpdateSize();
        }

        private void 标记MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            标记MToolStripMenuItem.Checked = bMark = !bMark;
        }

        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            PaintGame(e.Graphics);
        }
        private void PaintGame(Graphics g)
        {
            g.Clear(Color.White);
            //Graphics g = this.CreateGraphics();   //  绘图句柄
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));
            int nOffsetX = 6;   //x偏移量
            int nOffsetY = MenuStrip_Main.Height + 6;   //y偏移量
            for (int i = 1; i <= nWidth; i++)
                for (int j = 1; j <= nHeight; j++)
                {
                    if(pState[i,j]!=1)       //未点开
                    {
                        if (i == MouseFocus.X && j == MouseFocus.Y)
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SandyBrown)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        else
                            g.FillRectangle(Brushes.SandyBrown, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        //绘制标记
                        if (pState[i, j] == 2)
                            g.DrawImage(Properties.Resources.flag, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);  //绘制红旗
                        if (pState[i, j] == 3)
                            g.DrawImage(Properties.Resources.doubt, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);  //绘制问号

                    }
                    else if(pState[i,j]==1)     //点开
                    {
                        //绘制背景
                        if (i == MouseFocus.X && j == MouseFocus.Y)
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.LightGray)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        else
                            g.FillRectangle(Brushes.LightGray, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        //绘制数字
                        if (pMine[i,j]>0)
                        {
                                Brush DrawBrush = new SolidBrush(Color.Blue);
                                //各个数目的颜色
                                if (pMine[i, j] == 2)
                                    DrawBrush = new SolidBrush(Color.Green);
                                if (pMine[i, j] == 3)
                                    DrawBrush = new SolidBrush(Color.Red);
                                if (pMine[i, j] == 4)
                                    DrawBrush = new SolidBrush(Color.DarkBlue);
                                if (pMine[i, j] == 5)
                                    DrawBrush = new SolidBrush(Color.DarkRed);
                                if (pMine[i, j] == 6)
                                    DrawBrush = new SolidBrush(Color.DarkSeaGreen);
                                if (pMine[i, j] == 7)
                                    DrawBrush = new SolidBrush(Color.Black);
                                if (pMine[i, j] == 8)
                                    DrawBrush = new SolidBrush(Color.DarkGray);
                                SizeF Size = g.MeasureString(pMine[i, j].ToString(), new Font("Consolas", 16));
                                g.DrawString(pMine[i, j].ToString(), new Font("Consolas", 16), DrawBrush, nOffsetX + 34 * (i - 1) + 1 + (32 - Size.Width) / 2, nOffsetY + 34 * (j - 1) + 1 + (32 - Size.Height) / 2);
                        }
                        //绘制地雷
                        if (pMine[i, j] == -1)
                            g.DrawImage(Properties.Resources.mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);
                    }
                }
        }
        private void beginnerBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 10; nHeight = 10; nMineCnt = 10;
            SelectLevel();
            UpdateSize();
        }

        private void intermediateIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 16;nHeight = 16;nMineCnt = 40;
            SelectLevel();
            UpdateSize();
        }

        private void expertEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 30;nHeight = 16;nMineCnt = 99;
            SelectLevel();
            UpdateSize();
        }

        private void 音效ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            音效ToolStripMenuItem.Checked = bAudio = !bAudio;
        }

        private void rankRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Rank Rank = new Form_Rank();
            Rank.ShowDialog();
        }

        private void Form_Main_MouseMove(object sender, MouseEventArgs e)
        {
            //判断是否在区域内
            if(e.X<6||e.X>6+nWidth*34||e.Y<6+MenuStrip_Main.Height||e.Y>6+MenuStrip_Main.Height+nHeight*34)
            {
                MouseFocus.X = 0;
                MouseFocus.Y = 0;
            }
            else
            {
                //get the position of x,y
                int x = (e.X - 6) / 34 + 1;
                int y = (e.Y - MenuStrip_Main.Height - 6) / 34 + 1;
                MouseFocus.X = x;
                MouseFocus.Y = y;
            }
            //PaintGame();
            this.Refresh();
        }

        private void Timer_Main_Tick(object sender, EventArgs e)
        {
            //自增1秒
            Label_Timer.Text = Convert.ToString(Convert.ToInt32(Label_Timer.Text) + 1);
        }

        private void Form_Main_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标左键被按下
            if (e.Button == MouseButtons.Left)
                bMouseLeft = true;
            //鼠标右键被按下
            if (e.Button == MouseButtons.Right)
                bMouseRight = true;
        }
        
        private void GameLost()
        {
            for(int i=1;i<=nWidth;i++)
                for(int j=1;j<=nHeight;j++)
                {
                    if (pMine[i, j] == -1 && (pState[i, j] == 0 || pState[i, j] == 3))  //未点开或者标记为问号
                        pState[i, j] = 1;       //点开
                }
            Timer_Main.Enabled = false; //关闭计时器
            MessageBox.Show(String.Format("你输啦！耗时： {0} 秒", Label_Timer.Text), "提示", MessageBoxButtons.OK);
            bGame = true;
        }

        private bool OpenMine(int sx,int sy)
        {
            bool bFlag = true;
            for(int i=0;i<8;i++)
            {
                //获取偏移量
                int x = MouseFocus.X + dx[i];
                int y = MouseFocus.Y + dy[i];
                if (x < 1 || x > nWidth || y < 1 || y > nHeight)
                    continue;
                if(pState[x,y]==0)  //问号
                {
                    pState[x, y] = 1;   //打开
                    if (pMine[x, y] != -1)
                        dfs(x, y);
                    else  //有雷
                    {
                        bFlag = false;
                        break;
                    }
                }
            }
            return bFlag;
        }

        private void GameWin()
        {

            int nCnt = 0;   //红旗数目、问号数目、以及无标记未点开区域总数
            for(int i=1;i<=nWidth;i++)
                for(int j=1;j<=nHeight;j++)
                {
                    if (pState[i, j] == 0 || pState[i, j] == 2 || pState[i, j] == 3)
                        nCnt++;
                }
            if(nCnt==nMineCnt)
            {
                Timer_Main.Enabled = false; //关闭计时器
                MessageBox.Show(String.Format("你赢啦！耗时： {0} 秒", Label_Timer.Text), "提示", MessageBoxButtons.OK);
                
                //更新记录
                if(nWidth ==10&&nHeight ==10&&nMineCnt ==10)    //初级
                {
                    if(Properties.Settings.Default.Beginner>Convert.ToInt32(Label_Timer.Text))
                    {
                        Properties.Settings.Default.Beginner = Convert.ToInt32(Label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                else if(nWidth==16&&nHeight==16&&nMineCnt==40)  //中级
                {
                    if(Properties.Settings.Default.Intermediate > Convert.ToInt32(Label_Timer.Text))
                    {
                        Properties.Settings.Default.Intermediate = Convert.ToInt32(Label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                else if(nWidth==30&&nHeight==16&&nMineCnt==99)  //高级
                {
                    if(Properties.Settings.Default.Expert>Convert.ToInt32(Label_Timer.Text))
                    {
                        Properties.Settings.Default.Expert = Convert.ToInt32(Label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                bGame = true;
            }
        }
        
        private void Form_Main_MouseUp(object sender, MouseEventArgs e)
        {
            //不在区域内或游戏结束
            if (MouseFocus.X == 0 && MouseFocus.Y == 0 || bGame)
                return;
            if(bMouseLeft&&bMouseRight)     //左右键同时按下
            {
                if(pState[MouseFocus.X,MouseFocus.Y]==1&&pMine[MouseFocus.X,MouseFocus.Y]>0)    //数字区域
                {
                    int nFlagCnt = 0, nDoubtCnt = 0, nSysCnt = pMine[MouseFocus.X, MouseFocus.Y];   //红旗数目，问号数目，地雷数目
                    for(int i=0;i<8;i++)
                    {
                        //获取偏移量
                        int x = MouseFocus.X + dx[i];
                        int y = MouseFocus.Y + dy[i];
                        if (x < 1 || x > nWidth || y < 1 || y > nHeight)
                            continue;
                        if (pState[x, y] == 2)      //红旗
                            nFlagCnt++;
                        if (pState[x, y] == 3)  //问号
                            nDoubtCnt++;
                    }
                    if (nFlagCnt == nSysCnt || nFlagCnt + nDoubtCnt == nSysCnt)  //打开九宫格
                    {
                        bool bFlag = OpenMine(MouseFocus.X, MouseFocus.Y);
                        if (!bFlag)  //周围有地雷
                        {
                            //结束游戏
                            GameLost();
                            return;
                        }
                    }
                }
            }
            else if(bMouseLeft)     //左键被按下
            {
                if(pMine[MouseFocus.X,MouseFocus.Y]!=-1)
                {
                    //非地雷，打开周围区域
                    if(pState[MouseFocus.X, MouseFocus.Y] == 0)
                        dfs(MouseFocus.X, MouseFocus.Y);
                }
                else
                {
                    //地雷，游戏结束
                    GameLost();
                }
            }
            else if(bMouseRight)        //右键被按下
            {
                if(bMark)
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)    //未点开
                    {
                        if(Convert.ToInt32(Label_Mine.Text)>0)
                        {
                            pState[MouseFocus.X, MouseFocus.Y] = 2;     //红旗
                            Label_Mine.Text = Convert.ToString(Convert.ToInt32(Label_Mine.Text) - 1);
                        }
                    }    
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 2)   //红旗
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 3;     //问号
                        Label_Mine.Text = Convert.ToString(Convert.ToInt32(Label_Mine.Text) + 1);
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 3)   //问号
                        pState[MouseFocus.X, MouseFocus.Y] = 0;       //未点开
                }
            }
            this.Refresh();
            GameWin();
            bMouseLeft = bMouseRight = false;
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "扫雷", "开发人员：罗文卿，吴书晗\n我的Blog : www.laphets.com", this.Icon.Handle);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定退出吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void TableLayoutPanel_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
