using System.Diagnostics;
using NLua;

namespace cs_game_demo;

public class Controller
{
  private readonly Lua _lua = new();
  public Controller()
  {
    Debug.WriteLine("test");

    _lua.DoString(@"
      function greet(name)
        print(name)
        return 'first' .. name
      end
    ");

    var result = _lua.GetFunction("greet").Call("world")[0];
    System.Diagnostics.Debug.WriteLine(result);
  }
}
