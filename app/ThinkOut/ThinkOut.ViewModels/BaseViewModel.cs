using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace ThinkOut.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        private string _title;
        private bool _isBusy;

        public string Title
        { 
            get
            { 
                return _title; 
            }
            set
            { 
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public ICommand BackCommand
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

        public bool IsBusy
        {
            get
            { 
                return _isBusy;
            }
            set
            { 
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }
    }
}

