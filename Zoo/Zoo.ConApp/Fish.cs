
namespace Zoo.ConApp;

internal class Fish(string name) : Animal(name)
{
  public override string ToString()
    => new StringBuilder().Append(
                                  FishTypeEmoji(this) +
                                  $"{Name}, ich kann lange unter Wasser bleiben."
                                  ).ToString();

  private string FishTypeEmoji(Fish fish)
  {
    string fishEmoji = "🐟";
    switch (fish.Name)
    {
      case "Tropenfisch":
        fishEmoji = "🐠";
        break;
      case "Hai":
        fishEmoji = "🦈";
        break;
      case "Wal":
        fishEmoji = (new Random().Next(2) == 1) ? "🐋" : "🐳";
        break;
      default:
        break;
    }
    return fishEmoji + " ";
  }
}