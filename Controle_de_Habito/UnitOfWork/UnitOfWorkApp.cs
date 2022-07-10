using Controle_de_Habito.Data;
using Controle_de_Habito.Models;
using Controle_de_Habito.Repository;
using System.Data.Entity;

namespace Controle_de_Habito.UnitOfWork
{
    public class UnitOfWorkApp : DbContext
    {
        ContextApp context = new ContextApp();
        Repository<Habito> habitoRepository;

        public Repository<Habito> HabitoRepository 
        {
            get {
                if (habitoRepository == null)
                    habitoRepository = new Repository<Habito>(context);
                return habitoRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }

    }
}
