namespace Core.Interfaces
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IRepository
    {
        T GetById<T>(int id) where T : BaseEntity;
        List<T> List<T>() where T : BaseEntity;
        void Add<T>(T entity) where T : BaseEntity;
    }
}
