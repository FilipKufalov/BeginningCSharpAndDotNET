using Ch11Ex02;

AnimalCollection animalCollection = new AnimalCollection();
animalCollection.Add(new Cow("Donna"));
animalCollection.Add(new Chicken("Mary"));
foreach (Animal item in animalCollection)
{
    item.Feed();
}