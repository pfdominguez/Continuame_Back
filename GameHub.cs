using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace continuame_Back.Hubs
{
    public class GameHub : Hub
    {
        public async Task UnirseSala(string IdSala, string Nickname)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, IdSala);
            await Clients.Group(IdSala).SendAsync("JugadorUnido", Nickname);
        }

        public async Task IniciarJuego(string IdSala)
        {
            await Clients.Group(IdSala).SendAsync("InicioJuego");
        }

        public async Task FinRonda(string IdSala)
        {
            await Clients.Group(IdSala).SendAsync("RondaFinalizada");
        }

        public async Task FinJuego(string IdSala)
        {
            await Clients.Group(IdSala).SendAsync("FinDelJuego");
        }
    }
}

