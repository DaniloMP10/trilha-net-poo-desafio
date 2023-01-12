using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone(numero: "123-123", modelo: "X", imei: "10101", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "456-456", modelo: "N PLUS", imei: "20202", memoria: 16);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Brawlstars");

