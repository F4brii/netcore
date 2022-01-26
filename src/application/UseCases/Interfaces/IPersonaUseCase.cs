using application.DTO;

namespace application.UseCase.Interfaces
{
    public interface IPersonaUseCase
    {
        PersonaDTO GetPersona(int Id);
    }
}