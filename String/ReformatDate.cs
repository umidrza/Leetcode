namespace Leetcode.String;

// https://leetcode.com/problems/reformat-date
public class ReformatDateSolution
{
    public string ReformatDate(string date)
    {
        // Split the input into parts
        string[] parts = date.Split(' ');
        string day = parts[0];
        string month = parts[1];
        string year = parts[2];

        // Remove the suffix from the day ("st", "nd", "rd", "th")
        day = day.Substring(0, day.Length - 2);
        if (day.Length == 1) day = "0" + day;

        // Map month abbreviations to numbers
        Dictionary<string, string> monthMap = new Dictionary<string, string>()
        {
            {"Jan","01"},{"Feb","02"},{"Mar","03"},{"Apr","04"},
            {"May","05"},{"Jun","06"},{"Jul","07"},{"Aug","08"},
            {"Sep","09"},{"Oct","10"},{"Nov","11"},{"Dec","12"}
        };

        string monthNumber = monthMap[month];

        // Return formatted date
        return $"{year}-{monthNumber}-{day}";
    }
}
