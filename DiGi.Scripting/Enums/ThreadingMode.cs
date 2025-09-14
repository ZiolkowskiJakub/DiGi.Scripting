using System.ComponentModel;

namespace DiGi.Scripting.Core.Enums
{
    [Description("Threading Mode")]
    public enum ThreadingMode
    {
        [Description("Undefined")] Undefined,
        [Description("Series")] Series,
        [Description("Parallel")] Parallel,
    }
}
