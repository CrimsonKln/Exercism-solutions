public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] result = new byte[9];
        Array.Fill<byte>(result, 0);
        switch (reading)
        {
            case long n when n >= 0 && n <= ushort.MaxValue:
                BitConverter.GetBytes((ushort)reading).CopyTo(result, 1);
                result[0] = sizeof(ushort);
                break;
            case long n when n >= short.MinValue && n <= -1:
                BitConverter.GetBytes((short)reading).CopyTo(result, 1);
                result[0] = 256 - sizeof(short);
                break;
            case long n when (n > ushort.MaxValue && n <= int.MaxValue) || (n >= int.MinValue && n < short.MinValue):
                BitConverter.GetBytes((int)reading).CopyTo(result, 1);
                result[0] = 256 - sizeof(int);
                break;
            case long n when n > int.MaxValue && n <= uint.MaxValue:
                BitConverter.GetBytes((uint)reading).CopyTo(result, 1);
                result[0] = sizeof(uint);
                break;
            default:
                BitConverter.GetBytes(reading).CopyTo(result, 1);
                result[0] = 256 - sizeof(long);
                break;
        }
        return result;
    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch
    {
        sizeof(ushort) => BitConverter.ToInt64(buffer, 1),
        sizeof(uint) => BitConverter.ToInt64(buffer, 1),
        256 - sizeof(short) => (long)BitConverter.ToInt16(buffer, 1),
        256 - sizeof(int) => (long)BitConverter.ToInt32(buffer, 1),
        256 - sizeof(long) => BitConverter.ToInt64(buffer, 1),
        _ => 0
    };
}
