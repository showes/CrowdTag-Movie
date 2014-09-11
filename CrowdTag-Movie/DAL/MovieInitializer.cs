﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CrowdTagMovie.Models;

namespace CrowdTagMovie.DAL
{
	public class MovieInitializer : DropCreateDatabaseIfModelChanges<MovieContext>
	{
		protected override void Seed(MovieContext context)
		{
			var now = DateTime.Now;

			/*var ranks = new List<UserRank>
			{
				new UserRank
				{
					 Level=0,
				},
			};

			ranks.ForEach(r => context.Ranks.Add(r));
			context.SaveChanges();
			*/

			var crowdTagBot = new User
			{
				ID = Guid.NewGuid().ToString(),
				Username="CrowdTagBot",
				Score=0,
				Email="Noreply@CrowdTag.com",
				DateJoined=now,
				LastActivity=now,
				//UserRankID=ranks[0].UserRankID,
			}; 

			context.Users.Add(crowdTagBot);
			context.SaveChanges();

			var movies = new List<Movie>
			{
	 			new Movie{Title="The Shawshank Redemption",Director="Frank Darabont", ReleaseDate=DateTime.Parse("14 October 2010"),CreatedDateTime=DateTime.Parse("15 December 1995"), Description="Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."},
				new Movie{Title="The Godfather",Director="Francis Ford Coppola", ReleaseDate=DateTime.Parse("24 March 1972"),CreatedDateTime=DateTime.Parse("26 June 2013"), Description="The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."},
				new Movie{Title="The Godfather: Part II",Director="Francis Ford Coppola", ReleaseDate=DateTime.Parse("20 December 1974"),CreatedDateTime=DateTime.Parse("22 July 2012"), Description="The early life and career of Vito Corleone in 1920s New York is portrayed while his son, Michael, expands and tightens his grip on his crime syndicate stretching from Lake Tahoe, Nevada to pre-revolution 1958 Cuba."},
				new Movie{Title="The Dark Knight",Director="Christopher Nolan", ReleaseDate=DateTime.Parse("18 July 2008"),CreatedDateTime=DateTime.Parse("11 August 2011"), Description="When Batman, Gordon and Harvey Dent launch an assault on the mob, they let the clown out of the box, the Joker, bent on turning Gotham on itself and bringing any heroes down to his level"},
				new Movie{Title="Pulp Fiction", Director="Quentin Tarantino", ReleaseDate=DateTime.Parse("14 October 1994"),CreatedDateTime=DateTime.Parse("16 November 2010"), Description="The lives of two mob hit men, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption."},
				new Movie{Title="The Good, the Bad and the Ugly",Director="Sergio Leone", ReleaseDate=DateTime.Parse("29 December 1967"),CreatedDateTime=DateTime.Parse("31 December 2010"), Description="A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery."},
				new Movie{Title="Schindler's List",Director="Steven Spielberg", ReleaseDate=DateTime.Parse("15 December 1993"),CreatedDateTime=DateTime.Parse("17 January 2011"), Description="In Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis."},
				new Movie{Title="12 Angry Men",Director="Sidney Lumet", ReleaseDate=DateTime.Parse("April 1957"),CreatedDateTime=DateTime.Parse("01 May 2014"), Description="A dissenting juror in a murder trial slowly manages to convince the others that the case is not as obviously clear as it seemed in court."}
			};



			for (int ii = 0; ii < movies.Count; ii++)
			{
				movies[ii].SubmitterID = crowdTagBot.ID;
				context.Movies.Add(movies[ii]);
				context.SaveChanges();
			}
			//_context.SaveChanges();
		}
	}
}

/*
 * new Movie{Title="",Director="", ReleaseDate=DateTime.Parse(""),CreatedDateTime=DateTime.Parse(""), Description=""}
 */


