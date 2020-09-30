using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Avalonia.Media;
using GreenFox;

namespace Wanderer
{
    class Map
    {
        public int Width { get; protected set; } = 10;
        public int Height { get; protected set; } = 10;
        public bool TileIsEmpty { get; protected set; }
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Map()
        {
        }
        public void DrawMap(FoxDraw foxDraw)
        {
            string layoutFilePath = @"..\..\..\MapLayout.txt";
            string[] layout = File.ReadAllLines(layoutFilePath);
            string tile = @"..\..\..\Assets\floor.png";
            string wall = @"..\..\..\Assets\wall.png";
            for (int r = 0; r < layout.Length; r++)
            {
                for (int c = 0; c < layout[r].Length; c++)
                {
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
