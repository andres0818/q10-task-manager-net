using Microsoft.Extensions.Configuration;
using Q10.TaskManager.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10.TaskManager.Infraestructure.Repositories
{
    public class SettingRepository : IConfig
    {
        public IConfiguration Configuration { get; set;}
        public SettingRepository(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public string GetValues(string key)
        {
            return Configuration[key];
        }
    }
}
