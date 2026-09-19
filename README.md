# ⏱️ Comparación de tiempos

| Enfoque                           | Tiempo obtenido | ¿Supera 500 ms? |
| --------------------------------- | --------------: | :-------------: |
| 🔴 Ejecución síncrona             |       `1552 ms` |        ✅        |
| 🟠 Asincronía secuencial          |       `1544 ms` |        ✅        |
| 🟢 Asincronía optimizada          |        `515 ms` |        ✅        |
| ⏳ Asincronía secuencial + timeout |      `_____ ms` |        ✅        |
| ⚡ Asincronía optimizada + timeout |      `_____ ms` |        ✅        |

<br>
<br>
<br>

# 📊 Análisis de resultados

## 1. Diferencias entre las soluciones

**¿Qué diferencias has observado entre las 5 soluciones?**

**Respuesta:**

> Entre las tres primeras soluciones sin token he podido comprobar que hacerlo de forma asincrona secuencial, lo quq quiere ecir no utilizar bien la asincronia lleva a practicamente la misma duracion que lleva un proceso de froma asincrona, mientras que el poreso asincrono en paralelo bien propuesto reduce a bastante mas de la mitad el tiempo que tarda. Respecto a las soluciones con tokens de cancelacion, 

---

## 2. Ejecución simultánea y dependencias

**¿Qué acciones se pueden ejecutar a la vez y cuáles no? ¿Por qué?**

**Respuesta:**

> Escribe aquí tu respuesta.

---

## 3. Comportamiento con timeout

**¿Qué ha pasado con cada solución cuando introduces el timeout?**

**Respuesta:**

> Escribe aquí tu respuesta.

---

## 4. Rendimiento y seguridad

**¿El enfoque con mejor rendimiento es también el más seguro? ¿Por qué?**

**Respuesta:**

> Escribe aquí tu respuesta.

---

## 5. Uso de paralelismo y control de tiempo

**¿Merece la pena complicarse con paralelismo o con mecanismos de control de tiempo? Justifica tu respuesta.**

**Respuesta:**

> Escribe aquí tu respuesta.
