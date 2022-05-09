using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ScorchedEarth.Dusts;
using ScorchedEarth.Tiles;
using ScorchedEarth.Buffs;
using ScorchedEarth.Items.Placeable;

namespace ScorchedEarth.Items.Weapons.Swords{
    class StellarSpatha: ModItem {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stellar Spatha");
            Tooltip.SetDefault("Big Sword with low knockback but stuns enemies on impact");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
			item.melee = true;
			item.width = 35;
			item.height = 35;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 100;
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.useTurn = true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            int stun = ModContent.BuffType<StunnedDebuff>();
            target.AddBuff(stun, 75);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3)){
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<StarSparkle>());
            }    
        }

        public override void AddRecipes()
        {
            // 20 Star Bars + 10 Silver Bars
            // Crafting Station: Star Forge
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<StarBar>(), 20);
			recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddTile(ModContent.TileType<StarForgeTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}