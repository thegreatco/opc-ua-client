﻿// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.X509;

namespace Workstation.ServiceModel.Ua
{
    public class X509Identity : IUserIdentity
    {
        public X509Identity(X509Certificate certificate, RsaKeyParameters privateKey)
        {
            this.Certificate = certificate;
            this.PrivateKey = privateKey;
        }

        public X509Certificate Certificate { get; }

        public RsaKeyParameters PrivateKey { get; }
    }
}
