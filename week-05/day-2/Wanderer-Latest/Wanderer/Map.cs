using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Avalonia.Layout;
using Avalonia.Media;
using GreenFox;

namespace Wanderer
{
    class Map
    {
        public int Width { get; protected set; } = 10;
        public int Height { get; protected set; } = 10;
        public bool TileIsEmpty { get; protected set; }
        public int[,] Layout { get; protected set; }
        public Map()
        {
            
        }
        
        public void DrawMap(FoxDraw foxDraw)
        {
            string layoutFilePath = @"..\..\..\MapLayout.txt";
            string[] layout = File.ReadAllLines(layoutFilePath); 
            string tile = @"..\..\..\Assets\floor.png";
            string wall = @"..\..\..\Assets\wall.png";
            for (int row = 0; row < layout[0].Length; row++)
            {
                for (int col = 0; col < layout[1].Length; col++)
                {
                    if (layout[row][col] == '1')
                    {
                        var image = new Avalonia.Controls.Image();
                        image.Source = new Avalonia.Media.Imaging.Bitmap(tile);
                        foxDraw.AddImage(image, 72 * row, 72 * col);
                    }
                    else if (layout[row][col] == '0')
                    {
                        var image = new Avalonia.Controls.Image();
                        image.Source = new Avalonia.Media.Imaging.Bitmap(wall);
                        foxDraw.AddImage(image, 72 * row, 72 * col);
                    }
                }
            }
        }
    }
}
