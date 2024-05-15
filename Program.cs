using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NOKIA-2", imei: "111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");
nokia.ReceberLigacao();

Console.WriteLine("-------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Iphone 15", imei: "222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Apple TV");
iphone.ReceberLigacao();