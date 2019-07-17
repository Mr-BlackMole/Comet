﻿using System;

// ReSharper disable once CheckNamespace
namespace HotUI
{
    public static class LayoutExtensions
    {
        /// <summary>
        /// Set the padding to the default thickness.
        /// </summary>
        /// <param name="view"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Padding<T>(this T view) where T : View
        {
            var defaultThickness = new Thickness(10);
            view.Padding = defaultThickness;
            return view;
        }

        /// <summary>
        /// Set the padding to a specified thickness.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="padding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Padding<T>(this T view, Thickness padding) where T : View
        {
            view.Padding = padding;
            return view;
        }

        public static Thickness GetPadding(this View view)
        {
            return view.Padding;
            ;
        }

        public static T Overlay<T>(this T view, View overlayView) where T : View
        {
            view.SetEnvironment(EnvironmentKeys.View.Overlay, overlayView);
            return view;
        }

        public static T Overlay<T>(this T view, Shape shape) where T : View
        {
            var shapeView = new ShapeView(shape);
            view.SetEnvironment(EnvironmentKeys.View.Overlay, shapeView);
            return view;
        }

        public static View GetOverlay(this View view)
        {
            return view.GetEnvironment<View>(EnvironmentKeys.View.Overlay);
        }

        public static View Frame(this View view, float? width = null, float? height = null, Alignment alignment = null)
        {
            view.FrameConstraints = new FrameConstraints(width, height, alignment);
            return view;
        }
    }
}