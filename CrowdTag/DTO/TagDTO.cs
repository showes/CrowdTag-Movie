﻿using CrowdTag.Model;

namespace CrowdTag.DTO
{
    public class TagDTO : UserAddedItemDTO
    {
        public string Name { get; set; }

        public int? TaggedItemId { get; set; }

        public int? CategoryId { get; set; }

        public TagDTO() : base() { }

        public TagDTO(TagApplication entity) : this(entity.Tag)
        {
            this.TaggedItemId = entity.TaggedItemId;
            this.Id = entity.Id;
        }

        public TagDTO(TagBase entity)
            : base(entity)
        {
            this.Name = entity.Name;
            this.CategoryId = entity.CategoryId;
        }



        public new void UpdateEntity(ref TagBase entity)
        {
            entity.Name = this.Name;
        }

    }
}