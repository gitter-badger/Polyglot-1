using Umbraco.Core.Logging;

namespace Dimi.Polyglot.DAL
{
    public static class UmbracoDatabase
    {
        public static global::Umbraco.Core.Persistence.UmbracoDatabase Get()
        {
            return global::Umbraco.Core.ApplicationContext.Current == null ? new global::Umbraco.Core.Persistence.UmbracoDatabase("umbracoDbDSN", Logger.CreateWithDefaultLog4NetConfiguration()) :
                global::Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
        }
    }
}