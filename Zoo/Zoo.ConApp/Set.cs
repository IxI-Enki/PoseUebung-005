namespace Zoo.ConApp;

internal class Set
{
  #region PROPERTIES
  public int Count
  {
    get
    {
      int count = 0;
      Node? run = First;
      while (run != null)
      {
        count++;
        run = run.Next;
      }
      return count;
    }
  }
  public Node? First { get; set; }
  #endregion

  #region METHODS
  public void Add(Animal animalToAdd)
  {
    if (animalToAdd != null && !IsAnimalInSet(animalToAdd))
      if (First == null)
        First = new Node(animalToAdd);
      else
      {
        Node run = First;
        while (run.Next != null)
          run = run.Next!;
        run.Next = new Node(animalToAdd);
      }
  }
  public bool IsAnimalInSet(Animal animalToLookFor)
  {
    bool isAnimalInSet = false;
    Node? run = First;

    while (run != null)
    {
      if (animalToLookFor == run.Animal)
        return true;
      else
        run = run.Next;
    }
    return isAnimalInSet;
  }
  #endregion

  #region OVERRIDES
  public override string ToString()
  {
    StringBuilder sb = new();
    Node? run = First;
    while (run != null)
    {
      sb.Append(run.Animal.ToString() + "\n");
      run = run.Next;
    }
    return sb.ToString();
  }

  public static Set operator +(Set one , Set two)
  {
    Set newSet = new();
    Node? run = one.First;
    while (run != null)
    {
      if (!newSet.IsAnimalInSet(run.Animal))
        newSet.Add(run.Animal);
      run = run.Next;
    }
    run = two.First;
    while (run != null)
    {
      if (!newSet.IsAnimalInSet(run.Animal))
        newSet.Add(run.Animal);
      run = run.Next;
    }
    return newSet;
  }
  public static Set operator -(Set one , Set two)
  {
    Set newSet = new();
    Node? run = one.First;
    while (run != null)
    {
      if (!two.IsAnimalInSet(run.Animal))
        newSet.Add(run.Animal);
      run = run.Next;
    }
    return newSet;
  }
  public static Set operator *(Set one , Set two)
  {
    Set newSet = new();
    Node? run = one.First;
    while (run != null)
    {
      if (two.IsAnimalInSet(run.Animal))
        newSet.Add(run.Animal);
      run = run.Next;
    }
    return newSet;
  }
  #endregion

  #region EMBEDED CLASS
  internal class Node(Animal animal , Node? next = null)
  {
    public Animal Animal { get; set; } = animal;
    public Node? Next { get; set; } = next;
    #endregion
  }
}
