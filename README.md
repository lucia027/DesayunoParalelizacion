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

> Entre las tres primeras soluciones sin token he podido comprobar que hacerlo de forma asincrona secuencial, lo quq quiere ecir no utilizar bien la asincronia lleva a practicamente la misma duracion que lleva un proceso de froma asincrona, mientras que el poreso asincrono en paralelo bien propuesto reduce a bastante mas de la mitad el tiempo que tarda. Respecto a las soluciones con tokens de cancelacion siento que son muy utiles para ahorrar tiempo, por ejemplo, al utilizar un token con el asincrono secuencial ahorramo muchisimo tiempo al descartar su porceso por que ya no nos sirva. 

---

## 2. Ejecución simultánea y dependencias

**¿Qué acciones se pueden ejecutar a la vez y cuáles no? ¿Por qué?**

**Respuesta:**

> Las acciones que se pueden ejecutar a la vez son: preparar cafe, calentar sarten, tostar el pan, y preparar zumo, por que estas accciones son independientes las unas de las otras y ademas no interfieren en el proceso de las otras, por otro lado freir bacon, freir huevo y untar mermelada, dependen directamente de que algunas de las primeras acciones esten terminadas para poder realizarse.

---

## 3. Comportamiento con timeout

**¿Qué ha pasado con cada solución cuando introduces el timeout?**

**Respuesta:**

> Se limita el tiempo de espera para procesos que dejan de interesarnos, cuando el cafe se enfria ya no queremos ese desayuno por lo que limitamos el tiempo y si se excede lo descartamos.

---

## 4. Rendimiento y seguridad

**¿El enfoque con mejor rendimiento es también el más seguro? ¿Por qué?**

**Respuesta:**

> No necesariamente, lo mas seguro es utilizar tokens de cancelacion, asi conseguimos descartar los procesos que no nos interesen consiguiendo un codigo mucho mas controlado, pudiendom asi liberar esos recursos, mientras el enfoque con mejor rendimietno no esta pensando en controlar los procesos que ya no necesitamos, sino en que los que esten utilizandose se ejecuten de la forma mas eficiente posible.
---

## 5. Uso de paralelismo y control de tiempo

**¿Merece la pena complicarse con paralelismo o con mecanismos de control de tiempo? Justifica tu respuesta.**

**Respuesta:**

> Si cuando eso suponga una diferencia significativa del tiempo que tarda el proceso y necesitemos tener ese hilo disponible, optimizar el programa para poder ahorrar recursos y descartar procesos que apartir de un limite dejan de interesarnos merece la pena.
