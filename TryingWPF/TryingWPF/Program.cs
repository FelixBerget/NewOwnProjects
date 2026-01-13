using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TryingWPF
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var brush = new SolidColorBrush(Colors.Red);
            var list = new List<string>();
            list.Add("Hello");
            list.Add("Guys");
            var panel = new StackPanel()
            {
                Orientation = Orientation.Vertical
            };
            var button = new Button()
            {
                Content = "Test clicking"
            };
            var label1 = new Label()
            {
                Content = "Test Label"
            };
            var textblock = new TextBlock()
            {
                Text = "Come on lets play golf and eat sardines\nI too am a big fan of golf!"
                
            };
            var listbox = new ListBox()
            {
                Width = 100,
                Height = 100,
                BorderBrush = brush,
                ItemsSource = list

            };
            panel.Children.Add(button);
            panel.Children.Add(label1);
            panel.Children.Add(textblock);
            panel.Children.Add(listbox);
            window.Content = panel;
            app.Run(window);
        }
    }
}
