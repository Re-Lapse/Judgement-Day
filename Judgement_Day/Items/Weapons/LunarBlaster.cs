using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Judgement_Day.Items.Weapons
{
    public class LunarBlaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Blaster");
            Tooltip.SetDefault("Straight outta space");
        }

        public override void SetDefaults()
        {
            item.damage = 70;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = false;
            item.knockBack = 11;
            item.value = 10000;
            item.rare = 10;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 9f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(75, 99);
            recipe.AddIngredient(3467, 20);
            recipe.AddIngredient(679, 1);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
}