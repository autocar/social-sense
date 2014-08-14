using System;
using System.Configuration;

namespace SocialSense.Settings
{
    public class BingElement : ConfigurationElement
    {
        [ConfigurationProperty("token", IsRequired = true)]
        public string Token
        {
            get { return Convert.ToString (this ["token"]); }
        }
    }
}

