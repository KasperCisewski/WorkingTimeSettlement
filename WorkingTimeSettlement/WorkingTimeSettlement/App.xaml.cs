using System;
using WorkingTimeSettlement.Services;
using WorkingTimeSettlement.Views;
using Xamarin.Forms;

namespace WorkingTimeSettlement
{
    public partial class App : Application
    {

        public App()
        {
            _dayValidator = new DayValidator();
            SettlementService = new WorkingTimeSettlementService(DayRepository, _dayValidator);
            InitializeComponent();

            MainPage = new MainPage();

        }

        private static DayValidator _dayValidator;

        public static WorkingTimeSettlementService SettlementService;

        private static DayRepository _dayRepository;

        public static DayRepository DayRepository
        {
            get
            {
                if (_dayRepository == null)
                {
                    _dayRepository = new DayRepository();
                }

                return _dayRepository;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes	
        }
    }
}
