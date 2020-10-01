using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;
using System.IO;
using Wanderer;

namespace Wanderer
{
     abstract class Character
    {
        public int XPosition { get; protected set; } = 0;
        public int YPosition { get; protected set; } = 0;
        public FoxDraw FoxDraw { get; protected set; }
        public Image CharPicture { get; protected set; }
        public string PictureFile { get; protected set; }
        public Character(FoxDraw foxDraw, int xPosition, int yPosition)
        {
            FoxDraw = foxDraw;
            XPosition = xPosition;
            YPosition = yPosition;
            CharPicture = new Avalonia.Controls.Image();
        }
        public virtual void DrawOnTile()
        {
            FoxDraw.SetPosition(CharPicture, 72 * XPosition, 72 * YPosition);
        }
        public virtual void Move() 
        { 
        }       
    }
}
