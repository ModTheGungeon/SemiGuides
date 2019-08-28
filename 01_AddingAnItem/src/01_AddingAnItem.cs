using System;
using Semi;
using Logger = ModTheGungeon.Logger;

namespace AddingAnItem {
	public class AddingAnItem : Mod {
		public Logger Logger = new Logger("01_AddingAnItem");

		public override void Loaded() {
			Logger.Info($"Hello world!");
		}

		public override void RegisterContent() {
			Logger.Debug($"Registering content.");

			var def = RegisterEncounterIcon("@:my_item_icon", "my_item.png");
			RegisterSpriteCollection(
				"@:my_item_coll",
				def
			);
			RegisterSpriteTemplate(
				"@:my_item_sprite",
				"@:my_item_coll",
				"@:my_item_icon"
			);
			RegisterLocalization(
				"@:english_items",
				"english_items.txt",
				"gungeon:english",
				I18N.StringTable.Items
			);

			RegisterItem<MyItem>(
				"@:my_item",
				"@:my_item_icon",
				"@:my_item_sprite",
				"#@:MY_ITEM_NAME",
				"#@:MY_ITEM_SHORT_DESC",
				"#@:MY_ITEM_LONG_DESC"
			);
		}

		public override void InitializeContent() {
			Logger.Debug($"Initializing content.");
		}
	}
}
