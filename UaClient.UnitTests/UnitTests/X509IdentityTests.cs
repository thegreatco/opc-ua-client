using FluentAssertions;

using Workstation.ServiceModel.Ua;

using Xunit;

namespace Workstation.UaClient.UnitTests
{
    public class X509IdentityTests
    {
        [Fact]
        public void CreateNull()
        {
            var id = new X509Identity(null, null);

            id.Certificate
                .Should().BeNull();
            id.PrivateKey
                .Should().BeNull();
        }
    }
}
