using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Estadistica_Aplicada
{
    class Metodos
    {

        /*private void CalcularIntervalos()
       {
        double amplitud = double.Parse(lbl_AmplitudIntervalo.Text);
           double limite_Inferior = Convert.ToDouble(lbl_Inferior.Text);
           double limite_Superior = Convert.ToDouble(lbl_Superior.Text);
           double cantidad_Datos = Convert.ToDouble(lbl_CantidadDatos.Text);

           var sumar = limite_Inferior + amplitud;
           double PM = (limite_Inferior + sumar) / 2;
           List<int> F = new List<int>();
           foreach (int item in lbx_DatosAgregados.Items)
           {
               if (item > limite_Inferior && item < sumar)
               {
                   F.Add(item);
               }
           }

           double fr = F.Count / cantidad_Datos;
           dgv_Datos.Rows.Add(limite_Inferior, sumar, PM, F.Count, fr);


           int row = 0;

           for (int i = 1; i < cantidad_Datos; i++)
           {
               double dato_Anterior = Convert.ToDouble(dgv_Datos.Rows[row].Cells[1].Value);
               if (dato_Anterior < limite_Superior)
               {
                   double sumas = dato_Anterior + amplitud;
                   double puntoMedio = (dato_Anterior + sumas) / 2;

                   List<int> F1 = new List<int>();
                   foreach (int item in lbx_DatosAgregados.Items)
                   {
                       if (item > dato_Anterior && item < sumas)
                       {
                           F1.Add(item);
                       }
                   }
                   double frCiclo = F1.Count / cantidad_Datos;
                   dgv_Datos.Rows.Add(dato_Anterior, sumas, puntoMedio, F1.Count, frCiclo);

                   row++;
               }
               else
               {
                   break;
               }

           }
           ObtenerPuntoMedio();

       }*/
    }
}