namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        //per day
        private int _numDays;

        public Hoarding(int fee, int days, int rate) : base(fee)
        {
            _numDays = days;
            _rate = rate;
        }

        public new int Cost()
        {

            return base.Cost();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}