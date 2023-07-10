using System.Windows;
using WpfLibrary;

namespace DependencyInjectionInWPF
{
	public partial class MainWindow : Window
	{
		private readonly IDataAccess _dataAccess;

		public MainWindow(IDataAccess dataAccess)
		{
			InitializeComponent();
			this._dataAccess = dataAccess;
		}

		private void getData_Click(object sender, RoutedEventArgs e)
		{
			data.Text = _dataAccess.GetData();
		}
	}
}
