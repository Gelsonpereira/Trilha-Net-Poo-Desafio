using Projeto_de_Celular_dio.Models;

Console.WriteLine("Smartphone Nokia:");
Smartfone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativos("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartfone iphone = new Iphone(numero: "987654", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativos("Telegram");