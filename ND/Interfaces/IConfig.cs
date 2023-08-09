using ND.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetWebsite();
    }
}
