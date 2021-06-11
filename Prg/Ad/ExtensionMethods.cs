using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNGS.NetControls;
using TNGS.NetRoutines;

namespace Carm.Ad
{
    public static class MyExtensions
    {
        // FullTab
        public static void hidePage(this FullTab fullTab, TabPage pageToHide)
        {
            fullTab.PageVisible(pageToHide, false);
        }
        public static void hidePages(this FullTab fullTab, List<TabPage> pagesToHide)
        {
            pagesToHide.ForEach(pageToHide => fullTab.hidePage(pageToHide));
        }

        public static void disablePage(this FullTab fullTab, TabPage pageToDisable)
        {
            fullTab.PageEnable(pageToDisable, false);
        }

        public static void disablePages(this FullTab fullTab, List<TabPage> pagesToDisable)
        {
            pagesToDisable.ForEach(pageToDisable => fullTab.disablePage(pageToDisable));
        }

        // MiniReport
        public static void fill(this MiniReport miniReport, ListaEntidades list, string title, StatMsg statMsg)
        {
            miniReport.LoadData(list, "", "", "Carma", title, title, title, "", statMsg);
        }

        // Lists
        public static bool None<TSource>(this IEnumerable<TSource> source)
        {
            return !source.Any();
        }
    }
}
