using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var FizzBuzz = new Exercise(){
                Name = "Fizz Buzz",
                Language = "Javascript"
            };
            var UrbanPlanner = new Exercise(){
                Name = "Urban Planner",
                Language = "C#"
            };
            var RunAway = new Exercise(){
                Name = "Run Away",
                Language = "Python"
            };
            var Tourney = new Exercise(){
                Name = "Tourney",
                Language = "React"
            };

            var Cohort32 = new Cohort(){
                Name = "Cohort 32"
            };

            var Cohort33 = new Cohort(){
                Name = "Cohort 33"
            };

            var Cohort34 = new Cohort(){
                Name = "Cohort 34"
            };

            var jWebb = new Student(){
                FirstName = "Josh",
                LastName = "Webb",
                Slack = "Josh-Webb",
                Cohort = Cohort32
            };

            var eSpradlin = new Student(){
                FirstName = "Elena",
                LastName = "Spradlin",
                Slack = "Spradbae",
                Cohort = Cohort34
            };

            var eAshe = new Student(){
                FirstName = "Elle",
                LastName = "Ashe",
                Slack = "Asheville",
                Cohort = Cohort33
            };

            var bNilsen = new Instructor(){
                FirstName = "Bryan",
                LastName = "Nilsen",
                SlackHandle = "Bryan Nilsen",
                Cohort = Cohort32
            };
            
        }
    }
}
