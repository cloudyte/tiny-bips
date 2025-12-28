using AwesomeAssertions;
using Xunit;

namespace Cloudyte.TinyBips.Test;

public sealed class EmptyTest
{
    [Fact]
    public void EmptyTest_Run()
    {
        true.Should().BeTrue();
    }
}
