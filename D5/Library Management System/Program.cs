namespace Library_Management_System
{
    namespace LibraryManagementSystem
    {
        //class Category
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Description { get; set; }
        //}

        class Book
        {
            public Book(string iSBN, string title, string author, string categoryName, DateTime dateTime, decimal price, int quantity, bool status = true)
            {
                ISBN = iSBN;
                Title = title;
                Author = author;
                CategoryName = categoryName;
                dateTime = AddedDate;
                Price = price;
                Status = status;
                Quantity = quantity;
            }

            public string ISBN { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string CategoryName { get; set; }
            public DateTime AddedDate { get; set; }
            public decimal Price { get; set; }
            public bool Status { get; set; }
            public int Quantity { get; set; }
            public User? User { get; set; }
            public DateTime? ReturnedDate { get; set; }
        }

        enum Gender
        {
            Male,
            Female
        }

        class User
        {
            public User(string id, Gender gender, string name, string phoneNumber)
            {
                Id = id;
                Gender = gender;
                Name = name;
                PhoneNumber = phoneNumber;
                Books = new();
            }

            public string Id { get; set; }
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public List<Book> Books { get; set; }
        }

        class Library
        {
            public List<Book> Books { get; set; }
            public List<User> Users { get; set; }

            public Library()
            {
                Books = new();
                Users = new();
            }

            public bool AddBook(Book book)
            {
                if (book.Title is not null)
                {
                    Books.Add(book);
                    return true;
                }

                return false;
            }

            public List<Book>? SearchBook(string query)
            {
                List<Book> books = new();

                for (int i = 0; i < Books.Count; i++)
                {
                    if (Books[i].Title.Contains(query) || Books[i].Author.Contains(query) || Books[i].CategoryName.Contains(query))
                    {
                        books.Add(Books[i]);
                    }
                }

                if (books.Count > 0)
                {
                    return books;
                }
                else
                {
                    return null;
                }
            }

            public bool Borrow(Book book)
            {
                if (book.Status)
                {
                    book.Status = false;
                    book.ReturnedDate = DateTime.UtcNow.AddDays(10);

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Return(Book book)
            {
                if (book is not null)
                {
                    book.Status = true;
                    book.ReturnedDate = null;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Library library = new();
                List<Book>? books = new();
                string selection = "";

                while (true)
                {
                    Console.WriteLine("1. Add new Book");
                    Console.WriteLine("2. Add new User");
                    Console.WriteLine("3. Search a book");
                    Console.WriteLine("4. Borrow Book");
                    Console.WriteLine("5. Return Book");
                    Console.WriteLine("6. Exit");
                    selection = Console.ReadLine();

                    switch (selection)
                    {
                        case "1":
                            {
                                bool result = library.AddBook(new(Guid.NewGuid().ToString().Substring(0, 5), "C++ Introduction", "Mohamed Nabih", "Programming", DateTime.UtcNow, 50, 10));

                                if (result)
                                {
                                    Console.WriteLine("Add Book to the library successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Data");
                                }

                                result = library.AddBook(new(Guid.NewGuid().ToString().Substring(0, 5), "C++ Introduction", "Ali", "Programming", DateTime.UtcNow, 50, 10));

                                if (result)
                                {
                                    Console.WriteLine("Add Book to the library successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Data");
                                }
                            }
                            break;

                        case "3":
                            {
                                Console.WriteLine("Enter your query to search for a book: ");
                                books = library.SearchBook(Console.ReadLine());

                                if (books is not null)
                                {
                                    for (int i = 0; i < books.Count; i++)
                                    {
                                        Console.WriteLine(books[i].ISBN);
                                        Console.WriteLine(books[i].Title);
                                        Console.WriteLine(books[i].Author);
                                        Console.WriteLine(books[i].CategoryName);
                                        Console.WriteLine(books[i].Status);
                                        if (!books[i].Status)
                                        {
                                            Console.WriteLine(books[i].ReturnedDate);
                                        }
                                        Console.WriteLine(books[i].Price);
                                        Console.WriteLine("==========================");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Data");
                                }
                            }
                            break;
                        case "4":
                            {
                                Console.WriteLine("Enter your query to borrow a book: ");
                                books = library.SearchBook(Console.ReadLine());

                                if (books is not null)
                                {
                                    bool borrowedResult = library.Borrow(books[0]);

                                    if (borrowedResult)
                                    {
                                        Console.WriteLine("Borrowed Book successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Already Borrowed!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Data");
                                }
                            }
                            break;
                        case "5":
                            {
                                Console.WriteLine("Enter your return book: ");
                                books = library.SearchBook(Console.ReadLine());
                                if (books is not null)
                                {
                                    bool borrowedResult = library.Borrow(books[0]);

                                    if (borrowedResult)
                                    {
                                        Console.WriteLine("Borrowed Book successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Already Borrowed!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Data");
                                }
                            }
                            break;
                    }

                }
            }
        }
    }
}
