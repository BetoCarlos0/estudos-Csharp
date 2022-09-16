
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456789", "Nokia 15", "4444444", "124");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("987654", "Iphone 11", "888888", "212");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");
