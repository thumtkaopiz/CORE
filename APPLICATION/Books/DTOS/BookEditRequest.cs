namespace APPLICATION.Book.DTOS
{
    public class BookEditRequest
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int PublisherID { get; set; }
    }

}