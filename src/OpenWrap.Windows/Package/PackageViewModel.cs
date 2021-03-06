﻿using System;
using OpenWrap.Windows.Framework;

namespace OpenWrap.Windows.Package
{
    public class PackageViewModel : ViewModelBase
    {
        public string Name { get; set;  }
        public string Version { get; set; }
        public string ShortVersion { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }

        public DateTimeOffset Created { get; set; }
        public bool Anchored { get; set; }
        public bool Nuked { get; set; }
    }
}
