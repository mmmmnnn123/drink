using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Drawing;

namespace Water1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotifyIcon notifyIcon;
        public MainWindow()
        {
            InitializeComponent();
            InitailWindow();
        }

        private void InitailWindow()
        {

            this.Visibility = Visibility.Hidden;
 
            notifyIcon = new NotifyIcon();
            notifyIcon.BalloonTipText = "systray runnning...";
            notifyIcon.Text = "systray";
            notifyIcon.Icon = new Icon("1.ico");
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(2000);
            notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(notifyIcon_MouseClick);

            //设置菜单项  
         /*   MenuItem setting1 = new MenuItem("setting1");
            MenuItem setting2 = new MenuItem("setting2");
            MenuItem setting = new MenuItem("setting", new MenuItem[] { setting1, setting2 });

            //帮助选项  
            MenuItem help = new MenuItem("help");

            //关于选项  
            MenuItem about = new MenuItem("about");

            //退出菜单项  
            MenuItem exit = new MenuItem("exit");
            exit.Click += new EventHandler(exit_Click);

            //关联托盘控件  
            MenuItem[] childen = new MenuItem[] { setting, help, about, exit };
            notifyIcon.ContextMenu = new ContextMenu(childen);

            //窗体状态改变时候触发  
            this.StateChanged += new EventHandler(SysTray_StateChanged);*/
        }

        private void notifyIcon_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visibility == Visibility.Visible)
                {
                    this.Visibility = Visibility.Hidden;
                }
                else
                {
                    this.Visibility = Visibility.Visible;
                    this.Activate();
                }
            }
        }
    }
}
