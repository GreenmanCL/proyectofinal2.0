/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 08/12/2025
 * Time: 02:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PASTELERIA
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		double precio = 0, cant = 0, subtotal = 0, descuento = 0;
		int cntcompras = 0;
		
		void RdbSaladoClick(object sender, EventArgs e)
		{
			rdbDulce.ForeColor = Color.Red;
			rdbSalado.ForeColor = Color.Green;
			cmbproductos.Items.Clear();
			cmbproductos.Items.Add("Quesabirria");
			cmbproductos.Items.Add("crepa salada");
			cmbproductos.Items.Add("Albondigas");
			cmbproductos.Items.Add("Sopa");
			cmbproductos.Items.Add("Enchiladas verdes");
		}
		
		void RdbDulceClick(object sender, EventArgs e)
		{
			rdbDulce.ForeColor = Color.Green;
			rdbSalado.ForeColor = Color.Red;
			cmbproductos.Items.Clear();
			cmbproductos.Items.Add("dulce de leche");
			cmbproductos.Items.Add("crepa dulce");
			cmbproductos.Items.Add("pastel de chocolate");
			cmbproductos.Items.Add("chocolate");
			cmbproductos.Items.Add("fresas con crema");
		}
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
		    pictureBox1.Image=Image.FromFile("pblogo.jpg");

			RadioButton vacio4 = new RadioButton();
			vacio4.Visible = false;
			vacio4.TabStop = false;
			gpbeleccion.Controls.Add(vacio4);
			vacio4.Checked = true;
			rdbSalado.Checked = false;
			rdbDulce.Checked = false;
		}
		
		
		
		void CmbproductosSelectedIndexChanged(object sender, EventArgs e)
		{
			if( rdbDulce.Checked )
			{
				if( cmbproductos.SelectedIndex == 0 ) precio = 5;
				if( cmbproductos.SelectedIndex == 1 ) precio = 50;
				if( cmbproductos.SelectedIndex == 2 ) precio = 100;
				if( cmbproductos.SelectedIndex == 3 ) precio = 10;
				if( cmbproductos.SelectedIndex == 4 ) precio = 30;
			}
			else
			{
				if( cmbproductos.SelectedIndex == 0 ) precio = 50;
				if( cmbproductos.SelectedIndex == 1 ) precio = 40;
				if( cmbproductos.SelectedIndex == 2 ) precio = 80;
				if( cmbproductos.SelectedIndex == 3 ) precio = 30;
				if( cmbproductos.SelectedIndex == 4 ) precio = 25;
			}
			lblprecio.Text = precio.ToString();
		}
		
		void TxtCantidadTextChanged(object sender, EventArgs e)
		{
			if( txtCantidad.Text == "" ) 
				return;
			
			if( !double.TryParse(txtCantidad.Text, out cant) ) {
				MessageBox.Show("Ingrese valores numericos");
				txtCantidad.Text = "0";
				return;
			}
			lbltotal.Text = (cant * precio).ToString();
		}
		
		void LimpiarCosas() {
			precio = 0;
			cant = 0;
			lblprecio.Text = "0";
			txtCantidad.Text = "";
			lbltotal.Text = "0";
			cmbproductos.SelectedIndex = -1;
		}
		
		void BtnAgregarProductoClick(object sender, EventArgs e)
		{
			ListViewItem act = new ListViewItem(cmbproductos.Text);
			if( (cmbproductos.SelectedIndex == -1) || (txtCantidad.Text == "") ) {
				MessageBox.Show("Rellene los campos de manera correcta");
				return;
			}
			act.SubItems.Add(lblprecio.Text);
			act.SubItems.Add(txtCantidad.Text);
			act.SubItems.Add((precio * cant).ToString());
			
			cntcompras++;
			subtotal += precio * cant;
			lblsubtotal.Text = subtotal.ToString();
			LimpiarCosas();
			actualiza();
			lvregistro.Items.Add(act);
			
		}
		
		void actualiza()
		{
			double desa = 0;
			if( cntcompras > 3 && subtotal >= 200 )
				desa = .15;
			else if( cntcompras > 3 )
				desa = .07;
			else if( subtotal >= 200 )
				desa = .1;
			lblsubtotal.Text = subtotal.ToString();
			lblimporteneto.Text = (Math.Max(subtotal * (1.16- desa) - descuento, 0)).ToString();
			
			double act = double.Parse(lblimporteneto.Text), pa = 0;
			if( !double.TryParse(txtimportepagado.Text, out pa) )
				pa = 0;
			
			lblcambio.Text = (Math.Max(pa - act, 0)).ToString();
		}
		
		void BtnEliminarProductoClick(object sender, EventArgs e)
		{
			if( lvregistro.Items.Count == 0 ) {
				MessageBox.Show("No hay nada que eliminar");
				return;
			}
			
			int pos = lvregistro.Items.Count - 1;
			ListViewItem act = lvregistro.Items[pos];
			DialogResult Respuesta = MessageBox.Show("Esta seguro de eliminar el ultimo registro", "Confirmacion", MessageBoxButtons.YesNo, 
			                                         MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
			if( Respuesta == DialogResult.No )
				return;
			
			cntcompras--;
			subtotal -= double.Parse(act.SubItems[3].Text);
			LimpiarCosas();
			actualiza();
			lvregistro.Items.RemoveAt(pos);
		}
		
		void TxtdescuentoTextChanged(object sender, EventArgs e)
		{
			if( txtdescuento.Text == "" )
				return;
			if( !double.TryParse(txtdescuento.Text, out descuento) ) {
				MessageBox.Show("Ingrese solo datos numericos");
				txtdescuento.Clear();
				descuento = 0;
				actualiza();
				return;
			}
			actualiza();
		}
		
		void TxtimportepagadoTextChanged(object sender, EventArgs e)
		{
			double pag = 0;
			if( txtimportepagado.Text == "" )
				return;
			if( !double.TryParse(txtimportepagado.Text, out pag ) ) {
				MessageBox.Show("Ingrese solo datos numericos al pagar");
				txtimportepagado.Text = "0";
				actualiza();
				return;
			}
			actualiza();
		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			int pos = lvregistro.Items.Count - 1;
			while( pos >= 0 )
			{
				lvregistro.Items.RemoveAt(pos);
				pos--;
			}
			
			rdbDulce.Checked = false;
			rdbSalado.Checked = false;
			rdbSalado.ForeColor = Color.White;
			rdbDulce.ForeColor = Color.White;
			LimpiarCosas();
			precio = 0;
			cant = 0;
			subtotal = 0;
			descuento = 0;
			cntcompras = 0;
			actualiza();
		}
		
		public bool AgregarRegistro(string producto, decimal precio, int cantidad)
		{
			MySqlConnection cn = new MySqlConnection();
			
			cn.ConnectionString = "server=localhost; database=Proyecto; user=root;pwd=;";
			cn.Open();
			string strSQL = "insert into pasteleria (producto, precio, cantidad)" + " values(@producto, @precio, @cantidad)";
			MySqlCommand comando = new MySqlCommand(strSQL, cn);
			comando.Parameters.AddWithValue("producto", producto);
			comando.Parameters.AddWithValue("precio", precio);
			comando.Parameters.AddWithValue("cantidad", cantidad);
			comando.ExecuteNonQuery();
			
			comando.Dispose();
			cn.Close();
			cn.Dispose();
			
			return true;
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			foreach(ListViewItem act in lvregistro.Items) {
				string pro = act.SubItems[0].Text;
				decimal de = decimal.Parse(act.SubItems[1].Text);
				int cant = int.Parse(act.SubItems[2].Text);
				AgregarRegistro(pro, de, cant);
			}
			BtnBorrarClick(sender, e);
		}
		
		private void ImprimirListView(object sender, PrintPageEventArgs e)
		{
		    float x = 50;  
		    float y = 50;       
		    float altoFila = 25;
		    Font fuente = new Font("Arial", 10);
		    Pen lapiz = new Pen(Color.Black);
		    foreach (ColumnHeader col in lvregistro.Columns){
		        e.Graphics.DrawRectangle(lapiz, x, y, col.Width, altoFila);
		        e.Graphics.DrawString(col.Text, fuente, Brushes.Black, x + 3, y + 5);
		        x += col.Width;
		    }
		    y += altoFila;
		    x = 50;
		    foreach (ListViewItem item in lvregistro.Items) {
		        x = 50;
		        for (int i = 0; i < item.SubItems.Count; i++) {
		            e.Graphics.DrawRectangle(lapiz, x, y, lvregistro.Columns[i].Width, altoFila);
		            e.Graphics.DrawString(item.SubItems[i].Text, fuente, Brushes.Black, x + 3, y + 5);
		            x += lvregistro.Columns[i].Width;
		        }
		        y += altoFila;
		        if (y > e.MarginBounds.Bottom - altoFila) {
		            e.HasMorePages = true;
		            return;
		        }
		    }
		    e.HasMorePages = false;
		}
		
		void BtnImprimirClick(object sender, EventArgs e)
		{
		    PrintDocument doc = new PrintDocument();
		    doc.PrintPage += new PrintPageEventHandler(ImprimirListView);
		    PrintPreviewDialog pre = new PrintPreviewDialog();
		    pre.Document = doc;
		    pre.ShowDialog();
		}

	}
}
