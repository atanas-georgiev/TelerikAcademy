﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using YoutubePlaylists.Data.Models;

namespace YoutubePlaylists.Data
{
    public interface IYoutubePlaylistsDbContext : IDisposable
    {
        int SaveChanges();

        IDbSet<User> Users { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<TextExamItem> TextExamItems { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
