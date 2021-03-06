﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFNavi.ViewModels
{

    public class NextPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public DelegateCommand GoBackCommand { get; set; }

        private readonly INavigationService _navigationService;

        public NextPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoBackCommand = new DelegateCommand(() =>
            {
                _navigationService.GoBackAsync();
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Console.WriteLine($"  ------------  NextPage OnNavigatedFrom");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Console.WriteLine($"  ------------  NextPage OnNavigatingTo");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Console.WriteLine($"  ------------  NextPage OnNavigatedTo");
        }

    }

}
