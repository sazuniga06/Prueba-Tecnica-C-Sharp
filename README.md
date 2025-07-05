# 🧪 Pruebas Técnicas de Procesamiento de Imágenes con C# y OpenCV

Este repositorio reúne tres proyectos de procesamiento de imágenes desarrollados como solución a pruebas técnicas para el cargo de **Analista de Ingeniería** en **Intecol**. Cada solución aborda un desafío particular utilizando **C#**, **Windows Forms** y la biblioteca **OpenCVSharp**.

---

## 🔍 Descripción General de las Pruebas

### 🧪 Prueba 1: Detección de Fugas de Gas Propano

- **Objetivo:** Detectar zonas con fugas de gas propano en imágenes térmicas capturadas por cámaras OGI.
- **Procesamiento:** Escala de grises, suavizado, umbral adaptativo, contornos.
- **Resultado:** Estimación del volumen relativo de gas perdido por imagen.
- 📂 Carpeta: `Prueba1`

---

### 🍪 Prueba 2: Clasificación de Galletas con o sin Relleno

- **Objetivo:** Clasificar galletas que tienen o no crema aplicada correctamente.
- **Procesamiento:** Máscara circular, escala de grises, suavizado, bordes con Sobel, conteo de píxeles.
- **Resultado:** Clasificación binaria: `Con Relleno` / `Sin Relleno`.
- 📂 Carpeta: `Prueba2`

---

### 🚗 Prueba 3: Cálculo de Velocidad de un Objeto en Imagen

- **Objetivo:** Estimar la velocidad de un objeto en movimiento (por ejemplo, un coche) a partir de una imagen capturada.
- **Procesamiento:** Filtro de nitidez por convolución, estimación por longitud y tiempo de exposición.
- **Resultado:** Visualización de imagen mejorada y velocidad estimada en km/h.
- 📂 Carpeta: `Prueba3`

---

## 🛠 Tecnologías Utilizadas

- **Lenguaje:** C#
- **Entorno de desarrollo:** Visual Studio
- **Framework:** Windows Forms
- **Librerías NuGet:**
  - `OpenCvSharp4`
  - `OpenCvSharp4.Extensions`
  - `OpenCvSharp4.runtime.win`
  - `OpenCvSharp4.Windows`
  - `OpenCvSharp4.WpfExtensions`

---

## 🚀 Cómo Ejecutar los Proyectos

1. Abre cada carpeta de prueba como proyecto independiente en **Visual Studio**.
2. Instala los paquetes NuGet correspondientes.
3. Ejecuta la aplicación y sigue las instrucciones descritas en cada `README.md` de carpeta.

---

## 👨‍💻 Autor

**Ing. Santiago Alejandro Zuñiga Melo**  
Desarrollador de software e ingeniero físico.  
Este repositorio fue creado como parte del proceso de evaluación técnica para **Intecol**.

---

## 📄 Licencia

Todos los proyectos contenidos en este repositorio fueron desarrollados con fines de **evaluación técnica**.  
Su uso está permitido únicamente para fines **académicos, personales o de portafolio**.  
**Queda prohibido el uso comercial sin consentimiento expreso del autor.**
