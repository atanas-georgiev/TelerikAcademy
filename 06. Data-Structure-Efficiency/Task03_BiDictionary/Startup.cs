namespace Task03_BiDictionary
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var myBiDictionary = new BiDictionary<int, int, string>();
            myBiDictionary.Add(11, 21, "1");
            myBiDictionary.Add(11, 22, "2");
            myBiDictionary.Add(11, 23, "3");
            myBiDictionary.Add(12, 21, "4");
            myBiDictionary.Add(13, 21, "5");
            myBiDictionary.Add(14, 21, "6");
            myBiDictionary.Add(15, 21, "7");

            // find all key11 values for first key
            var res1 = myBiDictionary.Find(key1: 11);

            // find all key21 values for second key
            var res2 = myBiDictionary.Find(key2: 21);

            // find all key11 and key21 values for both keys
            var res3 = myBiDictionary.Find(11, 21);
        }
    }
}
