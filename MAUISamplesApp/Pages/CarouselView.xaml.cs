using MAUISamplesApp.Models;

namespace MAUISamplesApp.Pages;

public partial class CarouselView : ContentPage
{
	
	public CarouselView()
	{
		InitializeComponent();
		BindingContext= new SimpleCarouselViewModel();

	
	}

}