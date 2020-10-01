using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Input;
using GreenFox;
using System;
using System.Collections.Generic;
using System.IO;
using Wanderer;

namespace Wanderer
{
    class Hero : Character
    {
        public Hero(FoxDraw foxDraw, int xPosition, int yPosition) : base(foxDraw, xPosition, yPosition)
        {
            PictureFile = @"..\..\..\Assets\hero-down.png";
            CharPicture.Source = new Avalonia.Media.Imaging.Bitmap(PictureFile);
            FoxDraw.AddImage(CharPicture, 72 * XPosition, 72 * YPosition);
        }
        public void Move(object sender, KeyEventArgs pressed)
        {
            switch (pressed.Key)
            {
                case Key.A:
                    {
                        this.PictureFile = @"..\..\..\Assets\hero-left.png";
                        CharPicture.Source = new Avalonia.Media.Imaging.Bitmap(PictureFile);
                        this.XPosition -= 1;
                    }
                    break;
                case Key.W:
                    {
                        this.PictureFile = @"..\..\..\Assets\hero-up.png";
                        CharPicture.Source = new Avalonia.Media.Imaging.Bitmap(PictureFile);
                        this.YPosition -= 1;
                    }
                    break;
                case Key.D:
                    {
                        this.PictureFile = @"..\..\..\Assets\hero-right.png";
                        CharPicture.Source = new Avalonia.Media.Imaging.Bitmap(PictureFile);
                        this.XPosition += 1;
                    }
                    break;
                case Key.S:
                    {
                        this.PictureFile = @"..\..\..\Assets\hero-down.png";
                        CharPicture.Source = new Avalonia.Media.Imaging.Bitmap(PictureFile);
                        this.YPosition += 1;
                    }
                    break;
                default:
                    break;
            }
            DrawOnTile();
        }
    }
}
