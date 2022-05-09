using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Weapons.Bows
{
	public class JellyBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Jelly Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("I wonder how the string was made...");
		}

		public override void SetDefaults() 
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 35;
			item.height = 35;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 3;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 6f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}