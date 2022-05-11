using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ScorchedEarth.Items.Armor.Legs;
using ScorchedEarth.Items.Armor.Body;

namespace ScorchedEarth.Items.Armor.Head
{
	[AutoloadEquip(EquipType.Head)]
	public class ArgentArmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Argent Armet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Knight's trusted helmet. Good for privacy...");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 25;
			item.value = 50;
			item.rare = ItemRarityID.Pink;
			item.defense = 10;
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

        public override bool IsArmorSet(Item head, Item body, Item legs){
            return body.type == ModContent.ItemType<ArgentCuirass>() && legs.type == ModContent.ItemType<ArgentGreaves>();
        }

        public override void UpdateArmorSet(Player player){
            player.setBonus = "Armor Power - Argent Agility: +30% movement speed\nShine in the dark";
            player.moveSpeed += 0.30f;
            player.AddBuff(BuffID.Shine, 79200);
        }
	}
}