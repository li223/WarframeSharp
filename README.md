# WarframeSharp
Basic wrapper for https://api.warframestat.us

I got bored, don't ask.

# Example

```cs
static void Main(string[] args) => new Program().RunAsync().GetAwaiter().GetResult();

public async Task RunAsync()
{
  //New instance of WarframeSharpClient
  var client = new WarframeSharpClient();
  //Get all the current alerts on PC
  var data = await client.GetAlertsDataAsync(PlatformType.PC);
  //Display the mission type and planet node
  Console.WriteLine(string.Join("\n", data?.Select(x => $"Mission Type: {x.Mission.Type} || Node: {x.Mission.Node}")));
}
```
