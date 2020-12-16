using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BreakOut
{
    class Bonus
    {
        public double X = 0;
        public double Y = 0;

        public const double Height = 10;
        public const double Width = 10;
        internal Brush _brush = Brushes.Yellow;
        private Ellipse _visual;
        private Canvas _canvas;

        public int Value { get { return 100; } }

        public Bonus(Canvas parent)
        {
            _canvas = parent;

            _visual = new Ellipse();
            _visual.Name = "Bonusss";
            _visual.Height = Height;
            _visual.Width = Width;
            _visual.Fill = _brush;

            _canvas.Children.Add(_visual);
            MoveTo(X, Y);
        }

        public void MoveTo(double xX, double yY)
        {
            xX = X; yY = Y;
            Canvas.SetLeft(_visual, X);
            Canvas.SetTop(_visual, Y);
        }

        public void RemoveVisual()
        {
            _canvas.Children.Remove(_visual);
        }

    }
}