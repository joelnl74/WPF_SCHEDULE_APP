using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace Routine_and_schedule_application
{
    class TaskOverView : FrameworkElement
    {
        public TaskOverView(int index, int width, int row, int column, Grid grid)
        {
            var colors = new List<Color>();
            colors.Add(Colors.Red);
            colors.Add(Colors.Green);
            colors.Add(Colors.Blue);
            colors.Add(Colors.Yellow);

            Rectangle item = new Rectangle();
            var number = RandomNumberGenerator.GetInt32(4);
            item.Fill = new SolidColorBrush(colors[number]);
            item.Width = width / 2;

            TextBlock textBlock = new TextBlock();
            textBlock.Text = $"Japanese {index}";

            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Background = Brushes.Transparent;

            Grid.SetRow(item, row);
            Grid.SetColumn(item, column);

            Grid.SetRow(textBlock, row);
            Grid.SetColumn(textBlock, column);

            grid.Children.Add(item);
            grid.Children.Add(textBlock);
        }
    }
}
