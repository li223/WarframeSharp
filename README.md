<p align="center">
  <img src="docs/logo.png" />
  </a>
</p>

Basic wrapper for https://api.warframestat.us

I got bored, don't ask.

# Example

```cs
static async Task Main(string[] args)
{
  //New instance of WarframeSharpClient
  var client = new WarframeSharpClient();
  //Get all the current alerts on PC
  var data = await client.GetAlertsDataAsync(PlatformType.PC);
  //Display the mission type and planet node
  Console.WriteLine(string.Join("\n", data?.Select(x => $"Mission Type: {x.Mission.Type} || Node: {x.Mission.Node}")));
}
```
