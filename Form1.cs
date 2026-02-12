using Conexion_con__bases_de_datos_y_entity_framework__Brithany_Hidalgo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_con__bases_de_datos_y_entity_framework__Brithany_Hidalgo
{
    public partial class Form1 : Form
    {
        private void CargarProductos()
        {
            using (var db = new Datos.ConexionBDEntities())
            {
                dataGridView1.DataSource = db.Prodcuto.ToList();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            using (var db = new Datos.ConexionBDEntities())
            {
                Prodcuto p = new Prodcuto
                {
                    Nombre = Nombrebox.Text,
                    Precio = decimal.Parse(Preciobox.Text),
                    Stock = int.Parse(Stockbox.Text)
                };

                db.Prodcuto.Add(p);
                db.SaveChanges();
            }

            MessageBox.Show("Producto insertado correctamente");
 
            CargarProductos();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            using (var db = new Datos.ConexionBDEntities())
            {
                dataGridView1.DataSource = db.Prodcuto.ToList();
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDbox.Text);

            using (var db = new Datos.ConexionBDEntities())
            {
                Prodcuto p = db.Prodcuto.Find(id);

                if (p != null)
                {
                    p.Precio = decimal.Parse(Preciobox.Text);
                    p.Stock = int.Parse(Stockbox.Text);

                    db.SaveChanges();
                    MessageBox.Show("Producto actualizado correctamente");

                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDbox.Text);

            using (var db = new Datos.ConexionBDEntities())
            {
                Prodcuto p = db.Prodcuto.Find(id);

                if (p != null)
                {
                    db.Prodcuto.Remove(p);
                    db.SaveChanges();
                    MessageBox.Show("Producto eliminado correctamente");

                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Producto no encontrados");
                }
            }
        }

    }
}






