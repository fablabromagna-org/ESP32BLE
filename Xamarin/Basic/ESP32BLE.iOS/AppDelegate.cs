﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using nexus.protocols.ble;
using nexus.core.logging;
using UIKit;
using Xamarin.Forms;
using FFImageLoading.Forms.Platform;

namespace ESP32BLE.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            FormsMaterial.Init();
            CachedImageRenderer.Init();
            Syncfusion.SfChart.XForms.iOS.Renderers.SfChartRenderer.Init();

            LoadApplication(new App(BluetoothLowEnergyAdapter.ObtainDefaultAdapter()));
            UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

            return base.FinishedLaunching(app, options);
        }
    }
}
