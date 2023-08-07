
//PATRONES RELACIONALES
//para switches 
var temperatura = 35;

var mensaje = temperatura switch
{
    37 => "No tienes ninguna condicion",
    > 37 => "Tienes fiebre",
    < 37 => "Puede que tengas baja el azúcar"
};
Console.WriteLine(mensaje);