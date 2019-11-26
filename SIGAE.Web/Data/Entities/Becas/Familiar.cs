namespace SIGAE.Web.Data.Entities.Becas
{
    public class Familiar : IEntity
    {
        public int Id { get; set; }
        public Parentesco Parentesco { get; set; }
    }
}