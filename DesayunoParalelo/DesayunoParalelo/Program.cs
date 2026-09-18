using System.Diagnostics;
using System.Text;
using DesayunoParalelo;

Console.Title = "Agenda de contactos - DWES-01-Agenda";
Console.OutputEncoding = Encoding.UTF8;

// Programa principal
var sincrono = new Sincrono();
var asincrono = new Asincrono();
var texto1 = "El cafe se ha enfriado, no puedo tomarlo.";
var texto2 = "El cafe aun esta caliente, puedo tomarlo.";


Console.WriteLine("-----------------------------");
Console.WriteLine("       Proceso sincrono      ");
Console.WriteLine("-----------------------------");
var cronometro1 = new Stopwatch();
cronometro1.Start();
sincrono.PrepararCafe();
sincrono.CalentarSarten();
sincrono.FreirHuevo();
sincrono.FreirBacon();
sincrono.TostarPan();
sincrono.UntarMermelada();
sincrono.PrepararZumo();
cronometro1.Stop();
Console.WriteLine("Proceso sincrono terminado.");
Console.WriteLine($"Tiempo total: {cronometro1.ElapsedMilliseconds} milisegundos.");
var t = cronometro1.ElapsedMilliseconds > 12000L ? texto1 : texto2;
Console.WriteLine(t);
Console.WriteLine();

Console.WriteLine("-----------------------------");
Console.WriteLine("    Proceso asincrono mal    ");
Console.WriteLine("-----------------------------");
var cronometro2 = new Stopwatch();
cronometro2.Start();
var a = await asincrono.PrepararCafe();
var b = await asincrono.CalentarSarten();
var c = await asincrono.FreirHuevo();
var d = await asincrono.FreirBacon();
var e = await asincrono.TostarPan();
var f = await asincrono.UntarMermelada();
var g = await asincrono.PrepararZumo();
cronometro2.Stop();
Console.WriteLine("Proceso asincrono mal terminado.");
Console.WriteLine($"Tiempo total: {cronometro2.ElapsedMilliseconds} milisegundos.");
var t2 = cronometro2.ElapsedMilliseconds > 12000L ? texto1 : texto2;
Console.WriteLine(t2);
Console.WriteLine();

Console.WriteLine("-----------------------------");
Console.WriteLine("   Proceso asincrono bien    ");
Console.WriteLine("-----------------------------");
var cronometro3 = new Stopwatch();
cronometro3.Start();
var h = asincrono.PrepararCafe();
var i = asincrono.CalentarSarten();
var j = asincrono.TostarPan();
var k = asincrono.PrepararZumo();

await Task.WhenAll(h, i, j, k);

var l = asincrono.FreirHuevo();
var m = asincrono.FreirBacon();
var n = asincrono.UntarMermelada();

await Task.WhenAll(l, m, n);

cronometro3.Stop();
Console.WriteLine("Proceso asincrono bien terminado.");
Console.WriteLine($"Tiempo total: {cronometro3.ElapsedMilliseconds} milisegundos.");
var t3 = cronometro3.ElapsedMilliseconds > 12000L ? texto1 : texto2;
Console.WriteLine(t3);