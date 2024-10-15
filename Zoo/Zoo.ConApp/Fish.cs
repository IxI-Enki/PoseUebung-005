namespace Zoo.ConApp;

internal sealed class Fish(string name) : Animal(name)
{
  public override string ToString()
    => new StringBuilder().Append(
                                  $"{Name}, ich kann lange unter Wasser bleiben."
                                  ).ToString();
}
