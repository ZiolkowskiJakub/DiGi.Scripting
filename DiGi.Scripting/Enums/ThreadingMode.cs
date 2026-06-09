using System.ComponentModel;

namespace DiGi.Scripting.Enums
{
    /// <summary>
    /// Defines the threading mode used to control execution parallelism.
    /// </summary>
    [Description("Threading Mode")]
    public enum ThreadingMode
    {
        /// <summary>
        /// The threading mode is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Execution occurs in series (sequentially).
        /// </summary>
        [Description("Series")] Series,

        /// <summary>
        /// Execution occurs in parallel.
        /// </summary>
        [Description("Parallel")] Parallel,
    }
}