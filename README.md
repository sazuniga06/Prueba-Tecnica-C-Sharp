# 🔍 Sistema de Detección de Fugas de Propano con Procesamiento de Imágenes

Este proyecto consiste en una aplicación desarrollada en **C# con Windows Forms** que emplea técnicas de **procesamiento de imágenes** usando **OpenCVSharp** para detectar fugas de gas propano a partir de imágenes capturadas por cámaras de **Optical Gas Imaging (OGI)**. La aplicación calcula el volumen de gas perdido, visualiza los resultados y permite exportarlos en formato CSV.

---

## 🛠 Tecnologías Usadas

- **Lenguaje:** C#
- **Entorno de Desarrollo:** Microsoft Visual Studio
- **Librerías NuGet:**
  - [OpenCvSharp4](https://www.nuget.org/packages/OpenCvSharp4)
  - [OpenCvSharp4.Extensions](https://www.nuget.org/packages/OpenCvSharp4.Extensions)
- **Framework:** Windows Forms

---

## ⚙️ Características

- Carga de múltiples imágenes BMP desde una carpeta.
- Preprocesamiento de imágenes (escala de grises, suavizado Gaussiano, umbral adaptativo).
- Detección de contornos para identificar zonas de fuga.
- Estimación del volumen relativo de gas perdido.
- Visualización de resultados en una tabla y en `PictureBox`.
- Exportación de resultados a un archivo `.csv`.

---

## 📁 Estructura del Código

### Clase `Form1`

Contiene toda la lógica del sistema:

- `Form1()` – Inicializa componentes, configura el `DataGridView` y el temporizador.
- `Cargar_Button_Click()` – Permite seleccionar una carpeta con imágenes `.bmp`.
- `ConfigurarDataGridView()` – Configura las columnas "Ruta" y "Volumen".
- `ConfigurarTimer()` – Establece el intervalo de procesamiento automático.
- `Timer_Tick()` – Procesa la siguiente imagen cada 2 segundos.
- `ProcesarSiguienteImagen()` – Muestra la imagen, calcula el volumen y actualiza la tabla.
- `CalcularVolumenRelativo()` – Convierte la imagen, aplica filtros y calcula contornos.
- `MostrarImagenProcesada()` – Muestra la imagen binarizada.
- `Exportar_Button_Click()` – Exporta la tabla a `.csv`.

---

## 🧠 Algoritmos de Procesamiento de Imágenes

### 1. Conversión a Escala de Grises
Permite trabajar con un único canal de intensidad.  
👉 Función usada: `Cv2.CvtColor()`

### 2. Suavizado Gaussiano
Reduce el ruido y mejora la detección de contornos.  
👉 Función usada: `Cv2.GaussianBlur()` (kernel 3x3)

### 3. Umbral Adaptativo
Binariza la imagen adaptando el umbral localmente.  
👉 Función usada: `Cv2.AdaptiveThreshold()` con método Gaussiano

### 4. Detección de Contornos
Permite localizar áreas de fuga mediante detección de bordes.  
👉 Función usada: `Cv2.FindContours()` (modo `External`)

### 5. Cálculo de Volumen Relativo
Basado en el área total de los contornos detectados.  
- La imagen `image(22)` se usa como referencia con un volumen de 5 litros.
- Para imágenes posteriores se aplica un factor de escala relativo.

---

## 🚀 Instrucciones de Uso

1. **Clona el repositorio**:
   ```bash
   git clone https://github.com/tuusuario/nombre-repo.git
2. **Abre el proyecto** en **Visual Studio**.

3. **Instala los paquetes NuGet necesarios:**
   - [OpenCvSharp4](https://www.nuget.org/packages/OpenCvSharp4)
   - [OpenCvSharp4.Extensions](https://www.nuget.org/packages/OpenCvSharp4.Extensions)

4. **Ejecuta la aplicación** y sigue estos pasos:

   - Haz clic en **"Cargar Imágenes"** y selecciona una carpeta con archivos `.bmp`.
   - Se mostrará automáticamente la imagen de referencia: `image(22).bmp`.
   - Haz clic en **"Calcular"** para comenzar el procesamiento automático.
   - Revisa los resultados en la tabla con las columnas **Ruta** y **Volumen**.
   - Haz clic en **"Exportar"** para guardar los resultados en formato `.csv`.

---

## 📊 Pruebas de Rendimiento

El sistema fue evaluado durante cinco etapas clave del flujo de ejecución:

1. 🟢 **Inicio de ejecución**
2. 📁 **Exploración de archivos**
3. 🖼️ **Carga de imágenes**
4. ⚙️ **Procesamiento de cada imagen**
5. 💾 **Exportación de resultados**

Estas pruebas permitieron verificar la **estabilidad**, **velocidad** y **eficiencia** en el uso de recursos (memoria y CPU) del sistema bajo distintos escenarios operativos.

---

## ❓ ¿Por qué la cámara OGI puede detectar gas?

Aunque el **propano** es incoloro e invisible al ojo humano, **emite radiación térmica en el espectro infrarrojo**.  
Las cámaras **Optical Gas Imaging (OGI)** están diseñadas específicamente para **detectar esta radiación** y traducirla en una imagen visible.  
Esto permite visualizar de forma clara y efectiva las fugas de gas en condiciones reales.

---

## 👨‍💻 Autor

**Ing. Santiago Alejandro Zuñiga Melo**  
Solución desarrollada como parte de la **Prueba Técnica 1** para el cargo de **Analista de Ingeniería** en **Intecol**.

---

## 📄 Licencia

Este proyecto fue desarrollado exclusivamente con fines de **evaluación técnica**.  
Su uso está limitado a fines **personales, académicos o de portafolio**.  
Cualquier uso **comercial** requiere **autorización previa del autor**.
