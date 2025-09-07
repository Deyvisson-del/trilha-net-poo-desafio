using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone ip = new Iphone(numero: "(81)99750-1837", modelo: "Iphone 16", imei: "878488515154#", memoria: 255);
Nokia No = new Nokia(numero: "(81)98586-7517", modelo: "Nokia One", imei: "829592ufhsfh#", memoria: 512);

ip.InstalarAplicativo("Whatsapp");
No.InstalarAplicativo("Google");

ip.ReceberLigacao();
No.ReceberLigacao();

ip.Ligar();
No.Ligar();
