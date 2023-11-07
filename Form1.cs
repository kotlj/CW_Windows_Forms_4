namespace CW_Windows_Forms_4
{
    public partial class Form1 : Form
    {
        List<Book> books;
        public Form1()
        {
            InitializeComponent();
            Book Test1 = new Book("ForTest", "Someone", 2022);
            Book Test2 = new Book("Second", "Another", 2222);
            Book Test3 = new Book("Last", "Who?", 0);
            books = new List<Book>();
            books.Add(Test1); books.Add(Test2); books.Add(Test3);
            int counter = 0;
            foreach (Book book in books)
            {
                
                Button button = new Button();
                button.Text = book.Title;
                button.Tag = book;
                button.Location = new Point(0 + 100 * counter, 0);
                button.Click += button1_Click;
                this.Controls.Add(button);
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Book book in books)
            {
                string text = (sender as Button).Text;
                if (book.Title == text)
                {
                    MessageBox.Show($"Book: {book.Title}\nAuthor {book.Author}\nYear {book.Year}\nID {book.ID}");
                }
            }
        }
    }
}