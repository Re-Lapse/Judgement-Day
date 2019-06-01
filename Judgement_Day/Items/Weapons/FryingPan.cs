using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement_Day.Items.Weapons
{
	public class FryingPan : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frying Pan");
			Tooltip.SetDefault("Does not block bullets");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(22, 10);
            recipe.AddIngredient(207, 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
