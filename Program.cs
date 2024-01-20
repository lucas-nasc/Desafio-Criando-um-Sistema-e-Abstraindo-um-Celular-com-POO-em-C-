using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia");
// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new("123456","Modelo1","152434526",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("Smartphone Iphone");
Iphone iphone = new("157896526","Modelo2","2222222",128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

