using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ScorchedEarth.Items.Armor.Body;
using ScorchedEarth.Items.Armor.Legs;

namespace ScorchedEarth.Items.Armor.Head
{
	[AutoloadEquip(EquipType.Head)]
	public class LinariteBarbute : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Linarite Barbute"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shining with the radiance of a blue sun");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 50;
			item.rare = ItemRarityID.Lime;
			item.defense = 16;
		}

        public override void AddRecipes()
		{
            // 25 Linarite Bars
            // Crafting Station: Orichalcum/Mythril Anvil
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool IsArmorSet(Item head, Item body, Item legs){
            return body.type == ModContent.ItemType<LinaritePlatemail>() &&  legs.type == ModContent.ItemType<LinariteJambeaux>();
        }

        public override void UpdateArmorSet(Player player){
            player.setBonus = "Armor Power - Azul: +30% Movement Speed;\n+30% Life Regeneration;\nGain slowfall";
            player.slowFall = true;
            player.moveSpeed += 0.30f;
            player.lifeRegen = (int)(player.lifeRegen * 1.30f);
        }
    }
}