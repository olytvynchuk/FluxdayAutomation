using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxday.Maps;

namespace Fluxday.Pages
{
    public class DepartmentsPage : SideBarMenu
    {
        private readonly DepartmentsPageMap Map;

        public DepartmentsPage(): base()
        {
            Map = new DepartmentsPageMap();
        }
    }
}
