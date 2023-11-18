using Blau.UseCases;

namespace Blau.Flex.UseCases.PersonLocalLoginUseCase;

public class PersonLocalLoginRequest(string email, string password) : IUseCaseRequest
{
    public string Email { get; private set; } = email;
    public string Password { get; private set; } = password;
}
