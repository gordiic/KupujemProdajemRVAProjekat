﻿using Microsoft.AspNetCore.Mvc;
using RVAProjekat.AppData;
using RVAProjekat.Logger;
using RVAProjekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RVAProjekat.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OcjenaController : ControllerBase
	{
		private readonly ILoggerManager _logger;
		public OcjenaController(ILoggerManager logger)
		{
			_logger = logger;
		}


		[HttpPost]
		[Route("uploadOcjena")]
		public IActionResult UploadOcjena([FromBody]Ocjena ocjena)
		{
			if (ocjena.BrOcjene <= 0 || ocjena.Komentar == "")
			{
				_logger.LogWarning($"Neuspjelo postavljanje ocjene, nepravilni parametri: brOcjene={ocjena.BrOcjene} , komentar={ocjena.Komentar}");
				return NotFound("Neuspjesno postavljen komentar.");
			}
			User user = DataBaseUserProvider.FindUserById(ocjena.IdKorisnikaOcijenjenog);
			double suma = user.ProsjecnaOcjena * user.BrOcjena;
			suma += ocjena.BrOcjene;
			user.BrOcjena++;
			user.ProsjecnaOcjena = suma / user.BrOcjena;
			DataBaseUserProvider.UpdateUser(user);
			DataBaseMarkProvider.AddOcjena(ocjena);

			_logger.LogInformation($"Korisnik {ocjena.KorisnickoIme} je ocijenio korisnika {user.KorisnickoIme}.");
			return Ok($"Uspjesno ste postavili ocjenu korisniku {user.KorisnickoIme}.");
		}
		
		[HttpGet]
		[Route("getOcjeneForUser")]
		public IEnumerable<Ocjena> GetOcjeneForUser(int id)
		{
			List<Ocjena> ocjene = DataBaseMarkProvider.FindOcjeneByUserId(id);

			if (ocjene == null)
				return new List<Ocjena>();
			else
				return ocjene.ToArray();
		}
	}
}
