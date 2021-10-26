using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTareaS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos()
        {
            InitializeComponent();
        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            //almaceno en variables los datos de las cajas de texto
            double datoUno = Convert.ToDouble(txtNota1.Text);
            double datoDos = Convert.ToDouble(txtExamen.Text);
            //operación
            double result1 = datoUno * 0.3;
            double result2 = datoDos * 0.2;
            double suma = result1 + result2;
            //se convierte a string para visualizar en Entry
            txtParcial1.Text = Convert.ToString(suma);
            //almaceno en variables los datos de las cajas de texto
            double datoTres = Convert.ToDouble(txtNota2.Text);
            double datoCuatro = Convert.ToDouble(txtExamen2.Text);
            //operación
            double result3 = datoTres * 0.3;
            double result4 = datoCuatro * 0.2;
            double sumar = result3 + result4;
            //se convierte a string para visualizar en Entry
            txtParcial2.Text = Convert.ToString(sumar);

            double parcial1 = Convert.ToDouble(txtParcial1.Text);
            double parcial2 = Convert.ToDouble(txtParcial2.Text);

            double nf = parcial1 + parcial2;
            txtNotaFinal.Text = Convert.ToString(nf);

            //creo un string para comentario
            string comentario = "";
            try
            {
                if (nf >= 7)
                {
                    comentario = "APROBADO";
                    txtEvaluado.Text = "APROBADO";
                }
                else if (nf >= 5 && nf <= 6.9)
                {
                    comentario = "COMPLEMENTARIO";
                    txtEvaluado.Text = "COMPLEMENTARIO";
                }
                else if (nf < 5)
                {
                    comentario = "REPROBADO";
                    txtEvaluado.Text = "REPROBADO";
                }
                else
                {
                    comentario = "Universidad Israel";
                }
                DisplayAlert("COMENTARIO", comentario, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("ALERTA", ex.Message, "OK");
            }
        }
        private void txtNota1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtNota1.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                }
            }
            catch (Exception ex)
            {
                //DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtExamen_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtExamen.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                }
            }
            catch
            {
            }
        }

        private void txtNota2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtNota2.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                }
            }
            catch
            {
            }
        }

        private void txtExamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtExamen2.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                }
            }
            catch
            {
            }
        }
    }
}