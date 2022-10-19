using DesafioPOO.Models;

Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia(numero: "99 9999-9999", "N26", "1231232", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();

Console.WriteLine("Testando IPhone:");
Smartphone iphone = new Iphone(numero: "88 8888-888", "14x Plus", "13123122", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();