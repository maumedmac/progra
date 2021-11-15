using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_LOGICA_NEGOCIO;
using CAPA_ENTIDAD;
using System.IO;
namespace CAPA_PRESENTACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductoCN objProdCN = new ProductoCN();
        CategoriaCN obCateCN = new CategoriaCN();
        Categoria objCateE = new Categoria();
        Marca objMaE = new Marca();
        MarcaCN objMaCN = new MarcaCN();
        Producto objPE = new Producto();
        ProductoCN objPCN = new ProductoCN();
        ProductoCategoriaCN objPxCCN =new  ProductoCategoriaCN();
        // PARA  SERIALIZAR
        OpenFileDialog OP = new OpenFileDialog();
       
        private void Form1_Load(object sender, EventArgs e)
        {
           // dgvProducto.DataSource = objProdCN.mostrarProducto();
            dgvCategoria.DataSource = obCateCN.MostrarCATEGORIA();
            dgvMarca.DataSource = objMaCN.MOSTRARmarca();
            dgvProductos.DataSource = objProdCN.MOSTRARproducto();
            dgvProductosXcategoria.DataSource = objPxCCN.MOSTRARclasificacion1();

            
            // LLENAR LOS COMBOBOX
            llenarMARCA();
            llenarCATEGORIA();
            llenarProducto();
            //llenarPRODUCTOxCATEGORIA();
        }
        
        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            objCateE.idCategoria = txtIdCategoria.Text;
            objCateE.descripcionC = txtDescripcionC.Text;
            try
            {
                obCateCN.AGREGARcategoria(objCateE);
                dgvCategoria.DataSource = obCateCN.MostrarCATEGORIA();
                MessageBox.Show("Se registro");
            }
            catch(Exception x)
            {
                MessageBox.Show("No Se registro"+ x);
            }
            
        }

        private void dgvCategoria_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           txtIdCategoria.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
           txtDescripcionC.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            objCateE.idCategoria = txtIdCategoria.Text;
            objCateE.descripcionC = txtDescripcionC.Text;
            try
            {
                obCateCN.ELIMINARcategoria(objCateE);
                dgvCategoria.DataSource = obCateCN.MostrarCATEGORIA();
                MessageBox.Show("se elimino");
            }
            catch(Exception x)
            {
                MessageBox.Show("NO se elimino");
            }
            
            
                    }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            objCateE.idCategoria = txtIdCategoria.Text;
            objCateE.descripcionC = txtDescripcionC.Text;
            try
            {
                obCateCN.MODIFICARcategoria(objCateE);
                dgvCategoria.DataSource = obCateCN.MostrarCATEGORIA();
                MessageBox.Show("se MODIFICO");
            }
            catch (Exception x)
            {
                MessageBox.Show("NO se MODIFICO");
            }
            
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            objMaE.idMarca = txtIdMarca.Text;
            objMaE.descricionM = txtDescripcionM.Text;
            // SEREALIZANDO
            
                PictureBox imagen = pbxImagenMarca;
                MemoryStream ms = new MemoryStream();
                if(pbxImagenMarca.Image!=null)
                {
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                objMaE.fotoM = ms.GetBuffer();
                try
                {
                    objMaCN.AGREGARmarca(objMaE);
                    dgvMarca.DataSource = objMaCN.MOSTRARmarca();

                    MessageBox.Show("se registro");

                }
                catch (Exception x)
                {
                    MessageBox.Show("no se registro");

                }

            }
                
            

          
            
           
            
        }

        private void btnImagenM_Click(object sender, EventArgs e)
        {
            OP.Filter = "Archivo jpg|*.jpg";
            if (OP.ShowDialog() != DialogResult.OK);
            {
                pbxImagenMarca.Image = Image.FromFile(OP.FileName);
            }
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            objMaE.idMarca = txtIdMarca.Text;
            objMaE.descricionM = txtDescripcionM.Text;
            
            try
            {
                objMaCN.ELIMINARmarca(objMaE);
                dgvMarca.DataSource = objMaCN.MOSTRARmarca();
                
                MessageBox.Show("se elimino");
            }
            catch (Exception )
            {
                MessageBox.Show("NO se elimino");
            }
            
            
        }

        private void btnModificarM_Click(object sender, EventArgs e)
        {
            objMaE.idMarca = txtIdMarca.Text;
            objMaE.descricionM = txtDescripcionM.Text;
            // SEREALIZANDO
            PictureBox imagen = pbxImagenMarca;
            MemoryStream ms = new MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            objMaE.fotoM = ms.GetBuffer();

            try
            {
                objMaCN.MODIFICARmarca(objMaE);
                dgvMarca.DataSource = objMaCN.MOSTRARmarca();

                MessageBox.Show("se registro");

            }
            catch (Exception x)
            {
                MessageBox.Show("no se registro");

            }
            
        }

        private void dgvMarca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdMarca.Text = dgvMarca.CurrentRow.Cells[0].Value.ToString();
            txtDescripcionM.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString();
            byte[] dato = new byte[0];
            dato = (byte[])dgvMarca.CurrentRow.Cells[2].Value;

            MemoryStream ms = new MemoryStream(dato);
           Image imagen = Image.FromStream(ms);
           pbxImagenMarca.Image = imagen;
            
           
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            objPE.idProducto = txtIdProducto.Text;
            objPE.nombre = txtNombreP.Text;
            objPE.precioC = float.Parse(txtPrecioC.Text);
            objPE.precioV = float.Parse(txtPrecioV.Text);
            
            // SEREALIZANDO
            PictureBox imagen = pbxImagenProducto;
            MemoryStream ms = new MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            objPE.foto = ms.GetBuffer();

            try
            {
                objPCN.AGREGARproducto(objPE);
                dgvProductos.DataSource = objProdCN.MOSTRARproducto();

                MessageBox.Show("se registro");

            }
            catch (Exception x)
            {
                MessageBox.Show("no se registro");

            }

            
           
        }

        private void txtEliminarP_Click(object sender, EventArgs e)
        {
            objPE.idProducto = txtIdProducto.Text;
            objPE.nombre = txtNombreP.Text;
            
            try
            {
                objProdCN.ELIMINARproducto(objPE);
                dgvMarca.DataSource = objProdCN.MOSTRARproducto();

                MessageBox.Show("se elimino");
            }
            catch (Exception)
            {
                MessageBox.Show("NO se elimino");
            }
            
            
        }

        private void txtModificarP_Click(object sender, EventArgs e)
        {
            objPE.idProducto = txtIdProducto.Text;
            objPE.nombre = txtNombreP.Text;
            objPE.precioC = float.Parse(txtPrecioC.Text);
            objPE.precioV = float.Parse(txtPrecioV.Text);
            // SEREALIZANDO
            PictureBox imagen = pbxImagenProducto;
            MemoryStream ms = new MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            objPE.foto = ms.GetBuffer();

            try
            {
                objProdCN.MODIFICARproducto(objPE);
                dgvMarca.DataSource = objMaCN.MOSTRARmarca();

                MessageBox.Show("se registro");

            }
            catch (Exception x)
            {
                MessageBox.Show("no se registro");

            }
        }

        private void dgvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombreP.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecioC.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtPrecioV.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();

            byte[] dato = new byte[0];
            dato = (byte[])dgvProductos.CurrentRow.Cells[2].Value;

            MemoryStream ms = new MemoryStream(dato);
            Image imagen = Image.FromStream(ms);
            pbxImagenProducto.Image = imagen;
        }

        private void btnImagenProducto_Click(object sender, EventArgs e)
        {
            OP.Filter = "Archivo jpg|*.jpg";
            if (OP.ShowDialog() == DialogResult.OK) 
            {
                pbxImagenProducto.Image = Image.FromFile(OP.FileName);
            }
        }
        // AQUI VA  PROCEDIMIENTO PARA MOSTRAR EN EL COMBOBOX DE MARCA
        void llenarMARCA()
        {
            cboMarcaP.DataSource = objMaCN.MOSTRARmarca();
            cboMarcaP.DisplayMember = "descripcionM";
            cboMarcaP.ValueMember = "idMarca";
            
        }

        void llenarCATEGORIA()
        {
            
           cboCategoriaP.DataSource = obCateCN.MostrarCATEGORIA();
           cboCategoriaP.DisplayMember = "DescripcionCat";
           cboCategoriaP.ValueMember = "idCategoria";
            

        }

        void llenarProducto()
        {
            cboProducto.DataSource = objProdCN.MOSTRARproducto();
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "idProducto";
        }

        string idMarca;
        string idCategoria;
        string idProducto;
        private void cboMarcaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMarca = cboMarcaP.SelectedValue.ToString();
        }

        private void cboCategoriaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCategoria = cboCategoriaP.SelectedValue.ToString();
        }

        private void txtPrecioV_TextChanged(object sender, EventArgs e)
        {

        }

        //void llenarPRODUCTOxCATEGORIA()
        //{

        //    cboCategoriaP.DataSource = objPxCCN.MOSTRARclasificacion(objMaE, objCateE);
        //    cboCategoriaP.DisplayMember = "DescripcionCat";
        //    cboCategoriaP.ValueMember = "idCategoria";
        //}

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProducto = cboProducto.SelectedValue.ToString();
            dgvProductosXcategoria.DataSource = objPxCCN.MOSTRARclasificacion1();

        }
        ProductoCategoria objPCE = new ProductoCategoria();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objPCE.clasi = txtClasi.Text;
            objPCE.idCategoria = idCategoria;
            objPCE.idMarca = idMarca;
            objPCE.idProducto = idProducto;
              try
            {
                objPxCCN.AGREGARproductoXcategoria(objPCE);
                dgvProductosXcategoria.DataSource = objPxCCN.MOSTRARclasificacion1();
                MessageBox.Show("se registro");


            }
            catch (Exception x)
            {
                MessageBox.Show("no se registro");

            }

            dgvProductos.DataSource = objPxCCN.MOSTRARclasificacion1();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objPCE.clasi=dgvProductosXcategoria.CurrentRow.Cells[0].Value.ToString();
            objPxCCN.EliminarPxC(objPCE);
            dgvProductosXcategoria.DataSource = objPxCCN.MOSTRARclasificacion1();

        }

        private void dgvProductosXcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //txtIdProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvProductosXcategoria_DoubleClick(object sender, EventArgs e)
        {
            txtClasi.Text = dgvProductosXcategoria.CurrentRow.Cells[0].Value.ToString();
            cboCategoriaP.Text= dgvProductosXcategoria.CurrentRow.Cells[3].Value.ToString();
            cboMarcaP.Text= dgvProductosXcategoria.CurrentRow.Cells[2].Value.ToString();
            cboProducto.Text = dgvProductosXcategoria.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objPCE.clasi = txtClasi.Text;
            objPCE.idCategoria = cboCategoriaP.Text;
            objPCE.idMarca = cboMarcaP.Text;
            objPCE.idProducto = cboProducto.Text;
            
            
            try
            {
                objPxCCN.MODIFICARpxc(objPCE);
                dgvProductosXcategoria.DataSource = objPxCCN.MOSTRARclasificacion1();
                MessageBox.Show("se registro");
                dgvProductosXcategoria.Refresh();


            }
            catch (Exception x)
            {
                MessageBox.Show("no se registro");

            }
            dgvProductos.DataSource = objPxCCN.MOSTRARclasificacion1();
        }

        // JOIN  O FUSION  DE TABLAS CATEGORIA,MARCA Y PRODUCTO

    }
}
