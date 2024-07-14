namespace Entities
{
    public class Vocabulary
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public EnumWordType WordTypeId { get; set; }
        public string Pronounciation { get; set; }
        public string Description { get; set; }

    }
}
