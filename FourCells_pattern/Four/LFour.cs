using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourCells_pattern {
	class LFourU : Block {
		public override void region(int[] region, int point) {
			region[0] = point; 
			region[1] = point + convert; 
			region[2] = point + 2 * convert; 
			region[3] = point + 2 * convert + 1;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };
		}
	}
	class LFourR : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + 1;
			region[2] = point + 2;
			region[3] = point + convert;
		}
		public override byte[] areaNum() {
			return new byte[] { 2, 2, 3, 3 };
		}
	}
	class LFourD : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + 1;
			region[2] = point + convert + 1;
			region[3] = point + 2 * convert + 1;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };
		}
	}
	class LFourL : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + convert;
			region[2] = point + convert - 1;
			region[3] = point + convert - 2;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };
		}
	}

	class LFourTU : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + convert;
			region[2] = point + 2 * convert;
			region[3] = point + 2 * convert - 1;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };
		}
	}
	class LFourTR : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + convert;
			region[2] = point + convert + 1;
			region[3] = point + convert + 2;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };
		}
	}
	class LFourTD : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + 1;
			region[2] = point + convert;
			region[3] = point + 2 * convert;
		}
		public override byte[] areaNum() {
			return new byte[] { 2, 3, 2, 3 };
		}
	}
	class LFourTL : Block {
		public override void region(int[] region, int point) {
			region[0] = point;
			region[1] = point + 1;
			region[2] = point + 2;
			region[3] = point + convert + 2;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };
		}
	}
}
