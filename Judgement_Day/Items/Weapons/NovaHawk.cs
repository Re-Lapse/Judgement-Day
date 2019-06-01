using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement_Day.Items.Weapons
{
    public class NovaHawk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Hawk");
            Tooltip.SetDefault("The Evertrusty Sidearm of uhh someone");
        }

        public override void SetDefaults()
        {
            item.damage = 60;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 11;
            item.value = 10000;
            item.rare = 10;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 9f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3467, 7);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}