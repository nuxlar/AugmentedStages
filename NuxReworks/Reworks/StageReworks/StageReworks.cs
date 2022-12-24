using BepInEx;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace NuxReworks
{
  public class StageReworks
  {
    // Spawn Cards
    // Beetle Family
    static SpawnCard beetle = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Beetle/cscBeetle.asset").WaitForCompletion();
    static SpawnCard beetleGuard = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Beetle/cscBeetleGuard.asset").WaitForCompletion();
    static SpawnCard beetleQueen = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Beetle/cscBeetleQueen.asset").WaitForCompletion();

    // Clay Family
    static SpawnCard clayTemplar = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/ClayBruiser/cscClayBruiser.asset").WaitForCompletion();
    static SpawnCard clayApothecary = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/ClayGrenadier/cscClayGrenadier.asset").WaitForCompletion();
    static SpawnCard clayDunestrider = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/ClayBoss/cscClayBoss.asset").WaitForCompletion();

    // Wisp Family
    static SpawnCard lesserWisp = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Wisp/cscLesserWisp.asset").WaitForCompletion();
    static SpawnCard greaterWisp = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/GreaterWisp/cscGreaterWisp.asset").WaitForCompletion();
    static SpawnCard grovetender = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Gravekeeper/cscGravekeeper.asset").WaitForCompletion();

    // Titan family
    static SpawnCard golem = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Golem/cscGolem.asset").WaitForCompletion();
    static SpawnCard titan = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Titan/cscTitanBlackBeach.asset").WaitForCompletion();

    // Lemurian Family
    static SpawnCard lemurian = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Lemurian/cscLemurian.asset").WaitForCompletion();
    static SpawnCard elderLemurian = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/LemurianBruiser/cscLemurianBruiser.asset").WaitForCompletion();

    // Imp Family
    static SpawnCard imp = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Imp/cscImp.asset").WaitForCompletion();
    static SpawnCard impBoss = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/ImpBoss/cscImpBoss.asset").WaitForCompletion();

    // Vermin Family
    static SpawnCard blindVermin = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/Vermin/cscVermin.asset").WaitForCompletion();
    static SpawnCard blindPest = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/FlyingVermin/cscFlyingVermin.asset").WaitForCompletion();

    // Regular Family
    static SpawnCard parent = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Parent/cscParent.asset").WaitForCompletion();
    static SpawnCard grandparent = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Grandparent/cscGrandparent.asset").WaitForCompletion();

    // Roboball Family
    static SpawnCard solusProbes = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/RoboBallBoss/cscRoboBallMini.asset").WaitForCompletion();
    static SpawnCard solusControlUnit = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/RoboBallBoss/cscRoboBallBoss.asset").WaitForCompletion();

    // Jelly Family
    static SpawnCard jellyfish = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard wanderingVagrant = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();

    // Constructs
    static SpawnCard alphaConstruct = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard xiConstruct = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();

    // Misc
    static SpawnCard larva = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/AcidLarva/cscAcidLarva.asset").WaitForCompletion();
    static SpawnCard gup = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard brassContraption = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard bighornBison = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard miniMushrum = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard vulture = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard magmaWorm = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard electricWorm = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    static SpawnCard scav = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Scav/cscScav.asset").WaitForCompletion();

    // Stage Monsters
    // Stage 1
    static DirectorCardCategorySelection roostMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/blackbeach/dccsBlackBeachMonstersDLC.asset").WaitForCompletion();
    static DirectorCardCategorySelection plainsMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/golemplains/dccsGolemplainsMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection forestMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/DLC1/snowyforest/dccsSnowyForestMonstersDLC1.asset").WaitForCompletion();

    // Stage 2
    static DirectorCardCategorySelection aqueductMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/goolake/dccsGooLakeMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection wetlandMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/foggyswamp/dccsFoggySwampMonstersDLC.asset").WaitForCompletion();
    static DirectorCardCategorySelection aphleianMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/DLC1/ancientloft/dccsAncientLoftMonstersDLC1.asset").WaitForCompletion();

    // Stage 3
    static DirectorCardCategorySelection rallypointMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/frozenwall/dccsFrozenWallMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection scorchedMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/wispgraveyard/dccsWispGraveyardMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection sulfurMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/dampcave/dccsDampCaveMonstersDLC1.asset").WaitForCompletion();


    // Stage 4
    static DirectorCardCategorySelection abyssalMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/dampcave/dccsDampCaveMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection groveMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/rootjungle/dccsRootJungleMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection sirenMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/shipgraveyard/dccsShipgraveyardInteractablesDLC1.asset").WaitForCompletion();

    // Stage 5
    static DirectorCardCategorySelection meadowsMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/skymeadow/dccsSkyMeadowMonstersDLC1.asset").WaitForCompletion();

    public void ReworkStages()
    {
      roostMonsters.categories = ReworkStageOne();
      plainsMonsters.categories = ReworkStageOne();
      forestMonsters.categories = ReworkStageOne();

      aqueductMonsters.categories = ReworkStageTwo();
      wetlandMonsters.categories = ReworkStageTwo();
      aphleianMonsters.categories = ReworkStageTwo();

      rallypointMonsters.categories = ReworkStageThree();
      scorchedMonsters.categories = ReworkStageThree();
      sulfurMonsters.categories = ReworkStageThree();

      abyssalMonsters.categories = ReworkStageFour();
      groveMonsters.categories = ReworkStageFour();
      sirenMonsters.categories = ReworkStageFour();

      meadowsMonsters.categories = ReworkStageFive();
    }

    private DirectorCardCategorySelection.Category[] ReworkStageOne()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = beetle, selectionWeight = 2 }, new DirectorCard() { spawnCard = golem, selectionWeight = 2 }, new DirectorCard() { spawnCard = lesserWisp, selectionWeight = 1 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = greaterWisp, selectionWeight = 1 }, new DirectorCard() { spawnCard = beetleGuard, selectionWeight = 1 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = beetleQueen, selectionWeight = 1 }, new DirectorCard() { spawnCard = titan, selectionWeight = 1 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    private DirectorCardCategorySelection.Category[] ReworkStageTwo()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = lemurian, selectionWeight = 2 }, new DirectorCard() { spawnCard = blindVermin, selectionWeight = 2 }, new DirectorCard() { spawnCard = blindPest, selectionWeight = 1 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = greaterWisp, selectionWeight = 1 }, new DirectorCard() { spawnCard = clayTemplar, selectionWeight = 1 }, new DirectorCard() { spawnCard = clayApothecary, selectionWeight = 1 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = clayDunestrider, selectionWeight = 1 }, new DirectorCard() { spawnCard = wanderingVagrant, selectionWeight = 1 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    private DirectorCardCategorySelection.Category[] ReworkStageThree()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = lemurian, selectionWeight = 2 }, new DirectorCard() { spawnCard = solusProbes, selectionWeight = 2 }, new DirectorCard() { spawnCard = jellyfish, selectionWeight = 1 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = bighornBison, selectionWeight = 1 }, new DirectorCard() { spawnCard = brassContraption, selectionWeight = 1 }, new DirectorCard() { spawnCard = miniMushrum, selectionWeight = 1 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = solusControlUnit, selectionWeight = 1 }, new DirectorCard() { spawnCard = magmaWorm, selectionWeight = 1 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    private DirectorCardCategorySelection.Category[] ReworkStageFour()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = imp, selectionWeight = 2 }, new DirectorCard() { spawnCard = vulture, selectionWeight = 2 }, new DirectorCard() { spawnCard = alphaConstruct, selectionWeight = 1 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = elderLemurian, selectionWeight = 1 }, new DirectorCard() { spawnCard = gup, selectionWeight = 1 }, new DirectorCard() { spawnCard = brassContraption, selectionWeight = 1 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = impBoss, selectionWeight = 1 }, new DirectorCard() { spawnCard = xiConstruct, selectionWeight = 1 }, new DirectorCard() { spawnCard = grovetender, selectionWeight = 1 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }

    private DirectorCardCategorySelection.Category[] ReworkStageFive()
    {
      DirectorCardCategorySelection.Category basicMonsters = new DirectorCardCategorySelection.Category();
      basicMonsters.name = "Basic Monsters";
      basicMonsters.cards = new DirectorCard[] { new DirectorCard() { spawnCard = imp, selectionWeight = 2 }, new DirectorCard() { spawnCard = vulture, selectionWeight = 2 }, new DirectorCard() { spawnCard = larva, selectionWeight = 1 } };
      basicMonsters.selectionWeight = 3;
      DirectorCardCategorySelection.Category minibosses = new DirectorCardCategorySelection.Category();
      minibosses.name = "Minibosses";
      minibosses.cards = new DirectorCard[] { new DirectorCard() { spawnCard = parent, selectionWeight = 1 }, new DirectorCard() { spawnCard = elderLemurian, selectionWeight = 1 }, new DirectorCard() { spawnCard = brassContraption, selectionWeight = 1 } };
      minibosses.selectionWeight = 2;
      DirectorCardCategorySelection.Category champions = new DirectorCardCategorySelection.Category();
      champions.name = "Champions";
      champions.cards = new DirectorCard[] { new DirectorCard() { spawnCard = grandparent, selectionWeight = 1 }, new DirectorCard() { spawnCard = electricWorm, selectionWeight = 1 }, new DirectorCard() { spawnCard = scav, selectionWeight = 1 } };
      champions.selectionWeight = 2;
      DirectorCardCategorySelection.Category special = new DirectorCardCategorySelection.Category();
      special.name = "Special";
      special.cards = new DirectorCard[] { new DirectorCard() { spawnCard = scav, selectionWeight = 1 } };
      special.selectionWeight = 1;
      DirectorCardCategorySelection.Category[] newCategories = { basicMonsters, minibosses, champions, special };
      return newCategories;
    }
  }
}