namespace FirstProject;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class DisplayPropertyAttribute: Attribute {
    
    public string DisplayName { get; }
    
    public DisplayPropertyAttribute(string displayName) {
        DisplayName = displayName;
    }
}