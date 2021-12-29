using System.Diagnostics;
using System.Windows;

namespace LCARSToolkit.Controls
{
    public static class Title
    {
        public static string GetText(DependencyObject obj) => (string)obj.GetValue(TextProperty);

        public static void SetText(DependencyObject obj, string value) => obj.SetValue(TextProperty, value);

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached(
                "Text",
                typeof(string),
                typeof(Title),
                new FrameworkPropertyMetadata("", TextChanged));

        private static void TextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine($"Update Title {e.OldValue}=>{e.NewValue}");
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
                typeof(Title),
                new FrameworkPropertyMetadata(Visibility.Collapsed, VisibilityChanged ));

        private static void VisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine($"Update Visibility {e.OldValue}=>{e.NewValue}");
        }
    }
}