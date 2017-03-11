﻿using System;
using System.Resources;
using System.Reflection;

namespace Ant.Tools.SOA.Util
{
    /// <summary>
    /// This is a helper class which allows to read the resource file entries.
    /// </summary>
    public class ResourceHelper
    {
        public ResourceHelper()
        {
        }

        public static string GetString(string baseName, Assembly assembly, string key)
        {
            ResourceManager rm = new ResourceManager(baseName, assembly);
            return rm.GetString(key);
        }
    }
}
