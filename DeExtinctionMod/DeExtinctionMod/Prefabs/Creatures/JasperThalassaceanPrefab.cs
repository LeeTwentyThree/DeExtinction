﻿using ECCLibrary;
using System.Collections.Generic;
using UnityEngine;
using UWE;

namespace DeExtinctionMod.Prefabs.Creatures
{
    public class JasperThalassaceanPrefab : ThalassaceanPrefab
    {
        public override string GetEncyDesc => "A large, docile filter feeder, nearly reaching leviathan class sizes. Creature inhabits an expansive cave system.\n\n1. Diet:\nFeeds on small planktonic organisms within the water column. Digestive system analysis shows the presence of brine matching in composition of that found in the surrounding cave system. The Jasper Thalassacean likely swallows this substance to aid in the digestion of more resilient plankton.\n\n2. Coloration:\nCreature has evolved a green and grey coloration, seemingly to help camouflage with surrounding flora and cavern walls.\n\nAssessment: Filter feeding organism commonly predated by other large creatures.";

        public override string GetEncyTitle => "Jasper Thalassacean";

        public override ScannableItemData ScannableSettings => new ScannableItemData(true, 8f, "Lifeforms/Fauna/Carnivores", new string[] { "Lifeforms", "Fauna", "Carnivores" }, QPatch.assetBundle.LoadAsset<Sprite>("Jasper_Popup"), QPatch.assetBundle.LoadAsset<Texture2D>("Jasper_Ency"));

        public JasperThalassaceanPrefab(string classId, string friendlyName, string description, GameObject model, Texture2D spriteTexture) : base(classId, friendlyName, description, model, spriteTexture)
        {
             
        }

        public override List<LootDistributionData.BiomeData> BiomesToSpawnIn => new List<LootDistributionData.BiomeData>()
        {
            new LootDistributionData.BiomeData()
            {
                biome = BiomeType.LostRiverCorridor_Open_CreatureOnly,
                count = 1,
                probability = 0.04f
            },
            new LootDistributionData.BiomeData()
            {
                biome = BiomeType.LostRiverJunction_Open_CreatureOnly,
                count = 1,
                probability = 0.04f
            },
            new LootDistributionData.BiomeData()
            {
                biome = BiomeType.BonesField_Skeleton_Open_CreatureOnly,
                count = 1,
                probability = 0.06f
            },
            new LootDistributionData.BiomeData()
            {
                biome = BiomeType.BonesField_LakePit_Open_CreatureOnly,
                count = 1,
                probability = 0.04f
            },
            new LootDistributionData.BiomeData()
            {
                biome = BiomeType.GhostTree_Open_Big_CreatureOnly,
                count = 1,
                probability = 0.04f
            },
            new LootDistributionData.BiomeData()
            {
                biome = BiomeType.Canyon_Open_CreatureOnly,
                count = 1,
                probability = 0.04f
            },
            new LootDistributionData.BiomeData()
            {
                biome = BiomeType.BonesField_Corridor_CreatureOnly,
                count = 1,
                probability = 0.04f
            }
        };

        public override bool AcidImmune => true;
    }
}
