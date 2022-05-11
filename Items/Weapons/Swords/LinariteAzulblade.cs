using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ScorchedEarth.Dusts;
using ScorchedEarth.Tiles;
using ScorchedEarth.Buffs;
using ScorchedEarth.Items.Placeable;
using ScorchedEarth.Projectiles;

namespace ScorchedEarth.Items.Weapons.Swords {
    class LinariteAzulblade: ModItem {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Linarite Azulblade");
            Tooltip.SetDefault(
                "Giant sword with the power of everything BLUE!\nWeapon Power: Azul Slash - Sends a blue wave that has a 50% chance to massively knock back enemies"
            );
        }

        public override void SetDefaults()
        {
            item.damage = 70;
			item.melee = true;
			item.width = 70;
			item.height = 70    ;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 100;
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.useTurn = false;
            item.shoot = ModContent.ProjectileType<AzulSlashProjectile>();
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            // 21 Linarite Bars
            // Crafting Station: Mythril/Orichalcum Anvil
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 offset = new Vector2(speedX * 7, speedY * 7);
			position += offset;
			return true;
        }
    }
}