using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.MultiTenancy.HostDashboard.Dto;

namespace LeCongCompany.LeCongTemplate.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}