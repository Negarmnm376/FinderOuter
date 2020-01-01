﻿// The FinderOuter
// Copyright (c) 2020 Coding Enthusiast
// Distributed under the MIT software license, see the accompanying
// file LICENCE or http://www.opensource.org/licenses/mit-license.php.

namespace FinderOuter.Backend.Cryptography
{
    public interface IRandomNumberGenerator
    {
        void GetBytes(byte[] toFill);
    }
}
