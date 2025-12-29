using System.Web;
using System.Web.Mvc;

namespace Empresa.ProdutoNomeAplicacaoTesteASPNETMVC.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
