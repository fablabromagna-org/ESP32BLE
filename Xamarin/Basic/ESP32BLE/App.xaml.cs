﻿using System;
using nexus.protocols.ble;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESP32BLE
{
    public partial class App : Application
    {
        public App(IBluetoothLowEnergyAdapter adapter)
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage( adapter ) );
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
