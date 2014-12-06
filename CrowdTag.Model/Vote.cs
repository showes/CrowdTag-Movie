﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrowdTag.Model
{
	public class Vote : UserAddedItem
	{
		[Required]
		public bool IsUpvote { get; set; }

		[Required]
		[ForeignKey("TagApplicationBase")]
		public int? TagApplicationID { get; set; }

		public virtual TagApplication TagApplicationBase { get; set; }
	}
}
