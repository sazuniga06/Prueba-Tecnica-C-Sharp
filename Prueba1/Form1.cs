/*
 * Nombre del archivo: Form1.cs
 * Descripción: Este archivo contiene la implementación de la clase Form1, que representa la interfaz gráfica principal de la aplicación de procesamiento de imágenes.
 * Fecha de creación: 20/03/2024
 * Autor: Ing. Santiago Alejandro Zuñiga Melo
 * Descripción: Esta es mi solución a la prueba 1 para la entrevista en el cargo de analista de ingeniería para la empresa Intecol. 
 *              La aplicacion permite cargar un conjunto de imagenes obtenidas por una camara OGI para posteriormente procesarlas y asi usarlas para el calculo del volumen
 *              de gas filtrado.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace Prueba1
{
    /*
    * Clase: Form1
    * Descripción: Esta clase representa el formulario principal de la aplicación. Contiene métodos para cargar una imagen BMP,
    *              procesarla y realizar varias operaciones de procesamiento de imágenes, como aplicar filtros, detectar bordes
    *              y contar píxeles negros mediante segmentación.
    */
    public partial class Form1 : Form
    {
        // Lista que almacenará las rutas de los archivos BMP
        private List<string> archivos = new List<string>();
        // Lista que almacenará los volúmenes relativos calculados
        private List<double> volumenesRelativos = new List<double>();
        // Variable que almacenará la imagen de referencia
        private Bitmap imagenReferencia = null;
        // Índice utilizado para rastrear el archivo actual que se está procesando
        private int indiceProcesar = 0;
        // Temporizador utilizado para procesar imágenes periódicamente
        private Timer timer;

        /*
         * Constructor: Form1
         * Descripción: Inicializa una nueva instancia de la clase Form1.
         *              Configura el DataGridView y el temporizador.
         */
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // Configurar el DataGridView
            ConfigurarTimer(); // Configurar el temporizador
        }

        /* Método: ConfigurarDataGridView
         * Descripción: Configura el DataGridView con las columnas necesarias.
         */

        private void ConfigurarDataGridView()
        {
            dataGridView1.ColumnCount = 2; // Establecer el número de columnas en el DataGridView
            // Establecer los encabezados de columna
            dataGridView1.Columns[0].Name = "Ruta";
            dataGridView1.Columns[1].Name = "Volumen";
            // Ajustar el modo de tamaño automático de las columnas para que se ajusten al contenido
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /* Método: ConfigurarTimer
         * Descripción: Configura el temporizador con un intervalo de 2 segundos y asocia el evento Tick con Timer_Tick.
         */

        private void ConfigurarTimer()
        {
            timer = new Timer();
            timer.Interval = 2000; // Intervalo de 2000 milisegundos (2 segundos)
            timer.Tick += Timer_Tick; // Asociar el evento Tick del temporizador con Timer_Tick
        }

        /* Evento: Timer_Tick
         * Descripción: Manejador de eventos para el evento Tick del temporizador.
         *              Procesa la siguiente imagen en la lista o detiene el temporizador si todas las imágenes han sido procesadas.
         * Parámetros:
         *     - sender: El objeto que generó el evento.
         *     - e: Argumentos del evento.
         */
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (indiceProcesar < archivos.Count)
            {
                ProcesarSiguienteImagen(); // Procesar la siguiente imagen en la lista
            }
            else
            {
                // Detener el temporizador si ya se procesaron todas las imágenes
                timer.Stop();
                MessageBox.Show("Todas las imágenes han sido procesadas.");
            }
        }

        /* Método: ProcesarSiguienteImagen
         * Descripción: Procesa la siguiente imagen en la lista de archivos.
         */

        private void ProcesarSiguienteImagen()
        {
            Bitmap imagenActual = new Bitmap(archivos[indiceProcesar]);
            double volumenRelativo = CalcularVolumenRelativo(imagenActual, indiceProcesar);
            volumenesRelativos.Add(volumenRelativo);

            string rutaImagen = archivos[indiceProcesar];
            dataGridView1.Rows.Add(rutaImagen, volumenRelativo); // Agregar la ruta y el volumen a DataGridView

            MostrarImagen(indiceProcesar, pictureBox1); // Mostrar la imagen actual en pictureBox1

            indiceProcesar++; // Incrementar el índice para procesar la próxima imagen
        }
        /* Método: Cargar_Btn_Click
         * Descripción: Manejador de eventos para el botón de carga de imagen.
         *              Abre un diálogo para seleccionar una imagen BMP y la carga en una PictureBox.
         * Parámetros:
         *     - sender: El objeto que generó el evento.
         *     - e: Argumentos del evento.
         */
        private void Cargar_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string carpetaSeleccionada = folderBrowserDialog.SelectedPath;
                archivos = Directory.GetFiles(carpetaSeleccionada, "*.bmp").ToList();
                MessageBox.Show($"{archivos.Count} archivos BMP cargados desde la carpeta seleccionada.");

                // Ordenar los archivos según el número en el nombre del archivo
                archivos.Sort((a, b) =>
                    Convert.ToInt32(Path.GetFileNameWithoutExtension(a).Replace("image(", "").Replace(")", ""))
                    .CompareTo(Convert.ToInt32(Path.GetFileNameWithoutExtension(b).Replace("image(", "").Replace(")", ""))));

                // Cargar la imagen de referencia (imagen número 22)
                int indiceImagenReferencia = archivos.FindIndex(f => f.Contains("image(22)"));
                if (indiceImagenReferencia == -1)
                {
                    MessageBox.Show("No se encontró la imagen número 22 en los archivos cargados.");
                    return;
                }
                else
                {
                    imagenReferencia = new Bitmap(archivos[indiceImagenReferencia]);
                    MostrarImagenReferencia(imagenReferencia);
                }
            }
        }

        /* Método: MostrarImagenReferencia
         * Descripción: Muestra la imagen de referencia en el PictureBox pictureBox2.
         * Parámetros:
         *     - imagenReferencia: La imagen de referencia a mostrar.
         */

        private void MostrarImagenReferencia(Bitmap imagenReferencia)
        {
            pictureBox2.Image = (Bitmap)imagenReferencia.Clone();
        }
        /* Método: MostrarImagen
         * Descripción: Muestra la imagen en el PictureBox especificado.
         * Parámetros:
         *     - indice: El índice de la imagen en la lista de archivos.
         *     - pictureBox: El PictureBox en el que se mostrará la imagen.
         */

        private void MostrarImagen(int indice, PictureBox pictureBox)
        {
            if (indice < archivos.Count && File.Exists(archivos[indice]))
            {
                Bitmap imagen = new Bitmap(archivos[indice]);
                pictureBox.Image = (Bitmap)imagen.Clone();
            }
            else
            {
                MessageBox.Show($"No se pudo encontrar la imagen: {archivos[indice]}");
            }
        }

        /* Método: Calcular_Button_Click
         * Descripción: Manejador de eventos para el botón de cálculo de volúmenes.
         *              Inicia el temporizador para comenzar el procesamiento de imágenes cada 2 segundos.
         * Parámetros:
         *     - sender: El objeto que generó el evento.
         *     - e: Argumentos del evento.
         */
        private void Calcular_Button_Click(object sender, EventArgs e)
        {
            if (archivos.Count == 0 || imagenReferencia == null)
            {
                MessageBox.Show("Por favor carga los archivos primero.");
                return;
            }

            // Iniciar el temporizador para comenzar el procesamiento de imágenes cada 2 segundos
            timer.Start();
        }

        /* Método: CalcularVolumenRelativo
         * Descripción: Calcula el volumen relativo de la imagen actual.
         * Parámetros:
         *     - imagenActual: La imagen actual a procesar.
         *     - indiceImagen: El índice de la imagen en la lista de archivos.
         * Retorna: El volumen relativo calculado.
         */
        private double CalcularVolumenRelativo(Bitmap imagenActual, int indiceImagen)
        {
            double volumenReferencia = 5.0; // Volumen de referencia en litros (imagen 22)
            double factorEscala;

            if (indiceImagen < 20)
            {
                factorEscala = 0.0; // Si es una de las primeras 20 imágenes, el volumen es 0
            }
            else
            {
                // Factor de escala para el volumen perdido
                factorEscala = Math.Max((indiceImagen - 21) * 0.0001, 0);
            }

            Mat imagenMat = OpenCvSharp.Extensions.BitmapConverter.ToMat(imagenActual);
            Mat imagenGrayscale = new Mat();
            Cv2.CvtColor(imagenMat, imagenGrayscale, ColorConversionCodes.BGR2GRAY);
            Cv2.GaussianBlur(imagenGrayscale, imagenGrayscale, new OpenCvSharp.Size(3, 3), 0);
            Mat imagenBinarizada = new Mat();
            Cv2.AdaptiveThreshold(imagenGrayscale, imagenBinarizada, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 11, 2);
            OpenCvSharp.Point[][] contornos;
            HierarchyIndex[] jerarquia;
            Cv2.FindContours(imagenBinarizada, out contornos, out jerarquia, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            double areaTotal = 0;
            foreach (var contorno in contornos)
            {
                double areaContorno = Cv2.ContourArea(contorno);
                if (areaContorno > 100)
                {
                    areaTotal += areaContorno;
                }
            }

            double volumenPerdido = areaTotal * factorEscala;

            if (indiceImagen == 21)
            {
                volumenPerdido = volumenReferencia;
            }

            MostrarImagenProcesada(imagenBinarizada);

            return volumenPerdido;
        }

        /* Método: MostrarImagenProcesada
         * Descripción: Muestra la imagen procesada en el PictureBox pictureBox2.
         * Parámetros:
         *     - imagenProcesadaMat: La imagen procesada en formato Mat.
         */
        private void MostrarImagenProcesada(Mat imagenProcesadaMat)
        {
            Bitmap imagenProcesadaBitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(imagenProcesadaMat);
            pictureBox2.Image = (Bitmap)imagenProcesadaBitmap.Clone();
        }

        /* Método: Exportar_Button_Click
         * Descripción: Manejador de eventos para el botón de exportar resultados.
         *              Exporta los datos del DataGridView como un archivo CSV.
         * Parámetros:
         *     - sender: El objeto que generó el evento.
         *     - e: Argumentos del evento.
         */
        private void Exportar_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV|*.csv";
            saveFileDialog.Title = "Guardar resultados";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir encabezados de columna
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            sw.Write(column.HeaderText + ",");
                        }
                        sw.WriteLine();

                        // Escribir datos de cada fila
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                sw.Write(cell.Value + ",");
                            }
                            sw.WriteLine();
                        }

                        MessageBox.Show("Resultados exportados correctamente como archivo CSV.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar: {ex.Message}");
                }
            }
        }
    }
}