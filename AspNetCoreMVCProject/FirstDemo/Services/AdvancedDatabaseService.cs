using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDemo.Services
{
    public class AdvancedDatabaseService : IDatabaseService 
    {
        public string GetName()
        {
            return "AdvancedDatabaseService";
        }
    }
}
