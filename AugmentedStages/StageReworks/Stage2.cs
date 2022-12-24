using RoR2;

namespace AugmentedStages
{
  public class Stage2
  {
    public DirectorCardCategorySelection.Category[] ReworkAqueduct()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.lemurian, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindVermin, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindPest, selectionWeight = 3 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.greaterWisp, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.beetleGuard, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.clayApothecary, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.clayTemplar, selectionWeight = 2 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.clayDunestrider, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.titan, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.beetleQueen, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    public DirectorCardCategorySelection.Category[] ReworkWetland()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.lemurian, selectionWeight = 4 }, new DirectorCard() { spawnCard = AugmentedStages.blindVermin, selectionWeight = 4 }, new DirectorCard() { spawnCard = AugmentedStages.blindPest, selectionWeight = 4 }, new DirectorCard() { spawnCard = AugmentedStages.jellyfish, selectionWeight = 4 } };
      basicMonsters.selectionWeight = 4;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.beetleGuard, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.golem, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.brassContraption, selectionWeight = 2 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.titan, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.wanderingVagrant, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    public DirectorCardCategorySelection.Category[] ReworkAphelian()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.lemurian, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindVermin, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.blindPest, selectionWeight = 3 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.clayApothecary, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.clayTemplar, selectionWeight = 3 } };
      minibosses.selectionWeight = 3;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.clayDunestrider, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.wanderingVagrant, selectionWeight = 2 } };
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