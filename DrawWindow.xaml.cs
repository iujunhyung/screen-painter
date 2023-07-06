using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ScreenDrawing
{
	public partial class DrawWindow : Window
	{
		public DrawWindow()
		{
			InitializeComponent();
		}

		private void Move_Down(object sender, MouseButtonEventArgs e)
		{
			DragMove();
			e.Handled = true;
		}

		private void Mode_Click(object sender, RoutedEventArgs e)
		{
			MainMenu.Visibility = Visibility.Hidden;
			BackCanvas.Color = Colors.White;
			WindowState = WindowState.Maximized;
		}

		private void KeyDown_Event(object sender, KeyEventArgs e)
		{
			if(e.Key == Key.Escape)
			{
				MainMenu.Visibility = Visibility.Visible;
				BackCanvas.Color = Colors.Transparent;
				WindowState = WindowState.Normal;
			}
		}

		private void ChangePenColor_Click(object sender, RoutedEventArgs e)
		{
			MainCanvas.DefaultDrawingAttributes.Color = Color.FromRgb(255, 0, 0);
		}

		private void Erase_Click(object sender, RoutedEventArgs e)
		{
			MainCanvas.Strokes.Clear();
		}
	}
}
