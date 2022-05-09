using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Placeable.Crafting {
    class StarForge : ModItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Forge");
            Tooltip.SetDefault("For crafting items made from stars");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Furnace);
            item.createTile = ModContent.TileType<Tiles.StarForgeTile>();
        }

        public override void AddRecipes()
        {
            // 10 Star Bars + 10 Iron Bars + 50 Stone Blocks
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<StarBar>(), 10);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}