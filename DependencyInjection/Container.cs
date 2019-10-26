using Advisor.Controllers;
using Advisor.Service.Auth;
using Advisor.Service.Validator;
using Ninject.Modules;

namespace Advisor.DependencyInjection
{
    public class Container : NinjectModule
    {
        public override void Load()
        {
            //Bind<IAuthController>().To<AuthController>();
            //Bind<IUniversityController>().To<UniversityController>();
            //Bind<IUniversityComparisonController>().To<UniversityComparisonController>();
            //Bind<IFacultyController>().To<FacultyController>();
            //Bind<IStudyProgramController>().To<StudyProgramController>();
            //Bind<ILecturerReviewController>().To<LecturerReviewController>();
            //Bind<ICourseReviewController>().To<CourseReviewController>();
            //Bind<IStudyProgramReviewController>().To<StudyProgramReviewController>();
            //Bind<ICourseController>().To<CourseController>();

            //Bind<ILoginDataValidator>().To<LoginDataValidator>();
            //Bind<ISignupDataValidator>().To<SignupDataValidator>();
            //Bind<IPasswordEncoder>().To<PasswordEncoder>();
        }
    }
}
