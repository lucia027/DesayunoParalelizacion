# ⏱️ Sincronía y Asincronía

Esta práctica sirve como una primera toma de contacto con la **sincronía y la asincronía en C#**.

El objetivo es comprobar y comparar los **tiempos de ejecución** de un mismo proceso realizado de tres formas diferentes:

* 🔴 **Síncrona:** las tareas se ejecutan una detrás de otra.
* 🟡 **Asíncrona mal implementada:** se utilizan métodos asíncronos, pero se esperan uno a uno, por lo que no se aprovecha correctamente la asincronía.
* 🟢 **Asíncrona bien implementada:** las tareas pueden ejecutarse de forma simultánea, reduciendo el tiempo total de ejecución.

Con esta práctica se puede observar de forma sencilla cómo una correcta implementación de la **asincronía** puede mejorar el rendimiento y reducir los tiempos de espera.
