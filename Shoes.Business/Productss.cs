using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoes.Data;
using System.Data;

namespace Shoes.Business
{
    public class Productss
    {
        public int p_idType { get; set; }
        public int p_idColor { get; set; }
        public int p_idBrand { get; set; }
        public int p_idProvider { get; set; }
        public int p_idCatalog { get; set; }
        public String p_Title { get; set; }
        public String p_Nombre { get; set; }
        public String p_Description { get; set; }
        public String p_Observations { get; set; }
        public Decimal p_PriceDistributor { get; set; }
        public Decimal p_PriceClient { get; set; }
        public Decimal p_PriceMember { get; set; }
        public Boolean p_IsEnable { get; set; }
        public String p_Keywords { get; set; }
        public DateTime p_DateUpdate { get; set; }

    }

    
 }
