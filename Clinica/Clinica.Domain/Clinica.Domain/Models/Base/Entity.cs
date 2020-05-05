using System;
using FluentValidation;

namespace Clinica.Domain.Models.Base
{
    public class Entity
    {
        public Guid? Id { get; set; }

        public void GerarId()
        {
            if(!Id.HasValue)
                Id = Guid.NewGuid();
        }
    }
}
