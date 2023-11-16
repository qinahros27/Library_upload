namespace Library.src.Manage.TypeOfBook 
{
    public class ResearchPaper: Book 
    {
        private int _maxPage = 20;

        public ResearchPaper(string title, string author, string isbn, string publicationYear): base(title, author, isbn, publicationYear)
        {
            CanBorrow = false;
        }

        public void PrintPages(int startPage, int endPage) 
        {
            int amountPage = endPage - startPage;
            if(amountPage >= _maxPage) 
            {
                throw new ArgumentException("Amount of page to be printed can not exceed 20 pages.");
            }
            else 
            {
                Console.WriteLine($"Print the book from page {startPage} to {endPage}.");
            }
        }
    }
}