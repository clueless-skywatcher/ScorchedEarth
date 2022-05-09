using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Armor.Body
{
	[AutoloadEquip(EquipType.Body)]
	public class JellyChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jelly Chestplate"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Jelly suit for all genders. Is it even comfy?");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 30;
			item.rare = ItemRarityID.Blue;
			item.defense = 2;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}