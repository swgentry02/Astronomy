using System;

namespace Astronomy
{
    public static class BodySystemData
    {
        public static AstronomicalBody Arms = new AstronomicalBody()
        {
            Name = "Arm Exercises",
            Mass = "Diamond Pushups",
            Circumference = "Drag Curls",
            Age = "Kettelbell Hammer Curls",          
            Workout4 = "Cable Skull Crusher",
            Workout5 = "JM Press"
        };

        public static AstronomicalBody Chest = new AstronomicalBody()
        {

            Name = "Chest Exercises",
            Mass = "Single Arm Hammer Chest Press",
            Circumference = "Reverse Grip Bench Press",
            Age = "Partial Reps Bench Press",
            Workout4 = "Incline Bench Cable Fly",
            Workout5 = "Incline Dumbbell Pull Over"

        };

        public static AstronomicalBody Legs = new AstronomicalBody()
        {
            Name = "Leg Exercises",
            Mass = "Hack Squat",
            Circumference = " Romanian Deadlift",
            Age = "Nordic Hamstring Curl",          
            Workout4 = "Bulgarin Split Squat",
            Workout5 = "Goblet Squat"
        };

        public static AstronomicalBody Back = new AstronomicalBody()
        {
            Name = "Back Exercises",
            Mass = "Alternated Grip Pull Up",
            Circumference = "Double Cable Pulldown",
            Age = "Reverse-Grip Barbell Pullover",          
            Workout4 = "Landmine Row",
            Workout5 = "Bent-Over Barbell Row"

        };
    }
}
