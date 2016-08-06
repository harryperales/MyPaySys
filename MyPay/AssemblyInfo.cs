using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyPay
{
    public static class AssemblyInfo
    {
        private static Assembly assembly = Assembly.GetExecutingAssembly();

        public static string GetProduct()
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.ProductName;
        }

        public static string GetVersion()
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return string.Format("{0}.{1}", fvi.ProductMajorPart, fvi.ProductMinorPart);
        }
    }
}