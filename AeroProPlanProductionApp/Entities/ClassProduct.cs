using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroProPlanProductionApp.Entities
{
    public partial class Product
    {
        public string NameProduct
        {
            get
            {
                var nameProduct = $"{ProductType.TypeProduct} {Balloon.NameBalloon}";

                return nameProduct;

            }
        }
    }
}
