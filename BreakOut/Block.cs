using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BreakOut
{
    class Block
    {
        public double X = 0;
        public double Y = 0;

        public const double Height = 20;
        public const double Width = 50;
        internal Brush _brush = Brushes.Green;
        private Rectangle _visual;
        private Canvas _canvas;

        public int Value { get { return 100; } }

        public Block(Canvas parent)
        {
            _canvas = parent;

            _visual = new Rectangle();
            _visual.Name = "Blcooo";
            _visual.Height = Height;
            _visual.Width = Width;
            _visual.Fill = _brush;

            _canvas.Children.Add(_visual);
            MoveTo(X, Y);
        }

        public void MoveTo(double xX, double yY)
        {
            X = xX; Y = yY;
            Canvas.SetLeft(_visual, X);
            Canvas.SetTop(_visual, Y);

        }

        public void Remove()
        {
            _canvas.Children.Remove(_visual);
        }
    }
}
