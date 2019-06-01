using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement_Day.Items.Weapons
{
	public class DirtSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Sword");
			Tooltip.SetDefault("Why would you make this?");
		}
		public override void SetDefaults()
		{
			item.damage = 3;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
