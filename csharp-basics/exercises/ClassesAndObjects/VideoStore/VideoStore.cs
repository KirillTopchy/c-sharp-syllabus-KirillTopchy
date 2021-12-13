using System;
using System.Collections.Generic;

namespace VideoStore
{
     class VideoStore
    {
        private readonly List<Video> _videos = new List<Video>();

        public void AddVideo(string title)
        {
            var video = new Video(title);
            _videos.Add(video);
        }
        
        public void Checkout(string title)
        {
            foreach (var video in _videos)
            {
                if (video.GetTitle() == title)
                {
                    video.BeingCheckedOut();
                    return;
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var video in _videos)
            {
                if (video.GetTitle() == title)
                {
                    video.BeingReturned();
                    return;
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var video in _videos)
            {
                if (video.GetTitle() == title)
                {
                    video.ReceivingRating(rating);
                    return;
                }
            }
        }

        public void ListInventory()
        {
            foreach (var video in _videos)
            {
                Console.WriteLine(video.ToString());
            }
        }

        public double GetRating(string title)
        {
            foreach (var video in _videos)
            {
                if (video.GetTitle() == title)
                {
                    return video.AverageRating();
                }
            }

            return 0;
        }
    }
}
