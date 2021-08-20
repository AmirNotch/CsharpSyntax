using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class ClassRectangle
    {
        static void Main()
        {
            Console.Write("Введите число длины прямоугольника: ");
            var side1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число ширины прямоугольника: ");
            var side2 = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Вычисления площади прямоугольника: { rectangle.AreaCalculator()}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.PerimeterCalculator()}");

        }
    }
    class Rectangle
    {
        public double side1;
        public double side2;

        public double Area
        {
            get
            {
                return side1 * side2;
            }
        }
        public double Perimeter
        {
            get
            {
                return 2 * (side1 + side2);
            }
        }

        public double AreaCalculator()
        {
            return Area;
        }

        public double PerimeterCalculator()
        {
            return Perimeter;
        }

        public Rectangle()
        {

        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
    class Book
    {
        static void Main()
        {
            Console.Write("Введите Название книги: ");
            var titleText = Console.ReadLine();

            Console.Write("Введите Имя Автора книги: ");
            var authorText = Console.ReadLine();
            
            Console.Write("Введите контент книги: ");
            var contentText = Console.ReadLine();

            var title = new Title(titleText);
            var author = new Author(authorText);
            var content = new Content(contentText);

            Console.WriteLine();

            Console.WriteLine($"Название книги: {title.Show()}");
            Console.ResetColor();
            
            Console.WriteLine($"Имя Автора книги: {author.Show()}");
            Console.ResetColor();
            
            Console.WriteLine($"Контент книги: {content.Show()}");
            Console.ResetColor();
        }
    }
    class Title
    {
        public string title;

        public Title(string title)
        {
            this.title = title;
        } 

        public string Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return title;
        }
    }
    class Author
    {
        public string author;
        public Author(string author)
        {
            this.author = author;
        }
        public string Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return author;
        }
    }
    class Content
    {
        public string content;
        public Content(string content)
        {
            this.content = content;
        }
        public string Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return content;
        }
    }
}
