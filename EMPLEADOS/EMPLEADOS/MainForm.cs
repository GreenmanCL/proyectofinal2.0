/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 08/12/2025
 * Time: 02:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EMPLEADOS
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
		
		
		
		void BtnguardarClick(object sender, EventArgs e)
		{
             if (txtnombre.Text=="" || cbpuesto.Text=="" || cbsexo.Text=="" || pictureBox1.Image==null || (!radioButtonRegular.Checked && !radioButtonContrato.Checked))
               {
                 MessageBox.Show("Debe llenar todos los campos y subir una foto.");
                 return;
               }

             string waza="Server=localhost;Database=Proyecto;Uid=root;Pwd=;";
             
                 MySqlConnection cnn = new MySqlConnection(waza);
                 cnn.Open();
                    string sql = "INSERT INTO empleados(codigo, nombre, puesto, fecha_nac, sexo, estado, foto) " +
                                 "VALUES (@codigo, @nombre, @puesto, @fecha, @sexo, @estado, @foto)";

                    MySqlCommand xdelprimo = new MySqlCommand(sql, cnn);
                    
                    xdelprimo.Parameters.AddWithValue("@codigo", txtcodigo.Text);
                    xdelprimo.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    xdelprimo.Parameters.AddWithValue("@puesto", cbpuesto.Text);
                    xdelprimo.Parameters.AddWithValue("@fecha", dateTimePicker.Value);
                    xdelprimo.Parameters.AddWithValue("@sexo", cbsexo.Text);
                    xdelprimo.Parameters.AddWithValue("@estado", radioButtonRegular.Checked ? "REGULAR" : "CONTRATO");
                    xdelprimo.Parameters.AddWithValue("@foto", "SI");

                    xdelprimo.ExecuteNonQuery();
                    dataGridView1.Rows.Add(
                    txtcodigo.Text,
                    txtnombre.Text,
                    cbpuesto.Text,
                    dateTimePicker.Value.ToString("yyyy-MM-dd"),
                    cbsexo.Text,
                    radioButtonRegular.Checked ? "REGULAR" : "CONTRATO",
                    "SI");
                    
                    cnn.Close();
                    MessageBox.Show("Empleado registrado correctamente 🤑");
                    
                    btnsubirfoto.Visible = true;
		}
                 
                  


		void BtnsubirfotoClick(object sender, EventArgs e)
		{
          
           OpenFileDialog open = new OpenFileDialog();
           open.Filter = "Imagen|*.jpg;*.png;*.jpeg;";

           if (open.ShowDialog() == DialogResult.OK)
            {
             pictureBox1.Image = Image.FromFile(open.FileName);
             btnsubirfoto.Visible = false;  
            }
 

		}
		
		void BtnquitarfotoClick(object sender, EventArgs e)
		{
			pictureBox1.Image=null;
		}
		
		void BtnactualizarfotoClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
           open.Filter = "Imagen|*.jpg;*.png;*.jpeg;";

           if (open.ShowDialog() == DialogResult.OK)
            {
             pictureBox1.Image = Image.FromFile(open.FileName);
             btnsubirfoto.Visible = false;  
            }
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

		}
		
		
		
		
		
		
		
		
		void BtneliminarClick(object sender, EventArgs e)
		{
            if (txtcodigo.Text == "")
            {
             MessageBox.Show("Debe ingresar el código del empleado para eliminar.");
             return;
            }


            string waza = "Server=localhost;Database=Proyecto;Uid=root;Pwd=;";

            MySqlConnection cnn = new MySqlConnection(waza);
            cnn.Open();

            string sql = "DELETE FROM empleados WHERE codigo = @codigo";

            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text);
            int xd = cmd.ExecuteNonQuery(); 

       

            cnn.Close();

 
            MessageBox.Show("Se ha eliminado al empleado: " + txtnombre.Text, "Eliminado");

            btnsubirfoto.Visible = true;

            txtcodigo.Clear();
            txtnombre.Clear();
            cbpuesto.Text = "";
            cbsexo.Text = "";
            pictureBox1.Image = null;
            

	   }
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		void BtnlimpiarClick(object sender, EventArgs e)
		{
			txtcodigo.Text="";
			txtnombre.Text="";
			cbpuesto.Text="";
			cbsexo.Text="";
			radioinvisible.Focus();
            pictureBox1.Image = null;
            btnsubirfoto.Visible = true;
            txtcodigo.Focus();
            dataGridView1.Rows.Clear();

		}
	}
}
