string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM",
    "ABU DHABI", "PARIS" };
string[] sortedCities = cities.OrderBy(c => c.Length).ToArray();
foreach (string c in sortedCities)
{
    Console.WriteLine(c);
}