namespace GymLife.API.Models
{
    public class ResponseClie
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public object? Data { get; set; }
    }
    public class ResponseClieGetDetalleMascota
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public DetailClie Data { get; set; }
    }
    public class DetailClie
    {
        public int? IdUser { get; set; }
        public string? Email { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string LostStatus { get; set; }
        public string AdoptionStatus { get; set; }
        public string Type { get; set; }
        public string Age { get; set; }
        public ICollection<PetImage> PetImage { get; set; }
        }
        public class GetClie
        {
            public int? IdUser { get; set; }
            public string Status { get; set; }
        }
        public class GetDataClie
        {
            public string Status { get; set; }
        }
    }
}
