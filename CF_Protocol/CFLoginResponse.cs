//Login and ConnectPassing
struct CFLoginResponse
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
    char[] ip;
    int port;
    
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    char[] cookie;

}
