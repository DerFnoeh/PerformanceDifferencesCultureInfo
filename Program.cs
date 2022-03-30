using System.Diagnostics;
using System.Globalization;

var timer = Stopwatch.StartNew();

for (var i = 0; i < 100000; i++)
{
    var cultureInfo = new CultureInfo("de-De");
    decimal.TryParse("100", NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, cultureInfo, out var @out);
}

timer.Stop();
Console.WriteLine(timer.ElapsedMilliseconds);
