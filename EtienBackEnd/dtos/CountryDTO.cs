namespace dtos
{
    public class CountryDTO: BaseDTO
    {
        public virtual string Name { get; set; }

        public CountryDTO(long id, string name) : base(id)
        {
            Name = name;
        }
    }
}