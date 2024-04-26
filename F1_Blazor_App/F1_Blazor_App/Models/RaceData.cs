namespace F1_Blazor_App.Models
{
    public class RaceData
    {
        public MetaData_Race? Meta { get; set; }
        public List<RaceResult>? Results { get; set; }
    }

    public class MetaData_Race
    {
        public string? Description { get; set; }
        public FieldsData_Race? Fields { get; set; }
        public string? Title { get; set; }
    }

    public class FieldsData_Race
    {
        public string? Country { get; set; }
        public string? EndDate { get; set; }
        public string? Name { get; set; }
        public string? RaceId { get; set; }
        public string? Season { get; set; }
        public SessionModel? SessionArray { get; set; }
        public string? StartDate { get; set; }
        public string? Status { get; set; }
        public string? Track { get; set; }
    }

    public class RaceResult
    {
        public string? Country { get; set; }
        public string? End_Date { get; set; }
        public string? Name { get; set; }
        public int? Race_Id { get; set; }
        public string? Season { get; set; }
        public List<SessionModel>? Sessions { get; set; }
        public string? Start_Date { get; set; }
        public string? Status { get; set; }
        public string? Track { get; set; }
    }

    public class SessionModel
    {
        public string? Date { get; set; }
        public int? Id { get; set; }
        public string? Session_Name { get; set; }
    }
}


