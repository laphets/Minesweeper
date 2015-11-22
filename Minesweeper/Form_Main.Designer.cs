namespace Minesweeper
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初级ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.beginnerBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.设置sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.标记MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音效ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.rankRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Mine = new System.Windows.Forms.Label();
            this.Label_Timer = new System.Windows.Forms.Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip_Main.SuspendLayout();
            this.TableLayoutPanel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(879, 25);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameNToolStripMenuItem,
            this.初级ToolStripMenuItem,
            this.beginnerBToolStripMenuItem,
            this.intermediateIToolStripMenuItem,
            this.expertEToolStripMenuItem,
            this.toolStripMenuItem1,
            this.设置sToolStripMenuItem,
            this.toolStripMenuItem2,
            this.标记MToolStripMenuItem,
            this.音效ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.rankRToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.gameToolStripMenuItem.Text = "菜单(&G)";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // newGameNToolStripMenuItem
            // 
            this.newGameNToolStripMenuItem.Name = "newGameNToolStripMenuItem";
            this.newGameNToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newGameNToolStripMenuItem.Text = "新游戏(&N)";
            this.newGameNToolStripMenuItem.Click += new System.EventHandler(this.newGameNToolStripMenuItem_Click);
            // 
            // 初级ToolStripMenuItem
            // 
            this.初级ToolStripMenuItem.Name = "初级ToolStripMenuItem";
            this.初级ToolStripMenuItem.Size = new System.Drawing.Size(159, 6);
            this.初级ToolStripMenuItem.Click += new System.EventHandler(this.初级ToolStripMenuItem_Click);
            // 
            // beginnerBToolStripMenuItem
            // 
            this.beginnerBToolStripMenuItem.Name = "beginnerBToolStripMenuItem";
            this.beginnerBToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.beginnerBToolStripMenuItem.Text = "Beginner(&B)";
            this.beginnerBToolStripMenuItem.Click += new System.EventHandler(this.beginnerBToolStripMenuItem_Click);
            // 
            // intermediateIToolStripMenuItem
            // 
            this.intermediateIToolStripMenuItem.Name = "intermediateIToolStripMenuItem";
            this.intermediateIToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.intermediateIToolStripMenuItem.Text = "Intermediate(&I)";
            this.intermediateIToolStripMenuItem.Click += new System.EventHandler(this.intermediateIToolStripMenuItem_Click);
            // 
            // expertEToolStripMenuItem
            // 
            this.expertEToolStripMenuItem.Name = "expertEToolStripMenuItem";
            this.expertEToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.expertEToolStripMenuItem.Text = "Expert(&E)";
            this.expertEToolStripMenuItem.Click += new System.EventHandler(this.expertEToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // 设置sToolStripMenuItem
            // 
            this.设置sToolStripMenuItem.Name = "设置sToolStripMenuItem";
            this.设置sToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.设置sToolStripMenuItem.Text = "设置(&S)";
            this.设置sToolStripMenuItem.Click += new System.EventHandler(this.设置sToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // 标记MToolStripMenuItem
            // 
            this.标记MToolStripMenuItem.Name = "标记MToolStripMenuItem";
            this.标记MToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.标记MToolStripMenuItem.Text = "标记(&M)";
            this.标记MToolStripMenuItem.Click += new System.EventHandler(this.标记MToolStripMenuItem_Click);
            // 
            // 音效ToolStripMenuItem
            // 
            this.音效ToolStripMenuItem.Name = "音效ToolStripMenuItem";
            this.音效ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.音效ToolStripMenuItem.Text = "音效(&A)";
            this.音效ToolStripMenuItem.Click += new System.EventHandler(this.音效ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // rankRToolStripMenuItem
            // 
            this.rankRToolStripMenuItem.Name = "rankRToolStripMenuItem";
            this.rankRToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rankRToolStripMenuItem.Text = "Rank(&R)";
            this.rankRToolStripMenuItem.Click += new System.EventHandler(this.rankRToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.ColumnCount = 9;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.TableLayoutPanel_Main.Controls.Add(this.Label_Mine, 3, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_Timer, 5, 0);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 370);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 1;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(879, 48);
            this.TableLayoutPanel_Main.TabIndex = 1;
            // 
            // Label_Mine
            // 
            this.Label_Mine.AutoSize = true;
            this.Label_Mine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Mine.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mine.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label_Mine.Location = new System.Drawing.Point(99, 0);
            this.Label_Mine.Name = "Label_Mine";
            this.Label_Mine.Size = new System.Drawing.Size(321, 48);
            this.Label_Mine.TabIndex = 0;
            this.Label_Mine.Text = "Label_Mine";
            this.Label_Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Timer
            // 
            this.Label_Timer.AutoSize = true;
            this.Label_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Timer.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Timer.ForeColor = System.Drawing.Color.Crimson;
            this.Label_Timer.Location = new System.Drawing.Point(458, 0);
            this.Label_Timer.Name = "Label_Timer";
            this.Label_Timer.Size = new System.Drawing.Size(321, 48);
            this.Label_Timer.TabIndex = 1;
            this.Label_Timer.Text = "Label_Timer";
            this.Label_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 1000;
            this.Timer_Main.Tick += new System.EventHandler(this.Timer_Main_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "扫雷正在运行......\r\nBulid By laphets";
            this.notifyIcon.BalloonTipTitle = "Minesweeper";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Minesweeper";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 418);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Minesweeper";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseUp);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.TableLayoutPanel_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 初级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设置sToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 标记MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音效ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rankRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.Label Label_Mine;
        private System.Windows.Forms.Label Label_Timer;
        private System.Windows.Forms.Timer Timer_Main;
        public System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

