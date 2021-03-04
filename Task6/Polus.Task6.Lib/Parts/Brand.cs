using Polus.Task6.Core;

namespace Polus.Task6.Lib.Parts
{
    public class Brand : IBrand
    {
        private string _rating;
        public string BrandName { get; }
        public string BrandRating { get{ return _rating; } }

        public Brand(string brandName)
        {
            BrandName = brandName;
        }

        public void SetRating(Rating rating)
        {
            _rating = rating.ToString();
        }
    }



    public enum Rating
    {
        None,
        OneStar,
        TwoStar,
        ThreeStar,
        FourStar,
        FiveStar
    }
}
