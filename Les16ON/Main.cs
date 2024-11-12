using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les16ON
{

    internal class Book
    {
        public string title { get; private set; }
        public string author { get; private set; }
        public int year { get; private set; }

        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public Book()
        {
            title = "Emty";
            author = "None";
            year = 1890;
        }
    }

     class BookStore
    {
        private List<Book> books = new List<Book>();


        public void AddBook()
        {
            string strTitle = null;
            string strAuthor = null;

            int years = 0;

            Console.Write("Enter title of the book ");
            strTitle = Console.ReadLine();


            Console.Write("Enter author of the book ");
            strAuthor = Console.ReadLine();


            Console.Write("Enter year of the book ");
            years = Convert.ToInt32(Console.ReadLine());

            Book tmpBook = new Book(strTitle, strAuthor, years);

            books.Add(tmpBook);
        }

        public void RemoveBook()
        {
            string strTitle = null;
            ShowAllBooks();
            Console.WriteLine("Enter title to remove ");
            strTitle = Console.ReadLine();

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == strTitle)
                {
                    books.RemoveAt(i);
                    Console.WriteLine("Element is cleared");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        }

        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Title: " + book.title);
                Console.WriteLine("Author: " + book.author);
                Console.WriteLine("Year: " + book.year);
                Console.WriteLine();
            }
        }
    



        internal class Program
        {
            static void Main(string[] args)
            {
                const int addBook = 1;
                const int showBooks = 2;
                const int removeBook = 3;
                const int updateBook = 4;
                //const int deleteBook = 5;
                const int exitProgram = 6;

                int num;

                bool isWork = true;

                Book book = new Book();
                BookStore bookShop = new BookStore();

                /*
                            Создать хранилище книг.
                    Каждая книга имеет название, автора и год выпуска(можно добавить еще параметры).В хранилище можно добавить книгу, убрать книгу, 
                    показать все книги и показать книги по указанному параметру(по названию, по автору, по году выпуска).
                    Про указанный параметр, к примеру нужен конкретный автор, выбирается показ по авторам, запрашивается у пользователя автор и 
                    показываются все книги с этим автором.
                */
                while (isWork)
                {
                    //HashSet<Book> b = new HashSet<Book>();                   
                    Console.WriteLine("1: Add book\n2: Show all books\n3: Remove book\n4: Update book\n5: empty command \n6: Log out\n");
                    Console.WriteLine("Enter command: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    switch (num)
                    {
                        case addBook:
                            bookShop.AddBook();
                            break;

                        case exitProgram:
                            isWork = false;
                            break;

                        case showBooks:
                            bookShop.ShowAllBooks();
                            break;

                        case removeBook:
                            bookShop.RemoveBook();
                            break;

                        default:
                            Console.WriteLine("Error enter");
                            break;

                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}  
