using System.Collections.Generic;
using System.Drawing;

using SingleplayerLauncher.Names;

namespace SingleplayerLauncher.Entities
{
    public class Map
    {
        public const int _6000_COIN = 6000;
        public const int _9000_COIN = 9000;

        public string Name { get; private set; }
        public string UmapCode { get; private set; }
        public int StartingCoin { get; private set; }
        public Image MiniMapResource { get; private set; }


        // private constructor
        public Map(string nameParam, string uMapCodeParam, Bitmap miniMapParam, int? startingCoinParam = null)
        {
            Name = nameParam;
            UmapCode = uMapCodeParam;
            MiniMapResource = miniMapParam;
            StartingCoin = startingCoinParam ?? _9000_COIN;
        }

        // static members
        private static readonly Map AcademySewers = new Map(MapNames.ACADEMY_SEWERS, "PvE_Sewers.umap", Properties.Resources.MiniMap_PvE_Sewers);
        private static readonly Map ArchmageLibrary = new Map(MapNames.ARCHMAGE_LIBRARY, "PvE_AcademyLibrary.umap", Properties.Resources.MiniMap_NPE_2);
        private static readonly Map Avalanche = new Map(MapNames.AVALANCHE, "PvE_Avalanche.umap", Properties.Resources.MiniMap_PvE_Avalanche);
        private static readonly Map BanquetHall = new Map(MapNames.BANQUET_HALL, "PvE_BanquetHall.umap", Properties.Resources.MiniMap_PvE_BanquetHall);
        //REPLACE THIS IMAGE?????????????
        private static readonly Map CastleGates = new Map(MapNames.CASTLE_GATES, "PvE_ASN_CastleGates.umap", Properties.Resources.Castle_Gates_minimap, _6000_COIN);
        private static readonly Map CliffsideClash = new Map(MapNames.CLIFFSIDE_CLASH, "PvE_2Lane.umap", Properties.Resources.MiniMap_PvE_2Lane);
        private static readonly Map Confluence = new Map(MapNames.CONFLUENCE, "PvE_AcademyCanals.umap", Properties.Resources.MiniMap_PvE_AcademyCanals);
        private static readonly Map CrogonKeep = new Map(MapNames.CROGON_KEEP, "PvE_CrogonKeep.umap", Properties.Resources.MiniMap_PvE_CrogonKeep);
        private static readonly Map DocksAtEventide = new Map(MapNames.DOCKS_AT_EVENTIDE, "PvE_SUR_Pirates.umap", Properties.Resources.MiniMap_PvE_SUR_Pirates);
        private static readonly Map EventideFortress = new Map(MapNames.EVENTIDE_FORTRESS, "PvE_Surrounded.umap", Properties.Resources.MiniMap_PvE_Surrounded);
        private static readonly Map EventideRamparts = new Map(MapNames.EVENTIDE_RAMPARTS, "PvE_SUR_NorthernClans.umap", Properties.Resources.MiniMap_PvE_SUR_NorthernClans);
        private static readonly Map Frostbite = new Map(MapNames.FROSTBITE, "PvE_FrostBite.umap", Properties.Resources.Minimap_PvE_FrostBite);
        private static readonly Map GatesOfThuricvod = new Map(MapNames.GATES_OF_THURICVOD, "PvE_Corridors.umap", Properties.Resources.MiniMap_PvE_Corridors);
        private static readonly Map Highlands = new Map(MapNames.HIGHLANDS, "PvE_Highlands.umap", Properties.Resources.MiniMap_PvE_Highlands);
        private static readonly Map MaximumSecurity = new Map(MapNames.MAXIMUM_SECURITY, "PvE_AcademyDungeon.umap", Properties.Resources.MiniMap_PvE_AcademyDungeon);
        //REPLACE THIS IMAGE?????
        private static readonly Map MidnightMarket = new Map(MapNames.MIDNIGHT_MARKET, "PvE_ASN_NightMarket.umap", Properties.Resources.Midnight_Market_minimap, _6000_COIN);
        private static readonly Map Orcatraz = new Map(MapNames.ORCATRAZ, "PvE_Orcatraz.umap", Properties.Resources.Minimap_PvE_Orcatraz);
        private static readonly Map OrcriLa = new Map(MapNames.ORCRI_LA, "PvE_OrcVil_Temple.umap", Properties.Resources.MiniMap_PvE_Orcvil_Temple);
        private static readonly Map RestrictedSection = new Map(MapNames.RESTRICTED_SECTION, "PvE_RestrictedSection.umap", Properties.Resources.MiniMap_PvE_RestrictedSection);
        private static readonly Map RiftmakersTemple = new Map(MapNames.RIFTMAKERS_TEMPLE, "PvE_AcademyTemple.umap", Properties.Resources.MiniMap_PvE_AcademyTemple, _6000_COIN);
        private static readonly Map SharkIsland = new Map(MapNames.SHARK_ISLAND, "PvE_SharkIsle.umap", Properties.Resources.MiniMap_PvE_SharkIsle);
        private static readonly Map StablesAtEventide = new Map(MapNames.STABLES_AT_EVENTIDE, "PvE_SUR_JungleTribe.umap", Properties.Resources.MiniMap_PvE_SUR_JungleTribe);
        private static readonly Map StormDrain = new Map(MapNames.STORM_DRAIN, "PvE_Flushed.umap", Properties.Resources.MiniMap_PvE_Flushed);
        private static readonly Map TempleGraveyard = new Map(MapNames.TEMPLE_GRAVEYARD, "PvE_Mausoleum.umap", Properties.Resources.MiniMap_PvE_Mausoleum);
        private static readonly Map TheBaths = new Map(MapNames.THE_BATHS, "PvE_Baths.umap", Properties.Resources.MiniMap_PvE_Baths, _6000_COIN);
        private static readonly Map TheFallingFolly = new Map(MapNames.THE_FALLING_FOLLY, "PvE_Towering.umap", Properties.Resources.MiniMap_PvE_Towering);
        private static readonly Map TheWall = new Map(MapNames.THE_WALL, "PvE_TheWall.umap", Properties.Resources.MiniMap_PvE_TheWall);
        private static readonly Map ThroneRoom = new Map(MapNames.THRONE_ROOM, "PvE_ThroneRoom.umap", Properties.Resources.MiniMap_PvE_ThroneRoom);
        private static readonly Map ThuricvodVillage = new Map(MapNames.THURICVOD_VILLAGE, "PvE_Gap.umap", Properties.Resources.MiniMap_PvE_Gap);
        private static readonly Map TrainingGrounds = new Map(MapNames.TRAINING_GROUNDS, "PvE_TrainingGrounds.umap", Properties.Resources.MiniMap_PvE_TrainingGrounds);
        private static readonly Map UnchainedFortress = new Map(MapNames.UNCHAINED_FORTRESS, "PvE_OneWay.umap", Properties.Resources.MiniMap_PvE_OneWay);
        private static readonly Map WaterGarden = new Map(MapNames.WATER_GARDEN, "PvE_ASN_WaterGarden.umap", Properties.Resources.Water_Garden_minimap, _6000_COIN);


        // Maps { Name, umap }
        public static readonly List<Map> Maps = new List<Map>
        {
            AcademySewers,
            ArchmageLibrary,
            Avalanche,
            BanquetHall,
            CastleGates,
            CliffsideClash,
            Confluence,
            CrogonKeep,
            DocksAtEventide,
            EventideFortress,
            EventideRamparts,
            Frostbite,
            GatesOfThuricvod,
            Highlands,
            MaximumSecurity,
            MidnightMarket,
            Orcatraz,
            OrcriLa,
            RestrictedSection,
            RiftmakersTemple,
            SharkIsland,
            StablesAtEventide,
            StormDrain,
            TempleGraveyard,
            TheBaths,
            TheFallingFolly,
            TheWall,
            ThroneRoom,
            ThuricvodVillage,
            TrainingGrounds,
            UnchainedFortress,
            WaterGarden,
        };
    }


}
