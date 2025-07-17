using System.Diagnostics;
using System.Security.Authentication;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Chamando o iphone
Iphone iphone1 = new Iphone(numero: "1234", modelo: "Teste", imei: "1234", memoria: 1234);
Console.WriteLine("Smartphone Iphone:");
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Zap Zap");

Console.WriteLine("\n");