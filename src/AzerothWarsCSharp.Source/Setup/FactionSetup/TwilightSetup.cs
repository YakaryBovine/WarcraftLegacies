using AzerothWarsCSharp.MacroTools.FactionSystem;

namespace AzerothWarsCSharp.Source.Setup.FactionSetup
{
  public static class TwilightSetup{
    public static Faction FACTION_TWILIGHT { get; private set; }
  

    public static void Setup( ){
      Faction f;

      FACTION_TWILIGHT = Faction.create("Twilight", PLAYER_COLOR_LAVENDER, "|cff9178a8","ReplaceableTextures\\CommandButtons\\BTNChogall.blp");
      f = FACTION_TWILIGHT;
      f.Team = TEAM_OLDGOD;
      f.StartingGold = 150;
      f.StartingLumber = 350;

      f.ModObjectLimit(FourCC("o039"), Faction.UNLIMITED)   ;//Great Hall
      f.ModObjectLimit(FourCC("o03A"), Faction.UNLIMITED)   ;//Stronghold
      f.ModObjectLimit(FourCC("o03B"), Faction.UNLIMITED)   ;//Fortress
      f.ModObjectLimit(FourCC("o03C"), Faction.UNLIMITED)   ;//Altar of Storms
      f.ModObjectLimit(FourCC("o03D"), Faction.UNLIMITED)   ;//Barracks
      f.ModObjectLimit(FourCC("o03J"), Faction.UNLIMITED)   ;//War Mill
      f.ModObjectLimit(FourCC("o03E"), Faction.UNLIMITED)   ;//Spirit Lodge
      f.ModObjectLimit(FourCC("o03F"), Faction.UNLIMITED)   ;//Bestiary
      f.ModObjectLimit(FourCC("o03I"), Faction.UNLIMITED)   ;//Shipyard
      f.ModObjectLimit(FourCC("o03G"), Faction.UNLIMITED)   ;//Watch Tower
      f.ModObjectLimit(FourCC("o03H"), Faction.UNLIMITED)   ;//Improved Watch Tower
      f.ModObjectLimit(FourCC("u00Y"), Faction.UNLIMITED)   ;//Shop
      f.ModObjectLimit(FourCC("o03K"), Faction.UNLIMITED)   ;//Burrow

      f.ModObjectLimit(FourCC("n051"), 4)           ;//Black Drake
      f.ModObjectLimit(FourCC("o04J"), 8)           ;//WindRider
      f.ModObjectLimit(FourCC("n07X"), Faction.UNLIMITED)   ;//Fel Orc Warlock
      f.ModObjectLimit(FourCC("o01H"), Faction.UNLIMITED)   ;//Fel Orc Grunt
      f.ModObjectLimit(FourCC("o04B"), Faction.UNLIMITED)   ;//Fel Orc Peon
      f.ModObjectLimit(FourCC("n083"), Faction.UNLIMITED)   ;//Horde Cavarly
      f.ModObjectLimit(FourCC("o04I"), 6)           ;//Executioner
      f.ModObjectLimit(FourCC("o04K"), 6)           ;//Demolisher
      f.ModObjectLimit(FourCC("n09O"), 6)           ;//DK
      f.ModObjectLimit(FourCC("u01T"), Faction.UNLIMITED)   ;//Necrolyte
      f.ModObjectLimit(FourCC("n087"), Faction.UNLIMITED)   ;//Phase Grenadier
      f.ModObjectLimit(FourCC("obot"), 12)  	    ;//Transport Ship
      f.ModObjectLimit(FourCC("odes"), 12)  	    ;//Orc Frigate
      f.ModObjectLimit(FourCC("ojgn"), 6)          ;//Juggernaught

      f.ModObjectLimit(FourCC("O01P"), 1)           ;//Chogall
      f.ModObjectLimit(FourCC("H08Q"), 1)           ;//Azil
      f.ModObjectLimit(FourCC("U01S"), 1)           ;//Feludius
      f.ModObjectLimit(FourCC("O04H"), 1)           ;//ignacius


      f.ModObjectLimit(FourCC("R023"), Faction.UNLIMITED)   ;//Spiritual Infusion
      f.ModObjectLimit(FourCC("Rosp"), Faction.UNLIMITED)   ;//Spiked Barricades
      f.ModObjectLimit(FourCC("R06X"), Faction.UNLIMITED)   ;//Magic Training
      f.ModObjectLimit(FourCC("R06Z"), Faction.UNLIMITED)   ;//Herald Training



    }

  }
}
