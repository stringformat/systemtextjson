namespace WebApplication2.Domain;

public record User(Email email, Age age);

public record Email(string Value);

public record Age(int Value);