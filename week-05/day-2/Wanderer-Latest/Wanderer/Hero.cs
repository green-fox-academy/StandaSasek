using System;
using System.Collections.Generic;
using System.Text;
using Avalonia;
using GreenFox;

namespace Wanderer
{
    class Hero : Character
    {
        public Hero(int xPosition, int yPosition) : base(xPosition, yPosition)
        {
            CharPicture = @"..\..\..\Assets\hero-down.png";
        }
        public override void DrawOnTile(FoxDraw foxDraw)
        {
            var image = new Avalonia.Controls.Image();
            image.Source = new Avalonia.Media.Imaging.Bitmap(CharPicture);
            foxDraw.AddImage(image, 72 * this.XPosition, 72 * this.YPosition);
        }
        public void Move(int x, int y, Avalonia.Input.KeyEventArgs Key)
        {
            switch (Key.Key)
            {
                case Avalonia.Input.Key.Left:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-left.png";
                    }
                    break;
                case Avalonia.Input.Key.Up:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-up.png";
                    }
                    break;
                case Avalonia.Input.Key.Right:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-right.png";
                    }
                    break;
                case Avalonia.Input.Key.Down:
                    {
                        this.CharPicture = @"..\..\..\Assets\hero-down.png";
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
