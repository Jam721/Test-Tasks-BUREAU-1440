var tokens = File.ReadAllText("data_prog_contest_problem_2.txt").Split(
    [' ', '\t', '\n', '\r'], 
    StringSplitOptions.RemoveEmptyEntries
);

var n = tokens.Length;
var numbers = new int[n];
for (var i = 0; i < n; i++)
{
    numbers[i] = int.Parse(tokens[i]);
}

var freq = new int[27];
var count = 0;
var start = 0;
var minLen = int.MaxValue;

for (var end = 0; end < n; end++)
{
    var num = numbers[end];
    if (num is >= 1 and <= 26)
    {
        if (freq[num] == 0) count++;
        freq[num]++;
    }

    while (count == 26)
    {
        if (end - start + 1 < minLen)
        {
            minLen = end - start + 1;
        }

        var numStart = numbers[start];
        if (numStart is >= 1 and <= 26)
        {
            freq[numStart]--;
            if (freq[numStart] == 0) count--;
        }
        start++;
    }
}

Console.WriteLine(minLen == int.MaxValue ? "NONE" : minLen.ToString());