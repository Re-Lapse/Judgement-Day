using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement_Day.Items.Weapons
{
	public class LunarDuelist : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Duelist");
			Tooltip.SetDefault("Bring the moon crashing down onto your opponents!");
		}
		public override void SetDefaults()
		{
			item.damage = 200;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
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
			recipe.AddIngredient(3507, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
