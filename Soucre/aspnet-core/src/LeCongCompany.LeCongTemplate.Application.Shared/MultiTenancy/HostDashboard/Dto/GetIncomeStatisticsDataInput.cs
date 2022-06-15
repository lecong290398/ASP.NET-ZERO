namespace LeCongCompany.LeCongTemplate.MultiTenancy.HostDashboard.Dto
{
    public class GetIncomeStatisticsDataInput : DashboardInputBase
    {
        public ChartDateInterval IncomeStatisticsDateInterval { get; set; }
    }
}