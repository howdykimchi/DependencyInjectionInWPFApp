using DependencyInjectionInWPF.StartupHelpers;
using System.Windows;
using WpfLibrary;

namespace DependencyInjectionInWPF
{
	public partial class MainWindow : Window
	{
		private readonly IDataAccess _dataAccess;
		//private readonly ChildForm _childForm;
		private readonly IAbstractFactory<ChildForm> _factory;

		public MainWindow(IDataAccess dataAccess, IAbstractFactory<ChildForm> factory)
		{
			InitializeComponent();
			this._dataAccess = dataAccess;
			this._factory = factory;
		}

		private void getData_Click(object sender, RoutedEventArgs e)
		{
			data.Text = _dataAccess.GetData();
		}

		private void openChildForm_Click(object sender, RoutedEventArgs e)
		{
			_factory.Create().Show();
		}
	}
}
