using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            // foxDraw.SetBackgroundColor(Colors.Wheat);
            int middleVInt = Convert.ToInt32(Height) / 2;
            int middleHInt = Convert.ToInt32(Width) / 2;
            var middleV = Height / 2;
            var middleH = Width / 2;


            // Drawings here

            // MIDDLE LINES
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.
            // DrawCross(foxDraw, 400, 400, 200, Colors.Red, Colors.Green);

            // COLORED BOX
            // Draw a box that has different colored lines on each edge.

            // VAR WITH DIRECT DRAWING
            /* var leftFirstPointX = 150;
             var leftFirstPointY = 150;
             var topLeftPoint = new Point(leftFirstPointX, leftFirstPointY);
             var sizeH = 100;
             var sizeV = 150;
             var bottomLeftPoint = new Point(leftFirstPointX, leftFirstPointY + sizeV);
             var bottomRightPoint = new Point(leftFirstPointX + sizeH, leftFirstPointY + sizeV);
             var topRightPoint = new Point(leftFirstPointX + sizeH, leftFirstPointY);
             var leftColor = Colors.Aqua;
             var rightColor = Colors.Beige;
             var topColor = Colors.Chocolate;
             var bottomColor = Colors.DeepPink;

             // foxDraw.SetStrokeThicknes(5);

             foxDraw.SetStrokeColor(leftColor);
             foxDraw.DrawLine(topLeftPoint, bottomLeftPoint);
             foxDraw.SetStrokeColor(bottomColor);
             foxDraw.DrawLine(bottomLeftPoint, bottomRightPoint);
             foxDraw.SetStrokeColor(rightColor);
             foxDraw.DrawLine(bottomRightPoint, topRightPoint);
             foxDraw.SetStrokeColor(topColor);
             foxDraw.DrawLine(topLeftPoint, topRightPoint);*/

            // VAR WITH LOOP
            var leftFirstPointX = 150;
            var leftFirstPointY = 150;
            var sizeH = 100;
            var sizeV = 150;
            var nextX = 0;
            var nextY = 0;
            var point1 = new Point();
            var point2 = new Point();

            for (int y = 0; y < 1; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    if (y == 0 || x == 0)
                    {
                        point1 = nextX, nextY;
                        foxDraw.SetStrokeColor(GetColor());
                        foxDraw.DrawLine(new Point(point1, point2);
                    }
                }

            }



            // DIAGONALS
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
            /*var leftFirstPointX = 150;
            var leftFirstPointY = 150;
            var topLeftPoint = new Point(leftFirstPointX, leftFirstPointY);
            var sizeH = 100;
            var sizeV = 150;
            var bottomLeftPoint = new Point(leftFirstPointX, leftFirstPointY + sizeV);
            var bottomRightPoint = new Point(leftFirstPointX + sizeH, leftFirstPointY + sizeV);
            var topRightPoint = new Point(leftFirstPointX + sizeH, leftFirstPointY);
            var leftColor = GetColor();
            var rightColor = GetColor();
            var topColor = GetColor();
            var bottomColor = GetColor();
            var leftDiagonalColor = GetColor();
            var rightDiagonalColor = GetColor();

            foxDraw.SetStrokeThicknes(5);

            foxDraw.SetStrokeColor(leftColor);
            foxDraw.DrawLine(topLeftPoint, bottomLeftPoint);
            foxDraw.SetStrokeColor(bottomColor);
            foxDraw.DrawLine(bottomLeftPoint, bottomRightPoint);
            foxDraw.SetStrokeColor(rightColor);
            foxDraw.DrawLine(bottomRightPoint, topRightPoint);
            foxDraw.SetStrokeColor(topColor);
            foxDraw.DrawLine(topLeftPoint, topRightPoint);
            foxDraw.SetStrokeColor(leftDiagonalColor);
            foxDraw.DrawLine(topLeftPoint, bottomRightPoint);
            foxDraw.SetStrokeColor(rightDiagonalColor);
            foxDraw.DrawLine(topRightPoint, bottomLeftPoint);*/

            // TO THE CENTER
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.

            // ToTheCenter(foxDraw, 30);

            // HORIZONTAL
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.

            // DrawLines50Long(foxDraw, 40);

            // SQUARE IN THE CENTER
            // Draw a green 10x10 square to the canvas' center.

            /*            foxDraw.SetFillColor(Colors.Green);
                        foxDraw.DrawRectangle(middleH - 5, middleV -5, 10, 10);*/

            // FILL WITH RECTANGLES
            // draw four different size and color rectangles.
            // avoid code duplication.

            // DrawNumberOfRectangles(foxDraw, 35);

            // SQUARE POSITIONING
            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            DrawNumberOfRectanglesSize50(foxDraw);


        }

        private void DrawNumberOfRectanglesSize50(FoxDraw foxDraw)
        {
            Console.WriteLine("Specify number of rectangles: ");
            string inputR = Console.ReadLine();  // Get a number:
            bool isInputCorrectR = Int32.TryParse(inputR, out Int32 userNumberR);

            for (int i = 0; i < userNumberR; i++)
            {
                Console.WriteLine("Specify top left corner of {0}. rectangle - coordinate X: ", i + 1);
                string inputX = Console.ReadLine();  // Get a number:
                bool isInputCorrectX = Int32.TryParse(inputX, out Int32 userNumberX);
                Console.WriteLine("Specify top left corner of {0}. rectangle - coordinate Y: ", i + 1);
                string inputY = Console.ReadLine();  // Get a number:
                bool isInputCorrectY = Int32.TryParse(inputY, out Int32 userNumberY);
                var size = 50;
                foxDraw.SetFillColor(GetColor());
                foxDraw.DrawRectangle(userNumberX, userNumberY, size, size);
            }
        }
        private void DrawNumberOfRectangles(FoxDraw foxDraw, Int32 number)
        {
            Random rnd = new Random();
            var numberRectangles = number;

            for (int i = 0; i < numberRectangles; i++)
            {
                var x = rnd.Next(0, Convert.ToInt32(Width));
                var y = rnd.Next(0, Convert.ToInt32(Height));
                var size = rnd.Next(0, 50);
                foxDraw.SetFillColor(GetColor());
                foxDraw.DrawRectangle(x, y, size, size);
            }
        }

        private void DrawLines50Long(FoxDraw foxDraw, Int32 numberOfLines)
        {

            Random rnd = new Random();
            for (int i = 0; i < numberOfLines; i++)
            {
                var x = rnd.Next(0, Convert.ToInt32(Width));
                var y = rnd.Next(0, Convert.ToInt32(Height));
                foxDraw.SetStrokeColor(GetColor());
                foxDraw.SetStrokeThicknes(2);
                foxDraw.DrawLine(new Point(x, y), new Point(x + 50, y));
            }
        }

        private void ToTheCenter(FoxDraw foxDraw, Int32 numberOfLines)
        {
            Random rnd = new Random();
            for (int i = 0; i < numberOfLines; i++)
            {
                var x = rnd.Next(0, Convert.ToInt32(Width));
                var y = rnd.Next(0, Convert.ToInt32(Height));
                foxDraw.SetStrokeColor(GetColor());
                foxDraw.SetStrokeThicknes(2);
                foxDraw.DrawLine(new Point(x, y), new Point(Width / 2, Height / 2));
            }
        }

        private static Color GetColor()
        {
            var listColors = new List<Color>
            {
                new Color(100,0,0,0), new Color(100, 0,0,128), new Color(100, 0,0,255),
                new Color(100, 0,128,0), new Color(100, 0,128,128), new Color(100, 0,255,0),
                new Color(100, 0,255,255), new Color(100, 128,0,0), new Color(100, 128,0,128),
                new Color(100, 128,128,0), new Color(100, 128,128,128),
                new Color(100,255,0,0), new Color(100,255,0,255), new Color(100,255,255,0) };
            var randomNum = new Random().Next(0, listColors.Count);
            var colorRandomizer = listColors[randomNum];
            return colorRandomizer;
        }

        private static void DrawCross(FoxDraw foxDraw, double middlePointX, double middlePointY, double size, Color horizontalColor, Color verticalColor)
        {
            var horizontalLinePoint1 = new Point(middlePointX - size / 2, middlePointY);
            var horizontalLinePoint2 = new Point(middlePointX + size / 2, middlePointY);
            var verticalLinePoint1 = new Point(middlePointX, middlePointY - size / 2);
            var verticalLinePoint2 = new Point(middlePointX, middlePointY + size / 2);
            foxDraw.SetStrokeColor(horizontalColor);
            foxDraw.DrawLine(horizontalLinePoint1, horizontalLinePoint2);
            foxDraw.SetStrokeColor(verticalColor);
            foxDraw.DrawLine(verticalLinePoint1, verticalLinePoint2);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}