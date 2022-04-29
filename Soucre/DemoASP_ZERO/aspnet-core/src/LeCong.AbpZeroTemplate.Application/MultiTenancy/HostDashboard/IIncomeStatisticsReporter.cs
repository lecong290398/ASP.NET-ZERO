using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.MultiTenancy.HostDashboard.Dto;

namespace LeCong.AbpZeroTemplate.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}