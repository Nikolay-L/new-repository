using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VisualBariga.Controller;

namespace VisualBariga
{
    class MyApp : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var controller = new RootController();
            controller.Start();
        }
    }

}
