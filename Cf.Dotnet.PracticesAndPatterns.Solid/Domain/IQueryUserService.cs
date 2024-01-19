namespace Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

/// <summary>
/// Proporciona la definición para un servicio de consulta de usuarios.
/// Este servicio incluye métodos para obtener información específica de usuarios.
/// </summary>
public interface IQueryUserService
{
    /// <summary>
    /// Obtiene un usuario basado en su identificador único.
    /// </summary>
    /// <param name="id">El identificador único del usuario.</param>
    /// <returns>El usuario correspondiente al identificador proporcionado.</returns>
    /// <exception cref="InvalidOperationException">Se produce cuando no se encuentra un usuario con el identificador proporcionado.</exception>
    User GetUser(int id);

    /// <summary>
    /// Obtiene una lista de los identificadores de todos los usuarios.
    /// </summary>
    /// <returns>Una lista de identificadores de usuarios.</returns>
    /// <remarks>
    /// Este método puede ser utilizado para obtener una vista rápida de todos los usuarios existentes en el sistema.
    /// </remarks>
    List<int> ListUserIds();
}