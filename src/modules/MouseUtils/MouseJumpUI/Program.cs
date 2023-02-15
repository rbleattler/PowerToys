// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Windows.Forms;

namespace MouseJumpUI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        if (Application.HighDpiMode != HighDpiMode.PerMonitorV2)
        {
            throw new InvalidOperationException("high dpi mode is not set to PerMonitorV2");
        }

        Application.Run(new MainForm());
    }
}