namespace Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

/// <summary>
/// Representa un usuario en el dominio de la aplicación.
/// </summary>
public class User
{
    /// <summary>
    /// Obtiene o establece el identificador único del usuario.
    /// </summary>
    /// <value>
    /// El identificador único del usuario.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Obtiene o establece el nombre del usuario.
    /// </summary>
    /// <value>
    /// El nombre del usuario.
    /// </value>
    public required string Name { get; set; }
}