using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoes.Data;

namespace Shoes.Business
{
    public class ProductsBL
    {
        DataProductsEntities modeldb = new DataProductsEntities();

        public List<AVHM_MostrarProducts_Result> ListaProductos()
        {
            DatoProducts datoProducts = new DatoProducts();
            return datoProducts.ListaProductos();
        }

        public List<AVHM_BusquedaID_Result> ListaID(int Id)
        {
            DatoProducts buscarId = new DatoProducts();
            return buscarId.ListaID(Id);
        }

        public List<AVHM_BusquedaNombre_Result> ListaNombre(string Nombre)
        {
            DatoProducts buscarNombre = new DatoProducts();
            return buscarNombre.ListaNombre(Nombre);
        }

        public void InsertarProd(int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal PriceDistributor, decimal PriceClient, decimal PriceMember, bool IsEnabled, string Keywords, DateTime DateUdate)
        {
            DatoProducts ObjetoDatos = new DatoProducts();
            ObjetoDatos.InsertarProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUdate);
        }
    }
}
