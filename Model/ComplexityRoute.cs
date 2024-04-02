using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDashboard.Model
{
    class ComplexityRoute
    {
        public int Id { get; set; }
        public string TitleComplexity { get; set; }
        public int EnergyConsumption { get; set; }

        public ComplexityRoute(int id, string titleComplexity, int energyConsumption)
        {
            this.Id = id;
            this.TitleComplexity = titleComplexity;
            this.EnergyConsumption = energyConsumption;
        }
    }
}
