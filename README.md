# 🚗 Detección de Velocidad y Mejora de Nitidez de Imágenes con OpenCV

Este proyecto es una aplicación desarrollada en **C# con Windows Forms**, como solución a la **Prueba Técnica 3** para el cargo de *Analista de Ingeniería* en la empresa **Intecol**.

La aplicación permite **cargar una imagen**, **mejorar su nitidez mediante filtrado por convolución**, y **calcular la velocidad de un objeto en movimiento** (por ejemplo, un coche) utilizando su longitud estimada y el tiempo de exposición de la cámara.

---

## 🛠 Tecnologías Usadas

- **Lenguaje:** C#
- **Entorno de desarrollo:** Microsoft Visual Studio
- **Librerías NuGet:**
  - `OpenCvSharp4`
  - `OpenCvSharp4.Extensions`
  - `OpenCvSharp4.runtime.win`
  - `OpenCvSharp4.Windows`
  - `OpenCvSharp4.WpfExtensions`
- **Framework:** Windows Forms

---

## ⚙️ Funcionalidades

- Carga de imágenes en formato `.jpg`, `.jpeg`, `.png`, `.bmp`.
- Aplicación de un filtro de **nitidez (sharpening)** a través de un kernel convolucional.
- Cálculo de la **velocidad** de un objeto en movimiento usando:
  - Longitud del objeto (cm)
  - Tiempo de exposición de la cámara (s)
- Visualización en interfaz gráfica:
  - Imagen original
  - Imagen procesada
  - Velocidad estimada en **km/h**

---

## 📁 Explicación Detallada del Código

### Clase `Form1`

Contiene toda la lógica de interfaz y procesamiento:

- `Form1()`  
  Inicializa los componentes de la interfaz.

- `Cargar_Button_Click()`  
  Permite al usuario seleccionar una imagen del sistema de archivos y la carga en `PictureBox1`.

- `Procesar_Button_Click()`  
  Aplica el filtro de nitidez, muestra la imagen en `PictureBox2`, calcula y muestra la velocidad del objeto.

- `ApplySharpen(Mat image)`  
  Aplica una convolución con kernel `3x3` que resalta bordes y detalles para mejorar la nitidez.

- `CalcularVelocidad(double longitudPlaca, double tiempoExposicion)`  
  Implementa la fórmula \( v = \frac{d}{t} \) para obtener la velocidad en **cm/s**, que se convierte luego a **km/h**.

---

## 🧠 Algoritmos Utilizados

### 🔹 Filtro de Aumento de Nitidez (Sharpen)
Se aplica un **kernel de convolución**:

[ -1, -1, -1 ]
[ -1, 9, -1 ]
[ -1, -1, -1 ]


Esto permite mejorar el enfoque de la imagen resaltando bordes y contornos útiles para el reconocimiento.

### 🔹 Cálculo de Velocidad

Se usa la fórmula clásica de cinemática:

velocidad (cm/s) = longitud / tiempo
velocidad (km/h) = (cm/s) * 3600 / 100000


---

## 🚀 Instrucciones de Uso

1. **Abre el proyecto** en **Visual Studio**.

2. **Instala los paquetes NuGet necesarios:**
   - `OpenCvSharp4`
   - `OpenCvSharp4.Extensions`
   - `OpenCvSharp4.runtime.win`
   - `OpenCvSharp4.Windows`
   - `OpenCvSharp4.WpfExtensions`

3. **Ejecuta la aplicación** y sigue estos pasos:

   - Haz clic en **"Cargar"** y selecciona una imagen del sistema de archivos.
   - La imagen se mostrará en el primer `PictureBox`.
   - Haz clic en **"Procesar"** para aplicar el filtro de nitidez.
   - La imagen procesada se mostrará en el segundo `PictureBox`.
   - La velocidad del objeto será calculada y mostrada en la caja de texto correspondiente (en **km/h**).

---

## 📊 Pruebas de Rendimiento

El sistema fue sometido a pruebas durante distintas fases del flujo de trabajo:

1. Inicio de ejecución
2. Exploración de archivos
3. Carga de imágenes de distintos tamaños
4. Aplicación del filtro de nitidez
5. Cálculo de velocidad y visualización

Los resultados mostraron **tiempos de respuesta aceptables** y buen manejo de imágenes incluso de gran resolución.

---

## ❓ ¿Qué hace esta aplicación?

Permite **mejorar visualmente una imagen** y **calcular la velocidad de un objeto** si se tiene información básica de su longitud y el tiempo de exposición. Es útil en contextos como análisis de cámaras de tráfico o experimentos de movimiento.

---

## 👨‍💻 Autor

**Ing. Santiago Alejandro Zuñiga Melo**  
Solución desarrollada como parte de la **Prueba Técnica 3** para el cargo de *Analista de Ingeniería* en **Intecol**.

---

## 📄 Licencia

Este proyecto fue desarrollado exclusivamente como parte de una **evaluación técnica**.  
Su uso está limitado a fines **personales, académicos o de portafolio**.  
**Cualquier uso comercial requiere autorización previa del autor.**
