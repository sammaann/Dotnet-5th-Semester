using System;
using FitnessTracker.Workout;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkoutPlan workout = new WorkoutPlan();
            workout.Run();
        }
    }
}