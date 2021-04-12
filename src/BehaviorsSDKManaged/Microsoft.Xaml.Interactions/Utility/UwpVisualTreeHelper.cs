﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Xaml.Interactions.Utility
{
#if HAS_WINUI
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Media;
#else
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;
#endif

    /// <summary>
    /// IVisualTreeHelper implementation that calls the real VisualTreeHelper.
    /// </summary>
    internal partial class UwpVisualTreeHelper : IVisualTreeHelper
    {
        #region IVisualTreeHelper implementation

        public DependencyObject GetParent(DependencyObject reference)
        {
            return VisualTreeHelper.GetParent(reference);
        }

        #endregion
    }
}
