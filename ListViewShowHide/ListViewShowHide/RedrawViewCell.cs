using Xamarin.Forms;

namespace ListViewShowHide
{
    public class RedrawViewCell : ViewCell
    {
        public static readonly BindableProperty IsRedrawRequiredProperty = BindableProperty.Create(nameof(IsRedrawRequired), typeof(bool), typeof(RedrawViewCell), false, propertyChanged: IsRedrawRequired_Changed);

        private static void IsRedrawRequired_Changed(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (oldvalue == newvalue)
            {
                return;
            }
            if (newvalue != null && (bool)newvalue)
            {
                (bindable as RedrawViewCell)?.ForceUpdateSize();
            }
        }

        public bool IsRedrawRequired
        {
            get { return (bool)GetValue(IsRedrawRequiredProperty); }
            set { SetValue(IsRedrawRequiredProperty, value); }
        }
    }
}