namespace AdventOfCode_2023
{
    static public class Day5
    {
        static public long AnswerPartOne(string inputFile = "Day5_input.txt")
        {
            // Read the input file
            string[] lines = File.ReadAllLines(inputFile);

            // Parse the seeds
            List<long> seeds = lines[0].Split(' ').Skip(1).Select(long.Parse).ToList();

            // Find the index of each map section based on the headers and parse the maps
            var soilMap = ParseMappings(FindMapSection(lines, "seed-to-soil map:"));
            var fertilizerMap = ParseMappings(FindMapSection(lines, "soil-to-fertilizer map:"));
            var waterMap = ParseMappings(FindMapSection(lines, "fertilizer-to-water map:"));
            var lightMap = ParseMappings(FindMapSection(lines, "water-to-light map:"));
            var temperatureMap = ParseMappings(FindMapSection(lines, "light-to-temperature map:"));
            var humidityMap = ParseMappings(FindMapSection(lines, "temperature-to-humidity map:"));
            var locationMap = ParseMappings(FindMapSection(lines, "humidity-to-location map:"));

            long lowestLocation = long.MaxValue;

            foreach (var seed in seeds)
            {
                long soil = MapValue(soilMap, seed);
                long fertilizer = MapValue(fertilizerMap, soil);
                long water = MapValue(waterMap, fertilizer);
                long light = MapValue(lightMap, water);
                long temperature = MapValue(temperatureMap, light);
                long humidity = MapValue(humidityMap, temperature);
                long location = MapValue(locationMap, humidity);

                lowestLocation = Math.Min(lowestLocation, location);
            }

            Console.WriteLine($"The lowest location number is: {lowestLocation}");
            return lowestLocation;
        }

        static IEnumerable<string> FindMapSection(string[] lines, string header)
        {
            int startIndex = Array.IndexOf(lines, header) + 1;
            var sectionLines = new List<string>();
            for (int i = startIndex; i < lines.Length && !string.IsNullOrWhiteSpace(lines[i]); i++)
            {
                sectionLines.Add(lines[i]);
            }
            return sectionLines;
        }

        static Dictionary<long, (long destinationStart, long sourceStart, long rangeLength)> ParseMappings(IEnumerable<string> mapLines)
        {
            var map = new Dictionary<long, (long, long, long)>();
            foreach (var line in mapLines)
            {
                var parts = line.Split(' ');
                long destinationStart = long.Parse(parts[0]);
                long sourceStart = long.Parse(parts[1]);
                long rangeLength = long.Parse(parts[2]);

                // Instead of generating all mappings, store the start and end points of the ranges
                map[sourceStart] = (destinationStart, sourceStart, rangeLength);
            }
            return map;
        }

        static long MapValue(Dictionary<long, (long destinationStart, long sourceStart, long rangeLength)> map, long sourceValue)
        {
            // Search for the range that sourceValue falls into
            foreach (var entry in map)
            {
                long sourceStart = entry.Value.sourceStart;
                long rangeLength = entry.Value.rangeLength;

                if (sourceValue >= sourceStart && sourceValue < sourceStart + rangeLength)
                {
                    // Calculate the offset from the start of the source range
                    long offset = sourceValue - sourceStart;
                    // Apply the same offset to the destination start
                    return entry.Value.destinationStart + offset;
                }
            }

            // If not found, the source number corresponds to the same destination number
            return sourceValue;
        }

        static public int AnswerPartTwo()
        {
            return 0;
        }
    }
}
