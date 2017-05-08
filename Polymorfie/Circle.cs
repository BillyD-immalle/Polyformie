using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Polymorfie
{
    class Circle : Shape
    {
        private Ellipse ellipse;

        public Circle(int initX, int initY)
        {
            x = initX;
            y = initY;
            CreateEllipse();
        }

        public override void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(ellipse);
        }
        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = brush;
            ellipse.Width = size;
            ellipse.Height = size;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }
    }
}
