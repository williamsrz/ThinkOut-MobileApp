using System;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Linq;
using ThinkOut.ViewModels;

namespace ThinkOut.Droid
{
    public class CustomPresenter : MvxAndroidViewPresenter
    {
        private static CustomPresenter _presenter;

        public static CustomPresenter Presenter
        {
            get
            {
                _presenter = _presenter ?? new CustomPresenter();
                return _presenter;
            }
        }

        public List<IMvxViewModel> ViewModels;

        public CustomPresenter()
        {
            ViewModels = new List<IMvxViewModel>();
        }

        public override void Close(Cirrious.MvvmCross.ViewModels.IMvxViewModel viewModel)
        {             
            this.ViewModels.Remove(viewModel);
            var lastViewModel = this.ViewModels.LastOrDefault() as IHandlesResult;

            if (lastViewModel != null)
            {
                lastViewModel.HandlesResult(viewModel);
            }

            base.Close(viewModel);
        }

        public override void ChangePresentation(Cirrious.MvvmCross.ViewModels.MvxPresentationHint hint)
        {
            base.ChangePresentation(hint);
        }

        protected override void Show(Android.Content.Intent intent)
        {                        
            base.Show(intent);
        }

        public override void Show(Cirrious.MvvmCross.ViewModels.MvxViewModelRequest request)
        {            
            base.Show(request);
        }
    }
}

