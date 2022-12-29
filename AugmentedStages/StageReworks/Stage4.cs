using RoR2;

namespace AugmentedStages
{
  public class Stage4
  {
    public DirectorCardCategorySelection.Category[] ReworkAbyssal()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.imp, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.solusProbes, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.larva, selectionWeight = 3 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.brassContraption, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.gup, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.elderLemurian, selectionWeight = 3 } };
      minibosses.selectionWeight = 3;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.impBoss, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.solusControlUnit, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions };
      return newCategories;
    }

    public DirectorCardCategorySelection.Category[] ReworkGrove()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.solusProbes, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.larva, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.miniMushrum, selectionWeight = 3 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.brassContraption, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.gup, selectionWeight = 3 }, new DirectorCard() { spawnCard = AugmentedStages.elderLemurian, selectionWeight = 3 } };
      minibosses.selectionWeight = 3;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.solusControlUnit, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.grovetender, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    public DirectorCardCategorySelection.Category[] ReworkSirens()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.imp, selectionWeight = 4 }, new DirectorCard() { spawnCard = AugmentedStages.larva, selectionWeight = 4 }, new DirectorCard() { spawnCard = AugmentedStages.vulture, selectionWeight = 4 } };
      basicMonsters.selectionWeight = 4;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.brassContraption, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.gup, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.elderLemurian, selectionWeight = 2 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = AugmentedStages.solusControlUnit, selectionWeight = 2 }, new DirectorCard() { spawnCard = AugmentedStages.impBoss, selectionWeight = 2 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions };
      return newCategories;
    }
  }
}