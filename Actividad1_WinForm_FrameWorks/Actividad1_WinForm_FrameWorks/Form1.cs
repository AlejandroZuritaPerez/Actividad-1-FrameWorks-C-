using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Actividad1_WinForm_FrameWorks
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = metroComboBox1.SelectedItem.ToString().Trim().ToLower();

            if (opcion == "perímetro")
            {
                CalcularPerimetro();
            }
            else if (opcion == "área")
            {
                CalcularArea();
            }
            else
            {
                MessageBox.Show("Opción no válida. Por favor, escriba 'perímetro' o 'área'.");
                return;
            }
        }

        private void CalcularPerimetro()
        {

            int numeroLados;
            if (!int.TryParse(metroTextBox4.Text, out numeroLados) || numeroLados < 3)
            {
                MessageBox.Show("Número de lados inválido. Por favor, ingrese un número entero mayor o igual a 3:");
                return;
            }


            double longitudLado;
            if (!double.TryParse(metroTextBox5.Text, out longitudLado) || longitudLado <= 0)
            {
                MessageBox.Show("Longitud de lado inválida. Por favor, ingrese un número real mayor que 0:");
                return;
            }

            double perimetro = numeroLados * longitudLado;
            metroLabel10.Text = ($"El perímetro del polígono es: {perimetro}");
        }

        private void CalcularArea()
        {

            int numeroLados;
            if (!int.TryParse(metroTextBox1.Text, out numeroLados) || numeroLados < 3)
            {
                MessageBox.Show("Número de lados inválido. Por favor, ingrese un número entero mayor o igual a 3:");
                return;
            }


            double longitudLado;
            if (!double.TryParse(metroTextBox2.Text, out longitudLado) || longitudLado <= 0)
            {
                MessageBox.Show("Longitud de lado inválida. Por favor, ingrese un número real mayor que 0:");
                return;
            }
            double apotema;

            if (!double.TryParse(metroTextBox3.Text, out apotema) || apotema <= 0)
            {
                MessageBox.Show("Longitud de apotema inválida. Por favor, ingrese un número real mayor que 0:");
                return;
            }

            double area = (numeroLados * longitudLado * apotema) / 2;
            metroLabel9.Text = ($"El área del polígono es: {area}");

        }
    }
}
