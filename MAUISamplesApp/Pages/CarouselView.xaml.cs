using Android.OS;
using MAUISamplesApp.Models;

namespace MAUISamplesApp.Pages;

public partial class CarouselView : ContentPage
{
	
	public CarouselView()
	{
		InitializeComponent();
		BindingContext= new SimpleCarouselViewModel();

	
	}

	private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
	{
		if (e.CurrentItem != null)
		{
			Console.WriteLine(((LogImage)e.CurrentItem).title);
		}
	
	}
}