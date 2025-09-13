namespace FirstProject;

public record Currency(string Name, decimal Value): BaseRecordCurrency(Name, Value) {
}

public record class BaseRecordCurrency(string Name, decimal Value): ICurrency {
    
    // sealed override to prevent further overriding
    public sealed override string ToString() => Name;
}
