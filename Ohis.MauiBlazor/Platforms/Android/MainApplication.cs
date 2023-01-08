﻿using Android.App;
using Android.Runtime;

namespace Ohis.MauiBlazor
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiBlazorProgram.CreateMauiApp();
    }
}