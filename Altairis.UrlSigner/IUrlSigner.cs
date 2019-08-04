﻿using System;

namespace Altairis.UrlSigner {
    public interface IUrlSigner {

        string Sign(string url);

        Uri Sign(Uri url);

        bool Verify(string url);

        bool Verify(Uri url);

    }
}