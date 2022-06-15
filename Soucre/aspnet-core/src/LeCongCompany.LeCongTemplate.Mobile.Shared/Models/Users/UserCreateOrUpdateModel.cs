using System.ComponentModel;
using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Authorization.Users.Dto;

namespace LeCongCompany.LeCongTemplate.Models.Users
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}