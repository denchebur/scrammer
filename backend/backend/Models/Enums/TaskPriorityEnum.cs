using System.Runtime.Serialization;

namespace backend.Models.Enums;

public enum TaskPriorityEnum
{
    [EnumMember(Value = "Low")]
    Low,
    [EnumMember(Value = "Normal")]
    Normal,
    [EnumMember(Value = "High")]
    High
}