using System.Windows;
using WpfLibrary;

namespace DependencyInjectionInWPF;

public partial class ChildForm : Window
{
	private readonly IDataAccess _dataAccess;

	public ChildForm(IDataAccess dataAccess)
	{
		InitializeComponent();
		this._dataAccess = dataAccess;
		dataAccessInfo.Text = _dataAccess.GetData();
	}
}
