namespace Zoo.ConApp;

internal abstract class Animal(string name)
{
  #region PROPPERTIES
  public string Name { get; set; } = name;
  #endregion

  #region OVERRIDES
  public override string ToString() => base.ToString()!;
  #endregion
}