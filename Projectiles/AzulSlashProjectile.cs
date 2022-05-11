using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace ScorchedEarth.Projectiles
{
    class AzulSlashProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Azul Slash");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 8;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 10;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 1;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.alpha = 255;
            projectile.penetrate = -1;
            projectile.ranged = true;
            projectile.knockBack = 10f;
            projectile.timeLeft = 300;
        }

        public override void AI() {
			projectile.ai[0] += 1f;
			if (projectile.ai[0] > 50f) {
				// Fade out
				projectile.alpha += 25;
				if (projectile.alpha > 255) {
					projectile.alpha = 255;
				}
			}
			else {
				// Fade in
				projectile.alpha -= 25;
				if (projectile.alpha < 100) {
					projectile.alpha = 100;
				}
			}
			// Slow down
			projectile.velocity *= 1.01f;
			// Loop through the 4 animation frames, spending 5 ticks on each.
			if (++projectile.frameCounter >= 5) {
				projectile.frameCounter = 0;
				if (++projectile.frame >= 4) {
					projectile.frame = 0;
				}
			}
			if (projectile.ai[0] >= 60f) {
				projectile.Kill();
			}
			projectile.direction = projectile.spriteDirection = projectile.velocity.X > 0f ? 1 : -1;
			projectile.rotation = projectile.velocity.ToRotation();
			if (projectile.velocity.Y > 16f) {
				projectile.velocity.Y = 16f;
			}
			// Since our sprite has an orientation, we need to adjust rotation to compensate for the draw flipping.
			if (projectile.spriteDirection == -1) {
				projectile.rotation += MathHelper.Pi;
			}
		}

        public override Color? GetAlpha(Color lightColor) {
			return new Color(255, 255, 255, 0) * (1f - (float)projectile.alpha / 255f);
		}

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.rand.NextFloat() >= 0.5f){
                knockback = 15f;
            }
        }
    }
}
