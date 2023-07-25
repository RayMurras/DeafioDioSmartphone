using DesafioPOO.Models;

System.Console.WriteLine("Smatphone Nokia: ");
Smartphone nokia = new Nokia(numero: "22222222", modelo: "Nokia 2", imei: "55555", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Candy Crush");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smatphone Iphone: ");
Smartphone iphone = new Nokia(numero: "22222222", modelo: "Iphone 12", imei: "55555", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Candy Crush");
