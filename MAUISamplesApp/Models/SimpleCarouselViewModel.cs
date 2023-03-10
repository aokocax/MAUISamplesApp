using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISamplesApp.Models
{
	public class LogImage
	{


		public string imageSource { get; set; }
	
		public string title { get; set; }

	}
	internal class SimpleCarouselViewModel
	{
		public List<LogImage> model { get; set; }
		public SimpleCarouselViewModel() {
			model = new List<LogImage>
		{
			new LogImage{imageSource="dotnet_bot",title="Title One"},
			new LogImage{imageSource="dotnet_bot",title="Title Two"},
			new LogImage{imageSource="dotnet_bot",title="Title Three"},
		};
			
		}
	}
}
