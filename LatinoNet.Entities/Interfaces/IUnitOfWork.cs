﻿using System.Threading.Tasks;

namespace LatinoNet.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}