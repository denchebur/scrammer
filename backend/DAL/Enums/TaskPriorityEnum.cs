using System.Runtime.Serialization;

namespace DAL.Enums;

public enum TaskPriorityEnum
{
    [EnumMember(Value = "Low")]
    Low,
    [EnumMember(Value = "Normal")]
    Normal,
    [EnumMember(Value = "High")]
    High
}