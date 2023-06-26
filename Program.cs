namespace CollectionsEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListMethods listMethods = new ListMethods();
            listMethods.ArrayList();

            LinkedList linkedList = new LinkedList();
            linkedList.LinkedlistM();

            StackMethods stackMethods = new StackMethods();
            stackMethods.stackMethod();

            HashTableMethods hashTableMethods = new HashTableMethods();
            hashTableMethods.hashtableMethods();
        }   
    }
}