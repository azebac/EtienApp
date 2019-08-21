namespace dtos
{
    public class CountryDTO: BaseDTO
    {
        public virtual string Name { get; set; }
        public virtual string ISO { get; set; }
        public virtual string NiceName { get; set; }
        public virtual string ISO3 { get; set; }
        public virtual int NumCode { get; set; }
        public virtual int PhoneCode { get; set; }

        public CountryDTO(long id, string name, string iso, string niceName, string iso3, int numCode,
            int phoneCode) : base(id)
        {
            Name = name;
            ISO = iso;
            NiceName = niceName;
            ISO3 = iso3;
            NumCode = numCode;
            PhoneCode = phoneCode;
        }

        public CountryDTO(long id, string name) : base(id)
        {
            Name = name;
        }
    }
}