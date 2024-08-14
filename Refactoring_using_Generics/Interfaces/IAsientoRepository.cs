using Refactoring_using_Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_using_Generics.Interfaces
{
    public interface IAsientoRepository : IRepository<Asiento>
    {
        // Métodos específicos de AsientoRepository si es necesario
    }
}
