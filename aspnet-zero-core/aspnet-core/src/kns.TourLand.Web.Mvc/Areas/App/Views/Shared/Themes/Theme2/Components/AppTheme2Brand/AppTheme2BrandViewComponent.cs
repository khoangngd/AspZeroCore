﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kns.TourLand.Web.Areas.App.Models.Layout;
using kns.TourLand.Web.Session;
using kns.TourLand.Web.Views;

namespace kns.TourLand.Web.Areas.App.Views.Shared.Themes.Theme2.Components.AppTheme2Brand
{
    public class AppTheme2BrandViewComponent : TourLandViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme2BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}