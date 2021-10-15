using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kns.TourLand.MultiTenancy.HostDashboard.Dto;

namespace kns.TourLand.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}