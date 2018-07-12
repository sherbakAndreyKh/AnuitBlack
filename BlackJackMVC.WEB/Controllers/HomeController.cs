using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackJackMVC.WEB.Models;
using BlackJackMVC.BLL.Interfaces;
using BlackJackMVC.BLL.DTO.Participant;
using BlackJackMVC.BLL.BusinessModels;
using AutoMapper;
using System.Data.Entity;

namespace BlackJackMVC.WEB.Controllers
{
    public class HomeController : Controller
    {
        IPlayerService playerService;
        public HomeController(IPlayerService service)
        {
            playerService = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Options()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Options(OptionsViewModel options)
        {
            Options option = new Options()
            {
                NamePlayer = options.NamePlayer,
                NameBot = options.NameBot
            };

            playerService.GameOptions(option);

            return RedirectToAction("Index");
        }
    
    }
}