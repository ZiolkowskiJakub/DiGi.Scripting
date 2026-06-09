using DiGi.Scripting.Classes;
using DiGi.Scripting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Scripting.Core
{
#pragma warning disable CS1591
    public static partial class Query
#pragma warning restore CS1591
    {
        /// <summary>
        /// Executes a <see cref="Script"/> against multiple sets of input data using the specified threading mode.
        /// </summary>
        /// <param name="script">The script to execute.</param>
        /// <param name="inputDatas">A collection of <see cref="Data"/> objects providing inputs for each execution.</param>
        /// <param name="threadingMode">The <see cref="ThreadingMode"/> used to control the parallelism of the execution. Defaults to Parallel.</param>
        /// <returns>A list of <see cref="Response"/> objects containing the results, or null if the script, input data, or threading mode is invalid.</returns>
        public static List<Response?>? Execute(this Script? script, IEnumerable<Data>? inputDatas, ThreadingMode threadingMode = ThreadingMode.Parallel)
        {
            if (script == null || threadingMode == ThreadingMode.Undefined || inputDatas == null)
            {
                return null;
            }

            int count = inputDatas.Count();
            if (count == 0)
            {
                return [];
            }

            List<Response?>? result = null;

            if (threadingMode == ThreadingMode.Series)
            {
                result = [];
                foreach (Data inputData in inputDatas)
                {
                    result.Add(script.Execute(inputData));
                }
            }
            else
            {
                result = [.. Enumerable.Repeat<Response?>(null, count)];
                Parallel.For(0, count, i =>
                {
                    result[i] = script.Execute(inputDatas.ElementAt(i));
                });
            }

            return result;
        }

        /// <summary>
        /// Executes a <see cref="Script"/> against multiple sets of input data using the provided parallel options.
        /// </summary>
        /// <param name="script">The script to execute.</param>
        /// <param name="inputDatas">A collection of <see cref="Data"/> objects providing inputs for each execution.</param>
        /// <param name="parallelOptions">The <see cref="ParallelOptions"/> used to configure the parallel loop.</param>
        /// <returns>A list of <see cref="Response"/> objects containing the results, or null if the script or input data is null.</returns>
        public static List<Response?>? Execute(this Script? script, IEnumerable<Data>? inputDatas, ParallelOptions parallelOptions)
        {
            if (script == null || inputDatas == null)
            {
                return null;
            }

            int count = inputDatas.Count();
            if (count == 0)
            {
                return [];
            }

            parallelOptions ??= new ParallelOptions();

            List<Response?> result = [.. Enumerable.Repeat<Response?>(null, count)];
            Parallel.For(0, count, parallelOptions, i =>
            {
                if (parallelOptions.CancellationToken != null && parallelOptions.CancellationToken.IsCancellationRequested)
                {
                    return;
                }

                result[i] = script.Execute(inputDatas.ElementAt(i));
            });

            return result;
        }

        /// <summary>
        /// Executes a <see cref="Script"/> against multiple sets of input data with the ability to stop execution based on a response predicate.
        /// </summary>
        /// <param name="script">The script to execute.</param>
        /// <param name="inputDatas">A collection of <see cref="Data"/> objects providing inputs for each execution.</param>
        /// <param name="parallelOptions">The <see cref="ParallelOptions"/> used to configure the parallel loop.</param>
        /// <param name="stopFunc">A function that takes a <see cref="Response"/> and returns true if the overall execution should stop.</param>
        /// <param name="stopResponse">When this method returns, contains the <see cref="Response"/> that triggered the stop condition, if any.</param>
        /// <returns>A list of <see cref="Response"/> objects containing the results, or null if the script or input data is null.</returns>
        public static List<Response?>? Execute(this Script? script, IEnumerable<Data>? inputDatas, ParallelOptions? parallelOptions, Func<Response?, bool>? stopFunc, out Response? stopResponse)
        {
            stopResponse = null;

            if (script == null || inputDatas == null)
            {
                return null;
            }

            int count = inputDatas.Count();
            if (count == 0)
            {
                return [];
            }

            parallelOptions ??= new ParallelOptions();

            int index = -1;

            List<Response?>? result = [.. Enumerable.Repeat<Response?>(null, count)];
            Parallel.For(0, count, parallelOptions, (i, state) =>
            {
                if (parallelOptions.CancellationToken != null && parallelOptions.CancellationToken.IsCancellationRequested)
                {
                    return;
                }

                result[i] = script.Execute(inputDatas.ElementAt(i));

                if (stopFunc != null && stopFunc.Invoke(result[i]))
                {
                    state.Stop();
                    Interlocked.Exchange(ref index, i);
                    return;
                }
            });

            if (index != -1)
            {
                stopResponse = result[index];
            }

            return result;
        }
    }
}