﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrowdTag.Model
{
	public class TagCategory : UserAddedItem
	{
		[RegularExpression(ModelConstant.RegEx.TagName)]
		public string Name { get; set; }

		public string Description { get; set; }

		public virtual ICollection<TagBase> Tags { get; set; }
	}
}