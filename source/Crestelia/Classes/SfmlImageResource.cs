using SFML.Graphics;
using System;
using System.IO;

namespace Crestelia.Classes
{
    public class SfmlImageResource : IDisposable
    {
        public Image Image { get; private set; }
        public Texture Texture { get; private set; }

        public SfmlImageResource(string filename)
        {
            if(File.Exists(filename))
            {
                Image = new Image(filename);

                Texture = new Texture(Image)
                {
                    Smooth = false
                };
            }
        }

        public void Dispose()
        {
            Texture?.Dispose();
            Texture = null;

            Image?.Dispose();
            Image = null;
        }
    }
}
