using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345-6789", modelo: "Nokia Tijolão", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");


Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "98765-4321", modelo: "Iphone 100 PRO MAX", imei: "000000000", memoria: 1000);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");
