namespace F1_Blazor_App.Models
{
    public class ConstructorData
    {
        public MetaData_Constructors? Meta { get; set; }
        public List<ResultData_Constructors>? Results { get; set; }
    }
    public class MetaData_Constructors
    {
        public string? Description { get; set; }
        public FieldsData_Constructors? Fields { get; set; }
        public string? Title { get; set; }
    }

    public class FieldsData_Constructors
    {
        public string? Points { get; set; }
        public string? Position { get; set; }
        public string? Season { get; set; }
        public string? TeamId { get; set; }
        public string? TeamName { get; set; }
    }

    public class ResultData_Constructors
    {
        public String? Points { get; set; }
        public int? Position { get; set; }
        public int? Season { get; set; }
        public int? Team_Id { get; set; }
        public string? Team_Name { get; set; }
    }

}
