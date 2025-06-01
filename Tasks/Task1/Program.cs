var lines = File.ReadAllLines("data_prog_contest_problem_1.txt");
var n = int.Parse(lines[0].Trim());
        
var segments = new List<Tuple<int, int>>();
for (var i = 1; i <= n; i++)
{
    if (string.IsNullOrWhiteSpace(lines[i])) 
        continue;
                
    var parts = lines[i].Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);
    if (parts.Length < 2) 
        continue;
                
    var a = int.Parse(parts[0]);
    var b = int.Parse(parts[1]);
            
    if (a > b)
        (a, b) = (b, a); 
    
    segments.Add(Tuple.Create(a, b));
}
        
segments = segments.OrderBy(seg => seg.Item2).ToList();

var count = 0;
var currentPoint = int.MinValue;
        
foreach (var seg in segments.Where(seg => seg.Item1 > currentPoint))
{
    count++;
    currentPoint = seg.Item2;
}
        
Console.WriteLine(count);