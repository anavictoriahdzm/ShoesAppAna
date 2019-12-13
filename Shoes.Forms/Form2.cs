using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.Business;
using Shoes.Data;

namespace Shoes.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void InsertarProd(int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal PriceDistributor, decimal PriceClient, decimal PriceMember, bool IsEnabled, string Keywords, DateTime DateUdate)
        {
            ProductsBL ObjetoNegocio = new ProductsBL();
            ObjetoNegocio.InsertarProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUdate);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int IdType = int.Parse(txtIdType.Text);
            int IdColor = int.Parse(txtIdColor.Text);
            int IdBrand = int.Parse(txtIdBrand.Text);
            int IdProvider = int.Parse(txtIdProvider.Text);
            int IdCatalog = int.Parse(txtIdCatalog.Text);
            string Title = txtTitle.Text;
            string Nombre = txtNom.Text;
            string Description = txtDescrip.Text;
            string Observations = txtObservation.Text;
            decimal PriceDistributor = decimal.Parse(txtPDistributor.Text);
            decimal PriceClient = decimal.Parse(txtPClient.Text);
            decimal PriceMember = decimal.Parse(txtPMember.Text);
            bool IsEnabled = cbIsEnable.Checked;
            string Keywords = txtKeywords.Text;
            DateTime DateUdate = dtpDateUpdate.Value;

            InsertarProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUdate);

            MessageBox.Show("Se inserto Producto correctamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdType.Text = "";
            txtIdColor.Text = "";
            txtIdBrand.Text = "";
            txtIdProvider.Text = "";
            txtIdCatalog.Text = "";txtTitle.Text = "";
            txtNom.Text = "";
            txtDescrip.Text = "";
            txtObservation.Text = "";
            txtPDistributor.Text = "";
            txtPClient.Text = "";
            txtPMember.Text = "";
            cbIsEnable.Checked = false;
            txtKeywords.Text = "";
            dtpDateUpdate.Value = DateTime.Now;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (txtId.Text != null)
            {
                DataProductsEntities dtp = new DataProductsEntities();
                ProductsBL objnegocio = new ProductsBL();

                List<AVHM_BusquedaID_Result> ListaId = objnegocio.ListaID(int.Parse(txtId.Text));
                foreach (var item in ListaId.ToList())
                {
                    try
                    {
                        txtNom.Text = item.Nombre;
                        txtIdBrand.Text = item.IdBrand.ToString();
                        txtIdCatalog.Text = item.IdCatalog.ToString();
                        txtIdColor.Text = item.IdColor.ToString();
                        txtIdProvider.Text = item.IdProvider.ToString();
                        txtIdType.Text = item.IdType.ToString();
                        txtKeywords.Text = item.Keywords;
                        txtDescrip.Text = item.Description.ToString();
                        txtPClient.Text = item.PriceClient.ToString();
                        txtObservation.Text = item.Observations.ToString();
                        txtPDistributor.Text = item.PriceDistributor.ToString();
                        txtPMember.Text = item.PriceMember.ToString();
                        txtTitle.Text = item.Title.ToString();
                        cbIsEnable.Checked = item.IsEnabled;
                        dtpDateUpdate.Value = item.DateUpdate.Value;
                    }
                    catch
                    {

                    }
                    
                }
            }
        }
    }
}
