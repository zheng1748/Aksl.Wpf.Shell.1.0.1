using Prism.Events;
using System;
using System.Collections;

namespace Aksl.Infrastructure.Events
{
    #region Eventbase
    public class OnBuildWorkspaceViewEventbase : PubSubEvent<OnBuildWorkspaceViewEventbase>
    {
        #region Constructors
        public OnBuildWorkspaceViewEventbase()
        {
        }
        #endregion

        #region Properties
        public string Name { get; set; }

        public MenuItem CurrentMenuItem { get; set; }
        #endregion
    }
    #endregion

    #region SideBar
    public class OnBuildHamburgerMenuNavigationSideBarWorkspaceViewEvent : OnBuildWorkspaceViewEventbase
    {
        #region Constructors
        public OnBuildHamburgerMenuNavigationSideBarWorkspaceViewEvent()
        {
            Name = typeof(OnBuildHamburgerMenuNavigationSideBarWorkspaceViewEvent).Name;
        }
        #endregion
    }
    #endregion
}