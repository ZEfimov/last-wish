////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////

namespace Server.Items
{
    public class hex_CornerFireplaceAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {33, 1, -1, 1}, {1180, 0, 2, 0}, {7138, 1, 1, 6}// 1	2	3	
			, {27, -1, 0, 1}, {29, -1, -1, 1}, {45, 1, 1, 0}// 6	7	8	
			, {36, 1, 1, 11}, {28, 0, 1, 0}, {27, 1, 0, 0}// 9	10	11	
			, {28, 0, -1, 1}, {1180, 1, 2, 0}, {32, -1, 1, 1}// 12	13	14	
			, {13410, 0, 1, 0}, {7138, 0, 2, 0}, {13410, 1, 1, 0}// 15	16	17	
			, {2862, 2, 0, 0}// 18	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new hex_CornerFireplaceAddonDeed();
			}
		}

		[ Constructable ]
		public hex_CornerFireplaceAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6571, 1, 1, 9, 0, 1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1179, -2, -2, 0, 1891, -1, "", 1);// 5

		}

		public hex_CornerFireplaceAddon( Serial serial ) : base( serial )
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

	public class hex_CornerFireplaceAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new hex_CornerFireplaceAddon();
			}
		}

		[Constructable]
		public hex_CornerFireplaceAddonDeed()
		{
			Name = "Corner Fireplace Big";
		}

		public hex_CornerFireplaceAddonDeed( Serial serial ) : base( serial )
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