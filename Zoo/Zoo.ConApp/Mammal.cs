namespace Zoo.ConApp;

  internal sealed class Mammal(string name) : Animal(name)
  {
    public override string ToString()
      => new StringBuilder().Append(
                                    $"{Name}, ich wurde gesäugt."
                                    ).ToString();
  }
