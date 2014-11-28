﻿/*using System;
using System.Text;
using System.Collections.Generic;
using CrowdTag.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrowdTag.Controllers;
using System.Web.Mvc;

namespace CrowdTag.Tests.Controllers
{
	/// <summary>
	/// Summary description for MovieControllerTests
	/// </summary>
	[TestClass]
	public class MovieControllerTests
	{
		public MovieControllerTests()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void CreateMovie_ShouldRedirectToMovie()
		{
			// Arrange
			var newMovie = new TaggedItemDTO
			{
				Name="New TaggedItem",
				//ReleaseDate=DateTime.Now,
				Description="This is longer than 20 characters",
				//Director="Me"
			};
			ActionResult result = null;

			// Act
			using (var controller = new MovieController())
			{
				result = controller.Create(newMovie);
			}

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
*/