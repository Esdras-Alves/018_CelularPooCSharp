using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("40028922", "Modelo Tijolo", "42123659", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone("48903610", "Xs", "51566365", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");