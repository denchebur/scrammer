using System.Runtime.Serialization;

namespace DAL.Models.Enums;

public enum TaskStatusEnum
{
    [EnumMember(Value = "ToDo")]
    ToDo,
    [EnumMember(Value = "InProgress")]
    InProgress,
    [EnumMember(Value = "Completed")]
    Completed,
    [EnumMember(Value = "Rejected")]
    Rejected
}