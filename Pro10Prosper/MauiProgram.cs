﻿using Microsoft.Extensions.Logging;
using Pro10Prosper.Repositories;
using Pro10Prosper.MVVM.Models;
using Syncfusion.Maui.Core.Hosting;


namespace Pro10Prosper
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Black.ttf", "Strong");
                    fonts.AddFont("LibreFranflin-Regular.ttf", "Regular");
                });

//#if DEBUG
//    		builder.Logging.AddDebug();
//#endif

            builder.Services.AddSingleton<BaseRepository<Transaction>>();

            return builder.Build();
        }
    }
}
