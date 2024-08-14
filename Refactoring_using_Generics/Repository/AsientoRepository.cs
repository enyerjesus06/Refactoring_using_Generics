using Microsoft.EntityFrameworkCore;
using Refactoring_using_Generics.Base;
using Refactoring_using_Generics.Entities;
using Refactoring_using_Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_using_Generics.Repository
{
    public class AsientoRepository : BaseRepository<Asiento>, IAsientoRepository
    {
        public AsientoRepository(DbContext context) : base(context)
        {
        }

        // Métodos adicionales específicos de AsientoRepository, si los hay
    }
}
