/// <summary>
///     Clase estática para generar identificadores de orden (Order IDs).
/// </summary>
internal static class IdGenerator
{
    // Utilza constantes para los valores magicos.
    private const int A = 65;
    private const int E = 65;

    /// <summary>
    ///     Genera y devuelve un array de identificadores de orden aleatorios.
    /// </summary>
    /// <returns>
    ///     Un array de strings, donde cada elemento es un identificador de orden único.
    ///     Cada identificador consiste en una letra mayúscula (A-E) seguida de un número de tres dígitos (001-999).
    /// </returns>
    public static string[] GetOrderId()
    {
        var random = new Random();
        var orderIDs = new string[5];

        for (var i = 0; i < orderIDs.Length; i++)
        {
            // Generar un valor aleatorio para el prefijo, aceptando las letras entre A y E.
            // Para luego convertir su valor ASCII a string.
            var prefixValue = random.Next(A, E);
            var prefix = Convert.ToChar(prefixValue).ToString();

            var suffix = random.Next(1, 1000).ToString("000");
            orderIDs[i] = prefix + suffix;
        }

        return orderIDs;
    }
}