using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinteWeb.Models
{
    public class DataService // : IDataService
    {
        private readonly ApplicationContexto contexto;

        public DataService(ApplicationContexto contexto)
        {
            this.contexto = contexto;
        }

        public void Initializadb()
        {
            contexto.Database.EnsureCreated();
        }
    }
}
