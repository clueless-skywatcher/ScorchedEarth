using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ScorchedEarth.NPCs;

namespace ScorchedEarth.Buffs{
    class StunnedDebuff: ModBuff {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Stunned");
            DisplayName.SetDefault("The stunned character cannot move");
            Main.debuff[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (!npc.GetGlobalNPC<ScorchedEarthNPC>().stunned){
                npc.GetGlobalNPC<ScorchedEarthNPC>().stunned = true;
            }
        }
    }
}