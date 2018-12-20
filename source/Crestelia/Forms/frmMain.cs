using Crestelia.Classes;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Color = SFML.Graphics.Color;
using Image = SFML.Graphics.Image;

namespace Crestelia.Forms
{
    public partial class frmMain : Form
    {
        public RenderWindow Render { get; private set; }
        public Thread RenderThread { get; private set; }
        public bool IsClosed { get; private set; }

        public SfmlImageResource Resource { get; private set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtFile.Text = Application.StartupPath + Path.DirectorySeparatorChar + "input" + Path.DirectorySeparatorChar;
            txtOutputPath.Text = Application.StartupPath + Path.DirectorySeparatorChar + "output" + Path.DirectorySeparatorChar;

            Console.WriteLine("Initializing preview window render thread...");
            RenderThread = new Thread(() =>
            {
                Console.WriteLine("Initializing SFML preview window...");
                Render = new RenderWindow(new VideoMode((uint)Size.Width, (uint)Size.Height), "Crestelia - Preview", Styles.Titlebar)
                {
                    Position = new Vector2i(Location.X + Size.Width, Location.Y)
                };

                Sprite sprite = new Sprite();

                Console.WriteLine("Rendering SFML preview window...");
                while (Render != null && Render.IsOpen && !IsClosed)
                {
                    Render.Position = new Vector2i(Location.X + Size.Width - 12, Location.Y);
                    Render.Clear(Color.Black);

                    if (Resource != null && Resource.Texture != null && Resource.Image != null)
                    {
                        try
                        {
                            var cols = ((int)numericX.Value >= 1) ? (int)numericX.Value : 1;
                            var rows = ((int)numericY.Value >= 1) ? (int)numericY.Value : 1;

                            sprite.Texture = Resource.Texture;
                            sprite.TextureRect = new IntRect(0, 0,
                                (int)Resource.Image.Size.X / cols,
                                (int)Resource.Image.Size.Y / rows);
                            sprite.Position = new Vector2f(0, 0);

                            Render.Draw(sprite);
                        }
                        catch
                        {

                        }
                    }

                    Render.Display();
                    Render.DispatchEvents();

                    Application.DoEvents();
                }

                sprite?.Dispose();
                sprite = null;

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
            if (Resource != null)
            {
                btnSplit.Visible = false;

                if (!Directory.Exists(txtOutputPath.Text))
                {
                    Directory.CreateDirectory(txtOutputPath.Text);
                }

                var srcExt = txtFile.Text.Substring(
                    txtFile.Text.LastIndexOf(".") + 1);
                var srcName = txtFile.Text.Substring(
                    txtFile.Text.LastIndexOf(Path.DirectorySeparatorChar) + 1).Replace("." + srcExt, string.Empty);

                var cols = ((int)numericX.Value >= 1) ? (int)numericX.Value : 1;
                var rows = ((int)numericY.Value >= 1) ? (int)numericY.Value : 1;
                var width = (int)Resource.Image.Size.X / cols;
                var height = (int)Resource.Image.Size.Y / rows;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        var destName = txtOutputFormat.Text.Replace(
                            "%f", srcName).Replace(
                            "%ext", srcExt).Replace(
                            "%r", r.ToString()).Replace(
                            "%c", c.ToString()).Replace(
                            "%t", ((r * cols) + c).ToString());

                        Image image = new Image((uint)width, (uint)height);
                        image.Copy(Resource.Image, 0, 0, new IntRect(c * width, r * height, width, height), true);

                        image.SaveToFile(txtOutputPath.Text + destName);
                        image?.Dispose();
                        image = null;

                        Application.DoEvents();
                    }
                }

                btnSplit.Visible = true;
            }

            txtFile.Focus();
        }

        private void txtFile_Validated(object sender, EventArgs e)
        {
            if (File.Exists(txtFile.Text))
            {
                Resource = new SfmlImageResource(txtFile.Text);
            }
        }
    }
}