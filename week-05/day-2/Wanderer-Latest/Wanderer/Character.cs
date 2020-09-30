using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Avalonia;
using GreenFox;

namespace Wanderer
{
    class Character
    {
        public int XPosition { get; protected set; } = 0;
        public int YPosition { get; protected set; } = 0;
        public string CharPicture { get; protected set; }
        public Character(int xPosition, int yPosition)
        {
            XPosition = xPosition;
            YPosition = yPosition;
        }
        public virtual void DrawOnTile(FoxDraw foxDraw)
        {
            var image = new Avalonia.Controls.Image();
            image.Source = new Avalonia.Media.Imaging.Bitmap(CharPicture);
            foxDraw.AddImage(image, 72 * XPosition, 72 * YPosition);
        }
        public virtual void Move(object sender, Avalonia.Input.KeyEventArgs Key)
        {
            switch (Key.Key)
            {
                case Avalonia.Input.Key.Left:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-left.png";
                        this.XPosition += 72;
                        // this.DrawOnTile(foxDraw); // why it does not call the function
                    }
                    break;
                case Avalonia.Input.Key.Up:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-up.png";
                        this.YPosition -= 72;
                    }
                    break;
                case Avalonia.Input.Key.Right:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-right.png";
                        this.XPosition -= 72;
                    }
                    break;
                case Avalonia.Input.Key.Down:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-down.png";
                        this.YPosition += 72;
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
