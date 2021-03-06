﻿namespace AntServiceStack.CacheAccess
{
    public interface IGZipProvider
    {
        byte[] GZip(string text);

        string GUnzip(byte[] gzBuffer);
    }
}