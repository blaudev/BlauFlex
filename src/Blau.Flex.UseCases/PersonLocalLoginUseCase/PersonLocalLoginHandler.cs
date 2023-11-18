using Blau.UseCases;

namespace Blau.Flex.UseCases.PersonLocalLoginUseCase;

public class PersonLocalLoginHandler : IUseCaseHandler<PersonLocalLoginRequest, PersonLocalLoginResponse>
{
    public Task<PersonLocalLoginResponse> HandleAsync(PersonLocalLoginRequest request)
    {
        throw new NotImplementedException();
    }
}
