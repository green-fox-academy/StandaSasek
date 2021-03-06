﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;
using System.IO;
using Wanderer;

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

            this.KeyUp += MainWindow_KeyUp;

            Map gameMap = new Map();
            gameMap.DrawMap(foxDraw);
            Hero hero = new Hero(foxDraw, 0, 0);
            hero.DrawOnTile();

            KeyUp += hero.Move;
            
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void MainWindow_KeyUp(object sender, Avalonia.Input.KeyEventArgs e)
        {
            Console.WriteLine(e.Key);
        }
    }
}