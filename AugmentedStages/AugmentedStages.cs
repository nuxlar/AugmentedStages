using BepInEx;
using RoR2;
using UnityEngine.AddressableAssets;

namespace AugmentedStages
{
  [BepInPlugin("com.Nuxlar.AugmentedStages", "AugmentedStages", "1.1.1")]

  public class AugmentedStages : BaseUnityPlugin
  {
    // Spawn Cards
    // Beetle Family
    public static SpawnCard beetle = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Beetle/cscBeetle.asset").WaitForCompletion();
    public static SpawnCard beetleGuard = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Beetle/cscBeetleGuard.asset").WaitForCompletion();
    public static SpawnCard beetleQueen = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Beetle/cscBeetleQueen.asset").WaitForCompletion();

    // Clay Family
    public static SpawnCard clayTemplar = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/ClayBruiser/cscClayBruiser.asset").WaitForCompletion();
    public static SpawnCard clayApothecary = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/ClayGrenadier/cscClayGrenadier.asset").WaitForCompletion();
    public static SpawnCard clayDunestrider = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/ClayBoss/cscClayBoss.asset").WaitForCompletion();

    // Wisp Family
    public static SpawnCard lesserWisp = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Wisp/cscLesserWisp.asset").WaitForCompletion();
    public static SpawnCard greaterWisp = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/GreaterWisp/cscGreaterWisp.asset").WaitForCompletion();
    public static SpawnCard grovetender = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Gravekeeper/cscGravekeeper.asset").WaitForCompletion();

    // Titan family
    public static SpawnCard golem = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Golem/cscGolem.asset").WaitForCompletion();
    public static SpawnCard titan = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Titan/cscTitanBlackBeach.asset").WaitForCompletion();

    // Lemurian Family
    public static SpawnCard lemurian = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Lemurian/cscLemurian.asset").WaitForCompletion();
    public static SpawnCard elderLemurian = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/LemurianBruiser/cscLemurianBruiser.asset").WaitForCompletion();

    // Imp Family
    public static SpawnCard imp = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Imp/cscImp.asset").WaitForCompletion();
    public static SpawnCard impBoss = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/ImpBoss/cscImpBoss.asset").WaitForCompletion();

    // Vermin Family
    public static SpawnCard blindVermin = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/Vermin/cscVermin.asset").WaitForCompletion();
    public static SpawnCard blindPest = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/FlyingVermin/cscFlyingVermin.asset").WaitForCompletion();

    // Regular Family
    public static SpawnCard parent = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Parent/cscParent.asset").WaitForCompletion();
    public static SpawnCard grandparent = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Grandparent/cscGrandparent.asset").WaitForCompletion();

    // Roboball Family
    public static SpawnCard solusProbes = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/RoboBallBoss/cscRoboBallMini.asset").WaitForCompletion();
    public static SpawnCard solusControlUnit = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/RoboBallBoss/cscRoboBallBoss.asset").WaitForCompletion();

    // Jelly Family
    public static SpawnCard jellyfish = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Jellyfish/cscJellyfish.asset").WaitForCompletion();
    public static SpawnCard wanderingVagrant = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vagrant/cscVagrant.asset").WaitForCompletion();

    // Constructs
    public static SpawnCard alphaConstruct = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/MajorAndMinorConstruct/cscMinorConstruct.asset").WaitForCompletion();
    public static SpawnCard xiConstruct = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/MajorAndMinorConstruct/cscMegaConstruct.asset").WaitForCompletion();

    // Misc
    public static SpawnCard larva = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/AcidLarva/cscAcidLarva.asset").WaitForCompletion();
    public static SpawnCard gup = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/Gup/cscGupBody.asset").WaitForCompletion();
    public static SpawnCard brassContraption = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Bell/cscBell.asset").WaitForCompletion();
    public static SpawnCard bighornBison = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Bison/cscBison.asset").WaitForCompletion();
    public static SpawnCard miniMushrum = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/MiniMushroom/cscMiniMushroom.asset").WaitForCompletion();
    public static SpawnCard vulture = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Vulture/cscVulture.asset").WaitForCompletion();
    public static SpawnCard magmaWorm = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/MagmaWorm/cscMagmaWorm.asset").WaitForCompletion();
    public static SpawnCard electricWorm = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/ElectricWorm/cscElectricWorm.asset").WaitForCompletion();
    public static SpawnCard scav = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Scav/cscScav.asset").WaitForCompletion();
    public static SpawnCard jailer = Addressables.LoadAssetAsync<SpawnCard>("RoR2/DLC1/VoidJailer/cscVoidJailer.asset").WaitForCompletion();
    public static SpawnCard reaver = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/Nullifier/cscNullifier.asset").WaitForCompletion();
    public static SpawnCard hermitCrab = Addressables.LoadAssetAsync<SpawnCard>("RoR2/Base/HermitCrab/cscHermitCrab.asset").WaitForCompletion();

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
    static DirectorCardCategorySelection sulfurMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/DLC1/sulfurpools/dccsSulfurPoolsMonstersDLC1.asset").WaitForCompletion();


    // Stage 4
    static DirectorCardCategorySelection abyssalMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/dampcave/dccsDampCaveMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection groveMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/rootjungle/dccsRootJungleMonstersDLC1.asset").WaitForCompletion();
    static DirectorCardCategorySelection sirenMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/shipgraveyard/dccsShipgraveyardMonstersDLC1.asset").WaitForCompletion();

    // Stage 5
    static DirectorCardCategorySelection meadowsMonsters = Addressables.LoadAssetAsync<DirectorCardCategorySelection>("RoR2/Base/skymeadow/dccsSkyMeadowMonstersDLC1.asset").WaitForCompletion();

    public void Awake()
    {
      ReworkStages();
    }

    // check each stage's enemies
    public void ReworkStages()
    {
      Stage1 stage1Reworks = new();
      roostMonsters.categories = stage1Reworks.ReworkRoost();
      plainsMonsters.categories = stage1Reworks.ReworkPlains();
      forestMonsters.categories = stage1Reworks.ReworkForest();

      Stage2 stage2Reworks = new();
      aqueductMonsters.categories = stage2Reworks.ReworkAqueduct();
      wetlandMonsters.categories = stage2Reworks.ReworkWetland();
      aphleianMonsters.categories = stage2Reworks.ReworkAphelian();

      Stage3 stage3Reworks = new();
      rallypointMonsters.categories = stage3Reworks.ReworkRallypoint();
      scorchedMonsters.categories = stage3Reworks.ReworkAcres();
      sulfurMonsters.categories = stage3Reworks.ReworkPools();

      Stage4 stage4Reworks = new();
      abyssalMonsters.categories = stage4Reworks.ReworkAbyssal();
      groveMonsters.categories = stage4Reworks.ReworkGrove();
      sirenMonsters.categories = stage4Reworks.ReworkSirens();

      Stage5 stage5Reworks = new();
      meadowsMonsters.categories = stage5Reworks.ReworkMeadows();
    }
  }
}
// Default Stage values
// Roost
// Monsters
// Lemurian 4, Lesser Wisp 4, Beetle 4, Jellyfish 4
// Minibosses
// Golem 2, Greater Wisp 2
// Champions
// Titan 2, Beetle Queen 2, Vagrant 2
// Special
// Scav 1

// Plains
// Monsters
// Lemurian 4, Lesser Wisp 4, Beetle 4, Alpha Construct 4, Hermit Crab 4, Jellyfish 4
// Minibosses
// Golem 2, Greater Wisp 2
// Champions
// Titan 2, Beetle Queen 2, Vagrant 2, Xi Construct 2
// Special
// Scav 1

// Forest
// Monsters
// Lemurian 4, Lesser Wisp 4, Flying Vermin 4, Vermin 4
// Minibosses
// Golem 2, Greater Wisp 2, Nullifier 2
// Champions
// Titan 2, Beetle Queen 2, Vagrant 2
// Special
// Scav 1

// Aqueduct
// Monsters
// Lemurian 3, Lesser Wisp 3, Beetle 3
// Minibosses
// Greater Wisp 2, Beetle Guard 2, Apothecary 2, Templar 2
// Champions
// Titan 2, Beetle Queen 2, Dunestrider 2
// Special
// Scav 1

// Wetlands
// Monsters
// Lemurian 4, Lesser Wisp 4, Jellyfish 4, Beetle 4
// Minibosses
// Golem 2, Bell 2, Gup 2
// Champions
// Titan 2, Beetle Queen 2, Vagrant 2
// Special
// Scav 1

// Aphleian
// Monsters
// Lemurian 3, Beetle 3, Flying Vermin 3, Vermin 3
// Minibosses
// Apothecary 3, Templar 3
// Champions
// Dunestrider 2, Beetle Queen 2, Vagrant 2
// Special
// Scav 1

// Rallypoint Delta
// Monsters
// Flying Vermin 3, Vermin 3, Imp 3
// Minibosses
// Greater Wisp 3, Golem 3, Bison 3
// Champions
// Imp Overlord 2, Magma Worm 2, Dunestrider 2, Electric Worm 2
// Special
// Scav 1

// Scorched Acres
// Monsters
// Beetle 3, Lesser Wisp 3, Vulture 3, Imp 3
// Minibosses
// Beetle Guard 3, Greater Wisp 3, Templar 3
// Champions
// Imp Overlord 2, Dunestrider 2, Grovetender 2
// Special
// Scav 1

// Sulfur Pools
// Monsters
// Alpha Construct 3, Beetle 3, Flying Vermin 3, Vermin 3
// Minibosses
// Beetle Guard 2, Greater Wisp 2, Templar 2
// Champions
// Dunestrider 2, Xi Construct 2, Beetle Queen 2
// Special
// Scav 1

// Abyssal
// Monsters
// Hermit Crab 3, Lemurian 3, Imp 3
// Minibosses
// Bell 3, Gup 3, Elder Lemurian 3
// Champions
// Imp Overlord 2, Magma Worm 2, Titan 2, Electric Worm 2
// Special
// Scav 1

// Grove
// Monsters
// Jellyfish 3, Larva 3, MiniMushroom 3
// Minibosses
// Golem 3, Greater Wisp 3, Gup 3
// Champions
// Vagrant 2, Dunestrider 2, Titan 2
// Special
// Scav 1

// Sirens
// Monsters
// Jellyfish 4, Larva 4, Vulture 4
// Minibosses
// Bell 2, Greater Wisp 2, Elder Lemurian 2
// Champions
// Vagrant 2, Solus Control Unit 2, Magma Worm 2
// Special
// Scav 1

// Meadows
// Monsters
// MiniMushroom 3, Lesser Wisp 3, Bell 3, Alpha Construct 3
// Minibosses
// Greater Wisp 2, Parent 2, Gup 2, Elder Lemurian 2
// Champions
// Solus Control Unit 2, Xi Construct 2, Grandparent 2, Electric Worm 2
// Special
// Scav 1