namespace Leetcode.src.Solutions.Queue;

//https://leetcode.com/problems/number-of-students-unable-to-eat-lunch
public class NumberOfStudentsUnableToEatLunch
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        int[] count = new int[2];

        foreach (int student in students)
        {
            count[student]++;
        }

        foreach (int sandwich in sandwiches)
        {
            if (count[sandwich] == 0) break;
            count[sandwich]--;
        }

        return count[0] + count[1];
    }
}
