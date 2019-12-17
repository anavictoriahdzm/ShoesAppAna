using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shoes.Data
{
    public class DatoProducts
    {
        DataProductsEntities modeldb = new DataProductsEntities();

        //Metodo con storeProcedure muestra todo los datos en el datagridview 
        public List<AVHM_MostrarProducts_Result> ListaProductos()
        {
            List<AVHM_MostrarProducts_Result> MostrarTodo = new List<AVHM_MostrarProducts_Result>();
            foreach (var item in modeldb.AVHM_MostrarProducts().ToList())
            {
                AVHM_MostrarProducts_Result spMostrar = new AVHM_MostrarProducts_Result();
                spMostrar.Id = item.Id;
                spMostrar.IdType = item.IdType;
                spMostrar.IdColor = item.IdColor;
                spMostrar.IdBrand = item.IdBrand;
                spMostrar.IdProvider = item.IdProvider;
                spMostrar.IdCatalog = item.IdCatalog;
                spMostrar.Title = item.Title;
                spMostrar.Nombre = item.Nombre;
                spMostrar.Description = item.Description;
                spMostrar.Observations = item.Observations;
                spMostrar.PriceDistributor = item.PriceDistributor;
                spMostrar.PriceClient = item.PriceClient;
                spMostrar.PriceMember = item.PriceMember;
                spMostrar.IsEnabled = item.IsEnabled;
                spMostrar.Keywords = item.Keywords;
                spMostrar.DateUpdate = item.DateUpdate;

                MostrarTodo.Add(spMostrar);

              
            }
            return MostrarTodo;
        }

        public List<AVHM_BusquedaID_Result> ListaID(int Id)
        {
                List<AVHM_BusquedaID_Result> BusquedaID = new List<AVHM_BusquedaID_Result>();
                foreach (var item in modeldb.AVHM_BusquedaID(Id).ToList())
                {
                    AVHM_BusquedaID_Result ID = new AVHM_BusquedaID_Result();
                    ID.Id = item.Id;
                    ID.IdType = item.IdType;
                    ID.IdColor = item.IdColor;
                    ID.IdBrand = item.IdBrand;
                    ID.IdProvider = item.IdProvider;
                    ID.IdCatalog = item.IdCatalog;
                    ID.Title = item.Title;
                    ID.Nombre = item.Nombre;
                    ID.Description = item.Description;
                    ID.Observations = item.Observations;
                    ID.PriceDistributor = item.PriceDistributor;
                    ID.PriceClient = item.PriceClient;
                    ID.PriceMember = item.PriceMember;
                    ID.IsEnabled = item.IsEnabled;
                    ID.Keywords = item.Keywords;
                    ID.DateUpdate = item.DateUpdate;

                    BusquedaID.Add(ID);
                }
                return BusquedaID;
        }

        public List<AVHM_BusquedaNombre_Result> ListaNombre(string Nombre)
        {
            List<AVHM_BusquedaNombre_Result> BusquedaNombre = new List<AVHM_BusquedaNombre_Result>();
            foreach (var item in modeldb.AVHM_BusquedaNombre(Nombre).ToList())
            {
                AVHM_BusquedaNombre_Result Nom = new AVHM_BusquedaNombre_Result();
                Nom.Id = item.Id;
                Nom.IdType = item.IdType;
                Nom.IdColor = item.IdColor;
                Nom.IdBrand = item.IdBrand;
                Nom.IdProvider = item.IdProvider;
                Nom.IdCatalog = item.IdCatalog;
                Nom.Title = item.Title;
                Nom.Nombre = item.Nombre;
                Nom.Description = item.Description;
                Nom.Observations = item.Observations;
                Nom.PriceDistributor = item.PriceDistributor;
                Nom.PriceClient = item.PriceClient;
                Nom.PriceMember = item.PriceMember;
                Nom.IsEnabled = item.IsEnabled;
                Nom.Keywords = item.Keywords;
                Nom.DateUpdate = item.DateUpdate;

                BusquedaNombre.Add(Nom);
            }
            return BusquedaNombre;
        }

        public void InsertarProd(int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal PriceDistributor, decimal PriceClient, decimal PriceMember, bool IsEnabled, string Keywords, DateTime DateUdate)
        {
            modeldb.AVHM_SP_InsertProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUdate);
        }

        public void ModificarProd(int Id, int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal PriceDistributor, decimal PriceClient, decimal PriceMember, bool IsEnabled, string Keywords, DateTime DateUdate)
        {
            modeldb.AVHM_Modificar(Id, IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUdate);
        }

        public void EliminarProd(int Id)
        {
            modeldb.AVHM_Eliminar(Id);
        }
    }
}
