﻿

namespace Core.Configuration
{
    public class BrowserConfiguration : IConfiguration
    {
        public string SectionName => "Browser";

        public bool Hedless { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int TimeOut { get; set; }
    }
}
