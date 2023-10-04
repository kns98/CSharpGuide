using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{


public class TsfnObjectWrap<T> : IDisposable
    {
        private ThreadSafeFunction<T> _tsfn;
        private Thread _thread;

        public TsfnObjectWrap(Action<T> callback)
        {
            _tsfn = new ThreadSafeFunction<T>(callback);
            _thread = new Thread(ThreadFunction);
            _thread.Start(_tsfn);
        }

        public void Dispose()
        {
            _tsfn.Abort();
            _thread.Join();
        }

        private void ThreadFunction(object obj)
        {
            var tsfn = obj as ThreadSafeFunction<T>;
            T[] buffer = new T[3];
            int idx = 0;

            while (true)
            {
                buffer[idx] = tsfn.GetNextValue(); // Assuming you have a mechanism to produce the next value
                idx = (idx + 1) % 3;
                var valueRef = buffer[idx];

                bool isClosing = tsfn.BlockingCall(valueRef);

                if (isClosing)
                {
                    break;
                }
            }
        }
    }

    public class ThreadSafeFunction<T>
    {
        private Action<T> _callback;

        public ThreadSafeFunction(Action<T> callback)
        {
            _callback = callback;
        }

        public bool BlockingCall(T data)
        {
            try
            {
                _callback.Invoke(data);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                return true;
            }
        }

        public void Abort()
        {
            // Cleanup or abort logic
        }

        // Mock method to produce next value - should be implemented based on your requirements
        public T GetNextValue()
        {
            return default(T);
        }
    }

    class Test
    {
        public static void Main30(string[] args)
        {
            var longWrapper = new TsfnObjectWrap<long>(data =>
            {
                Console.WriteLine($"Received long data: {data}");
            });

            var stringWrapper = new TsfnObjectWrap<string>(data =>
            {
                Console.WriteLine($"Received string data: {data}");
            });

            // Clean up when done
            longWrapper.Dispose();
            stringWrapper.Dispose();

        }
    }
}


