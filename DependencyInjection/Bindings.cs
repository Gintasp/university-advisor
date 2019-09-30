using Advisor.Controller;
using Advisor.Service.Validator;
using Ninject.Modules;

namespace Advisor.DependencyInjection
{
    class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthController>().To<AuthController>();
            Bind<IHomeController>().To<HomeController>();
            Bind<IUniversityController>().To<UniversityController>();
            Bind<IFacultyListController>().To<FacultyListController>();
            Bind<IFacultyController>().To<FacultyController>();
            Bind<IStudyProgramController>().To<StudyProgramController>();
            Bind<IStudySubjectListController>().To<StudySubjectListController>();
            Bind<IStudyProgramController>().To<StudyProgramController>();

            Bind<ILoginDataValidator>().To<LoginDataValidator>();
            Bind<ISignupDataValidator>().To<SignupDataValidator>();
        }
    }
}
