﻿using Windows.UI.Xaml.Navigation;

namespace ReduxSimple.Uwp.RouterStore
{
    public class RouterNavigating
    {
        public NavigatingCancelEventArgs Event { get; set; }
    }

    public class RouterNavigated
    {
        public NavigationEventArgs Event { get; set; }
    }

    public class RouterError
    {
        public NavigationFailedEventArgs Event { get; set; }
    }

    public class RouterCancel
    {
        public NavigationEventArgs Event { get; set; }
    }
}