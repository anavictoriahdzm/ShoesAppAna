﻿using System;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = LlenarGrid();
        }


        private List<AVHM_MostrarProducts_Result> LlenarGrid()  //ProductBL es classe de capa Negocio
        {
            ProductsBL negocioProducto = new ProductsBL();
            return negocioProducto.ListaProductos();
        }

        private List<AVHM_BusquedaID_Result> BusquedaID(int Id) //ProductBL clase de negocio
        {
            ProductsBL negocioBusquedaID = new ProductsBL();
            return negocioBusquedaID.ListaID(Id);
        }

        private void btnBuscarIDS_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = BusquedaID(int.Parse(txtIDS.Text));
        }

        private List<AVHM_BusquedaNombre_Result> BusquedaNombre(string Nombre)
        {
            ProductsBL negocioBusquedaNombre = new ProductsBL();
            return negocioBusquedaNombre.ListaNombre(Nombre);
        }

        private void btnBuscarNom_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = BusquedaNombre(txtNombre.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDS.Text = "";
            txtNombre.Text = "";
            dgvDatos.DataSource = LlenarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Shoes.Forms.Form2 Frm2 = new Shoes.Forms.Form2();
            Frm2.ShowDialog();
        }
    }
}
