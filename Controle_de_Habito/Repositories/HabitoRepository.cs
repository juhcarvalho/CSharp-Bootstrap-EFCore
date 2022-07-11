using Controle_de_Habito.Data;
using Controle_de_Habito.Models;
using Controle_de_Habito.Repositories.Interfaces;

namespace Controle_de_Habito.Repositories
{
    public class HabitoRepository : IHabitoRepository
    {
        private readonly ContextApp _contextApp;

        public HabitoRepository(ContextApp contextApp)
        {
            _contextApp = contextApp;
        }
    
        public IEnumerable<Habito> Habitos => _contextApp.Habitos;
    }
}
