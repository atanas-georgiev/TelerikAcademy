namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement the data structure linked list.
            //Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type ListItem<T>).
            //Define additionally a class LinkedList<T> with a single field FirstElement(of type ListItem<T>).

            LinkedList<int> myList = new LinkedList<int>();
            ListItem<int> firstItem = new ListItem<int>() {Value = 0};
        }
    }
}
