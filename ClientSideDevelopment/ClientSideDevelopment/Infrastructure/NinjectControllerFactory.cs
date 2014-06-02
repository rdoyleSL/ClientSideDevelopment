// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NinjectControllerFactory.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the NinjectControllerFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Infrastructure
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    using ClientSideDevelopment.Repositories.Abstract;
    using ClientSideDevelopment.Repositories.Concrete;
    using ClientSideDevelopment.Services.Abstract;
    using ClientSideDevelopment.Services.Concrete;

    using Ninject;

    /// <summary>
    /// The ninject controller factory.
    /// </summary>
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// The ninject kernel.
        /// </summary>
        private readonly IKernel ninjectKernel;

        /// <summary>
        /// Initializes a new instance of the <see cref="NinjectControllerFactory"/> class.
        /// </summary>
        public NinjectControllerFactory()
        {
            this.ninjectKernel = new StandardKernel();
            this.AddBindings();
        }

        /// <summary>
        /// The get controller instance.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <param name="controllerType">The controller type.</param>
        /// <returns>
        /// The <see cref="IController" />.
        /// </returns>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)this.ninjectKernel.Get(controllerType);
        }

        /// <summary>
        /// Add bindings.
        /// </summary>
        private void AddBindings()
        {
            this.ninjectKernel.Bind<IMovieService>().To<MovieService>();
            this.ninjectKernel.Bind<IMovieRepository>().To<MovieRepository>();
            this.ninjectKernel.Bind<IDirectorService>().To<DirectorService>();
            this.ninjectKernel.Bind<IDirectorRepository>().To<DirectorRepository>();
        }
    }
}