using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using SharpDX.WIC;
using SkiaSharp;

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


            // draw from here

            /*foxDraw.SetFillColor(Colors.White);
            RectangleFractal(foxDraw, 100, 100, 600); // Not exact lines, made by thirds rounding somehow*/

            HexagonFractal(foxDraw, 200, 400, 400);



        }
        private static void HexagonFractal(FoxDraw foxDraw, double size, double x, double y)
        {
                Hexagon(foxDraw, size, x, y); 

            if (size < 110)
            {
                Hexagon(foxDraw, size, x, y);
            }
            else
            {
                HexagonFractal(foxDraw, size / 2, x - size / 4, y - (size / 2)); // top left small - perfect position
                HexagonFractal(foxDraw, size / 2, x + size / 2, y); // right small - x is OK, y is like +10% or so - BUT there should be NO change in y at all

                // Console.WriteLine("size " + (size / 2) + " x " + (x - size / 4) + " y " + (y + (size / 2))); // numbers from calc itself looks correct, new middle is 400 - 50, 400 + 100

                HexagonFractal(foxDraw, size / 2, x - size / 4, y + (size / 2)); // left bottom small - x is OK, y is like +20% or so
            }
        }

        private static void RectangleFractal(FoxDraw foxDraw, double xPoint, double yPoint, double size)
        {
            foxDraw.DrawRectangle(xPoint, yPoint, size, size);

            if (size < 5)
            {
                foxDraw.DrawRectangle(xPoint, yPoint, size, size);
            }
            else
            {
                RectangleFractal(foxDraw, xPoint + size / 3, yPoint, size / 3);
                RectangleFractal(foxDraw, xPoint + 2 * size / 3, yPoint + size / 3, size / 3);
                RectangleFractal(foxDraw, xPoint + size / 3, yPoint + 2 * size / 3, size / 3);
                RectangleFractal(foxDraw, xPoint, yPoint + size / 3, size / 3);
            }
        }

        private static void SuperHexagon(FoxDraw foxDraw)
        {
            var size = 30;
            List<int> hexOnLine = new List<int> { 4, 5, 6, 7 };
            var x = 400 - 5 * size;
            var y = 400 - (4 * (Math.Sqrt(3) / 2 * size));
            var x2 = x + size * (9);

            for (int col = 0; col < hexOnLine.Count; col++)
            {
                for (int line = 0; line < hexOnLine[col]; line++)
                {
                    Hexagon(foxDraw, size, x + (col * 1.5 * size), y - (col * (Math.Sqrt(3) / 2 * size)) + line * 2 * (Math.Sqrt(3) / 2 * size));
                    Hexagon(foxDraw, size, x2 - (col * 1.5 * size), y - (col * (Math.Sqrt(3) / 2 * size)) + line * 2 * (Math.Sqrt(3) / 2 * size));
                }
            }
        }

        private static void Hexagon(FoxDraw foxDraw, double size, double x, double y)
        {
            Point startingPoint = new Point(x, y);
            Console.WriteLine(size + " " + x + " " + y); // numbers from calc itself looks correct

            foxDraw.SetFillColor(Colors.White);

            Console.WriteLine((startingPoint.X - (0.5 * size)) + "  " + (startingPoint.Y - (1.0 * size))); // numbers from calc itself looks correct

            Point a = new Point(startingPoint.X - (0.5 * size), startingPoint.Y - (1.0 * size));
            Point b = new Point(a.X + 1 * size, a.Y);
            Point c = new Point(a.X + 1.5 * size, a.Y + (Math.Sqrt(3) / 2.0 * size));
            Point d = new Point(a.X + 1 * size, a.Y + 2 * (Math.Sqrt(3) / 2.0 * size));
            Point e = new Point(a.X, a.Y + 2 * (Math.Sqrt(3) / 2.0 * size));
            Point f = new Point(a.X - 0.5 * size, a.Y + (Math.Sqrt(3) / 2.0 * size));
            foxDraw.DrawPolygon(a, new List<Point> { a, b, c, d, e, f });
        }

        private static void Triangles(FoxDraw foxDraw, int lines, int size)
        {
            Point startingPoint = new Point(400, 400 - lines / 2 * (Math.Sqrt(3) / 2.0 * size));
            foxDraw.SetFillColor(Colors.White);

            for (int i = 0; i < lines; i++)
            {
                for (int col = 0; col < i + 1; col++)
                {
                    Point a = new Point(col * size + startingPoint.X - i * size / 2, startingPoint.Y + i * (Math.Sqrt(3) / 2.0 * size));
                    Point b = new Point(a.X - size / 2, (Math.Sqrt(3) / 2.0 * size) + a.Y);
                    Point c = new Point(a.X + size / 2, (Math.Sqrt(3) / 2.0 * size) + a.Y);
                    foxDraw.DrawPolygon(a, new List<Point> { b, c, a });
                }
            }
        }

        private static void EnvelopeStar(FoxDraw foxDraw, double size, double numberOfLines)
        {
            foxDraw.SetBackgroundColor(Colors.White);
            foxDraw.SetStrokeThicknes(2);
            var center = 400;
            var sideSize = size / 2;
            var step = sideSize / numberOfLines;
            foxDraw.SetStrokeColor(Colors.LightGreen);
            var negator = 1;

            for (int row = 0; row < 2; row++)
            {
                negator = negator * -1;
                for (int i = 0; i <= numberOfLines; i++)
                {
                    var linePoint = step * i;
                    foxDraw.DrawLine(center + (negator * linePoint), center, center, center + sideSize - linePoint);
                    foxDraw.DrawLine(center, center - sideSize + linePoint, center + (negator * linePoint), center);
                }
            }
        }
        private static void LinePlayQuarters(FoxDraw foxDraw, Int32 linePlay)
        {
            foxDraw.SetBackgroundColor(Colors.White);
            foxDraw.SetStrokeThicknes(2);
            var side = 800 / Math.Sqrt(linePlay);
            var step = side / 16;

            for (int col = 0; col < Math.Sqrt(linePlay); col++)
            {
                for (int row = 0; row < Math.Sqrt(linePlay); row++)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        var linePoint = step * (i + 1);
                        foxDraw.SetStrokeColor(Colors.LightGreen);
                        foxDraw.DrawLine(col * side, row * side + linePoint, col * side + linePoint, (row + 1) * side);
                        foxDraw.SetStrokeColor(Colors.Purple);
                        foxDraw.DrawLine(col * side + linePoint, row * side, (col + 1) * side, row * side + linePoint);
                    }
                }
            }
        }
        private static void LinePlayQuarters(FoxDraw foxDraw, Int32 linePlay, bool colors)
        {
            foxDraw.SetBackgroundColor(Colors.White);
            foxDraw.SetStrokeThicknes(2);
            var side = 800 / Math.Sqrt(linePlay);
            var step = side / 16;

            for (int col = 0; col < Math.Sqrt(linePlay); col++)
            {
                for (int row = 0; row < Math.Sqrt(linePlay); row++)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        var linePoint = step * (i + 1);
                        foxDraw.SetStrokeColor(GetColor());
                        foxDraw.DrawLine(col * side, row * side + linePoint, col * side + linePoint, (row + 1) * side);
                        foxDraw.SetStrokeColor(GetColor());
                        foxDraw.DrawLine(col * side + linePoint, row * side, (col + 1) * side, row * side + linePoint);
                    }
                }
            }
        }

        private static void LinePlay1(FoxDraw foxDraw)
        {
            foxDraw.SetBackgroundColor(Colors.White);
            foxDraw.SetStrokeThicknes(2);
            var side = 800 / 2;
            var step = side / 16;

            for (int i = 0; i < 15; i++)
            {
                var linePoint = step * (i + 1);
                foxDraw.SetStrokeColor(Colors.LightGreen);
                foxDraw.DrawLine(0, linePoint, linePoint, 400);
                foxDraw.SetStrokeColor(Colors.Purple);
                foxDraw.DrawLine(linePoint, 0, 400, linePoint);
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