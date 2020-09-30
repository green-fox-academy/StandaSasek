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
        public int[,] Layout { get; protected set; }
        public bool TileIsEmpty { get; protected set; }
        
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
        public virtual void DrawMap(FoxDraw foxDraw)
        {
            string layoutFilePath = @"..\..\..\MapLayout.txt";
            string[] layout = File.ReadAllLines(layoutFilePath);
            string tile = @"..\..\..\Assets\floor.png";
            string wall = @"..\..\..\Assets\wall.png";
            for (int r = 0; r < layout.Length; r++)
            {
                for (int c = 0; c < layout[r].Length; c++)
                {
                    Layout[r,c] = layout[r][c];
                    if (layout[r][c] == '1')
                    {
                        var image = new Avalonia.Controls.Image();
                        image.Source = new Avalonia.Media.Imaging.Bitmap(tile);
                        foxDraw.AddImage(image, 72 * r, 72 * c);
                    }
                    else
                    {
                        var image = new Avalonia.Controls.Image();
                        image.Source = new Avalonia.Media.Imaging.Bitmap(wall);
                        foxDraw.AddImage(image, 72 * r, 72 * c);
                    }
                }
            }
        }

    }
}
