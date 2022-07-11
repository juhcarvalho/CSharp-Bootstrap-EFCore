using Controle_de_Habito.Models;

namespace Controle_de_Habito.Repositories.Interfaces
{
    public interface IHabitoRepository
    {
            IEnumerable<Habito> Habitos { get; }
    }
}
