using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tls.demo.MultiTenancy.HostDashboard.Dto;

namespace tls.demo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}