﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shoes.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DataProductsEntities : DbContext
    {
        public DataProductsEntities()
            : base("name=DataProductsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatBrands> CatBrands { get; set; }
        public virtual DbSet<CatCatalogs> CatCatalogs { get; set; }
        public virtual DbSet<CatColors> CatColors { get; set; }
        public virtual DbSet<CatProviders> CatProviders { get; set; }
        public virtual DbSet<CatRatings> CatRatings { get; set; }
        public virtual DbSet<CatSizes> CatSizes { get; set; }
        public virtual DbSet<CatTypeDetails> CatTypeDetails { get; set; }
        public virtual DbSet<CatTypeProduct> CatTypeProduct { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<database_firewall_rules1> database_firewall_rules1 { get; set; }
        public virtual DbSet<DetailProduct> DetailProduct { get; set; }
        public virtual DbSet<ImagesProduct> ImagesProduct { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<SimilarProduct> SimilarProduct { get; set; }
        public virtual DbSet<SizeForProduct> SizeForProduct { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<database_firewall_rules2> database_firewall_rules2 { get; set; }
    
        public virtual ObjectResult<AVHM_BusquedaID_Result> AVHM_BusquedaID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AVHM_BusquedaID_Result>("AVHM_BusquedaID", idParameter);
        }
    
        public virtual ObjectResult<AVHM_BusquedaNombre_Result> AVHM_BusquedaNombre(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AVHM_BusquedaNombre_Result>("AVHM_BusquedaNombre", nombreParameter);
        }
    
        public virtual int AVHM_Modificar(Nullable<int> id, Nullable<int> idType, Nullable<int> idColor, Nullable<int> idBrand, Nullable<int> idProvider, Nullable<int> idCatalog, string title, string nombre, string description, string observations, Nullable<decimal> priceDistributor, Nullable<decimal> priceClient, Nullable<decimal> priceMember, Nullable<bool> isEnabled, string keywords, Nullable<System.DateTime> dateUpdate)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("idType", idType) :
                new ObjectParameter("idType", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            var idBrandParameter = idBrand.HasValue ?
                new ObjectParameter("idBrand", idBrand) :
                new ObjectParameter("idBrand", typeof(int));
    
            var idProviderParameter = idProvider.HasValue ?
                new ObjectParameter("idProvider", idProvider) :
                new ObjectParameter("idProvider", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("idCatalog", idCatalog) :
                new ObjectParameter("idCatalog", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var observationsParameter = observations != null ?
                new ObjectParameter("Observations", observations) :
                new ObjectParameter("Observations", typeof(string));
    
            var priceDistributorParameter = priceDistributor.HasValue ?
                new ObjectParameter("PriceDistributor", priceDistributor) :
                new ObjectParameter("PriceDistributor", typeof(decimal));
    
            var priceClientParameter = priceClient.HasValue ?
                new ObjectParameter("PriceClient", priceClient) :
                new ObjectParameter("PriceClient", typeof(decimal));
    
            var priceMemberParameter = priceMember.HasValue ?
                new ObjectParameter("PriceMember", priceMember) :
                new ObjectParameter("PriceMember", typeof(decimal));
    
            var isEnabledParameter = isEnabled.HasValue ?
                new ObjectParameter("IsEnabled", isEnabled) :
                new ObjectParameter("IsEnabled", typeof(bool));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var dateUpdateParameter = dateUpdate.HasValue ?
                new ObjectParameter("DateUpdate", dateUpdate) :
                new ObjectParameter("DateUpdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AVHM_Modificar", idParameter, idTypeParameter, idColorParameter, idBrandParameter, idProviderParameter, idCatalogParameter, titleParameter, nombreParameter, descriptionParameter, observationsParameter, priceDistributorParameter, priceClientParameter, priceMemberParameter, isEnabledParameter, keywordsParameter, dateUpdateParameter);
        }
    
        public virtual ObjectResult<AVHM_MostrarProducts_Result> AVHM_MostrarProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AVHM_MostrarProducts_Result>("AVHM_MostrarProducts");
        }
    
        public virtual int AVHM_SP_InsertProd(Nullable<int> idType, Nullable<int> idColor, Nullable<int> idBrand, Nullable<int> idProvider, Nullable<int> idCatalog, string title, string nombre, string description, string observations, Nullable<decimal> priceDistributor, Nullable<decimal> priceClient, Nullable<decimal> priceMember, Nullable<bool> isEnabled, string keywords, Nullable<System.DateTime> dateUpdate)
        {
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("idType", idType) :
                new ObjectParameter("idType", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            var idBrandParameter = idBrand.HasValue ?
                new ObjectParameter("idBrand", idBrand) :
                new ObjectParameter("idBrand", typeof(int));
    
            var idProviderParameter = idProvider.HasValue ?
                new ObjectParameter("idProvider", idProvider) :
                new ObjectParameter("idProvider", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("idCatalog", idCatalog) :
                new ObjectParameter("idCatalog", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var observationsParameter = observations != null ?
                new ObjectParameter("Observations", observations) :
                new ObjectParameter("Observations", typeof(string));
    
            var priceDistributorParameter = priceDistributor.HasValue ?
                new ObjectParameter("PriceDistributor", priceDistributor) :
                new ObjectParameter("PriceDistributor", typeof(decimal));
    
            var priceClientParameter = priceClient.HasValue ?
                new ObjectParameter("PriceClient", priceClient) :
                new ObjectParameter("PriceClient", typeof(decimal));
    
            var priceMemberParameter = priceMember.HasValue ?
                new ObjectParameter("PriceMember", priceMember) :
                new ObjectParameter("PriceMember", typeof(decimal));
    
            var isEnabledParameter = isEnabled.HasValue ?
                new ObjectParameter("IsEnabled", isEnabled) :
                new ObjectParameter("IsEnabled", typeof(bool));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var dateUpdateParameter = dateUpdate.HasValue ?
                new ObjectParameter("DateUpdate", dateUpdate) :
                new ObjectParameter("DateUpdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AVHM_SP_InsertProd", idTypeParameter, idColorParameter, idBrandParameter, idProviderParameter, idCatalogParameter, titleParameter, nombreParameter, descriptionParameter, observationsParameter, priceDistributorParameter, priceClientParameter, priceMemberParameter, isEnabledParameter, keywordsParameter, dateUpdateParameter);
        }
    
        public virtual int AVHM_Eliminar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AVHM_Eliminar", idParameter);
        }
    
        public virtual int AVHM_EliminarLogico(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AVHM_EliminarLogico", idParameter);
        }
    }
}
