﻿using ADN.Domain.Domain;
using ADN.Domain.DTO.Estudante;

namespace ADN.Domain.Interfaces.Services
{
    public interface IEstudanteService
    {
        Task<List<Estudante>> GetAll();
        Task Insert(EstudanteInsertDTO estudante);
    }
}
