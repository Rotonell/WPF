using System.Windows;
using System.Windows.Controls;

namespace MenuBar.View.UserControls
{
	public partial class MenuBar : UserControl
	{
		public MenuBar()
		{
			InitializeComponent();
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
