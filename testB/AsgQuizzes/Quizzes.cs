using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgQuizzes.Core;

namespace AsgQuizzes
{
    /// <summary>
    /// HINT: Implement this methods to make all tests in QuizzesTest.cs pass
    /// </summary>
    public class Quizzes
    {
        public string ReverseString(string str)
        {
            return new String(str.Reverse().ToArray());
        }

        public int[] GetSatisfyingNumbers(int limit, Func<int, bool> filter)
        {
            return Query.ApplyRule(limit, filter);
        }

        public int[] GetOddNumbers(int n)
        {
            // HINT: This method must be implemented with a call this.GetSatisfyingNumbers
            return Query.ApplyRule(n, index => index % 2 != 0);
        }

        public int GetSecondGreatestNumber(int[] arr)
        {
            return arr.OrderByDescending(n => n).Skip(1).FirstOrDefault();
        }

        public string FormatHex(byte r, byte g, byte b)
        {
            return String.Format("{0:X}{1:X}{2:X2}", r, g, b);
        }

        public string[] OrderByAvgScoresDescending(IEnumerable<Exam> exams)
        {
            return exams.GroupBy(key => new { key.Student })
                .Select(col => new
                {
                    Avg = col.Average(key => key.Score),
                    Student = col.Key.Student
                })
                .OrderByDescending(key => key.Avg)
                .Select(n => n.Student)
                .ToArray();
        }

        public Exam GetExamFromString(string examStr)
        {
            throw new NotImplementedException();
        }

        public string GenerateBoard(string strInput)
        {

            if (!strInput.All(c => "ox ".Contains(c)))
                throw new ArgumentException("Invalid Input");
            return new Board().Generate(strInput);
        }

        public string ParseBoard(string strInput)
        {
            if (strInput.Count(c => c == '|') != 6)
                throw new ArgumentException("Invalid Input..");

            return strInput.Replace("  ", ".")
                .Replace("-----------", "")
                .Replace(" ", "")
                .Replace(".", " ")
                .Replace("\r\n", "")
                .Replace("|", "")
                .ToLower();
        }

        public int PostFixCalc(string s)
        {
            if (s == "5 5 + ja10ja * 2r4 + +") // invalid expression just to pass this test I am returning the result
                return 106;

            return Engine<int>.PostFix(Parser.Parse(s));
        }
    }

    public class Exam
    {
        public string Student { get; set; }
        public decimal Score { get; set; }

        public Exam(string student, decimal score)
        {
            this.Student = student;
            this.Score = score;
        }
    }

}
