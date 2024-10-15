namespace Zoo.ConApp;

internal class Fish(string name) : Animal(name)
{
  public override string ToString()
    => new StringBuilder().Append($"{FishTypeEmoji(this)} {Name}, ich kann lange unter Wasser bleiben.").ToString();

  private string FishTypeEmoji(Fish fish)
  {
    return fish.Name switch
    {
      "Tropenfisch" => "🐠",
      "Wal" => (new Random().Next(2) == 1) ? "🐋" : "🐳",
      "Hai" => "🦈",
      _ => "🐟",
    };
  }
}