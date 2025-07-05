# Clasificador de Galletas con Relleno mediante Procesamiento de Imágenes

Este repositorio contiene una aplicación en **C# con Windows Forms** para la detección automática de galletas con o sin crema, a través de **procesamiento de imágenes**. El proyecto fue desarrollado como parte de una prueba técnica para el cargo de **Analista de Ingeniería en Intecol**.

## 🧠 Objetivo del Proyecto

Detectar visualmente si una galleta ha recibido o no la cantidad adecuada de crema durante el proceso de producción. Para ello se aplica un pipeline de procesamiento de imágenes que incluye:
- Máscara circular
- Conversión a escala de grises
- Suavizado Gaussiano
- Detección de bordes con Sobel
- Segmentación y conteo de píxeles negros

---

## 🛠 Tecnologías Utilizadas

- **Lenguaje:** C#
- **Entorno:** Microsoft Visual Studio
- **Interfaz:** Windows Forms
- **Procesamiento de imágenes:** Clases y métodos nativos de `System.Drawing`

---

## ⚙️ Funcionalidades

- Carga de imágenes en formato BMP.
- Visualización de la imagen original y la procesada.
- Aplicación de filtros:
  - Máscara circular (recorte centrado)
  - Suavizado Gaussiano (3x3)
  - Filtro Sobel (bordes)
- Clasificación binaria: **Con Relleno** / **Sin Relleno**
- Interfaz intuitiva para usuarios no técnicos.

---

## 🔄 Flujo de Procesamiento

1. **Carga de Imagen:**  
   Se carga una imagen BMP desde el sistema local.

2. **Preprocesamiento:**  
   - Se aplica una **máscara circular** para centrarse en la región de interés.  
   - Se convierte a **escala de grises** y se **suaviza** la imagen.

3. **Detección de Bordes:**  
   Se aplica el **filtro Sobel** para resaltar los contornos de la crema.

4. **Segmentación y Conteo:**  
   Se utiliza una técnica basada en **BFS** para contar los **píxeles negros** (zonas sin brillo).

5. **Clasificación:**  
   Si el número de píxeles negros < umbral → `Con relleno`, de lo contrario → `Sin relleno`.

---

## 🧪 Pruebas de Rendimiento

Se realizaron pruebas midiendo:
- **Tiempo de carga y procesamiento**
- **Consumo de memoria**
- **Uso de CPU**  
en distintos escenarios con imágenes de diferentes tamaños.

---

## 🖥️ Uso de la Aplicación

1. **Abrir el proyecto** en Visual Studio.
2. **Ejecutar la aplicación.**
3. Cargar una imagen (`.bmp`) con el botón **"Cargar Imagen"**.
4. Presionar **"Procesar"**.
5. Observar el resultado:
   - Imagen procesada (bordes detectados)
   - Clasificación: `Con relleno` o `Sin relleno`

---

## 📷 Capturas de Interfaz

> *(Puedes añadir aquí screenshots de la interfaz con imágenes de galletas, antes y después del procesamiento.)*

---

## 👨‍💻 Autor

**Ing. Santiago Alejandro Zuñiga Melo**  
Proyecto realizado como parte de la prueba técnica para **Intecol**.

---

## 📄 Licencia

Este proyecto fue desarrollado exclusivamente para evaluación técnica. Su uso está limitado a fines personales o educativos. No está autorizado para uso comercial sin previa autorización.

