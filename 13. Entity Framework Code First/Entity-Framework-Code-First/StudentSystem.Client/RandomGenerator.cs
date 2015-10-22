namespace StudentSystem.Client
{
    using System;
    using System.Text;

    public static class RandomGenerator
    {
        private static Random random = new Random(Environment.TickCount);

        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static string RandomString(int len)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            StringBuilder builder = new StringBuilder(len);

            for (int i = 0; i < len; ++i)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }

            return builder.ToString();
        }

        public static DateTime RandomDate(DateTime from, DateTime to)
        {
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(random.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }
    }
}
