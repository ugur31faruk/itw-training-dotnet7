using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace itw_training_dotnet7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> GetSingle(int id)
        {
            // return Ok(characters.FirstOrDefault<Character>(c => c.Id == id));
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> AddCharacter(AddCharacterDTO newCharacter) {
            
            // characters.Add(newCharacter);
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> UpdateCharacter(UpdateCharacterDTO updatedCharacter) {
            
            var response = await _characterService.UpdateCharacter(updatedCharacter);
            if(response.Data is null){
                return NotFound(response);
            }
            // characters.Add(newCharacter);
            return Ok(response);
            // return Ok(await _characterService.UpdateCharacter(updatedCharacter));
        }

        //          DENEME AMAÇLI, ÇALIŞMADI
        // [HttpPut]
        // public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> UpdateCharacterStrength(UpdateCharacterDTO updatedCharacter) {
            
        //     // characters.Add(newCharacter);
        //     return Ok(await _characterService.UpdateCharacter(updatedCharacter));
        // }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> DeleteCharacter(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if(response.Data is null){
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}