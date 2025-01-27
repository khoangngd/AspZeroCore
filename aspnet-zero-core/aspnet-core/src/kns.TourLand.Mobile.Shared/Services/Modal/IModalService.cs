﻿using System.Threading.Tasks;
using kns.TourLand.Views;
using Xamarin.Forms;

namespace kns.TourLand.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
