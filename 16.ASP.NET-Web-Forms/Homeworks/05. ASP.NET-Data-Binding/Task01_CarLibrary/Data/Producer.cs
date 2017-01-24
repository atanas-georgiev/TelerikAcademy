namespace Task01_CarLibrary.Data
{
    using System.Collections.Generic;

    public class Producer
    {
        public string Name { get; set; }

        public IEnumerable<string> Models { get; set; }
    }
}