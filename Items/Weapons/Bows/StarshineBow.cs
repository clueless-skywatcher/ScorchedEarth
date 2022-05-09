using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ScorchedEarth.Tiles;
using ScorchedEarth.Items.Placeable;

namespace ScorchedEarth.Items.Weapons.Bows
{
	public class StarshineBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Starshine Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("60% chance to convert Wooden Arrows to Starshine Arrows that confuse enemies");
		}

		public override void SetDefaults() 
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 5;
			item.value = 100;
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 8f;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			if (Main.rand.NextFloat() >= 0.4f)
            {
                if (type == ProjectileID.WoodenArrowFriendly){
                    type = mod.ProjectileType("StarshineArrowProjectile");
                }
            }
            return true;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ModContent.ItemType<StarBar>(), 5);
			recipe.AddTile(ModContent.TileType<StarForgeTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override Vector2? HoldoutOffset()
        {
			Vector2 offset = new Vector2(8, 0);
			return offset;
        }
    }
}