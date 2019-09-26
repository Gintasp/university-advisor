using Advisor.Controller;
using Advisor.Validator;
using Advisor.View;
using Ninject.Modules;

namespace Advisor.DependencyInjection
{
    class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthController>().To<AuthController>();

            Bind<ILoginDataValidator>().To<LoginDataValidator>();
            Bind<ISignupDataValidator>().To<SignupDataValidator>();

            Bind<ALoginFormView>().To<LoginFormView>();
            Bind<ASignupFormView>().To<SignupFormView>();
            Bind<AWhatUniversityView>().To<WhatUniversityView>();
        }
    }
}
