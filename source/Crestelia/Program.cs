using Crestelia.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crestelia
{
    public static class Program
    {
        public static Form Form { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine($"Initializing {AssemblyInformation.Product} v{AssemblyInformation.Version}...");
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            Console.WriteLine($"Starting {AssemblyInformation.Product} v{AssemblyInformation.Version}...");
            Application.Run(new frmMain());
        }
    }
}
