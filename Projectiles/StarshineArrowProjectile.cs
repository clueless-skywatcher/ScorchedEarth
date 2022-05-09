using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace ScorchedEarth.Projectiles
{
    class StarshineArrowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starshine Arrow");
        }

        public override void SetDefaults()
        {
            projectile.ranged = true;
            projectile.width = 6;
            projectile.height = 6;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.light = 1f;
            projectile.arrow = true;
            aiType = ProjectileID.WoodenArrowFriendly;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (!target.HasBuff(BuffID.Confused)){
                target.AddBuff(BuffID.Confused, 75);
            }
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 21, 0.8f, 0.8f);
            for (var i = 0; i < 6; i++){
                Dust.NewDust(
                    projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f
                );
            }
        }
    }
}
