namespace dtos
{
    public class PreferenceDTO:BaseDTO
    {
        public virtual string Name { get; set; }

        public PreferenceDTO(long id, string name) : base(id)
        {
            Name = name;
        }
    }
}