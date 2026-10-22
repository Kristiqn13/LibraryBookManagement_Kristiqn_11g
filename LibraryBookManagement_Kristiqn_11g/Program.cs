using LibraryBookManagement_Kristiqn_11g;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> library = new List<Book>
            {
                new Book("Под игото", "Иван Вазов", 1894, "Роман", 15.50),
                new Book("Бай Ганьо", "Алеко Константинов", 1895, "Сатира", 12.00),
                new Book("Тютюн", "Димитър Димов", 1951, "Роман", 22.90),
                new Book("Железният светилник", "Димитър Талев", 1952, "Исторически", 18.00),
                new Book("Малкият принц", "Антоан дьо Сент-Экзюпери", 1943, "Приказка", 10.00)
            };

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nМЕНЮ БИБЛИОТЕКА");
            Console.WriteLine("1. Покажи всички книги");
            Console.WriteLine("2. Търси книга по заглавие");
            Console.WriteLine("3. Добави нова книга");
            Console.WriteLine("4. Изтрий книга");
            Console.WriteLine("5. Изход");
            Console.Write("Изберете опция (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nСПИСЪК С КНИГИ");
                    foreach (Book book in library)
                    {
                        book.DisplayInfo();
                    }
                    break;

                case "2":
                    Console.Write("\nВъведете заглавие за търсене: ");
                    string searchTitle = Console.ReadLine();
                    Book foundBook = library.FirstOrDefault(b => b.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));

                    if (foundBook != null)
                    {
                        Console.WriteLine("\nКнигата е намерена!");
                        foundBook.DisplayInfo();
                    }
                    else
                    {
                        Console.WriteLine("\nКнигата не е намерена.");
                    }
                    break;

                     case "3":
                    Console.WriteLine("\nДОБАВЯНЕ НА НОВА КНИГА");
                    Console.Write("Заглавие: ");
                    string title = Console.ReadLine();

                    Console.Write("Автор: ");
                    string author = Console.ReadLine();

                    Console.Write("Година на издаване: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("Жанр: ");
                    string genre = Console.ReadLine();

                    Console.Write("Цена: ");
                    double price = double.Parse(Console.ReadLine());

                    Book newBook = new Book(title, author, year, genre, price);
                    library.Add(newBook);
                    Console.WriteLine("\nКнигата беше добавена успешно");
                    break;

                case "4":
                    Console.Write("\nВъведете заглавие на книгата за изтриване: ");
                    string deleteTitle = Console.ReadLine();
                    Book bookToRemove = library.FirstOrDefault(b => b.Title.Equals(deleteTitle, StringComparison.OrdinalIgnoreCase));

                    if (bookToRemove != null)
                    {
                        library.Remove(bookToRemove);
                        Console.WriteLine("\nКнигата беше изтрита успешно!");
                    }
                    else
                    {
                        Console.WriteLine("\nНяма книга с такова заглавие.");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("\nИзход от програмата");
                    break;

                default:
                    Console.WriteLine("\nНевалиден избор. Моля, изберете от 1 до 5.");
                    break;
            }
        }
    }
}