using GameStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
		IGameRepository repository;
		public GameController(IGameRepository repo)
		{
			repository = repo;
		}

		public ViewResult List()
		{
			var game = repository.Games;

			return View(game.First());
		}
    }
}