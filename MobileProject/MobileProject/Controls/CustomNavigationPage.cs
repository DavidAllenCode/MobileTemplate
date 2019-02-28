using System;
using Xamarin.Forms;

namespace MobileProject.Controls
{
    public class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage()
        {
        }

        public CustomNavigationPage(Page root) 
            : base(root)
        {
        }

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
            if (child != null)
                SetHasNavigationBar(child, false);
        }
    }
}
