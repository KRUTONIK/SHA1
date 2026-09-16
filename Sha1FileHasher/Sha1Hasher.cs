using System.Buffers.Binary;

namespace Sha1FileHasher;

public static class Sha1Hasher
{
    private const uint H0Initial = 0x67452301;
    private const uint H1Initial = 0xEFCDAB89;
    private const uint H2Initial = 0x98BADCFE;
    private const uint H3Initial = 0x10325476;
    private const uint H4Initial = 0xC3D2E1F0;

    public static byte[] ComputeHash(byte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);

        byte[] data = AddPadding(source);

        uint h0 = H0Initial;
        uint h1 = H1Initial;
        uint h2 = H2Initial;
        uint h3 = H3Initial;
        uint h4 = H4Initial;

        uint[] words = new uint[80];

        for (int offset = 0; offset < data.Length; offset += 64)
        {
            // Первые 16 слов формируются непосредственно из 512-битного блока.
            for (int i = 0; i < 16; i++)
                words[i] = BinaryPrimitives.ReadUInt32BigEndian(data.AsSpan(offset + i * 4, 4));

            // Остальные слова расписания сообщения вычисляются рекуррентно.
            for (int i = 16; i < 80; i++)
                words[i] = RotateLeft(words[i - 3] ^ words[i - 8] ^ words[i - 14] ^ words[i - 16], 1);

            uint a = h0;
            uint b = h1;
            uint c = h2;
            uint d = h3;
            uint e = h4;

            for (int i = 0; i < 80; i++)
            {
                uint f;
                uint k;

                if (i < 20)
                {
                    f = (b & c) | (~b & d);
                    k = 0x5A827999;
                }
                else if (i < 40)
                {
                    f = b ^ c ^ d;
                    k = 0x6ED9EBA1;
                }
                else if (i < 60)
                {
                    f = (b & c) | (b & d) | (c & d);
                    k = 0x8F1BBCDC;
                }
                else
                {
                    f = b ^ c ^ d;
                    k = 0xCA62C1D6;
                }

                uint temp = unchecked(RotateLeft(a, 5) + f + e + k + words[i]);

                e = d;
                d = c;
                c = RotateLeft(b, 30);
                b = a;
                a = temp;
            }

            h0 = unchecked(h0 + a);
            h1 = unchecked(h1 + b);
            h2 = unchecked(h2 + c);
            h3 = unchecked(h3 + d);
            h4 = unchecked(h4 + e);
        }

        byte[] result = new byte[20];
        BinaryPrimitives.WriteUInt32BigEndian(result.AsSpan(0, 4), h0);
        BinaryPrimitives.WriteUInt32BigEndian(result.AsSpan(4, 4), h1);
        BinaryPrimitives.WriteUInt32BigEndian(result.AsSpan(8, 4), h2);
        BinaryPrimitives.WriteUInt32BigEndian(result.AsSpan(12, 4), h3);
        BinaryPrimitives.WriteUInt32BigEndian(result.AsSpan(16, 4), h4);
        return result;
    }

    public static string ComputeHashHex(byte[] source) =>
        Convert.ToHexString(ComputeHash(source));

    private static byte[] AddPadding(byte[] source)
    {
        ulong bitLength = checked((ulong)source.LongLength * 8UL);

        int zeroCount = (56 - ((source.Length + 1) % 64) + 64) % 64;
        byte[] result = new byte[source.Length + 1 + zeroCount + 8];

        Buffer.BlockCopy(source, 0, result, 0, source.Length);
        result[source.Length] = 0x80;
        BinaryPrimitives.WriteUInt64BigEndian(result.AsSpan(result.Length - 8), bitLength);

        return result;
    }

    private static uint RotateLeft(uint value, int count) =>
        (value << count) | (value >> (32 - count));
}
