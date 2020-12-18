using System.Collections.Generic;

namespace WindowsFormsBoat
{
	class BoatComparer : IComparer<SwimmingTransport>
	{
		public int Compare(SwimmingTransport x, SwimmingTransport y)
		{
			if (x is Catamaran && y is Catamaran)
			{
				return CompareCatamaran((Catamaran)x, (Catamaran)y);
			}
			else if (x is Catamaran)
			{
				return 1;
			}
			else if (y is Catamaran)
			{
				return -1;
			}		
			return CompareBoat((Boat)x, (Boat)y);					
		}
		private int CompareBoat(Boat x, Boat y)
		{
			if (x.MaxSpeed != y.MaxSpeed)
			{
				return x.MaxSpeed.CompareTo(y.MaxSpeed);
			}
			if (x.Weight != y.Weight)
			{
				return x.Weight.CompareTo(y.Weight);
			}
			if (x.MainColor != y.MainColor)
			{
				return x.MainColor.Name.CompareTo(y.MainColor.Name);
			}
			return 0;
		}
		private int CompareCatamaran(Catamaran x, Catamaran y)
		{
			var res = CompareBoat(x, y);
			if (res != 0)
			{
				return res;
			}
			if (x.DopColor != y.DopColor)
			{
				return x.DopColor.Name.CompareTo(y.DopColor.Name);
			}
			if (x.RighrSideFloat != y.RighrSideFloat)
			{
				return x.RighrSideFloat.CompareTo(y.RighrSideFloat);
			}
			if (x.LeftSideFloat != y.LeftSideFloat)
			{
				return x.LeftSideFloat.CompareTo(y.LeftSideFloat);
			}		
			return 0;
		}
	}
}
