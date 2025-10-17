using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookAppDesktop
{
    public static class Utility
    {
        /// <summary>
        /// Convert TimeSpan to decimal (default take minutes) 
        /// </summary>
        /// <param name="evt">Evt to format</param>
        /// <param name="isHour">Take hour</param>
        public static void ConvertTimeSpanBinding(ConvertEventArgs evt, bool isHour = false)
        {
            decimal valueFormated = 0;
#pragma warning disable IDE0038 // Utiliser les critères spéciaux
#pragma warning disable S3247 // Duplicate casts should not be made
            if (evt.Value is TimeSpan)
                valueFormated = (isHour) ? ((TimeSpan)evt.Value).Hours : ((TimeSpan)evt.Value).Minutes;
#pragma warning restore S3247 // Duplicate casts should not be made
#pragma warning restore IDE0038 // Utiliser les critères spéciaux

            evt.Value = valueFormated;
        }

        //Reason for creating the method
        //The MouseWheel event trigger multiple time the increment (3 in this case) but after some research i couldn't find why...
        /// <summary>
        /// Handle The MouseWheel Event for NumericUpDown and Increment them by 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void HandleMouseWheelEventForNumericUpDown(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                ((NumericUpDown)sender).DownButton();
            else
                ((NumericUpDown)sender).UpButton();
            //Custom code

            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
}
