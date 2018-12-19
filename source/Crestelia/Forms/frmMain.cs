using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFML.Window;
using Color = SFML.Graphics.Color;
using SFML.System;
using System.Threading;

namespace Crestelia.Forms
{
    public partial class frmMain : Form
    {
        public RenderWindow Render { get; private set; }
        public Thread RenderThread { get; private set; }
        public bool IsClosed { get; private set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Initializing preview window render thread...");
            RenderThread = new Thread(() =>
            {
                Console.WriteLine("Initializing SFML preview window...");
                Render = new RenderWindow(new VideoMode((uint)Size.Width, (uint)Size.Height), "Crestelia - Preview", Styles.Titlebar)
                {
                    Position = new Vector2i(Location.X + Size.Width, Location.Y)
                };

                Console.WriteLine("Rendering SFML preview window...");
                while (Render != null && Render.IsOpen && !IsClosed)
                {
                    Render.Position = new Vector2i(Location.X + Size.Width - 12, Location.Y);
                    Render.Clear(Color.Black);

                    Render.Display();
                    Render.DispatchEvents();

                    Application.DoEvents();
                }

                Console.WriteLine("Disposing SFML preview window...");
                Render.Dispose();
                Render = null;
            });

            Console.WriteLine("Starting preview window render thread...");
            RenderThread.Start();
        }

        protected override void OnClosed(EventArgs e)
        {
            IsClosed = true;

            base.OnClosed(e);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            btnSplit.Visible = false;

            btnSplit.Visible = true;

            txtFile.Focus();
        }
    }
}