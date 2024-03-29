namespace MyReadings.Models
{
    public class MyReadingsModel
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public int Pages { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Obs { get; set; }

    }
}
