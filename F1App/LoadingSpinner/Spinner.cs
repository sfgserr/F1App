using System.Windows;
using System.Windows.Controls;

namespace LoadingSpinner
{
   
    public class Spinner : Control
    {
        public static readonly DependencyProperty IsLoadingProperty =
           DependencyProperty.Register("IsLoading", typeof(bool), typeof(Spinner), new PropertyMetadata(false));

        public bool IsLoading
        {
            get { return (bool)GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }
        static Spinner()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spinner), new FrameworkPropertyMetadata(typeof(Spinner)));
        }
    }
}
