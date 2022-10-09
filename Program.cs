using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone Iphone = new Iphone(numero: "1197772384", modelo: "Apple Perâ X9", imei: "2asd222349", memoria: 32);
Smartphone Nokia32 = new Nokia(numero: "119748236", modelo: "Nokia Tijolasso", imei: "342563sf", memoria: 12);

Console.WriteLine();
Iphone.InstalarAplicativo("SAFARIA BROWSER");
Nokia32.InstalarAplicativo("Jogo da Snake");

