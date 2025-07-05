# Sistema de Detección de Fugas de Propano con Procesamiento de Imágenes

Este proyecto consiste en una aplicación desarrollada en **C# con Windows Forms** que emplea técnicas de **procesamiento de imágenes** usando **OpenCVSharp** para detectar fugas de gas propano a partir de imágenes capturadas por cámaras de **Optical Gas Imaging (OGI)**. La aplicación calcula el volumen de gas perdido, visualiza los resultados y permite exportarlos en formato CSV.

## 🛠 Tecnologías Usadas

- **Lenguaje:** C#
- **Entorno de Desarrollo:** Microsoft Visual Studio
- **Librerías:**
  - [OpenCvSharp4](https://www.nuget.org/packages/OpenCvSharp4)
  - [OpenCvSharp4.Extensions](https://www.nuget.org/packages/OpenCvSharp4.Extensions)
- **Framework:** Windows Forms

---

## ⚙️ Características

- Carga de múltiples imágenes BMP desde una carpeta.
- Preprocesamiento de imágenes (escala de grises, suavizado Gaussiano, umbral adaptativo).
- Detección de contornos para identificar zonas de fuga.
- Cálculo estimado del volumen de gas perdido.
- Visualización de resultados en tabla e imágenes procesadas.
- Exportación de resultados a archivo `.csv`.

---

## 🚀 Instrucciones de Uso

1. **Clona el repositorio**:
   ```bash
   git clone https://github.com/tuusuario/nombre-repo.git
