/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 21/11/2025
 * Time: 02:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace t22
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
		
		
		
		void TxtpromediogeneralTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ListViewlistaSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBoxnombreTextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		
		
		
		void Txtparcial1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBoxparcial2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBoxparcial3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBoxgradoSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBoxasignaturaSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBoxespecialidadSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtfechaactualTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnregistrarClick(object sender, EventArgs e)
{
    
    double p1, p2, p3;
    
    
        p1 = double.Parse(txtparcial1.Text);
        p2 = double.Parse(textBoxparcial2.Text);
        p3 = double.Parse(textBoxparcial3.Text);
    
    
    

    double promedio = (p1+p2 + p3)/3.0;
    txtpromediogeneral.Text = promedio.ToString("0.00");

    string resultado = "";
    if (promedio >= 6){
        	resultado = "Aprobado";
    }
    else{
            resultado = "Reprobado";
    }

    ListViewItem fila = new ListViewItem(comboBoxasignatura.Text);
    fila.SubItems.Add(p1.ToString("0.0"));
    fila.SubItems.Add(p2.ToString("0.0"));
    fila.SubItems.Add(p3.ToString("0.0"));
    fila.SubItems.Add(promedio.ToString("0.00"));
    fila.SubItems.Add(resultado);

    listViewlista.Items.Add(fila);


}
		
		void BtncancelarClick(object sender, EventArgs e)
		{
			txtparcial1.Text=" ";
			textBoxparcial2.Text=" ";
			textBoxparcial3.Text=" ";
			txtpromediogeneral.Text=" ";
			textBoxnombre.Text=" ";
			comboBoxasignatura.Text=" ";
			
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			txtfechaactual.Text = DateTime.Today.Date.ToString("d");

		}
	}
}
