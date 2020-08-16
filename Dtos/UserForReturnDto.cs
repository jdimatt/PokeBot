using System.Collections.Generic;

namespace PokeBot.Dtos
{
    public class UserForReturnDto
    {
        public int Id { get; set; }
        public ulong DiscordId { get; set; }
        public ICollection<PokemonForReturnDto> PokeCollection { get; set; }
    }
}