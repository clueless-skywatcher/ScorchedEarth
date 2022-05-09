using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Armor.Head
{
	[AutoloadEquip(EquipType.Head)]
	public class JellyHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jelly Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A slime helmet which is surprisingly not slimy. Provides 5% more melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 1000;
			item.rare = ItemRarityID.Blue;
			item.defense = 2;
		}

        public override void UpdateEquip(Player player)
        {
			player.meleeDamage += 0.05f;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool IsArmorSet(Item head, Item body, Item legs){
            return body.type == mod.ItemType("JellyChestplate") &&  legs.type == mod.ItemType("JellyPants");
        }

        public override void UpdateArmorSet(Player player){
            player.setBonus = "20% more movement speed";
            player.moveSpeed += 0.20f;
        }
	}
}