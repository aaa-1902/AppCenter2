using Microsoft.AppCenter.Crashes;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCenter2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            CrashCommand = new DelegateCommand(Crash);
        }

        private void Crash()
        {
            Crashes.GenerateTestCrash();
        }

        public DelegateCommand CrashCommand { get; set; }
    }
}
