﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kns.TourLand.Web.Areas.App.Models.Layout;
using kns.TourLand.Web.Session;
using kns.TourLand.Web.Views;

namespace kns.TourLand.Web.Areas.App.Views.Shared.Themes.Theme6.Components.AppTheme6Footer
{
    public class AppTheme6FooterViewComponent : TourLandViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme6FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
