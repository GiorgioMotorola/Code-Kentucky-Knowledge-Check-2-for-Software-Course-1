namespace KnowledgeCheckTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());



            var recordList = new List<Music>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var entry = new Music();

                Console.WriteLine("Enter your Band Name: ");
                entry.ArtistName = Console.ReadLine();

                Console.WriteLine("Enter the Genre: ");
                entry.Genre = Console.ReadLine();

                recordList.Add(new Music() { ArtistName = entry.ArtistName, Genre = entry.Genre });
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var entry in recordList)
                Console.WriteLine("ARIST: " + entry.ArtistName + "\nGENRE: " + entry.Genre + "\n");

        }
    }
}