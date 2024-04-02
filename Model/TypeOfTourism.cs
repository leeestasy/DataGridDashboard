using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDashboard.Model
{
    class TypeOfTourism
    {
        public int Id { get; set; }
        public string TitleType { get; set; }
        public TypeOfTourism(int id, string titleType)
        {
            this.Id = id;
            this.TitleType = titleType;
        }
    }
}
