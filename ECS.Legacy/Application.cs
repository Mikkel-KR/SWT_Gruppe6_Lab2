﻿namespace ECS.Legacy
{
    // HEJ SLET DET HER MAGNUS

    // HEJ SLET DET HER JEPPE
    public class Application
    {
        public static void Main(string[] args)
        {
            var ecs = new ECS(28);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
