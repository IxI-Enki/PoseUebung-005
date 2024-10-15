
namespace Zoo.ConApp;

internal sealed class Bird(string name , bool cantFly = false) : Animal(name)
{
  private readonly bool _cantFly = cantFly;
  public override string ToString()
    => new StringBuilder().Append(
                                  BirdTypeEmoji(this) +
                                  Name + 
                                  FlightCapability()
                                  ).ToString();

  private string BirdTypeEmoji(Bird bird)
  {
    string birdEmoji = "🐦";
    switch (bird.Name)
    {
      case "Küken" : birdEmoji = (new Random().Next(1) == 1) ? "🐥": "🐣"; break;
      case "Pinguin" : birdEmoji = "🐧"; break;
      case "Pelikan" : birdEmoji = "🦩"; break;
      case "Kanari" : birdEmoji = "🦜"; break;
      case "Schwan" : birdEmoji = "🦢"; break;
      case "Adler" : birdEmoji = "🦅"; break;
      case "Taube": birdEmoji = "🕊️"; break;
      case "Huhn" : birdEmoji = "🦃"; break;
      case "Hahn" : birdEmoji = "🐓"; break;
      case "Pfau" : birdEmoji = "🦚"; break;
      case "Eule" : birdEmoji = "🦉"; break;
      case "Dodo" : birdEmoji = "🦤"; break;
      case "Ente" : birdEmoji = "🦆"; break;
      default: break;
    }
    return birdEmoji + " ";
  }

  private string FlightCapability()
    => !_cantFly ?
        ", ich kann lange Strecken fliegen." :
        ", ich bin zwar ein Vogel, aber ich kann nicht fliegen.";
}
