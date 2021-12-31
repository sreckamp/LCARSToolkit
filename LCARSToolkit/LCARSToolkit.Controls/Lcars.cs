using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

namespace LCARSToolkit.Controls
{
    public static class Lcars
    {
        public static double GetBar(DependencyObject obj) => (double)obj.GetValue(BarProperty);

        public static void SetBar(DependencyObject obj, double value) => obj.SetValue(BarProperty, value);

        public static readonly DependencyProperty BarProperty =
            DependencyProperty.RegisterAttached(
                "Bar",
                typeof(double),
                typeof(Lcars),
                new FrameworkPropertyMetadata(20.0, FrameworkPropertyMetadataOptions.Inherits));

        public static double GetColumn(DependencyObject obj) => (double)obj.GetValue(ColumnProperty);

        public static void SetColumn(DependencyObject obj, double value) => obj.SetValue(ColumnProperty, value);

        public static readonly DependencyProperty ColumnProperty =
            DependencyProperty.RegisterAttached(
                "Column",
                typeof(double),
                typeof(Lcars),
                new FrameworkPropertyMetadata(40.0));

        public static double GetInnerArcRadius(DependencyObject obj) => (double)obj.GetValue(InnerArcRadiusProperty);

        public static void SetInnerArcRadius(DependencyObject obj, double value) => obj.SetValue(InnerArcRadiusProperty, value);

        public static readonly DependencyProperty InnerArcRadiusProperty =
            DependencyProperty.RegisterAttached(
                "InnerArcRadius",
                typeof(double),
                typeof(Lcars),
                new FrameworkPropertyMetadata(10.0, FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetFill(DependencyObject obj) => (Brush)obj.GetValue(FillProperty);

        public static void SetFill(DependencyObject obj, Brush value) => obj.SetValue(FillProperty, value);

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.RegisterAttached(
                "Fill",
                typeof(Brush),
                typeof(Lcars),
                new FrameworkPropertyMetadata(Brushes.White, FrameworkPropertyMetadataOptions.Inherits));

        public static string GetText(DependencyObject obj) => (string)obj.GetValue(TextProperty);

        public static void SetText(DependencyObject obj, string value) => obj.SetValue(TextProperty, value);

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached(
                "Text",
                typeof(string),
                typeof(Lcars),
                new FrameworkPropertyMetadata("", TextChanged));

        private static void TextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SetVisibility(obj, string.IsNullOrEmpty(e.NewValue as string)
                ? Visibility.Collapsed
                : Visibility.Visible);
        }

        public static Visibility GetVisibility(DependencyObject obj) => (Visibility)obj.GetValue(VisibilityProperty);
        public static void SetVisibility(DependencyObject obj, Visibility value) => obj.SetValue(VisibilityProperty, value);

        public static readonly DependencyProperty VisibilityProperty =
            DependencyProperty.RegisterAttached(
                "Visibility",
                typeof(Visibility),
                typeof(Lcars),
                new FrameworkPropertyMetadata(Visibility.Collapsed));
    }
}