using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.Items.Placeable {
    public class StarBar: ModItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Bar");
            ItemID.Sets.SortingPriorityMaterials[item.type] = 60;
        }

        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 750;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddIngredient(ItemID.GoldOre, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}