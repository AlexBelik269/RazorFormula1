namespace F1_Blazor_App.Models
{ 
    public class DriverData
    {
        public MetaData_Driver? Meta { get; set; }
        public List<DriverResult>? Results { get; set; }
    }

    public class MetaData_Driver
    {
        public string? Description { get; set; }
        public FieldsData_Driver? Fields { get; set; }
        public string? Title { get; set; }
    }

    public class FieldsData_Driver
    {
        public string? DriverId { get; set; }
        public string? DriverName { get; set; }
        public string? IsReserve { get; set; }
        public string? Nationality { get; set; }
        public string? Points { get; set; }
        public string? Position { get; set; }
        public string? Season { get; set; }
        public string? TeamId { get; set; }
        public string? TeamName { get; set; }
        public string? Updated { get; set; }
    }

    public class DriverResult
    {
        public int? Driver_Id { get; set; }
        public string? Driver_Name { get; set; }
        public int? Is_Reserve { get; set; }
        public string? Nationality { get; set; }
        public string? Points { get; set; }
        public int? Position { get; set; }
        public int? Season { get; set; }
        public int? Team_Id { get; set; }
        public string? Team_Name { get; set; }
        public string? Updated { get; set; }
    }

}
