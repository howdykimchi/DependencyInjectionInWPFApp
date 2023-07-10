using System.Windows;
using WpfLibrary;

namespace DependencyInjectionInWPF
{
	public partial class MainWindow : Window
	{
		private readonly IDataAccess _dataAccess;
		private readonly ChildForm _childForm;

		public MainWindow(IDataAccess dataAccess, ChildForm childForm)
		{
			InitializeComponent();
			this._dataAccess = dataAccess;
			this._childForm = childForm;
		}

		private void getData_Click(object sender, RoutedEventArgs e)
		{
			data.Text = _dataAccess.GetData();
		}

		private void openChildForm_Click(object sender, RoutedEventArgs e)
		{
			_childForm.Show();
		}
	}
}
