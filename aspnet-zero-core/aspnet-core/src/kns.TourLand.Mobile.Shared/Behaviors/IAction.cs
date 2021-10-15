﻿using Xamarin.Forms.Internals;

namespace kns.TourLand.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}