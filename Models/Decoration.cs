namespace ApiPartyCatalog.Models
{
    public class Decoration
    {
        public int DecorationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal ValueDecoration { get; set; }
        public int DecoratorId { get; set; }
        public Decorator Decorator { get; set; }
    }
}
