using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ScorchedEarth.Projectiles
{
    class SlimeProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Projectile");
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 6;
            projectile.height = 6;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.light = 0f;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(
                projectile.Center, 1, 1, DustID.MagicMirror, 0f, 0f, 0, default(Color), 1f
            );
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
            Main.dust[dust].noGravity = true;
        }
    }
}
