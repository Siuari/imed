using System.Collections.Generic;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Clinica.Infra.Repositories
{
    public class CoberturaRepository : RepositoryBase<Cobertura>, ICoberturaRepository
    {
        private readonly ClinicaContext _context;

        public CoberturaRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }

    }
}