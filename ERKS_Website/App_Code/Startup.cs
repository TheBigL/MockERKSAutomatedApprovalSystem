﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERKS_Website.Startup))]
namespace ERKS_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
