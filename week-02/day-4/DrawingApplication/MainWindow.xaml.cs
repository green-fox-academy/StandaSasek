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

            //  DrawNumberOfRectanglesSize50(foxDraw);

            // CENTERED BOXES
            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            // CenteredBoxes(foxDraw, 10);

            // RAINBOW BOXES
            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            // RainbowCenteredBoxes(foxDraw);

            // PURPLE STEPS
            // Reproduce this:
            // [https://github.com/green-fox-academy/teaching-materials/blob/master/workshop/drawing/assets/r3.png]

            /*var size = 20;
            foxDraw.SetFillColor(Colors.Purple);

            for (int i = 0; i < 20; i++)
            {
                foxDraw.DrawRectangle(0 + i * size, 0 + i * size, size, size);
            }*/

            // PURPLE STEPS 3D
            // Reproduce this:
            // [https://github.com/green-fox-academy/teaching-materials/blob/master/workshop/drawing/assets/r4.png]

            /*var size = 20;
            var start = size;
            foxDraw.SetFillColor(Colors.Purple);

            for (int i = 0; i < 5; i++)
            {
                var sizeA = (i + 1) * size;
                foxDraw.DrawRectangle(0 + start, 0 + start, sizeA, sizeA);
                start = sizeA + start;
            }*/

            // CHECKERBOARD
            // Fill the canvas with a checkerboard pattern.

            /*var size = 50;
            foxDraw.SetFillColor(Colors.Black);

            for (int x = 0; x < Width / size; x++)
            {
                for (int y = 0; y < Height / size; y++)
                {
                    foxDraw.DrawRectangle((y % 2 * size) + x * 2 * size, 0 + y * size, size, size);
                }
            }*/

            // EVERYTHING GOES TO CENTER
            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            // LinesToCenter(foxDraw, 2);

            // CONNECT THE DOTS
            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            // RectangleFromPoints(foxDraw);

            // STARRY NIGHT
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            foxDraw.SetBackgroundColor(Colors.Black);
            for (int i = 0; i < 300; i++)
            {
                Random rnd = new Random();
                var rndC = rnd.Next(200, 254);
                Color randomColor = Color.FromRgb((byte)rndC, (byte)rndC, (byte)rndC);
                foxDraw.SetStrokeColor(randomColor);
                var x = rnd.Next(0, 800);
                var y = rnd.Next(0, 800);
                foxDraw.DrawLine(x, y, x + 6, y);
                foxDraw.DrawLine(x + 3, y - 3, x + 3, y + 3);
            }
        }

        private static void RectangleFromPoints(FoxDraw foxDraw)
        {
            List<Point> points1 = new List<Point> { new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290) };
            List<Point> points2 = new List<Point> { new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
             new Point(120, 100), new Point(85, 130), new Point(50, 100) };
            List<Point> points = new List<Point> { };

            Point newLast1 = points1[0];
            points1.Add(newLast1);

            for (int i = 0; i < points1.Count - 1; i++)
            {
                Point secondPoint = points1[i + 1];
                foxDraw.DrawLine(points1[i].X, points1[i].Y, secondPoint.X, secondPoint.Y);
            }
            Point newLast2 = points2[0];
            points2.Add(newLast2);

            for (int i = 0; i < points2.Count - 1; i++)
            {
                Point secondPoint = points2[i + 1];
                foxDraw.DrawLine(points2[i].X, points2[i].Y, secondPoint.X, secondPoint.Y);
            }
        }

        private static void LinesToCenter(FoxDraw foxDraw, Int32 numberOfLines)
        {
            Int32 numberOn1Side = 800 / numberOfLines;
            var x = 0;
            var y = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k <= numberOn1Side; k++)
                {
                    foxDraw.DrawLine(x, y, 400, 400);
                    x = (i + 1) % 2 * k * numberOfLines;
                    y = i % 2 * k * numberOfLines;
                }
                for (int k = 0; k <= numberOn1Side; k++)
                {
                    foxDraw.DrawLine(x, y, 400, 400);
                    x = 800 - (i % 2 * k * numberOfLines);
                    y = 800 - ((i + 1) % 2 * k * numberOfLines);
                }
            }
        }

        private static void RainbowCenteredBoxes(FoxDraw foxDraw)
        {
            var mid = 400;
            var sizeStep = mid * 2 / 7;
            var listColors = new List<Color> { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };

            for (int i = 0; i < 7; i++)
            {
                foxDraw.SetFillColor(listColors[i]);
                var sqSize = 800 - i * sizeStep;
                var startingX = mid - sqSize / 2;
                var startingY = mid - sqSize / 2;
                foxDraw.DrawRectangle(startingX, startingY, sqSize, sqSize);
            }
        }
        private static void CenteredBoxes(FoxDraw foxDraw, Int32 numberOfBoxes)
        {
            var mid = 400;
            var sizeStep = mid * 2 / numberOfBoxes;

            for (int i = 0; i < numberOfBoxes; i++)
            {
                foxDraw.SetFillColor(GetColor());
                var sqSize = 800 - i * sizeStep;
                var startingX = mid - sqSize / 2;
                var startingY = mid - sqSize / 2;
                foxDraw.DrawRectangle(startingX, startingY, sqSize, sqSize);
            }
        }
        private static void DrawNumberOfRectanglesSize50(FoxDraw foxDraw)
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
        private static void DrawNumberOfRectangles(FoxDraw foxDraw, Int32 number)
        {
            Random rnd = new Random();
            var numberRectangles = number;

            for (int i = 0; i < numberRectangles; i++)
            {
                var x = rnd.Next(0, 800);
                var y = rnd.Next(0, 800);
                var size = rnd.Next(0, 50);
                foxDraw.SetFillColor(GetColor());
                foxDraw.DrawRectangle(x, y, size, size);
            }
        }

        private static void DrawLines50Long(FoxDraw foxDraw, Int32 numberOfLines)
        {

            Random rnd = new Random();
            for (int i = 0; i < numberOfLines; i++)
            {
                var x = rnd.Next(0, 800);
                var y = rnd.Next(0, 800);
                foxDraw.SetStrokeColor(GetColor());
                foxDraw.SetStrokeThicknes(2);
                foxDraw.DrawLine(new Point(x, y), new Point(x + 50, y));
            }
        }

        private static void ToTheCenter(FoxDraw foxDraw, Int32 numberOfLines)
        {
            Random rnd = new Random();
            for (int i = 0; i < numberOfLines; i++)
            {
                var x = rnd.Next(0, 800);
                var y = rnd.Next(0, 800);
                foxDraw.SetStrokeColor(GetColor());
                foxDraw.SetStrokeThicknes(2);
                foxDraw.DrawLine(new Point(x, y), new Point(800 / 2, 800 / 2));
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