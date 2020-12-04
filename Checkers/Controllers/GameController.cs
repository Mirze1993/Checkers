using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Checkers.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Checkers.extensionMetods;
using Checkers.DB;
using Checkers.Oyun;

namespace Checkers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController : Controller
    {
        public ModelPosition model { get; set; }
        public IRepostory Repostory { get; }

        public GameController(IRepostory repostory)
        {
            Repostory = repostory;
        }

        [HttpGet]
        public ActionResult<ModelPosition> Index(int a)
        {
            if (a > 2)
                return Ok(new ModelPosition() { IsSelect = true });
            return View("Index",model);
        }


        //        [HttpPost]
        //        public IActionResult Login(User user)
        //        {
        //            User u = Repostory.GetUser(user.Name);
        //            if (u == null) return RedirectToAction("Index");
        //            HttpContext.Session.SetString("ad", user.Name);
        //            return View(Repostory.AllUser());
        //        }


        //        public string IstekGonder(string alan, string gonderen)
        //        {
        //            User u2 = Repostory.GetUser(alan);
        //            User u1 = Repostory.GetUser(gonderen);

        //            if (u1 != null && u2 != null)
        //            {
        //                Repostory.CreateGame(new DB.Game() { User1 = u1, User2 = u2 });
        //                return "gonderildi";
        //            }
        //            return "ugursuz oldu";
        //        }

        //        public string IstekYoxla(string ad)
        //        {
        //            User u2 = Repostory.GetUser(ad);
        //            if (u2 != null)
        //            {
        //                GelenVEGedenIstekler g = Repostory.getGames(u2);
        //                if (g != null)
        //                {
        //                    var x = JsonConvert.SerializeObject(g);
        //                    return JsonConvert.SerializeObject(g);
        //                }
        //            }
        //            return "istek yoxdur";
        //        }


        //        public string QebulEt(string ad)
        //        {
        //            User u1 = Repostory.GetUser(HttpContext.Session.GetString("ad"));
        //            User u2 = Repostory.GetUser(ad);
        //            if (u1 != null && u2 != null)
        //            {
        //                DB.Game g = Repostory.GetGame(u2, u1);
        //                if (g != null)
        //                {
        //                    g.State = true;
        //                    Repostory.UpdateGame(g);
        //                    return "qebul edildi";
        //                }
        //            }
        //            return "qebul edilmedi";
        //        }

        //        public void Reqib(string reqib)
        //        {
        //            HttpContext.Session.SetString("reqib", reqib);
        //        }


        //        public string OyunBaslasin(string oyuncu, string reqib)
        //        {
        //           return JsonConvert.SerializeObject(new MainControl(oyuncu, reqib).GetGame());
        //        }

        //        public string GedeceyiYer(string oyuncu, string reqib, string korX, string korY)
        //        {
        //            return JsonConvert.SerializeObject(new MainControl(oyuncu, reqib).MoveAbleTo(korX, korY));
        //        }


        //        public string HeretEdir(string oyuncu, string reqib, string kohKorX, string kohKorY, string yeniKorX, string yeniKorY)
        //        {
        //            return JsonConvert.SerializeObject(new MainControl(oyuncu,reqib).Move(kohKorX,kohKorY,yeniKorX,yeniKorY));
        //        }

        //        public string Vurmaq(string oyuncu, string reqib, string kohKorX, string kohKorY, string yeniKorX, string yeniKorY)
        //        {
        //            return JsonConvert.SerializeObject(new MainControl(oyuncu, reqib).Dum(kohKorX, kohKorY, yeniKorX, yeniKorY));
        //        }

        //        public string YeniGedisVarmi(string oyuncu, string reqib)
        //        {
        //            return JsonConvert.SerializeObject(new MainControl(oyuncu, reqib).GetGame());
        //        }



        //        [HttpPost]
        //        public IActionResult Start(User u)
        //        {
        //            return View();
        //        }


        //        public string gozle(string ad)
        //        {
        //            return ad;
        //        }


        //        public IActionResult Board()
        //        {
        //            return View();
        //        }

        //        [HttpPost]
        //        public ModelPosition Play()
        //        {

        //            return model;
        //        }
    }
}