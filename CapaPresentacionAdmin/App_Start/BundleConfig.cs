using System.Web;
using System.Web.Optimization;

namespace CapaPresentacionAdmin
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*Las modificaciones se haran por la version que se usara de bootstrap con los js y css 
             que en este caso es la version Boostrap 5.3.2*/

            //se quitara el Script de ScriptBundle
            /*
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            */

            //nuevo
            bundles.Add(new Bundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            //Nuevo bundles
            bundles.Add(new Bundle("~/bundles/complementos").Include(
                "~/Scripts/scripts.js",
                "~/Scripts/fontawesome/all.min.js",
                "~/Scripts/DataTables/jquery.dataTables.js",
                "~/Scripts/DataTables/dataTables.responsive.js"
                ));

            /*
            //estos bundles no se usaran en este proyecto por ahora

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios.  De esta manera estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.

            //estos bundles no se usaran en este proyecto por ahora
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            */

            //se modificara el archivo original
            /*
            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            */

            //el nuevo bundle
            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap.bundle.js"));

            //original
            /*
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            */

            //nuevo
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Content/DataTables/css/jquery.dataTables.css",
                "~/Content/DataTables/css/responsive.dataTables.css"
                ));
        }
    }
}
