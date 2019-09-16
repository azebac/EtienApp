namespace dtos
{
    public class BaseDTO
    {
        public virtual long Id { get; set; }

        public BaseDTO(long id)
        {
            Id = id;
        }

        public BaseDTO()
        {

        }
    }
}