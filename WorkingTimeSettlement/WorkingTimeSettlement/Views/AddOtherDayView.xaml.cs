using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingTimeSettlement.Services;
using WorkingTimeSettlement.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingTimeSettlement.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddOtherDayView : ContentPage
	{
	    private AddOtherDayViewModel vm;
		public AddOtherDayView ()
		{
            vm=new AddOtherDayViewModel();
		    BindingContext = vm;
			InitializeComponent ();
		}

	    private void SaveDay_OnClicked(object sender, EventArgs e)
	    {
	        vm.TryToSaveWorkingTimeToRepository();
	        DisplayAlert("Allert", vm.MessageForUser, "ok");

	    }
	}
}