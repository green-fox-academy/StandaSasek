using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP
{
    class PostIt
    {
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor TextColor { get; set; }
        public String Text { get; set; }

        public PostIt(ConsoleColor background, ConsoleColor textColor, string text)
        {
            BackgroundColor = background;
            TextColor = textColor;
            Text = text;
        }
        public PostIt()
        {
            BackgroundColor = ConsoleColor.Black;
            TextColor = ConsoleColor.White;
            Text = "new string";
        }
        public void PrintPostIt()
        {
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = TextColor;
            Console.WriteLine(Text);
        }
    }
}
