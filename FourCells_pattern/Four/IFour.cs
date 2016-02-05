using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourCells_pattern {
	class IFourV : Block {
		public override void region(int[] region ,int point) {
			region[0] =  point; 
			region[1] =  point + convert;
			region[2] =	 point + 2 * convert; 
			region[3] =  point + 3 * convert;	
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };	
		}
	}
	class IFourH : Block {
		public override void region(int[] region, int point) {
			region[0] = point; 
			region[1] = point + 1; 
			region[2] = point + 2; 
			region[3] = point + 3;
		}
		public override byte[] areaNum() {
			return new byte[] { 3, 2, 2, 3 };
		}
	}
}
