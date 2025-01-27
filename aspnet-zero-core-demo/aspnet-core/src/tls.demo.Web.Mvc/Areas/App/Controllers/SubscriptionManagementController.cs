﻿using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using tls.demo.Authorization;
using tls.demo.Web.Areas.App.Models.Editions;
using tls.demo.Web.Controllers;
using tls.demo.Web.Session;

namespace tls.demo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)]
    public class SubscriptionManagementController : demoControllerBase
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public SubscriptionManagementController(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<ActionResult> Index()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            var model = new SubscriptionDashboardViewModel
            {
                LoginInformations = loginInfo
            };

            return View(model);
        }
    }
}