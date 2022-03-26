using Carrito.Clases;

Carro miCarro = new Carro("Nissan Frotier",2022,"Azul", 180);

int cantacel = 0; int cantdsacel = 0;
string acel,dsacel, frno, estadomotor, bna;

Console.WriteLine($"Carro del Profe es marca: {miCarro.Marca} modelo: {miCarro.Modelo} color: {miCarro.Color} Velocidad maxima: {miCarro.MAXVELOCIDAD} \n");
estadomotor = miCarro.EncenderMotor();
Console.WriteLine(estadomotor);

cantacel = 7; //Cuantas veces hacelerara el carro
for (int i = 0; i < cantacel; i++)
{
    acel= miCarro.acelerar();
    Console.WriteLine(acel);
}
string velactual= miCarro.GetVelocidadActual();
Console.WriteLine(velactual,"\n");

cantdsacel = 7; // desaceleracion del carro
for (int i = 0; i < cantdsacel; i++)
{
    dsacel= miCarro.desacelerar();
    Console.WriteLine(dsacel);
}
velactual = miCarro.GetVelocidadActual();
Console.WriteLine(velactual);

bna = miCarro.bocina();
Console.WriteLine(bna);

frno= miCarro.frenar();
Console.WriteLine(frno);

estadomotor = miCarro.ApagarMotor();
Console.WriteLine(estadomotor,"\n");

