using System;
using Cirrious.MvvmCross.ViewModels;

namespace ThinkOut.ViewModels
{
    public interface IHandlesResult
    {
        void HandlesResult(IMvxViewModel model);
    }
}

