namespace FinalEgzam.RequestModels
{
    public class PersonRequestModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double PersonsCode { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] ProfilePicture { get; set; }
        public int ResidenceId { get; set; }
    }
}
