using Cf.Dotnet.PracticesAndPatterns.Solid.Data;
using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

namespace Cf.Dotnet.PracticesAndPatterns.Solid.Application;

/// <summary>
/// Servicio para crear usuarios. Implementa la interfaz IUserCreateService.
/// </summary>
public class UserCreateService : IUserCreateService
{
    private readonly DatabaseContext dbContext;

    /// <summary>
    /// Constructor de UserCreateService que inyecta una dependencia de DatabaseContext.
    /// </summary>
    /// <param name="dbContext">El contexto de la base de datos utilizado por este servicio.</param>
    public UserCreateService(DatabaseContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <summary>
    /// Crea un nuevo usuario con el nombre proporcionado.
    /// </summary>
    /// <param name="name">El nombre del nuevo usuario.</param>
    /// <returns>El usuario recién creado.</returns>
    /// <exception cref="ArgumentException">Se lanza si el usuario no es válido.</exception>
    public User CreateUser(string name)
    {
        var user = new User
        {
            Name = name
        };

        // Validar el usuario antes de añadirlo a la base de datos.
        if (!ValidateUser(user)) throw new ArgumentException("Invalid user");

        dbContext.Users.Add(user);
        dbContext.SaveChanges();
        return user;
    }

    /// <summary>
    /// Valida un usuario para asegurarse de que es válido.
    /// </summary>
    /// <param name="user">El usuario a validar.</param>
    /// <returns>True si el usuario es válido; de lo contrario, false.</returns>
    private bool ValidateUser(User user)
    {
        return !string.IsNullOrWhiteSpace(user.Name);
    }
}
