using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WorkingTimeSettlement.Models;
using WorkingTimeSettlement.Services;
using Xamarin.Forms;

namespace WorkingTimeSettlement.ViewModels
{
    public class AddOtherDayViewModel:INotifyPropertyChanged
    {   
        public DateTime MinimalDate { get; set; }
        public DateTime MaximalDate { get; set; }
        private DateTime _selectedDate;

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                if (value != this._selectedDate)
                {
                    this._selectedDate = value;
                    OnPropertyChanged(_selectedDate.ToString());
                }
            }
        }

        private string _workStart;

        public string WorkStart
        {
            get => _workStart;
            set
            {
                if (value != this._workStart)
                {
                    this._workStart = value;
                    OnPropertyChanged(_workStart);
                }
            }
        }

        private string _workEnd;

        public string WorkEnd
        {
            get => _workEnd;
            set
            {
                if (value != this._workEnd)
                {
                    this._workEnd = value;
                    OnPropertyChanged(_workEnd);
                }
            }
        }

        private string _breakAtWork;

        public string BreakAtWork
        {
            get => _breakAtWork;
            set
            {
                if (value != this._breakAtWork)
                {
                    this._breakAtWork = value;
                    OnPropertyChanged(_breakAtWork);
                }
            }
        }

        private string _description;

        public string Description
        {
            get => _description;
            set
            {
                if (value != this._description)
                {
                    this._description = value;
                    OnPropertyChanged(_description);
                }
            }
        }

        private WorkingDay _workingDay;


        public string MessageForUser { get; set; }
    

        public AddOtherDayViewModel()
        {
            MessageForUser = "";
            SelectedDate = DateTime.Today;
            MinimalDate = new DateTime(SelectedDate.Year-1,SelectedDate.Month,SelectedDate.Day);
            MaximalDate = new DateTime(SelectedDate.Year+1, SelectedDate.Month, SelectedDate.Day);
        }

        public void TryToSaveWorkingTimeToRepository()
        {
           
            try
            {
                _workingDay = new WorkingDay(_selectedDate, _workStart, _workEnd, _breakAtWork, _description);
            }
            catch (Exception e)
            {
                MessageForUser = "Something was wrong";
                Console.WriteLine(e);
                throw;
            }

            MessageForUser = App.SettlementService.CheckAndAddToRepository(_workingDay);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
