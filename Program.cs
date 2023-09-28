using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando a classe Nokia");
Nokia nokia = new Nokia("(21)9999-9999", "Nokia G11 Plus 4G", "111111111111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine(nokia.Numero);

Console.WriteLine("------------------------------------\n");

Console.WriteLine("Testando a classe Iphone");
Iphone iphone15 = new Iphone("(21)5555-5555", "Iphone 15", "222222222222222", 256);
iphone15.Ligar();
iphone15.ReceberLigacao();
iphone15.InstalarAplicativo("Telegram");
Console.WriteLine(iphone15.Numero);