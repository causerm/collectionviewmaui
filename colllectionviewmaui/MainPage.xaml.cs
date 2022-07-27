using collectionviewmaui.viewmodels;

namespace colllectionviewmaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		this.BindingContext = new MainViewModel();
	}	
}


