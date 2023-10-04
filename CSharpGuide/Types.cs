using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{


    public enum DummyOptions
    {
        open,
        closed,
        unknown
    }

    class TypesEx
    {
        // Simulating TypeScript's `Dictionary`
        Dictionary<string, string> stringDict = new Dictionary<string, string>
        {
            {"a", "A"},
            {"b", "B"}
        };

        Dictionary<int, string> dictOfNumbers = new Dictionary<int, string>
        {
            {420, "four twenty"},
            {1337, "HAX"}
        };


        Dictionary<DummyOptions, int> dictFromUnionType = new Dictionary<DummyOptions, int>
        {
            {DummyOptions.closed, 1},
            {DummyOptions.open, 2},
            {DummyOptions.unknown, 3}
        };

        PositiveNumber a = PositiveNumber.Create(5);
        NegativeNumber b = NegativeNumber.Create(-10);

        public class ComplexObject
        {
            public int Simple { get; set; }
            public NestedObject Nested { get; set; }
        }

        public class NestedObject
        {
            public string A { get; set; }
            public List<BarObject> Array { get; set; }
        }

        public class BarObject
        {
            public int Bar { get; set; }
        }

        // For DeepPartial, DeepRequired, DeepReadonly, we'd likely have to use classes 
        // and take advantage of nullable properties or other mechanisms in C#. Omit can be achieved 
        // by simply not adding the property or removing it.

        public class PositiveNumber
        {
            private PositiveNumber(double value) { Value = value; }
            public double Value { get; }

            public static PositiveNumber Create(double n)
            {
                if (n <= 0) throw new Exception($"Value {n} is not positive!");
                return new PositiveNumber(n);
            }
        }

        public class NegativeNumber
        {
            private NegativeNumber(double value) { Value = value; }
            public double Value { get; }

            public static NegativeNumber Create(double n)
            {
                if (n >= 0) throw new Exception($"Value {n} is not negative!");
                return new NegativeNumber(n);
            }
        }

        public interface ICiProvider
        {
            Task<string> GetSHA();
        }

        public class Circle : ICiProvider
        {
            public Task<string> GetSHA() => Task.FromResult("abc");
        }

        public class Travis : ICiProvider
        {
            public async Task<string> GetSHA()
            {
                // do async call
                return await Task.FromResult("def");
            }
        }
    }

}

