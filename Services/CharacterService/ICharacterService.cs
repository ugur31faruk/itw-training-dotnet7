using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace itw_training_dotnet7.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
        Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacter(int id);

        //          DENEME AMAÇLI, ÇALIŞMADI
        // Task<ServiceResponse<GetCharacterDTO>> UpdateCharacterStrength(UpdateCharacterDTO updatedCharacter);
        
    }
}