using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_E_Commerce_App.Helpers
{
    public static class FileHelper
    {
        public static string GetFilePath(string fileName)
        {
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }
    }
}
