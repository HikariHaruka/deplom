using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroProPlanProductionApp.Entities
{
    public partial class Balloon
    {
        public string NameBalloon
        {
            get
            {
                var nameBalloon = $"{Diameter} {Description}";

                return nameBalloon;

            }
        }
    }
}
