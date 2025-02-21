﻿using System;
using System.Security.Cryptography;
using Xunit;

namespace Altairis.Services.UrlSigner.Tests {
    public class HmacUrlSignerTest {
        private static readonly byte[] Key = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 };
        private static readonly Uri TestUri = new Uri("https://www.example.com/");
        private const string TestString = "https://www.example.com/";

        [Fact]
        public static void RoundtripUri() {
            var signer = new HmacUrlSigner<HMACSHA512>(Key);
            var signedUri = signer.Sign(TestUri);
            Assert.True(signer.Verify(signedUri));
        }

        [Fact]
        public static void RoundtripString() {
            var signer = new HmacUrlSigner<HMACSHA512>(Key);
            var signedString = signer.Sign(TestString);
            Assert.True(signer.Verify(signedString));
        }

    }
}
