using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourCells_pattern {
	class TFiveU : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + 1;
			region[2] = point + 2;
			region[3] = point + convert + 1;
			region[4] = point + 2 * convert + 1;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 1, 3, 2, 3 };
		}
	}
	class TFiveR : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + convert;
			region[2] = point + convert - 1;
			region[3] = point + convert - 2;
			region[4] = point + 2 * convert;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 1, 2, 3, 3 };
		}
	}
	class TFiveD : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + convert;
			region[2] = point + 2 * convert;
			region[3] = point + 2 * convert - 1;
			region[4] = point + 2 * convert + 1;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 1, 3, 3 };
		}
	}
	class TFiveL : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + convert;
			region[2] = point + convert + 1;
			region[3] = point + convert + 2;
			region[4] = point + 2 * convert;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 1, 2, 3, 3 };
		}
	}
}
