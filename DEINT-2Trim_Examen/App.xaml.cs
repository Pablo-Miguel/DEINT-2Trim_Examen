using DEINT_2Trim_Examen.MVVM.Views;

namespace DEINT_2Trim_Examen;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CompraView();
	}
}
