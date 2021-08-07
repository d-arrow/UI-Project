using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SingleplayerLauncher.Names.Map;
using System.Drawing;

namespace SingleplayerLauncher.Entities
{
    public class Map
    {
        private const int _6000_COIN = 6000;
        private const int _9000_COIN = 9000;

        public string Name { get; private set; }
        public string UmapCode { get; private set; }
        public int StartingCoin { get; private set; } = _9000_COIN;
        public Image MiniMapResource { get; private set; }



    // pictureBox1.Image = Properties.Resources
    //pictureBox1.Image = Properties.Resources.MiniMap_PvE_TrainingGrounds;

    // private constructor
    Map() { }

        // static members
        public static Map AcademySewers = new Map()
        {
            Name = ACADEMY_SEWERS,
            UmapCode = "PvE_Sewers.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Sewers,
        };
        public static Map ArchmageLibrary = new Map()
        {
            Name = ARCHMAGE_LIBRARY,
            UmapCode = "PvE_AcademyLibrary.umap",
            MiniMapResource = Properties.Resources.MiniMap_NPE_2,
        };
        public static Map Avalanche = new Map()
        {
            Name = AVALANCHE,
            UmapCode = "PvE_Avalanche.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Avalanche,
        };
        public static Map BanquetHall = new Map()
        {
            Name = BANQUET_HALL,
            UmapCode = "PvE_BanquetHall.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_BanquetHall,
        };
        public static Map CastleGates = new Map()
        {
            Name = CASTLE_GATES,
            UmapCode = "PvE_ASN_CastleGates.umap",
            StartingCoin = _6000_COIN,
            MiniMapResource = Properties.Resources.Castle_Gates_minimap, //REPLACE THIS IMAGE?????????????
        };
        public static Map CliffsideClash = new Map()
        {
            Name = CLIFFSIDE_CLASH,
            UmapCode = "PvE_2Lane.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_2Lane,
        };
        public static Map Confluence = new Map()
        {
            Name = CONFLUENCE,
            UmapCode = "PvE_AcademyCanals.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_AcademyCanals,
        };
        public static Map CrogonKeep = new Map()
        {
            Name = CROGON_KEEP,
            UmapCode = "PvE_CrogonKeep.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_CrogonKeep,
        };
        public static Map DocksAtEventide = new Map()
        {
            Name = DOCKS_AT_EVENTIDE,
            UmapCode = "PvE_SUR_Pirates.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_SUR_Pirates,
        };
        public static Map EventideFortress = new Map()
        {
            Name = EVENTIDE_FORTRESS,
            UmapCode = "PvE_Surrounded.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Surrounded,
        };
        public static Map EventideRamparts = new Map()
        {
            Name = EVENTIDE_RAMPARTS,
            UmapCode = "PvE_SUR_NorthernClans.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_SUR_NorthernClans,
        };
        public static Map Frostbite = new Map()
        {
            Name = FROSTBITE,
            UmapCode = "PvE_FrostBite.umap",
            MiniMapResource = Properties.Resources.Minimap_PvE_FrostBite,
        };
        public static Map GatesOfThuricvod = new Map()
        {
            Name = GATES_OF_THURICVOD,
            UmapCode = "PvE_Corridors.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Corridors,
        };
        public static Map Highlands = new Map()
        {
            Name = HIGHLANDS,
            UmapCode = "PvE_Highlands.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Highlands,
        };
        public static Map MaximumSecurity = new Map()
        {
            Name = MAXIMUM_SECURITY,
            UmapCode = "PvE_AcademyDungeon.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_AcademyDungeon,
        };
        public static Map MidnightMarket = new Map()
        {
            Name = MIDNIGHT_MARKET,
            UmapCode = "PvE_ASN_NightMarket.umap",
            StartingCoin = _6000_COIN,
            MiniMapResource = Properties.Resources.Midnight_Market_minimap, //REPLACE THIS IMAGE?????
        };
        public static Map Orcatraz = new Map()
        {
            Name = ORCATRAZ,
            UmapCode = "PvE_Orcatraz.umap",
            MiniMapResource = Properties.Resources.Minimap_PvE_Orcatraz,
        };
        public static Map OrcriLa = new Map()
        {
            Name = ORCRI_LA,
            UmapCode = "PvE_OrcVil_Temple.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Orcvil_Temple,
        };
        public static Map RestrictedSection = new Map()
        {
            Name = RESTRICTED_SECTION,
            UmapCode = "PvE_RestrictedSection.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_RestrictedSection,
        };
        public static Map RiftmakersTemple = new Map()
        {
            Name = RIFTMAKERS_TEMPLE,
            UmapCode = "PvE_AcademyTemple.umap",
            StartingCoin = _6000_COIN,
            MiniMapResource = Properties.Resources.MiniMap_PvE_AcademyTemple,
        };
        public static Map SharkIsland = new Map()
        {
            Name = SHARK_ISLAND,
            UmapCode = "PvE_SharkIsle.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_SharkIsle, //REPLACE THIS IMAGE????????
        };
        public static Map StablesAtEventide = new Map()
        {
            Name = STABLES_AT_EVENTIDE,
            UmapCode = "PvE_SUR_JungleTribe.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_SUR_JungleTribe, //REPLACE THIS IMAGE??????
        };
        public static Map StormDrain = new Map()
        {
            Name = STORM_DRAIN,
            UmapCode = "PvE_Flushed.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Flushed,
        };
        public static Map TempleGraveyard = new Map()
        {
            Name = TEMPLE_GRAVEYARD,
            UmapCode = "PvE_Mausoleum.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Mausoleum,
        };
        public static Map TheBaths = new Map()
        {
            Name = THE_BATHS,
            UmapCode = "PvE_Baths.umap",
            StartingCoin = _6000_COIN,
            MiniMapResource = Properties.Resources.MiniMap_PvE_Baths,
        };
        public static Map TheFallingFolly = new Map()
        {
            Name = THE_FALLING_FOLLY,
            UmapCode = "PvE_Towering.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Towering,
        };
        public static Map TheWall = new Map()
        {
            Name = THE_WALL,
            UmapCode = "PvE_TheWall.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_TheWall,
        };
        public static Map ThroneRoom = new Map()
        {
            Name = THRONE_ROOM,
            UmapCode = "PvE_ThroneRoom.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_ThroneRoom,
        };
        public static Map ThuricvodVillage = new Map()
        {
            Name = THURICVOD_VILLAGE,
            UmapCode = "PvE_Gap.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_Gap,
        };
        public static Map TrainingGrounds = new Map()
        {
            Name = TRAINING_GROUNDS,
            UmapCode = "PvE_TrainingGrounds.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_TrainingGrounds,
        };
        public static Map UnchainedFortress = new Map()
        {
            Name = UNCHAINED_FORTRESS,
            UmapCode = "PvE_OneWay.umap",
            MiniMapResource = Properties.Resources.MiniMap_PvE_OneWay,
        };
        public static Map WaterGarden = new Map()
        {
            Name = WATER_GARDEN,
            UmapCode = "PvE_ASN_WaterGarden.umap",
            StartingCoin = _6000_COIN,
            MiniMapResource = Properties.Resources.Water_Garden_minimap, //REPLACE THIS IMAGE????????????
        };


        // Maps { Name, umap }
        public static Dictionary<string, Map> Maps = new Dictionary<string, Map>
        {
            { ACADEMY_SEWERS, AcademySewers},
            { ARCHMAGE_LIBRARY, ArchmageLibrary},
            { AVALANCHE, Avalanche},
            { BANQUET_HALL, BanquetHall},
            { CASTLE_GATES, CastleGates},
            { CLIFFSIDE_CLASH, CliffsideClash},
            { CONFLUENCE, Confluence},
            { CROGON_KEEP, CrogonKeep},
            { DOCKS_AT_EVENTIDE, DocksAtEventide},
            { EVENTIDE_FORTRESS, EventideFortress},
            { EVENTIDE_RAMPARTS, EventideRamparts},
            { FROSTBITE, Frostbite},
            { GATES_OF_THURICVOD, GatesOfThuricvod},
            { HIGHLANDS, Highlands},
            { MAXIMUM_SECURITY, MaximumSecurity},
            { MIDNIGHT_MARKET, MidnightMarket},
            { ORCATRAZ, Orcatraz},
            { ORCRI_LA, OrcriLa},
            { RESTRICTED_SECTION, RestrictedSection},
            { RIFTMAKERS_TEMPLE, RiftmakersTemple},
            { SHARK_ISLAND, SharkIsland},
            { STABLES_AT_EVENTIDE, StablesAtEventide},
            { STORM_DRAIN, StormDrain},
            { TEMPLE_GRAVEYARD, TempleGraveyard},
            { THE_BATHS, TheBaths},
            { THE_FALLING_FOLLY, TheFallingFolly},
            { THE_WALL, TheWall},
            { THRONE_ROOM, ThroneRoom},
            { THURICVOD_VILLAGE, ThuricvodVillage},
            { TRAINING_GROUNDS, TrainingGrounds},
            { UNCHAINED_FORTRESS, UnchainedFortress},
            { WATER_GARDEN, WaterGarden},
};
    }


}
