using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Armor.Legs
{
	[AutoloadEquip(EquipType.Legs)]
	public class LinariteJambeaux : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Linarite Jambeaux"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shining with... dust?");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 50;
			item.rare = ItemRarityID.Lime;
			item.defense = 18;
		}

        public override void AddRecipes()
		{
            // 30 Linarite Bars
            // Crafting Station: Orichalcum/Mythril Anvil
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}