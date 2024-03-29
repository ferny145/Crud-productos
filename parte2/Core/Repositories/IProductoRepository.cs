﻿using parte2.Models;

namespace parte2.core.Repositories
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<Producto> GetById(int id);
        Task<int> Create(Producto producto);
        Task<int> Update(Producto producto);
        Task<int> Delete(int id);
    }
}
