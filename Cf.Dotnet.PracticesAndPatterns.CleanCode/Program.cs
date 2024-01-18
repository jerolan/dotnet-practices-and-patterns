int areaTotal;
int AreaTotal; // El compilador no se queja, pero no es la convencion.
var aT = 0; // No es descriptivo. Que significa a?, Que significa T?

// Se puede inferir el tipo de la variable
var orderComplete = false;

// NO se puede inferir el tipo de la variable
var alumnos = GetClients();

// Metodo unicamente para fines del ejemplo
static List<int> GetClients()
{
    return [1, 2, 3];
} 