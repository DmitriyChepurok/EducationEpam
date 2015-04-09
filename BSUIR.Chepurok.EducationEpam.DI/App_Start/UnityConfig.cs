using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Repository.Pattern.DataContext;
using BSUIR.Chepurok.EducationEpam.Entities.DbContext;
using BSUIR.Chepurok.EducationEpam.Entities.Models;
using Repository.Pattern.Ef6.Factories;
using Repository.Pattern.UnitOfWork;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using BSUIR.Chepurok.EducationEpam.Service.Interfaces;
using BSUIR.Chepurok.EducationEpam.Service.Implements;
using BSUIR.Chepurok.EducationEpam.BLL.Interfaces;
using BSUIR.Chepurok.EducationEpam.BLL.Services;
using AutoMapper;
using BSUIR.Chepurok.EducationEpam.BLL.Entities;

namespace BSUIR.Chepurok.EducationEpam.DI.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
          container
            .RegisterType<IDataContextAsync, EducationEpamDbContext>(new PerRequestLifetimeManager())
            .RegisterType<IRepositoryProvider, RepositoryProvider>(
              new PerRequestLifetimeManager(),
              new InjectionConstructor(new object[] { new RepositoryFactories() })
            )
            .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new PerRequestLifetimeManager())

            .RegisterType<IRepositoryAsync<Answer>, Repository<Answer>>()
            .RegisterType<IRepositoryAsync<Badge>, Repository<Badge>>()
            .RegisterType<IRepositoryAsync<Category>, Repository<Category>>()
            .RegisterType<IRepositoryAsync<Comment>, Repository<Comment>>()
            .RegisterType<IRepositoryAsync<Lession>, Repository<Lession>>()
            .RegisterType<IRepositoryAsync<Like>, Repository<Like>>()
            .RegisterType<IRepositoryAsync<News>, Repository<News>>()
            .RegisterType<IRepositoryAsync<Post>, Repository<Post>>()
            .RegisterType<IRepositoryAsync<Question>, Repository<Question>>()
            .RegisterType<IRepositoryAsync<Role>, Repository<Role>>()
            .RegisterType<IRepositoryAsync<Test>, Repository<Test>>()
            .RegisterType<IRepositoryAsync<Topic>, Repository<Topic>>()
            .RegisterType<IRepositoryAsync<User>, Repository<User>>()

            .RegisterType<IEducationService<Answer>, EducationService<Answer>>()
            .RegisterType<IEducationService<Badge>, EducationService<Badge>>()
            .RegisterType<IEducationService<Category>, EducationService<Category>>()
            .RegisterType<IEducationService<Comment>, EducationService<Comment>>()
            .RegisterType<IEducationService<Lession>, EducationService<Lession>>()
            .RegisterType<IEducationService<Like>, EducationService<Like>>()
            .RegisterType<IEducationService<News>, EducationService<News>>()
            .RegisterType<IEducationService<Post>, EducationService<Post>>()
            .RegisterType<IEducationService<Question>, EducationService<Question>>()
            .RegisterType<IEducationService<Role>, EducationService<Role>>()
            .RegisterType<IEducationService<Test>, EducationService<Test>>()
            .RegisterType<IEducationService<Topic>, EducationService<Topic>>()
            .RegisterType<IEducationService<User>, EducationService<User>>()

            .RegisterType<IRoleServiceBLL, RoleServiceBLL>();
        }
    }
}