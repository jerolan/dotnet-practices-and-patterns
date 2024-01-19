using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cf.Dotnet.PracticesAndPatterns.Solid.Data;

/// <summary>
/// Contexto de base de datos para la aplicación, utilizado para interactuar con la base de datos.
/// Hereda de DbContext, una clase de Entity Framework Core que facilita el mapeo entre objetos y registros de base de datos.
/// </summary>
public class DatabaseContext : DbContext
{
    /// <summary>
    /// Constructor sin parámetros para el contexto de base de datos.
    /// Utilizado por herramientas de Entity Framework Core.
    /// </summary>
    public DatabaseContext()
    {
    }

    /// <summary>
    /// Constructor que permite la configuración de opciones para el contexto de base de datos.
    /// </summary>
    /// <param name="options">Opciones de configuración para el contexto.</param>
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    /// <summary>
    /// DbSet que representa la colección de usuarios en la base de datos.
    /// Proporciona acceso a las operaciones CRUD para los objetos User.
    /// </summary>
    public DbSet<User> Users { get; set; } = null!;
}