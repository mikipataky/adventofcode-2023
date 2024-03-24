namespace AdventOfCode_2023
{
    static public class Day5
    {
        static public int AnswerPartOne(string inputFile = "Day5_input.txt")
        {
            // Read the input file
            string[] lines = File.ReadAllLines(inputFile);
            // Parse the seeds
            string[] seedNumbers = lines[0].Split(' ').Skip(1).ToArray();
            // Parse the mappings
            var soilMap = ParseMappings(lines[3..5]);
            var fertilizerMap = ParseMappings(lines[7..10]);
            var waterMap = ParseMappings(lines[12..16]);
            var lightMap = ParseMappings(lines[18..20]);
            var temperatureMap = ParseMappings(lines[22..25]);
            var humidityMap = ParseMappings(lines[27..29]);
            var locationMap = ParseMappings(lines[31..33]);

            int lowestLocation = int.MaxValue;

            foreach (var seed in seedNumbers)
            {
                int seedValue = int.Parse(seed);
                int soilValue = MapValue(soilMap, seedValue);
                int fertilizerValue = MapValue(fertilizerMap, soilValue);
                int waterValue = MapValue(waterMap, fertilizerValue);
                int lightValue = MapValue(lightMap, waterValue);
                int temperatureValue = MapValue(temperatureMap, lightValue);
                int humidityValue = MapValue(humidityMap, temperatureValue);
                int locationValue = MapValue(locationMap, humidityValue);

                lowestLocation = Math.Min(lowestLocation, locationValue);
            }

            Console.WriteLine($"The lowest location number is: {lowestLocation}");
            return lowestLocation; 
        }

        static Dictionary<int, int> ParseMappings(string[] mapLines)
        {
            var map = new Dictionary<int, int>();

            foreach (var line in mapLines)
            {
                var parts = line.Split(' ');
                int destStart = int.Parse(parts[0]);
                int sourceStart = int.Parse(parts[1]);
                int rangeLength = int.Parse(parts[2]);

                for (int i = 0; i < rangeLength; i++)
                {
                    map[sourceStart + i] = destStart + i;
                }
            }

            return map;
        }

        static int MapValue(Dictionary<int, int> map, int sourceValue)
        {
            if (map.ContainsKey(sourceValue))
            {
                return map[sourceValue];
            }
            return sourceValue; // If not mapped, the source number corresponds to the same destination number
        }

        static public int AnswerPartTwo()
        {
            return 0;
        }
    }
}
