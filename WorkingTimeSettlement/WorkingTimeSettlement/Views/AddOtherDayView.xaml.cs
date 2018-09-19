using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingTimeSettlement.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddOtherDayView : ContentPage
	{
	    private AddOtherDayView vm;
		public AddOtherDayView ()
		{
            vm=new AddOtherDayView();
		    BindingContext = vm;
			InitializeComponent ();
		}
	}
}