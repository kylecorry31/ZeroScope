using System;
namespace ZeroScope
{
    public class ScopeMOAToClickConverter : IMOAToClickConverter
    {

        private decimal MOAPerClick { get; set; }

        public ScopeMOAToClickConverter(decimal moaPerClick)
        {
            MOAPerClick = moaPerClick;
        }

        public decimal Convert(decimal moa)
        {
            return Math.Round(moa / MOAPerClick);
        }
    }
}
