using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MobileApp.MVVM.Models;

namespace MobileApp.MVVM.ViewModels
{
    [QueryProperty(nameof(Contact), "Contact")]

    public partial class DetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ContactModel contact;
    }
}
