using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using BlackJackMVC.BLL.Services;
using BlackJackMVC.BLL.Interfaces;

namespace BlackJackMVC.WEB.Util
{
    public class BlackJackModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPlayerService>().To<OptionsService>();
        }
    }
}