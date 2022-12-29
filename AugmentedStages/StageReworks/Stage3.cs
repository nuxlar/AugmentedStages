using RoR2;

namespace AugmentedStages
{
  public class Stage3
  {
    public DirectorCardCategorySelection.Category[] ReworkRallypoint()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.lemurian, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindVermin, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindPest, selectionWeight = 3 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.gup, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.bighornBison, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.greaterWisp, selectionWeight = 3 } };
      minibosses.selectionWeight = 3;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.magmaWorm, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.grovetender, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    public DirectorCardCategorySelection.Category[] ReworkAcres()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.blindVermin, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindPest, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.imp, selectionWeight = 3 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.brassContraption, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.gup, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.clayTemplar, selectionWeight = 3 } };
      minibosses.selectionWeight = 3;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.xiConstruct, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.grovetender, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    public DirectorCardCategorySelection.Category[] ReworkPools()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.lemurian, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindVermin, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindPest, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.alphaConstruct, selectionWeight = 3 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.greaterWisp, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.clayApothecary, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.clayTemplar, selectionWeight = 2 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.magmaWorm, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.xiConstruct, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }
  }
}