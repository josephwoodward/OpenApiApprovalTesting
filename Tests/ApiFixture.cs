using System.Net.Http;
using Api;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Tests
{
public class ApiFixture
{
    private readonly WebApplicationFactory<Startup> _fixture;

    public ApiFixture()
    {
        _fixture = new WebApplicationFactory<Startup>();
    }

    public HttpClient Create()
    {
        return _fixture.CreateClient();
    }
}
}