using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public bool CheckedOut { get; set; }

        public Video(string title)
        {
            Title = title;
        }

        public void BeingCheckedOut()
        {
            
        }

        public void BeingReturned()
        {
            
        }

        public void ReceivingRating(double rating)
        {
            
        }

        public double AverageRating()
        {
            return 0;
        }

        public bool Available()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
