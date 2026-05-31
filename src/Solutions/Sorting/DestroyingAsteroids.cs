namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/destroying-asteroids
public class DestroyingAsteroids
{
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        System.Array.Sort(asteroids);
        long currMass = mass;

        foreach (int asteroid in asteroids)
        {
            if (asteroid > currMass)
                return false;

            currMass += asteroid;
        }

        return true;
    }
}
