using System;
using LeCong.AbpZeroTemplate.ViewModels.Base;

namespace LeCong.AbpZeroTemplate.Models.NavigationMenu
{
    public class NavigationMenuItem : ExtendedBindableObject
    {
        private bool _isSelected;

        public string Title { get; set; }

        public string Icon { get; set; }

        public Type ViewType { get; set; }

        public object NavigationParameter { get; set; }

        public string RequiredPermissionName { get; set; }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                RaisePropertyChanged(() => IsSelected);
            }
        }
    }
}
