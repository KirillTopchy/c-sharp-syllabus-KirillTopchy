using System;

namespace VideoStore
{
    class VideoStoreTest
    {
        private const int CountOfMovies = 3;
        private static readonly VideoStore VideoStore = new VideoStore();
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
                Console.WriteLine("Choose 5 to check movie rating");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        CheckMovieRating();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            VideoStore.ListInventory();
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < CountOfMovies; i++)
            {
                Console.WriteLine("Enter movie name");
                string movieName = Console.ReadLine();

                Console.WriteLine("Enter rating");
                int rating = Convert.ToInt16(Console.ReadLine());

                VideoStore.AddVideo(movieName);
                VideoStore.TakeUsersRating(rating, movieName);
            }
        }

        private static void RentVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            VideoStore.Checkout(movieName);
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter movie rating");
            double movieRating = Convert.ToDouble(Console.ReadLine());
            VideoStore.ReturnVideo(movieName);
            VideoStore.TakeUsersRating(movieRating, movieName);
        }

        private static void CheckMovieRating()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            Console.WriteLine("Movie rating: {0}", VideoStore.GetRating(movieName));
        }
    }
}
