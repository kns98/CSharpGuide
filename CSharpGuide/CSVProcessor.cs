using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharpGuide
{


    [TestFixture]
    class CSVProcessorTests
    {
        CSVProcessor csvProcessor = new CSVProcessor();

        [Test]
        public void TestSimpleCSV()
        {
            string input = "one,\"two, too\",three";
            List<string> expected = new List<string> { "one", "two, too", "three" };

            var result = csvProcessor.SplitCSV(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestComplexCSV()
        {
            string input = "\"one\",\"t\"\"wo\",\",three,\"";
            List<string> expected = new List<string> { "one", "t\"wo", ",three," };

            var result = csvProcessor.SplitCSV(input);
            Assert.AreEqual(expected, result);
        }
    }

    class CSV
    {
        static void Main37()
        {
            Console.WriteLine("Hello, World!");

            CSVProcessor csvProcessor = new CSVProcessor();

            string myTextTestCase1 = "field1,field2,field3\r\naaa,bbb,ccc\r\nddd,eee,fff";
            string myTextTestCase2 = "\"aaa\",\"b,bb\",\"c\r\nc\"";

            Console.WriteLine("Scenario 1");
            csvProcessor.ProcessCSV(myTextTestCase1, true); // true indicates that we have a header

            Console.WriteLine("Scenario 2");
            csvProcessor.ProcessCSV(myTextTestCase2, false); // false indicates that we don't have a header

            Console.ReadLine();
        }
    }

    class CSVProcessor
    {
        const string delimiter = ",";
        const string lineEnding = "\r\n";

        public void ProcessCSV(string text, bool hasHeader)
        {
            string[] rows = text.Split(new[] { lineEnding }, StringSplitOptions.None);
            List<string> headers = new List<string>(); // Used to store headers if present.
            bool isFirstRow = true;

            foreach (var row in rows)
            {
                if (string.IsNullOrWhiteSpace(row)) continue; // skip empty lines

                // Use a regular expression to split the row into fields, considering quoted fields which may contain commas and newlines.
                var fields = SplitCSV(row);

                if (isFirstRow && hasHeader) // Process header row if present
                {
                    headers.AddRange(fields);
                    Console.WriteLine("Headers : " + string.Join(", ", headers));
                    isFirstRow = false;
                    continue;
                }

                // Process each field, using header names if available.
                for (int i = 0; i < fields.Count; i++)
                {
                    string field = fields[i];
                    string header = headers.Count > i ? headers[i] : $"Field {i}";
                    Console.WriteLine($"{header} : {field}");
                }
            }
        }

        public List<string> SplitCSV(string input)
        {
            var regex = new Regex($"(?:^|{delimiter})(\"(?:[^\"]+|\"\")*\"|[^{delimiter}]*)");
            var list = new List<string>();

            foreach (Match match in regex.Matches(input))
            {
                string field = match.Groups[1].Value;

                // Remove leading/trailing delimiter and unquote if necessary.
                if (field.StartsWith("\"") && field.EndsWith("\""))
                {
                    field = field.Substring(1, field.Length - 2).Replace("\"\"", "\"");
                }

                list.Add(field);
            }
            return list;
        }
    }

}
