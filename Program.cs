using System.Diagnostics;
using System.Security.Authentication;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Chamando o iphone
Iphone iphone1 = new Iphone(numero: "1234", modelo: "Teste", imei: "1234", memoria: 1234);
Console.WriteLine("Smartphone Iphone:");
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Nubank");

Console.WriteLine("\n");

//Chamando o Nokia
Nokia nokia1 = new Nokia(numero: "1234", modelo: "Teste", imei: "1234", memoria: 1234);
Console.WriteLine("Smartphone Nokia:");
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Instagram");