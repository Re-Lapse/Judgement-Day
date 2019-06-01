using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement_Day.Items.Weapons
{
	public class Cheese : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cheese");
			Tooltip.SetDefault("This is a literal block of cheese.");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 100);
recipe.AddIngredient(ItemID.Diamond ,10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
