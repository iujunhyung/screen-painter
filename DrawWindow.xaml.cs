using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ScreenDrawing
{
	public partial class DrawWindow : Window
	{
		private bool isDrawing;
		private Point startPoint;

		public DrawWindow()
		{
			InitializeComponent();
		}

		private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
		{
			isDrawing = true;
			startPoint = e.GetPosition(canvas);
		}

		private void canvas_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDrawing)
			{
				Line line = new Line
				{
					Stroke = Brushes.Red,
					StrokeThickness = 2,
					Opacity = 1,
					X1 = startPoint.X,
					Y1 = startPoint.Y,
					X2 = e.GetPosition(canvas).X,
					Y2 = e.GetPosition(canvas).Y
				};

				startPoint = e.GetPosition(canvas);
				canvas.Children.Add(line);
			}
		}

		private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
		{
			isDrawing = false;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			canvas.Children.Clear();
		}

		public void ClearCanvas()
		{
			canvas.Children.Clear();
		}
	}
}
