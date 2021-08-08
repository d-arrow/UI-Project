using System.Linq;
using System.Collections.Generic;

using SingleplayerLauncher.Names;

namespace SingleplayerLauncher.Resources
{
    internal static class GameInfo
    {

        public class Map
        {
            public string Name;
            public string[] SurvivalDifficulties;
            public Map(string name, string[] survivalDifficulties)
            {
                Name = name;
                SurvivalDifficulties = survivalDifficulties;
            }
        }

        public class Hero
        {
            public string Name;
            public Dictionary<string, Skin> Skins;
            public int BaseHealth;
            public Hero(string name, Dictionary<string, Skin> skins, int baseHealth)
            {
                Name = name;
                Skins = skins;
                BaseHealth = baseHealth;
            }

            public byte[] GetSkinHex(string skinName)
            {
                return Skins[skinName].HexSpitfireGameUPK;
            }
        }

        public class Skin
        {
            public string Name;
            public byte[] HexSpitfireGameUPK;
            public Skin(string name, byte[] hexSpitfireGameUPK)
            {
                Name = name;
                HexSpitfireGameUPK = hexSpitfireGameUPK;
            }
        }

        public static readonly Dictionary<string, Hero> Heroes = new Dictionary<string, Hero>
        {
            { HeroNames.BIONKA, new Hero( HeroNames.BIONKA, new Dictionary<string, Skin> {
                                                        { "Default", new Skin("Default", new byte[] { 0x54, 0xDF, 0x00, 0x00 } ) },
                                                        { "Lizard Queen", new Skin("Lizard Queen", new byte[] { 0x56, 0xDF, 0x00, 0x00 } ) },
                                                        { "Fluffalump", new Skin("Fluffalump", new byte[] { 0x58, 0xDF, 0x00, 0x00 } ) },
                                                        { "Bionka Bunny", new Skin("Bionka Bunny", new byte[] { 0x5A, 0xDF, 0x00, 0x00 } ) }
            }, 625)},
            { HeroNames.BLACKPAW, new Hero(HeroNames.BLACKPAW, null, 341) },
            { HeroNames.BLOODSPIKE, new Hero(HeroNames.BLOODSPIKE, null, 600) },
            { HeroNames.BRASS, new Hero( HeroNames.BRASS, null, 350) },
            { HeroNames.CYGNUS, new Hero(HeroNames.CYGNUS, null, 215) },
            { HeroNames.DEADEYE, new Hero(HeroNames.DEADEYE, null, 219) },
            { HeroNames.DOBBIN, new Hero(HeroNames.DOBBIN, null, 500) },
            { HeroNames.GABRIELLA, new Hero( HeroNames.GABRIELLA, new Dictionary<string, Skin> {
                                                        { "Violent Vintage", new Skin("Violent Vintage", new byte[] { 0x02, 0xE0, 0x00, 0x00 } ) },
                                                        { "Enchanted Armor", new Skin("Enchanted Armor", new byte[] { 0x04, 0xE0, 0x00, 0x00 } ) },
                                                        { "Blood Queen", new Skin("Blood Queen", new byte[] { 0x06, 0xE0, 0x00, 0x00 } ) },
                                                        { "Default", new Skin("Default", new byte[] { 0x08, 0xE0, 0x00, 0x00 } ) },
                                                        { "Frightfully Delightful", new Skin("Frightfully Delightful", new byte[] { 0x0A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Default (Red)", new Skin("Default (Red)", new byte[] { 0x0C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Life In Plastic", new Skin("Life In Plastic", new byte[] { 0x0E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Archmage of the Order", new Skin("Archmage of the Order", new byte[] { 0x10, 0xE0, 0x00, 0x00 } ) },
                                                        { "Mistress of Illusion", new Skin("Mistress of Illusion", new byte[] { 0x12, 0xE0, 0x00, 0x00 } ) },
                                                        { "Promising Prodigy", new Skin("Promising Prodigy", new byte[] { 0x14, 0xE0, 0x00, 0x00 } ) },
                                                        { "I Dream of Gabby", new Skin("I Dream of Gabby", new byte[] { 0x16, 0xE0, 0x00, 0x00 } ) },
                                                        { "Miracle Worker", new Skin("Miracle Worker", new byte[] { 0x18, 0xE0, 0x00, 0x00 } ) },
                                                        { "Winter Witch", new Skin("Winter Witch", new byte[] { 0x1A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Skull Ninja", new Skin("Skull Ninja", new byte[] { 0x1C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Evil Ways", new Skin("Evil Ways", new byte[] { 0x1E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Dragon Charmer", new Skin("Dragon Charmer", new byte[] { 0x20, 0xE0, 0x00, 0x00 } ) },
                                                        { "Chang'e", new Skin("Chang'e", new byte[] { 0x80, 0xDF, 0x00, 0x00 } ) }
            }, 200)},
            { HeroNames.HOGARTH, new Hero( HeroNames.HOGARTH, new Dictionary<string, Skin> {
                                                        { "Enchanted Armor", new Skin("Enchanted Armor", new byte[] { 0x8C, 0xDF, 0x00, 0x00 } ) },
                                                        { "God of Plunder", new Skin("God of Plunder", new byte[] { 0x8E, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default", new Skin("Default", new byte[] { 0x90, 0xDF, 0x00, 0x00 } ) },
                                                        { "Lumbering Jack", new Skin("Lumbering Jack", new byte[] { 0x92, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default (with some gold)", new Skin("Default (with some gold)", new byte[] { 0x94, 0xDF, 0x00, 0x00 } ) },
                                                        { "Ice Armor", new Skin("Ice Armor", new byte[] { 0x96, 0xDF, 0x00, 0x00 } ) },
                                                        { "Imperial Golden Warrior", new Skin("Imperial Golden Warrior", new byte[] { 0x98, 0xDF, 0x00, 0x00 } ) },
                                                        { "Beached Bod", new Skin("Beached Bod", new byte[] { 0x9A, 0xDF, 0x00, 0x00 } ) },
                                                        //{ "*crashed*", new Skin("*crashed*", new byte[] { 0x9C, 0xDF, 0x00, 0x00 } ) },
                                                        { "Black Thane", new Skin("Black Thane", new byte[] { 0x9E, 0xDF, 0x00, 0x00 } ) },
                                                        { "The Schling", new Skin("The Schling", new byte[] { 0xA0, 0xDF, 0x00, 0x00 } ) },
                                                        { "Dragon Ward", new Skin("Dragon Ward", new byte[] { 0xA2, 0xDF, 0x00, 0x00 } ) }
            }, 950)},
            { HeroNames.IVY, new Hero( HeroNames.IVY, new Dictionary<string, Skin> {
                                                        { "Enchanted Armor", new Skin("Enchanted Armor", new byte[] { 0xDA, 0xDF, 0x00, 0x00 } ) },
                                                        { "Valkyrie", new Skin("Valkyrie", new byte[] { 0xDC, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default", new Skin("Default", new byte[] { 0xDE, 0xDF, 0x00, 0x00 } ) },
                                                        { "Flower Friend", new Skin("Flower Friend", new byte[] { 0xE0, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default (with some gold)", new Skin("Default (with some gold)", new byte[] { 0xE2, 0xDF, 0x00, 0x00 } ) },
                                                        { "Imperial Ruby Archer", new Skin("Imperial Ruby Archer", new byte[] { 0xE4, 0xDF, 0x00, 0x00 } ) },
                                                        //{ "*crashed*", new Skin("*crashed*", new byte[] { 0xE6, 0xDF, 0x00, 0x00 } ) },
                                                        { "Wicked Warden", new Skin("Wicked Warden", new byte[] { 0xE8, 0xDF, 0x00, 0x00 } ) },
                                                        { "Grovewatch", new Skin("Grovewatch", new byte[] { 0xEA, 0xDF, 0x00, 0x00 } ) },
                                                        { "Dragon Tamer", new Skin("Dragon Tamer", new byte[] { 0xEC, 0xDF, 0x00, 0x00 } ) }
            }, 162)},
            { HeroNames.MAXIMILIAN, new Hero(HeroNames.MAXIMILIAN, new Dictionary<string, Skin> {
                                                        { "Lucky Tunic" , new Skin("Lucky Tunic" , new byte[] { 0x4A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Enchanted Armor" , new Skin("Enchanted Armor" , new byte[] { 0x4C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Knight's Watch" , new Skin("Knight's Watch" , new byte[] { 0x4E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Default" , new Skin("Default" , new byte[] { 0x50, 0xE0, 0x00, 0x00 } ) },
                                                        { "Orc Slayer" , new Skin("Orc Slayer" , new byte[] { 0x52, 0xE0, 0x00, 0x00 } ) },
                                                        { "Cardboard Samurai" , new Skin("Cardboard Samurai" , new byte[] { 0x54, 0xE0, 0x00, 0x00 } ) },
                                                        { "Scared-Crow" , new Skin("Scared-Crow" , new byte[] { 0x56, 0xE0, 0x00, 0x00 } ) },
                                                        { "Lion Heart" , new Skin("Lion Heart" , new byte[] { 0x58, 0xE0, 0x00, 0x00 } ) },
                                                        { "Robin Hood" , new Skin("Robin Hood" , new byte[] { 0x5A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Paximillian" , new Skin("Paximillian" , new byte[] { 0x5C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Legendary (default)" , new Skin("Legendary (default)" , new byte[] { 0x5E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Champion of the Order" , new Skin("Champion of the Order" , new byte[] { 0x60, 0xE0, 0x00, 0x00 } ) },
                                                        { "Jamez Ripher" , new Skin("Jamez Ripher" , new byte[] { 0x62, 0xE0, 0x00, 0x00 } ) },
                                                        { "Winter Warrior" , new Skin("Winter Warrior" , new byte[] { 0x64, 0xE0, 0x00, 0x00 } ) },
                                                        { "Boomstick" , new Skin("Boomstick" , new byte[] { 0x66, 0xE0, 0x00, 0x00 } ) },
                                                        { "Backdraft" , new Skin("Backdraft" , new byte[] { 0x68, 0xE0, 0x00, 0x00 } ) },
                                                        { "Dragon Slayer" , new Skin("Dragon Slayer" , new byte[] { 0x6A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Summer of Stunning" , new Skin("Summer of Stunning" , new byte[] { 0x6C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Red Scarf (China Ad)" , new Skin("Red Scarf (China Ad)" , new byte[] { 0x6E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Yellow Scarf (China Ad)" , new Skin("Yellow Scarf (China Ad)" , new byte[] { 0x70, 0xE0, 0x00, 0x00 } ) },
                                                        { "Blue Scarf (China Ad)" , new Skin("Blue Scarf (China Ad)" , new byte[] { 0x72, 0xE0, 0x00, 0x00 } ) }
            }, 206)},
            { HeroNames.MIDNIGHT, new Hero(HeroNames.MIDNIGHT, null, 220) },
            { HeroNames.OZIEL, new Hero(HeroNames.OZIEL, null, 200) },
            { HeroNames.SMOLDER, new Hero( HeroNames.SMOLDER, new Dictionary<string, Skin> {
                                                        { "Default", new Skin("Default", new byte[] { 0xF2, 0xDF, 0x00, 0x00 } ) },
                                                        { "Helter Swelter", new Skin("Helter Swelter", new byte[] { 0xF4, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default (White hair)", new Skin("Default (White hair)", new byte[] { 0xF6, 0xDF, 0x00, 0x00 } ) },
                                                        { "Elite", new Skin("Elite", new byte[] { 0xF8, 0xDF, 0x00, 0x00 } ) },
                                                        { "Kill-auea", new Skin("Kill-auea", new byte[] { 0xFA, 0xDF, 0x00, 0x00 } ) },
                                                        { "Fire-Alarm Femme", new Skin("Fire-Alarm Femme", new byte[] { 0xFC, 0xDF, 0x00, 0x00 } ) },
                                                        { "Firestarter", new Skin("Firestarter", new byte[] { 0xFE, 0xDF, 0x00, 0x00 } ) },
                                                        { "Wu Xing Dragon Mage", new Skin("Wu Xing Dragon Mage", new byte[] { 0x00, 0xE0, 0x00, 0x00 } ) }
            }, 313)},
            { HeroNames.STINKEYE, new Hero(HeroNames.STINKEYE, null, 356) },
            { HeroNames.TEMPER, new Hero(HeroNames.TEMPER, null, 500) },
            { HeroNames.TUNDRA, new Hero(HeroNames.TUNDRA, null, 625) },
            { HeroNames.YILIN, new Hero(HeroNames.YILIN, null, 250) },
            { HeroNames.ZOEY, new Hero(HeroNames.ZOEY, null, 275) }
        };

        public static readonly Dictionary<string, string[]> Maps = new Dictionary<string, string[]>
        {
            { MapNames.ACADEMY_SEWERS,      new string[] { DifficultyNames.RIFT_LORD.Key } },
            { MapNames.ARCHMAGE_LIBRARY,    new string[] { DifficultyNames.APPRENTICE.Key } },
            { MapNames.AVALANCHE,           new string[] { DifficultyNames.MASTER.Key,      DifficultyNames.RIFT_LORD.Key } },
            { MapNames.BANQUET_HALL,        new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.WAR_MAGE.Key,   DifficultyNames.RIFT_LORD.Key } },
            { MapNames.CASTLE_GATES,        new string[] { DifficultyNames.MASTER.Key,      DifficultyNames.RIFT_LORD.Key } },
            { MapNames.CLIFFSIDE_CLASH,     new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.MASTER.Key } },
            { MapNames.CONFLUENCE,          new string[] { DifficultyNames.RIFT_LORD.Key } },
            { MapNames.CROGON_KEEP,         new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.MASTER.Key,     DifficultyNames.RIFT_LORD.Key } },
            { MapNames.DOCKS_AT_EVENTIDE,   new string[] { DifficultyNames.MASTER.Key } },
            { MapNames.EVENTIDE_FORTRESS,   new string[] { DifficultyNames.RIFT_LORD.Key } },
            { MapNames.EVENTIDE_RAMPARTS,   new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.WAR_MAGE.Key } },
            { MapNames.FROSTBITE,           new string[] { DifficultyNames.MASTER.Key,      DifficultyNames.RIFT_LORD.Key } },
            { MapNames.GATES_OF_THURICVOD,  new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.RIFT_LORD.Key } },
            { MapNames.HIGHLANDS,           new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.WAR_MAGE.Key,   DifficultyNames.RIFT_LORD.Key } },
            { MapNames.MAXIMUM_SECURITY,    new string[] { DifficultyNames.RIFT_LORD.Key } },
            { MapNames.MIDNIGHT_MARKET,     new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.RIFT_LORD.Key } },
            { MapNames.ORCATRAZ,            new string[] { DifficultyNames.MASTER.Key } },
            { MapNames.ORCRI_LA,            new string[] { DifficultyNames.MASTER.Key } },
            { MapNames.RESTRICTED_SECTION,  new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.RIFT_LORD.Key } },
            { MapNames.RIFTMAKERS_TEMPLE,   new string[] { DifficultyNames.APPRENTICE.Key } },
            { MapNames.SHARK_ISLAND,        new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.MASTER.Key } },
            { MapNames.STABLES_AT_EVENTIDE, new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.MASTER.Key } },
            { MapNames.STORM_DRAIN,         new string[] { DifficultyNames.MASTER.Key } },
            { MapNames.TEMPLE_GRAVEYARD,    new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.RIFT_LORD.Key } },
            { MapNames.THE_BATHS,           new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.RIFT_LORD.Key } },
            { MapNames.THE_FALLING_FOLLY,   new string[] { DifficultyNames.MASTER.Key } },
            { MapNames.THE_WALL,            new string[] { DifficultyNames.WAR_MAGE.Key,    DifficultyNames.MASTER.Key } },
            { MapNames.THRONE_ROOM,         new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.WAR_MAGE.Key,   DifficultyNames.RIFT_LORD.Key } },
            { MapNames.THURICVOD_VILLAGE,   new string[] { DifficultyNames.WAR_MAGE.Key } },
            { MapNames.TRAINING_GROUNDS,    new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.WAR_MAGE.Key,   DifficultyNames.MASTER.Key } },
            { MapNames.UNCHAINED_FORTRESS,  new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.MASTER.Key } },
            { MapNames.WATER_GARDEN,        new string[] { DifficultyNames.APPRENTICE.Key,  DifficultyNames.MASTER.Key } }
        };

        public static readonly List<string> startingCoin9000Maps = Entities.Map.Maps.Where(x => x.StartingCoin == Entities.Map._9000_COIN).Select(y => y.Name).ToList();

        public static readonly List<string> startingCoin6000Maps = Entities.Map.Maps.Where(x => x.StartingCoin == Entities.Map._6000_COIN).Select(y => y.Name).ToList();

        public static readonly Dictionary<string, int> DifficultyTrapTierMap = new Dictionary<string, int>
        {
            { DifficultyNames.APPRENTICE.Key,  DifficultyNames.APPRENTICE.Value },
            { DifficultyNames.WAR_MAGE.Key, DifficultyNames.WAR_MAGE.Value },
            { DifficultyNames.MASTER.Key, DifficultyNames.MASTER.Value },
            { DifficultyNames.RIFT_LORD.Key, DifficultyNames.RIFT_LORD.Value }
        };
    }
}
