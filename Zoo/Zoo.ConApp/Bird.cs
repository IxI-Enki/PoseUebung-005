namespace Zoo.ConApp;

internal sealed class Bird(string name , bool cantFly = false) : Animal(name)
{
  private readonly bool _cantFly = cantFly;
  public override string ToString()
    => new StringBuilder().Append(Name + FlightCapability()).ToString();

  private string FlightCapability()
    => !_cantFly ?
        ", ich kann lange Strecken fliegen." :
        ", ich bin zwar ein Vogel, aber ich kann nicht fliegen.";
}
