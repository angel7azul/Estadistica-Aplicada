using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica_Aplicada
{
    public partial class Form1 : Form
    {        
        List<int> datosList;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbx_DatosAgregados.Items.Add(txt_DatosIngresados.Text);
            txt_DatosIngresados.Clear();
            txt_DatosIngresados.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datosList = new List<int>();
            foreach (var item in lbx_DatosAgregados.Items)
            {
                datosList.Add(Convert.ToInt32(item));
            }

            datosList = datosList.OrderBy(x => x).ToList();
            lbx_DatosAgregados.Items.Clear();
            foreach (var item in datosList)
            {
                lbx_DatosAgregados.Items.Add(item);
            }
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            lbl_CantidadDatos.Text = lbx_DatosAgregados.Items.Count.ToString();
        }

        private void btn_Operar_Click(object sender, EventArgs e)
        {        
            Logaritmo();
            Amplitud_Intervalo();
            LimiteInferiorSuperior();
            CalcularIntervalos();            
        }
        
        private void CalcularIntervalos()
        {
            double amplitud = double.Parse(lbl_AmplitudIntervalo.Text);
            double limite_Inferior = Convert.ToDouble(lbl_Inferior.Text);
            double limite_Superior = Convert.ToDouble(lbl_Superior.Text);
            double cantidad_Datos = Convert.ToDouble(lbl_CantidadDatos.Text);
            double cantidad_Intervalos = Convert.ToDouble(lbl_Paso1.Text);

            //LLenar los primeros datos
            double a = limite_Inferior + amplitud;
            RangoMinimo.Items.Add(limite_Inferior);
            RangoMaximo.Items.Add(limite_Inferior + amplitud);
            PointMedio.Items.Add((limite_Inferior + a) / 2);

            List<double> frecuencia = new List<double>();

            foreach (int item in lbx_DatosAgregados.Items)
            {
                if(item >= (double)RangoMinimo.Items[0] && item<= (double)RangoMaximo.Items[0])
                {
                    frecuencia.Add(item);
                }
            }
            Frecuencia.Items.Add(frecuencia.Count);
            double FR = Convert.ToDouble(Frecuencia.Items[0]);
           

            /*double FP = Convert.ToDouble(FrecuenciaR.Items[0]);
            FrecuenciaPorcentual.Items.Add(FP * 100);
            FrecuenciaAcomulada.Items.Add(FR);
            FrecuRelaAcomu.Items.Add(FP);
            double FRA = Convert.ToDouble(FrecuRelaAcomu.Items[0]);
            FrecPorcentuAcomulada.Items.Add(FRA);
            */

            int contadorRangos = 0; // En cero o en 1 proceso......
            //Agregar datos usando un Ciclo hasta que la cantidad de intervalos se cumpla
            double R_Min, R_Max;
            int contadorPuntoMedio=1;
            for (int i = 1; i < cantidad_Intervalos; i++)
            {
                //Agregar datos rango Minimi y Maximo
                double Dato_Anterior = Convert.ToDouble(RangoMaximo.Items[contadorRangos]);
                RangoMinimo.Items.Add(Dato_Anterior + 1);
                RangoMaximo.Items.Add(Dato_Anterior + amplitud);

                //Sacar en Punto Medio
                R_Min = Convert.ToDouble(RangoMinimo.Items[contadorPuntoMedio]);
                R_Max = Convert.ToDouble(RangoMaximo.Items[contadorPuntoMedio]);
                PointMedio.Items.Add((R_Min + R_Max)/2);
                List<int> F = new List<int>();
                foreach (int item in lbx_DatosAgregados.Items)
                {
                    if (item >= R_Min && item <= R_Max) 
                    {
                        F.Add(item);
                    }
                }               
                Frecuencia.Items.Add(F.Count);                
                contadorRangos++;
                contadorPuntoMedio++;
            }
            //Sacar Frecuencia Relativa
            foreach (int item in Frecuencia.Items)
            {
                double fr = item / cantidad_Datos;
                FrecuenciaR.Items.Add(fr);
            }
            //Sacar Frecuencia Porcentual
            foreach (double item in FrecuenciaR.Items)
            {
                double fr = item * 100;
                FrecuenciaPorcentual.Items.Add(fr);
            }

            //Sacar Frecuencia Acomulada... sacar datos de frecuencia y acomularlos en una lista para trabajar con la frecuancia acomulada
            List<int> _Frecuencia = new List<int>();
            foreach (int item in Frecuencia.Items)
            {
                _Frecuencia.Add(item);
            }

            FrecuenciaAcomulada.Items.Add(_Frecuencia[0]);
            int contadorDatoAnterior = 0;
            int contador_Frecuencia = 1;

            for (int i =1; i < cantidad_Intervalos; i++)
            {
                double dato_AnteriorFA = Convert.ToDouble(FrecuenciaAcomulada.Items[contadorDatoAnterior]);
                double dato_AnteriorFrecuencia = Convert.ToDouble(Frecuencia.Items[contador_Frecuencia]);
                FrecuenciaAcomulada.Items.Add(dato_AnteriorFA + dato_AnteriorFrecuencia);
                contadorDatoAnterior++;
                contador_Frecuencia++;
            }

            //Frecuencia Relativa Acomulada
            List<double> _FrecuenciaR = new List<double>();
            foreach (double item in FrecuenciaR.Items)
            {
                _FrecuenciaR.Add(item);
            }

            FrecuRelaAcomu.Items.Add(_FrecuenciaR[0]);

            int contador_DatoAnteriorFRA = 0;
            int contador_FrecuenciaR = 1;

            for (int i = 1; i < cantidad_Intervalos; i++)
            {
                double dato_AnteriorFRA = Convert.ToDouble(FrecuRelaAcomu.Items[contador_DatoAnteriorFRA]);
                double dato_AnteriorFrecuenciaRelativa = Convert.ToDouble(FrecuenciaR.Items[contador_FrecuenciaR]);
                FrecuRelaAcomu.Items.Add(dato_AnteriorFRA + dato_AnteriorFrecuenciaRelativa);
                contador_DatoAnteriorFRA++;
                contador_FrecuenciaR++;
            }
            //Frecuencia Porcentual Acomulada
            List<double> _FrecuenciaPA = new List<double>();
            foreach (double item in FrecuenciaPorcentual.Items)
            {
                _FrecuenciaPA.Add(item);
            }

            FrecPorcentuAcomulada.Items.Add(_FrecuenciaPA[0]);
            
            int contador_DatoAnteriorFPA = 0;
            int contador_FP = 1;

            for (int i = 1; i < cantidad_Intervalos; i++)
            {
                double DatoAnteriorFPA = Convert.ToDouble(FrecPorcentuAcomulada.Items[contador_DatoAnteriorFPA]);
                double dato_contadorFP = Convert.ToDouble(FrecuenciaPorcentual.Items[contador_FP]);
                FrecPorcentuAcomulada.Items.Add(DatoAnteriorFPA + dato_contadorFP);
                contador_DatoAnteriorFPA++;
                contador_FP++;
            }
        }

        private void LimiteInferiorSuperior()
        {
            //4.- Multiplicar Ra = Amplitud * m Cantidad de intervalos
            double amplitud = double.Parse(lbl_AmplitudIntervalo.Text);
            double Intervalos = double.Parse(lbl_Paso1.Text);

            double Ra = amplitud * Intervalos;

            double DatoMenor = Convert.ToDouble(lbx_DatosAgregados.Items[0]);
            var totalDatos = lbx_DatosAgregados.Items.Count;
            double DatoMayor = Convert.ToDouble(lbx_DatosAgregados.Items[totalDatos - 1]);
            double R = DatoMayor - DatoMenor;

            double a = Ra - R;

            double datoMenor = DatoMenor - a / 2;
            double datoMayor = DatoMayor + a / 2;

            //Redondear limite inferior al menor 11.5 = 11, y el superior el mayor 91.5 = 92
            var datoMenorRedondo = Math.Floor(datoMenor);
            var datoMayorRedondo = Math.Ceiling(datoMayor);

            lbl_Inferior.Text = datoMenorRedondo.ToString();
            lbl_Superior.Text = datoMayorRedondo.ToString();


        }

        public void Logaritmo()
        {
            double datos = double.Parse(lbl_CantidadDatos.Text);
            var logDatos = Math.Log10(datos);
            var logTotal = 1 + 3.3 * logDatos;
            var logRedondo = Math.Ceiling(logTotal);
            lbl_Paso1.Text = logRedondo.ToString();
        }

        public void Amplitud_Intervalo()
        {

            int DatoMenor = Convert.ToInt32(lbx_DatosAgregados.Items[0]);
            var totalDatos = lbx_DatosAgregados.Items.Count;
            int DatoMayor = Convert.ToInt32(lbx_DatosAgregados.Items[totalDatos-1]);
            double r = DatoMayor - DatoMenor;
            double m = double.Parse(lbl_Paso1.Text);
            double Amplitud = r / m;
            double amplitudRedonda = Math.Ceiling(Amplitud);
            lbl_AmplitudIntervalo.Text = amplitudRedonda.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgv_Datos.AllowUserToAddRows = false;
        }
    }
}
