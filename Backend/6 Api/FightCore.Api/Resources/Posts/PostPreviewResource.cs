﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightCore.Api.Resources.Posts
{
    /// <summary>
    /// Simplified UI resource of the <see cref="FightCore.Models.Resources.Post"/> class
    /// </summary>
    public class PostPreviewResource
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        /// <summary>
        /// The user who has written this resource
        /// </summary>
        public UserResource Author { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Title { get; set; }

        public int Views { get; set; }

        public int Category { get; set; }
    }
}
