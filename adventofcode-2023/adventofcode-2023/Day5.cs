// See https://aka.ms/new-console-template for more information

using System;

public class Day5
{
    private string inputFileName;
    private List<List<MapItem>> map = new List<List<MapItem>>();

    public Day5(string v)
    {
        this.inputFileName = v;
    }

    public void AnswerPartOne()
    {
        Console.Write("Hello, solution for the 5. day part one: ");

        using (StreamReader sr = new StreamReader(inputFileName))
        {

        }
    }

    public void AnswerPartTwo()
    {
        throw new NotImplementedException();
    }


    private class MapItem
    {
        public int SourceRangeStart { get; set; }
        public int DestinationRangeStart { get; set; }
        public int RangeLength{ get; set; }

        public MapItem(string line)
        {
            int[] values = line.Split(' ').ToList().ConvertAll<int>(int.Parse).ToArray();
            DestinationRangeStart = values[0];
            SourceRangeStart = values[1];
            RangeLength = values[2];
        }
    }
}