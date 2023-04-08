using DEINT_2Trim_Examen.MVVM.ViewModels;

namespace DEINT_2Trim_Examen.MVVM.Views;

public partial class CompraView : ContentPage
{
	public CompraView()
	{
		InitializeComponent();
		BindingContext = new CompraViewModel();
	}
}