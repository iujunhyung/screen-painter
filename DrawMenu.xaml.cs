using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ScreenDrawing
{
	public partial class DrawMenu : Window
    {
		private DrawWindow drawWindow;
		private bool isMoving = false;
		private Point startPoint;

		public DrawMenu(DrawWindow window)
        {
            InitializeComponent();
			drawWindow = window;
		}


		private void Move_Down(object sender, MouseButtonEventArgs e)
		{
			DragMove();
			e.Handled = true;
		}

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			drawWindow.ClearCanvas();
		}

		private void Mode_Click(object sender, RoutedEventArgs e)
		{
			Button? modeButton = sender as Button;
			if (modeButton is null) return;

			if (drawWindow.WindowState == WindowState.Normal)
			{
				drawWindow.WindowState = WindowState.Maximized;
				modeButton.Background = Brushes.Green;
			}
			else if (drawWindow.WindowState == WindowState.Maximized)
			{
				drawWindow.WindowState = WindowState.Normal;
				modeButton.Background = Brushes.Red;
			}
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
