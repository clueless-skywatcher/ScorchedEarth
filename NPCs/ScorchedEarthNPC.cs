using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScorchedEarth.NPCs {
    class ScorchedEarthNPC : GlobalNPC {
        public bool stunned;

        public override void SetDefaults(NPC npc)
        {
            stunned = false;
        }

        public override void ResetEffects(NPC npc)
        {
            stunned = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (stunned){
                npc.velocity.X *= 0;
                npc.velocity.Y *= 0;
            }
        }

        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {
            if (stunned){
                damage = 0;
            }
        }

        public override bool InstancePerEntity {
            get {
                return true;
            }
        }
    }
}