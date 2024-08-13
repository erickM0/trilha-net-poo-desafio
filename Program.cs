using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("11 9 9999-9999", "modelo 1", "11-12-13-14", 64);
Iphone iphone= new Iphone("12 9 9999-9990", "Pro Max Plus Advanced", "00-11-22-33",128);

Console.WriteLine("\n\n--teste funcionalidades Nokia--\n\n");

//metodos herdados de Smartphone
nokia.Ligar();
nokia.ReceberLigacao();

//metodo sobrescrito pela classe filha Nokia 
nokia.InstalarAplicativo("WhatsApp");

//metodo para exibir propriedades privadas
nokia.MostrarConfigurcoes();

Console.WriteLine("\n\n--teste funcionalidades Iphone--\n\n");

//metodos herdados de Smartphone
iphone.Ligar();
nokia.ReceberLigacao();

//metodo sobrescrito pela classe filha Nokia 
iphone.InstalarAplicativo("TikTok");

//metodo para exibir propriedades privadas
iphone.MostrarConfigurcoes();




