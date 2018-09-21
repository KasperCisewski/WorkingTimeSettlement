using System;
using System.IO;
using WorkingTimeSettlement.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingTimeSettlement.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
	   

		public MainPage ()
		{

			InitializeComponent ();
		}
	}
}