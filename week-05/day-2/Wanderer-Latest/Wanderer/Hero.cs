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
        public override void Move(object sender, Avalonia.Input.KeyEventArgs Key)
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
