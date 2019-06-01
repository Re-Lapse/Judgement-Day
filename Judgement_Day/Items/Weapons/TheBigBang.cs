using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Judgement_Day.Items.Weapons
{
    public class TheBigBang : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged at the Heart of the Universe");
        }

        public override void SetDefaults()
        {
            item.damage = 300;
            item.ranged = true;
            item.width = 1;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 11;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Terraria/ModLoader/Mod Sources/Judgement_Day/Sounds/Items/Bigbangsound");
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(25, 0);
        }
    }
}