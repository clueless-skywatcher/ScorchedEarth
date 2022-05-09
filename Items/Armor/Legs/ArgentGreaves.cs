using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Armor.Legs
{
	[AutoloadEquip(EquipType.Legs)]
	public class ArgentGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Argent Greaves"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Expensive greaves; +10% movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 50;
			item.rare = ItemRarityID.Pink;
			item.defense = 8;
		}

        public override void UpdateEquip(Player player)
        {
			player.moveSpeed += 0.10f;
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