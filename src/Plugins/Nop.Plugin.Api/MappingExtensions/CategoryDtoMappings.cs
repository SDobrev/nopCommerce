﻿using AutoMapper;
using Nop.Core.Domain.Catalog;
using Nop.Plugin.Api.DTOs.Categories;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class CategoryDtoMappings
    {
        public static CategoryDto ToDto(this Category category, string fields = null)
        {
            return Mapper.Map<Category, CategoryDto>(category);
        }
    }
}