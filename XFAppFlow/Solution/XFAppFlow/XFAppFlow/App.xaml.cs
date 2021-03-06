﻿using XFAppFlow.ViewModels;
using XFAppFlow.Views;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFAppFlow
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            if(App.Current.Properties.ContainsKey("Acc"))
            {
                await NavigationService.NavigateAsync("xf:///MDPage/NaviPage/MainPage");
            }
            else
            {
                await NavigationService.NavigateAsync("LoginPage");
            }
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MDPage>();
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<PersonalPage>();
            Container.RegisterTypeForNavigation<SystemPage>();
            Container.RegisterTypeForNavigation<PreferencePage>();
            Container.RegisterTypeForNavigation<ThemePage>();
            Container.RegisterTypeForNavigation<LoginPage>();
        }
    }
}
