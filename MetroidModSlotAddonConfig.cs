using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using MetroidMod;

namespace MetroidModSlotAddon
{
    [Label("Server Config")]
    public class MetroidModSlotAddonConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        public static MetroidModSlotAddonConfig Instance;
		
	[Header("General")]
		
		[Label("[i:MetroidMod/HiJumpBoots] BOOT Slot Whitelist")]
		[Tooltip("Accessories in this list can be equipped in the BOOT Slot.")]
		public List<ItemDefinition> slotBoot = new List<ItemDefinition>
		{
			/*new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.HiJumpBoots>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.SpaceJumpBoots>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.SpaceJump>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.SpeedBooster>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.ScrewAttack>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.SpaceBooster>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.ScrewSpaceBooster>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.TerraBooster>())*/
			new ItemDefinition(ItemID.HermesBoots)
		};

		[Label("[i:MetroidMod/PowerGrip] HAND Slot Whitelist")]
		[Tooltip("Accessories in this list can be equipped in the HAND Slot.")]
		public List<ItemDefinition> slotHand = new List<ItemDefinition>
		{
			/*new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.PowerGrip>()),
			new ItemDefinition(ModContent.ItemType<MetroidMod.Content.Items.Accessories.ScrewAttack>())*/
		};
    }
}