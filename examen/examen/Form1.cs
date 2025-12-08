/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 29/10/2025
 * Time: 12:59 p. m.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OcultarCampos();
        }
        
        void OcultarCampos()
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            lblresultado.Visible = false;
            btncalcular.Visible = false;
            btnlimpiar.Visible = false;
        }
        
        void Mostrar1(string etiqueta)
        {
            OcultarCampos();
            lbl1.Text = etiqueta;
            lbl1.Visible = true;
            txt1.Visible = true;
            lblresultado.Visible = true;
            btncalcular.Visible = true;
            btnlimpiar.Visible = true;
        }
        
        void Mostrar2(string etiqueta1, string etiqueta2)
        {
            OcultarCampos();
            lbl1.Text = etiqueta1;
            lbl1.Visible = true;
            txt1.Visible = true;
            lbl2.Text = etiqueta2;
            lbl2.Visible = true;
            txt2.Visible = true;
            lblresultado.Visible = true;
            btncalcular.Visible = true;
            btnlimpiar.Visible = true;
        }
        
        void SalirToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        void KilometrosAMillasToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Kilómetros:");
            btncalcular.Tag = "km_millas";
            
        }
        
        void KilogramosALibrasToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Kilogramos:");
            btncalcular.Tag = "kg_libras";
        }
        
        void CelsiusAFahrenheitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Celsius:");
            btncalcular.Tag = "celsius_fahrenheit";
        }
        
        void SegundosAHorasToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Segundos:");
            btncalcular.Tag = "segundos_horas";
        }
        
        void FactorialToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Número:");
            btncalcular.Tag = "factorial";
        }
        
        void FibonacciToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Cantidad:");
            btncalcular.Tag = "fibonacci";
        }
        
        void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Lado:");
            btncalcular.Tag = "area_cuadrado";
            pictureBox1.Image=Image.FromFile("cuadrado.png");
        }
        
        void RectanguloToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar2("Base:", "Altura:");
            btncalcular.Tag = "area_rectangulo";
            pictureBox1.Image=Image.FromFile("rectangulo.png");
        }
        
        void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar2("Base:", "Altura:");
            btncalcular.Tag = "area_triangulo";
            pictureBox1.Image=Image.FromFile("triangulo.jpg");
        }
        
        void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Radio:");
            btncalcular.Tag = "perimetro_circunferencia";
            pictureBox1.Image=Image.FromFile("circulo.png");
        }
        
        void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar2("Base Mayor:", "Base Menor:");
            btncalcular.Tag = "area_trapecio";
            pictureBox1.Image=Image.FromFile("trapecio.png");
        }
        
        void EsferaToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Radio:");
            btncalcular.Tag = "volumen_esfera";
            pictureBox1.Image=Image.FromFile("esfera.png");
        }
        
        void CuboToolStripMenuItemClick(object sender, EventArgs e)
        {
            Mostrar1("Lado:");
            btncalcular.Tag = "volumen_cubo";
            pictureBox1.Image=Image.FromFile("circulo.jpg");
        }
        
        void BtncalcularClick(object sender, EventArgs e)
        {
            try
            {
                string operacion = btncalcular.Tag.ToString();
                
                if (operacion == "km_millas")
                {
                    double km = Convert.ToDouble(txt1.Text);
                    double millas = km * 0.621371;
                    lblresultado.Text = "Resultado: " + millas.ToString("F2") + " millas";
                }
                else if (operacion == "kg_libras")
                {
                    double kg = Convert.ToDouble(txt1.Text);
                    double libras = kg * 2.20462;
                    lblresultado.Text = "Resultado: " + libras.ToString("F2") + " libras";
                }
                else if (operacion == "celsius_fahrenheit")
                {
                    double c = Convert.ToDouble(txt1.Text);
                    double f = (c * 9 / 5) + 32;
                    lblresultado.Text = "Resultado: " + f.ToString("F2") + " °F";
                }
                else if (operacion == "segundos_horas")
                {
                    double segundos = Convert.ToDouble(txt1.Text);
                    double horas = segundos / 3600;
                    lblresultado.Text = "Resultado: " + horas.ToString("F2") + " horas";
                }
                else if (operacion == "factorial")
                {
                    int n = Convert.ToInt32(txt1.Text);
                    if (n < 0)
                    {
                        MessageBox.Show("El factorial no existe para números negativos");
                        return;
                    }
                    long factorial = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        factorial = factorial * i;
                    }
                    lblresultado.Text = "Resultado: " + factorial.ToString();
                }
                else if (operacion == "fibonacci")
                {
                    int cantidad = Convert.ToInt32(txt1.Text);
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("Ingresa un número positivo");
                        return;
                    }
                    string serie = "";
                    int a = 0, b = 1;
                    for (int i = 0; i < cantidad; i++)
                    {
                        serie += a + ", ";
                        int temp = a + b;
                        a = b;
                        b = temp;
                    }
                    lblresultado.Text = "Serie: " + serie;
                }
                else if (operacion == "area_cuadrado")
                {
                    double lado = Convert.ToDouble(txt1.Text);
                    double area = lado * lado;
                    lblresultado.Text = "Área: " + area.ToString("F2");
                }
                else if (operacion == "area_rectangulo")
                {
                    double baseR = Convert.ToDouble(txt1.Text);
                    double alturaR = Convert.ToDouble(txt2.Text);
                    double area = baseR * alturaR;
                    lblresultado.Text = "Área: " + area.ToString("F2");
                }
                else if (operacion == "area_triangulo")
                {
                    double baseT = Convert.ToDouble(txt1.Text);
                    double alturaT = Convert.ToDouble(txt2.Text);
                    double area = (baseT * alturaT) / 2;
                    lblresultado.Text = "Área: " + area.ToString("F2");
                }
                else if (operacion == "perimetro_circunferencia")
                {
                    double radio = Convert.ToDouble(txt1.Text);
                    double perimetro = 2 * Math.PI * radio;
                    lblresultado.Text = "Perímetro: " + perimetro.ToString("F2");
                }
                else if (operacion == "area_trapecio")
                {
                    double baseMayor = Convert.ToDouble(txt1.Text);
                    double baseMenor = Convert.ToDouble(txt2.Text);
                    // Necesitarías altura pero solo tienes 2 textbox
                    MessageBox.Show("Necesitas también la altura del trapecio");
                }
                else if (operacion == "volumen_esfera")
                {
                    double radio = Convert.ToDouble(txt1.Text);
                    double volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;
                    lblresultado.Text = "Volumen: " + volumen.ToString("F2");
                }
                else if (operacion == "volumen_cubo")
                {
                    double lado = Convert.ToDouble(txt1.Text);
                    double volumen = lado * lado * lado;
                    lblresultado.Text = "Volumen: " + volumen.ToString("F2");
                }
            }
            catch
            {
                MessageBox.Show("NO");
            }
        }
        
        void BtnlimpiarClick(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lblresultado.Text = "Resultado:";
        }
        
        void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            Form2 g = new Form2();
		   	g.Show();
        }
    }
}