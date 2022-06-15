using System.ComponentModel;
using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.MultiTenancy.Dto;

namespace LeCongCompany.LeCongTemplate.Models.Tenants
{
    [AutoMapFrom(typeof(TenantEditDto))]
    public class TenantEditModel : TenantEditDto, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}