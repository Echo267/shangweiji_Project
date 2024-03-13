using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Zhaoxi_HostComputer.Views;

namespace Zhaoxi_HostComputer
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if (new LoginWindow().ShowDialog() == true)
            {
                new MainWindow().ShowDialog();
            }
            Application.Current.Shutdown();
        }
    }
}
