struct CFSignupRequest
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] user;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
    char[] password;
}

struct CFDeleteUserRequest
{
}

struct CFUpdateUserRequest
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
    char[] password;
}

struct CFDummySigninRequest
{
}

struct CFSigninRequest
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] user;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
    char[] password;
}

struct CFSignoutRequest
{
}
