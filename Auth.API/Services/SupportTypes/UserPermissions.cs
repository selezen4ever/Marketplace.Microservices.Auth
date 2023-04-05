﻿namespace Auth.API.Services.SupportTypes;

[Flags]
public enum UserPermissions : byte
{
    Read = 1,
    Edit = 2,
    Write = 4,
    Delete = 8
}