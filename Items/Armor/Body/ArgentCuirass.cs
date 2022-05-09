using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Armor.Body
{
	[AutoloadEquip(EquipType.Body)]
	public class ArgentCuirass : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Argent Cuirass"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Guaranteed to make you a knight in shining armor");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 50;
			item.rare = ItemRarityID.Pink;
			item.defense = 11;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.SilverBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}