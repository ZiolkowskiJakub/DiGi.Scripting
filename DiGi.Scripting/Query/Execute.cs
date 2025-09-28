using DiGi.Scripting.Classes;
using DiGi.Scripting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Scripting.Core
{
    public static partial class Query
    {
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
                if(parallelOptions.CancellationToken != null && parallelOptions.CancellationToken.IsCancellationRequested)
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

            if(index != -1)
            {
                stopResponse = result[index];
            }

            return result;
        }
    }
}
