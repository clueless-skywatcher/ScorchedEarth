using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Weapons.Swords
{
	public class JellySword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Jelly Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Sword made from solid gel, best for beginners...");
		}

		public override void SetDefaults() 
		{
			item.damage = 9;
			item.melee = true;
			item.width = 35;
			item.height = 35;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.scale = 0.8f;
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