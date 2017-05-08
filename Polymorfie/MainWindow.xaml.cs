using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Polymorfie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Square square1 = new Square(180, 180);
            Circle circle1 = new Circle(40, 40);
            List<Shape> group = new List<Shape>();

            group.Add(circle1);
            group.Add(square1);

            foreach (Shape shape in group)
            {
                shape.DisplayOn(canvas);
            }
        }
    }
}
