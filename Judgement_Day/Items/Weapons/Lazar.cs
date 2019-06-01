using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Judgement_Day.Items.Weapons
{
    public class Lazar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Hope you have a mana flower!");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.magic = true;
            item.mana = 5;
            item.width = 40;
            item.height = 40;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = (294);
            item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3467, 20);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}