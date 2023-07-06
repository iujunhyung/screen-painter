using System.Windows;

namespace ScreenDrawing
{
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var drawing = new DrawWindow();
			drawing.Show();
		}
	}
}
