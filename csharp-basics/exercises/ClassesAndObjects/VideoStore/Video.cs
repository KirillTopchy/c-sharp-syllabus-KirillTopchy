using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private readonly string _title;
        private double _rating;
        private bool _checkedOut;
        private int _ratingCount;

        public Video(string title)
        {
            _title = title;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void BeingCheckedOut()
        {
            _checkedOut = true;
        }

        public void BeingReturned()
        {
            _checkedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _ratingCount++;
            _rating += rating;
        }

        public double AverageRating()
        {
            if (_ratingCount == 0)
            {
                return 0;
            }
            return _rating / _ratingCount;
        }

        public bool Available()
        {
            return !_checkedOut;
        }

        public override string ToString()
        {
            return $"{_title} {AverageRating()} {Available()}";
        }
    }
}
