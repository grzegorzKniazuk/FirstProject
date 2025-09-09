namespace FirstProject;

public class PaginatedResult<T> {
    
    public List<T> Results { get; set; } = [];
    public int ResultsFrom { get; set; }
    public int ResultsTo { get; set; }
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}