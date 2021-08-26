using System;
using SampleForHTTP.Services;
using SampleForHTTP.Modules;
namespace SampleForHTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2" +
                "VyIjoi0JHQvtCz0LTQsNC9IiwidGVuYW50Ij" +
                "oiNzI5IiwibmJmIjoxNjI5OTkxNzY0LCJleHAiOjE2MzAwNzgxNj" +
                "QsImlzcyI6IlRlc3QtQmFja2VuZC0xIiwiYXVkIj" +
                "oiQmFza2V0QmFsbENsdWJTYW1wbGUifQ.QdYTyCFds97e6RFU" +
                "cjvvvG3oT-PacAV8lYvN2-gZdjk";
            Team team = new Team()
            {
                Id = 123,
                Name = "Arsenal",
                FoundationYear = new DateTime(2009,5,6),
                Conference = "A",
                Division = "d",
                ImageUrl = "dfkj"

            };


        }
    }
}
