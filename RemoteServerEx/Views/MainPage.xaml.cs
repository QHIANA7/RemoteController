﻿using System;

using RemoteServerEx.ViewModels;

using Windows.UI.Xaml.Controls;

namespace RemoteServerEx.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
