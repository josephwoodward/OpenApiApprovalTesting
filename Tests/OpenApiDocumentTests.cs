using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Tests
{
    public class OpenApiDocumentTests : IClassFixture<ApiFixture>
    {
        private readonly ApiFixture _apiFixture;

        public OpenApiDocumentTests(ApiFixture apiFixture)
        {
            _apiFixture = apiFixture;
        }

        [Fact]
        public async Task OpenApiDocumentHasChanged()
        {
            var client = _apiFixture.Create();

            var request = await client.GetAsync("/swagger/v1/swagger.json");
            var content = await request.Content.ReadAsStringAsync();

            content.ShouldMatchApproved();
        }
    }
}