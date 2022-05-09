using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Armor.Legs
{
	[AutoloadEquip(EquipType.Legs)]
	public class JellyPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jelly Pants"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Slimy pants. +7% movement speed");
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
			player.moveSpeed += 0.07f;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}