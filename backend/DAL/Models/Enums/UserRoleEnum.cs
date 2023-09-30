﻿using System.Runtime.Serialization;

namespace DAL.Models.Enums;

public enum UserRoleEnum
{
    [EnumMember(Value = "Owner")]
    Owner,
    [EnumMember(Value = "Admin")]
    Admin,
    [EnumMember(Value = "User")]
    User
}