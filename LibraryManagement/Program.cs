using System;

class Book{
    private string bookID,title,author;
    private bool isAvailable;
    public Book(string bookID,string title,string author,bool isAvailable){
        this.bookID = bookID;
        this.title = title;
        this.author = author;
        this.isAvailable = isAvailable;
    }
        public string BookId{
            get {return bookID;}
            set {bookID = value;}
        }
        public string Title{
            get {return title;}
            set {title = value;}
        }
        public string Author{
            get {return author;}
            set {author = value;}
        }
        public bool IsAvailable{
            get {return isAvailable;}
            set {isAvailable = value;}
        }
    
}

class Program{
    static void Main(){  
            int n;
            Console.WriteLine("Please insert the number of the Book to manage");
            n=int.Parse(Console.ReadLine());
            if(!(n>=1 && n<=10)){
                Console.WriteLine("Please give a valid input");
                Console.WriteLine("Number of books must be between number 1 - 10");
                return;
            }
            Book[] books = new Book[n];
            for(int i=0;i < n;i++){
                Console.WriteLine($"Enter the details on Book no {i+1}  ");
                Console.Write("Book ID   : ");
                string a=Console.ReadLine();
                Console.Write("Title    : ");
                string b=Console.ReadLine();
                Console.Write("Author   : ");
                string c=Console.ReadLine();
                Console.Write("Is the book available?(yes/no) : ");
                bool d;
                string s = Console.ReadLine();
                if(s=="yes"){
                    d = true;
                }else{
                    d= false;
                }
                Console.WriteLine();
                
                books[i] = new Book(a,b,c,d);
            }

            int count = 0;
            for(int i=0;i<n;i++){
                if(books[i].IsAvailable == true){
                    if(count == 0){Console.WriteLine("Available books:");}
                    Console.WriteLine($"Book ID : {books[i].BookId}, Title : {books[i].Title} , Author : {books[i].Author}");
                    count++;
                }
            }
            if(count == 0){
                Console.WriteLine("No books are currently available");
            }

        }

}