while (true)
{
    Console.WriteLine("Select collection type:");
    Console.WriteLine("1. Array");
    Console.WriteLine("2. List");
    Console.WriteLine("3. Hashtable");
    Console.WriteLine("4. Dictionary");
    Console.WriteLine("5. SortedList");
    Console.WriteLine("6. Stack");
    Console.WriteLine("7. Queue");
    Console.WriteLine("8. Set");
    Console.WriteLine("0. Выход");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            ProcessArray();
            break;
        case "2":
            ProcessList();
            break;
        case "3":
            ProcessHashtable();
            break;
        case "4":
            ProcessDictionary();
            break;
        case "5":
            ProcessSortedList();
            break;
        case "6":
            ProcessStack();
            break;
        case "7":
            ProcessQueue();
            break;
        case "8":
            ProcessSet();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Invalid input. Try again...");
            break;
    }
}

void ProcessArray()
{
    Console.WriteLine("Working with an array:");
    Console.WriteLine("Enter array elements separated by spaces: ");
    string[] elements = Console.ReadLine().Split(' ');

    Console.WriteLine("Array elements:");
    foreach (string element in elements)
    {
        Console.WriteLine(element);
    }
}

void ProcessList()
{
    Console.WriteLine("Working with a list:");
    Console.WriteLine("Enter array elements separated by spaces: ");
    string[] elements = Console.ReadLine().Split(' ');

    List<string> list = new List<string>(elements);

    Console.WriteLine("List elements:");
    foreach (string element in list)
    {
        Console.WriteLine(element);
    }
}

void ProcessHashtable()
{
    Console.WriteLine("Working with a hash table:");
    Console.WriteLine("Enter keys and values separated by spaces (each pair on a new line):");
    Dictionary<string, string> dictionary = new Dictionary<string, string>();

    while (true)
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            break;
        }

        string[] elements = input.Split(' ');
        if (elements.Length != 2)
        {
            Console.WriteLine("Invalid input. Try again...");
            continue;
        }

        string key = elements[0];
        string value = elements[1];

        dictionary[key] = value;
    }
    Console.WriteLine("Dictionary keys and values:");
    foreach (var pair in dictionary)
    {
        Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
    }
}

void ProcessDictionary()
{
    Console.WriteLine("Working with a Dictionary:");
    Console.WriteLine("Enter keys and values separated by spaces (each pair on a new line):");
    Dictionary<string, string> dictionary = new Dictionary<string, string>();

    while (true)
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            break;
        }

        string[] elements = input.Split(' ');
        if (elements.Length != 2)
        {
            Console.WriteLine("Invalid input. Try again...");
            continue;
        }

        string key = elements[0];
        string value = elements[1];

        dictionary[key] = value;
    }

    Console.WriteLine("Dictionary keys and values:");
    foreach (var pair in dictionary)
    {
        Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
    }
}

void ProcessSortedList()
{
    Console.WriteLine("Working with a SortedList:");
    Console.WriteLine("Enter keys and values separated by spaces (each pair on a new line):");
    SortedList<string, string> sortedList = new SortedList<string, string>();

    while (true)
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            break;
        }

        string[] elements = input.Split(' ');
        if (elements.Length != 2)
        {
            Console.WriteLine("Invalid input. Try again...");
            continue;
        }

        string key = elements[0];
        string value = elements[1];

        sortedList[key] = value;
    }

    Console.WriteLine("Keys and values of a sorted list:");
    foreach (var pair in sortedList)
    {
        Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
    }
}

void ProcessStack()
{
    Console.WriteLine("Working with a Stack:");
    Console.WriteLine("Enter stack elements separated by spaces:");
    string[] elements = Console.ReadLine().Split(' ');

    Stack<string> stack = new Stack<string>(elements);

    Console.WriteLine("Stack elements:");
    foreach (string element in stack)
    {
        Console.WriteLine(element);
    }
}

void ProcessQueue()
{
    Console.WriteLine("Working with a Queue:");
    Console.WriteLine("Enter queue elements separated by spaces:");
    string[] elements = Console.ReadLine().Split(' ');

    Queue<string> queue = new Queue<string>(elements);

    Console.WriteLine("Queue elements:");
    foreach (string element in queue)
    {
        Console.WriteLine(element);
    }
}

void ProcessSet()
{
    Console.WriteLine("Working with a Set:");
    Console.WriteLine("Enter the elements of the set separated by spaces:");
    string[] elements = Console.ReadLine().Split(' ');

    HashSet<string> set = new HashSet<string>(elements);

    Console.WriteLine("Set elements:");
    foreach (string element in set)
    {
        Console.WriteLine(element);
    }
}