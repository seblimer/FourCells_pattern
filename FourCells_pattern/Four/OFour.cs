using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourCells_pattern {
	class OFour : Block{
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + 1;
			region[2] = point + convert;
			region[3] = point + convert + 1;
		}
		public override byte[] areaNum() {
			return new byte[] { 2, 2, 2, 2 };
		}
	}
}
