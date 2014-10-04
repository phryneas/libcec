using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LibCECTray.controller.applications.@internal
{
    internal class AnyForegroundApplication : ApplicationController
    {

        public AnyForegroundApplication(CECController controller) :
      base(controller,
           "AnyForegroundApplication",
           "",
           "",
           Environment.SystemDirectory)
    {
      IsInternal = true;
      AutoStartApplication.Value = false;
      ControlApplication.Value = true;
    }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();


        /// <summary>
        /// The main window handle of the application if it's running.
        /// </summary>
        /// <returns>The main window handle, or IntPtr.Zero if it's not found</returns>
        override protected IntPtr FindInstance()
        {
            return GetForegroundWindow();
        }
    }
}
