//using API.Abstract;
//using API.Service;
//using Autofac;
//using Autofac.Extras.DynamicProxy;
//using Castle.DynamicProxy;
//using Core.Utilities.Interceptors;
//using Core.Utilities.Security.JWT;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace API.DependencyResolvers.Autofac
//{
//    public class AutofacApiModule : Module
//    {
//        protected override void Load(ContainerBuilder builder)
//        {
//            builder.RegisterType<APIService>().As<IApiConnection>().SingleInstance();

//            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

//            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
//                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
//                {
//                    Selector = new AspectInterceptorSelector()
//                }).SingleInstance();
//        }
//    }
//}
