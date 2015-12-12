
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class glassCoffeeTableSquareAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new glassCoffeeTableSquareAddonDeed();
			}
		}

		[ Constructable ]
		public glassCoffeeTableSquareAddon()
		{



			AddComplexComponent( (BaseAddon) this, 2719, 1, 0, 0, 0, -1, "table", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2721, -1, 0, 0, 0, -1, "table", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2723, -1, -1, 0, 0, -1, "table", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2724, 1, -1, 0, 0, -1, "table", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2722, 0, -1, 0, 0, -1, "table", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7388, 0, 0, 8, 1150, -1, "frosted glass", 1);// 6
			AddComplexComponent( (BaseAddon) this, 7388, 1, 0, 8, 1150, -1, "frosted glass", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2725, -1, 1, 0, 0, -1, "table", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2720, 0, 1, 0, 0, -1, "table", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2840, 1, 1, 0, 0, -1, "table", 1);// 10
			AddComplexComponent( (BaseAddon) this, 7388, 0, 1, 8, 1150, -1, "frosted glass", 1);// 11
			AddComplexComponent( (BaseAddon) this, 7388, 1, 1, 8, 1150, -1, "frosted glass", 1);// 12

		}

		public glassCoffeeTableSquareAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class glassCoffeeTableSquareAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new glassCoffeeTableSquareAddon();
			}
		}

		[Constructable]
		public glassCoffeeTableSquareAddonDeed()
		{
			Name = "glassCoffeeTableSquare";
		}

		public glassCoffeeTableSquareAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}