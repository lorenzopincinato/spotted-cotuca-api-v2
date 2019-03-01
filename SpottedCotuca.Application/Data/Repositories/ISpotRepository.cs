﻿using SpottedCotuca.Application.Entities.Models;
using System.Threading.Tasks;

namespace SpottedCotuca.Aplication.Repositories
{
    public interface ISpotRepository
    {
        Task<Spot> Read(long id);
        Task<PagingSpots> Read(Status status, int offset, int limit);
        Task Create(Spot spot);
        Task Update(Spot spot);
        Task Delete(long id);
    }
}