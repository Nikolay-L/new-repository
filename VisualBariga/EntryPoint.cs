using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBariga
{
    class EntryPoint
    {
        [STAThread]
        public static void Main()
        {
            var application = new MyApp();
            application.Run();
        }
    }
}
