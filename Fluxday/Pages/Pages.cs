using System;

namespace Fluxday.Pages
{
    public static class Pages
    {
        [ThreadStatic]
        public static HeaderNav Header;

        [ThreadStatic]
        public static AuthorizationPage Authorization;

        [ThreadStatic]
        public static SideBarMenu SideBar;

        [ThreadStatic]
        public static MyTasksPage MyTasks;
        

        public static void Init() 
        {
            Header = new HeaderNav();
            Authorization = new AuthorizationPage();
            SideBar = new SideBarMenu();
            MyTasks = new MyTasksPage();            
        }


    }
}
