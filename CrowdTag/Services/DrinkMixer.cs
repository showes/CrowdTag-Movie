﻿using CrowdTag.DataAccess;
using CrowdTag.DTO;
using CrowdTag.Model;

namespace CrowdTag.Services
{
    public class DrinkMixer
    {
        private DataContext _dataContext;

        public DrinkMixer(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public IngredientApplication AddIngredientToDrink(int drinkId, IngredientDTO ingredient)
        {
            var drink = _dataContext.TaggedItemRepository.GetById(drinkId);
            var tag = _dataContext.TagRepository.GetById(ingredient.Id);

            if (drink == null) throw new DbItemNotFoundException(typeof (TaggedItem), drinkId);

            var newEntity = new IngredientApplication {DrinkId = drinkId, IngredientId = ingredient.Id};
            ingredient.UpdateEntity(ref newEntity);
           // _dataContext.TagApplicationRepository.Add(newEntity);

            return newEntity;
        }
    }
}