﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FightCore.Models.Resources;
using FightCore.Repositories.Patterns;
using FightCore.Repositories.Resources;
using FightCore.Services.Patterns;

namespace FightCore.Services.Resources
{
    public interface IUserResourceService : IEntityService<UserResource>
    {
        /// <summary>
        /// Gets the total posts matching given optional filters
        /// </summary>
        /// <param name="category">Optionally filter on this post category</param>
        /// <returns>Total posts count</returns>
        Task<int> GetPostCountAsync(ResourceCategory? category);

        /// <summary>
        /// Gets a page of posts
        /// </summary>
        /// <param name="pageSize">Size per page of posts</param>
        /// <param name="pageNumber">Page index</param>
        /// <param name="sortOption">How results should be ordered</param>
        /// <param name="category">Optionally filter on this post category</param>
        /// <returns>Posts for given page</returns>
        IEnumerable<UserResource> GetPosts(int pageSize, int pageNumber, SortCategory sortOption, ResourceCategory? category);
    }
    public class UserResourceService : EntityService<UserResource>, IUserResourceService
    {
        private readonly IUserResourceRepository _repository;

        public UserResourceService(IUserResourceRepository repository) : base(repository)
        {
            _repository = repository;
        }

        /// <inheritdoc cref="IUserResourceService.GetPostCountAsync"/>
        public Task<int> GetPostCountAsync(ResourceCategory? category)
        {
            return _repository.GetPostCountAsync(category);
        }

        /// <inheritdoc cref="IUserResourceService.GetPosts"/>
        public IEnumerable<UserResource> GetPosts(int pageSize, int pageNumber, SortCategory sortOption, ResourceCategory? category)
        {
            return _repository.GetPosts(pageSize, pageNumber, sortOption, category);
        }
    }
}
