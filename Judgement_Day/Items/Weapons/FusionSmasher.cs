using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement_Day.Items.Weapons
{
	public class FusionSmasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fusion Smasher");
			Tooltip.SetDefault("Forged in the centre of a dying star");
		}
		public override void SetDefaults()
		{
			item.damage = 400;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 1000;
			item.useAnimation = 1000;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3467, 20);
            recipe.AddIngredient(3458, 1);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
