using System.Windows;

namespace ScreenDrawing
{
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			// 메뉴 창 생성
			var drawing = new DrawWindow();
			drawing.Left = 0;
			drawing.Top = 0;
			drawing.Show();

			// 드로잉 창 생성
			var menu = new DrawMenu(drawing);
			menu.Show();
		}
	}
}
