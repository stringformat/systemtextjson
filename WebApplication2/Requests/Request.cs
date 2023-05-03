using WebApplication2.Domain;

namespace WebApplication2.Requests;

public record Request(
    EmailRequest Email,
    AgeRequest Age)
{
    public User ToDomain() => new(Email.ToDomain(), Age.ToDomain());
}