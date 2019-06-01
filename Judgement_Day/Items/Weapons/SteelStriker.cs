using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement_Day.Items.Weapons
{
	public class SteelStriker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Striker");
			Tooltip.SetDefault("The Sword wielded by the Old PR Rep");
		}
		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 1;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1225, 15);
			recipe.AddIngredient(180, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
