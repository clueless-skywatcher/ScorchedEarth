using Terraria;
using Terraria.ObjectData;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace ScorchedEarth.Tiles {
    class StarForgeTile : ModTile {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.newTile.CoordinateHeights = new []{ 16, 20 };
			TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Star Forge");
            AddMapEntry(new Color(200, 225, 110), name);

            minPick = 30;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.812f;
            g = 0.882f;
            b = 0.431f;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("StarForge"), 1, false, 0, false, false);
		}

    }
}