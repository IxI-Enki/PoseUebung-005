
namespace Zoo.ConApp;

internal sealed class Bird(string name , bool cantFly = false) : Animal(name)
{
  private readonly bool _cantFly = cantFly;
  public override string ToString()
    => new StringBuilder().Append($"{BirdTypeEmoji(this)} {Name}, {FlightCapability()}").ToString();

  private string BirdTypeEmoji(Bird bird)
  {
    return bird.Name switch
    {
      "Küken" => (new Random().Next(1) == 1) ? "🐥" : "🐣",
      "Pinguin" => "🐧",
      "Pelikan" => "🦩",
      "Kanari" => "🦜",
      "Schwan" => "🦢",
      "Adler" => "🦅",
      "Taube" => "🕊️",
      "Huhn" => "🦃",
      "Hahn" => "🐓",
      "Pfau" => "🦚",
      "Eule" => "🦉",
      "Dodo" => "🦤",
      "Ente" => "🦆",
      _ => "🐦",
    };
  }

  private string FlightCapability()
    => !_cantFly ?
        "ich kann lange Strecken fliegen." :
        "ich bin zwar ein Vogel, aber ich kann nicht fliegen.";
}
