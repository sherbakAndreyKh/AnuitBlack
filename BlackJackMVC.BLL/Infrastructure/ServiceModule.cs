﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using BlackJackMVC.DAL.Interfaces;
using BlackJackMVC.DAL.Repositories;

namespace BlackJackMVC.BLL.Infrastructure
{
    class ServiceModule : NinjectModule
    {
        private string _connectionString;

        public ServiceModule(string connection)
        {
            _connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(_connectionString);
        }
    }
}
