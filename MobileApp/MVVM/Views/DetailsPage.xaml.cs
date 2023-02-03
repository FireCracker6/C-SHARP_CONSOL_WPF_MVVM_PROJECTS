using MobileApp.MVVM.ViewModels;

namespace MobileApp.MVVM.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
}