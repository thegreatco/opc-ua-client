﻿using FluentAssertions;

using System;

using Workstation.ServiceModel.Ua;

using Xunit;

namespace Workstation.UaClient.UnitTests
{
    public class TypeLibraryTests
    {
        [Fact]
        public void FindBinaryEncodingIdByType()
        {
            TypeLibrary.TryGetBinaryEncodingIdFromType(typeof(ReadRequest), out ExpandedNodeId nodeid)
                 .Should().BeTrue();
            nodeid
                .Should().Be(ExpandedNodeId.Parse(ObjectIds.ReadRequest_Encoding_DefaultBinary));
        }

        [Fact]
        public void FindTypeByBinaryEncodingId()
        {
            TypeLibrary.TryGetTypeFromBinaryEncodingId(ExpandedNodeId.Parse(ObjectIds.ReadRequest_Encoding_DefaultBinary), out Type type)
                .Should().BeTrue();
            type
                .Should().Be(typeof(ReadRequest));
        }

        [Fact]
        public void FindTypeByDataTypeId()
        {
            TypeLibrary.TryGetTypeFromDataTypeId(ExpandedNodeId.Parse("i=1"), out Type type)
                .Should().BeTrue();
            type
                .Should().Be(typeof(Boolean));
        }
    }
}
