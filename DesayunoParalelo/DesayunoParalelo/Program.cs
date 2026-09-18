using System.Diagnostics;
using System.Text;
using DesayunoParalelo;

Console.Title = "Agenda de contactos - DWES-01-Agenda";
Console.OutputEncoding = Encoding.UTF8;

// Variables del programa
var sincrono = new Sincrono();
var asincrono = new Asincrono();
var asincronoToken = new AsincronoToken();
var texto1 = "☕ ¡El café se ha enfriado! Los huevos y tostadas con café frío no tienen gracia...";
var texto2 = "🥓 ¡El café sigue caliente! Hora de desayunar...";
var cronometro = new Stopwatch();


Console.WriteLine("-----------------------------");
Console.WriteLine("       Proceso sincrono      ");
Console.WriteLine("-----------------------------");
cronometro.Restart();
sincrono.PrepararCafe();
sincrono.CalentarSarten();
sincrono.FreirHuevo();
sincrono.FreirBacon();
sincrono.TostarPan();
sincrono.UntarMermelada();
sincrono.PrepararZumo();
cronometro.Stop();
Console.WriteLine("Proceso sincrono terminado.");
Console.WriteLine($"Tiempo total: {cronometro.ElapsedMilliseconds} milisegundos.");
Console.WriteLine();

Console.WriteLine("-----------------------------");
Console.WriteLine("    Proceso asincrono mal    ");
Console.WriteLine("-----------------------------");
cronometro.Restart();
var a = await asincrono.PrepararCafe();
var b = await asincrono.CalentarSarten();
var c = await asincrono.FreirHuevo();
var d = await asincrono.FreirBacon();
var e = await asincrono.TostarPan();
var f = await asincrono.UntarMermelada();
var g = await asincrono.PrepararZumo();
cronometro.Stop();
Console.WriteLine("Proceso asincrono mal terminado.");
Console.WriteLine($"Tiempo total: {cronometro.ElapsedMilliseconds} milisegundos.");
Console.WriteLine();

Console.WriteLine("-----------------------------");
Console.WriteLine("   Proceso asincrono bien    ");
Console.WriteLine("-----------------------------");
cronometro.Restart();
var h = asincrono.PrepararCafe();
var i = asincrono.CalentarSarten();
var j = asincrono.TostarPan();
var k = asincrono.PrepararZumo();

await Task.WhenAll(h, i, j, k);

var l = asincrono.FreirHuevo();
var m = asincrono.FreirBacon();
var n = asincrono.UntarMermelada();

await Task.WhenAll(l, m, n);

cronometro.Stop();
Console.WriteLine("Proceso asincrono bien terminado.");
Console.WriteLine($"Tiempo total: {cronometro.ElapsedMilliseconds} milisegundos.");
Console.WriteLine();

Console.WriteLine("-----------------------------");
Console.WriteLine(" Proceso asincrono mal token ");
Console.WriteLine("-----------------------------");
cronometro.Restart();
using var cts1 = new CancellationTokenSource();
cts1.CancelAfter(500);
try {
    var a2 = await asincronoToken.PrepararCafe(cts1.Token);
    var b2 = await asincronoToken.CalentarSarten(cts1.Token);
    var c2 = await asincronoToken.FreirHuevo(cts1.Token);
    var d2 = await asincronoToken.FreirBacon(cts1.Token);
    var e2 = await asincronoToken.TostarPan(cts1.Token);
    var f2 = await asincronoToken.UntarMermelada(cts1.Token);
    var g2 = await asincronoToken.PrepararZumo(cts1.Token);
} catch (OperationCanceledException) {
    Console.WriteLine("☠️ Vaya, el proceso a superado el tiempo maximo..");
}
cronometro.Stop();
Console.WriteLine("Proceso asincrono mal con token terminado.");
Console.WriteLine($"Tiempo total: {cronometro.ElapsedMilliseconds} milisegundos.");
var t1 = cronometro.ElapsedMilliseconds > 500L ? texto1 : texto2;
Console.WriteLine(t1);
Console.WriteLine();

Console.WriteLine("-----------------------------");
Console.WriteLine(" Proceso asincrono bien token");
Console.WriteLine("-----------------------------");
cronometro.Restart();
using var cts2 = new CancellationTokenSource();
cts2.CancelAfter(500);
try {
    var h2 = asincronoToken.PrepararCafe(cts2.Token);
    var i2 = asincronoToken.CalentarSarten(cts2.Token);
    var j2 = asincronoToken.TostarPan(cts2.Token);
    var k2 = asincronoToken.PrepararZumo(cts2.Token);
    await Task.WhenAll(h2, i2, j2, k2);

    var l2 = asincronoToken.FreirHuevo(cts2.Token);
    var m2 = asincronoToken.FreirBacon(cts2.Token);
    var n2 = asincronoToken.UntarMermelada(cts2.Token);
    await Task.WhenAll(l2, m2, n2);
} catch (OperationCanceledException) {
    Console.WriteLine("☠️ Vaya, el proceso a superado el tiempo maximo..");
}
cronometro.Stop();
Console.WriteLine("Proceso asincrono bien con token terminado.");
Console.WriteLine($"Tiempo total: {cronometro.ElapsedMilliseconds} milisegundos.");
var t2 = cronometro.ElapsedMilliseconds > 500L ? texto1 : texto2;
Console.WriteLine(t2);
Console.WriteLine();