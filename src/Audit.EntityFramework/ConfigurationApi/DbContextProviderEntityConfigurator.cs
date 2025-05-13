﻿#if NET7_0_OR_GREATER
using System;
using System.Collections.Generic;
using Audit.Core;

namespace Audit.EntityFramework.ConfigurationApi;

public class DbContextProviderEntityConfigurator<TEntity> : IDbContextProviderEntityConfigurator<TEntity>
    where TEntity : class, new()
{
    internal Action<AuditEvent, TEntity> _mapper;
    internal bool _disposeDbContext;

    public IDbContextProviderEntityConfigurator<TEntity> Mapper(Action<AuditEvent, TEntity> mapper)
    {
        _mapper = mapper;
        return this;
    }
    
    public IDbContextProviderEntityConfigurator<TEntity> DisposeDbContext(bool dispose = true)
    {
        _disposeDbContext = dispose;
        return this;
    }
}

public class DbContextProviderEntityConfigurator : IDbContextProviderEntityConfigurator
{
    internal Func<AuditEvent, IEnumerable<object>> _entityBuilder;
    internal bool _disposeDbContext;

    public IDbContextProviderEntityConfigurator EntityBuilder(Func<AuditEvent, IEnumerable<object>> entitiesBuilder)
    {
        _entityBuilder = entitiesBuilder;
        return this;
    }

    public IDbContextProviderEntityConfigurator EntityBuilder(Func<AuditEvent, object> entityBuilder)
    {
        _entityBuilder = ev => new List<object>() { entityBuilder?.Invoke(ev) };
        return this;
    }

    public IDbContextProviderEntityConfigurator DisposeDbContext(bool dispose = true)
    {
        _disposeDbContext = dispose;
        return this;
    }
}
#endif