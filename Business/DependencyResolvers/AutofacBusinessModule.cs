using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<MusteriManager>().As<IMusteriService>();
            builder.RegisterType<EfMusteriDal>().As<IMusteriDal>();

            builder.RegisterType<SatilanUrunManager>().As<ISatilanUrunService>();
            builder.RegisterType<EfSatilanUrunDal>().As<ISatilanUrunDal>();

            builder.RegisterType<UrunManager>().As<IUrunService>();
            builder.RegisterType<EfUrunDal>().As<IUrunDal>();
        }
    }
}
