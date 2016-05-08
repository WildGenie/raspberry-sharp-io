using System;

namespace Raspberry.IO.Components.Displays.Ssd1306.Fonts
{
	public class Fixed1L : IFont
	{
		private static byte[][] fontData = new byte[][] {
			new byte[] { (byte)' ', 8, 8, 0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'!', 8, 8, 0x00,0x00,0x5F,0x00,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'"', 8, 8, 0x00,0x00,0x07,0x00,0x07,0x00,0x00,0x00 },
			new byte[] { (byte)'#', 8, 8, 0x00,0x14,0x7F,0x14,0x7F,0x14,0x00,0x00 },
			new byte[] { (byte)'$', 8, 8, 0x00,0x24,0x2A,0x7F,0x2A,0x12,0x00,0x00 },
			new byte[] { (byte)'%', 8, 8, 0x00,0x23,0x13,0x08,0x64,0x62,0x00,0x00 },
			new byte[] { (byte)'&', 8, 8, 0x00,0x36,0x49,0x55,0x22,0x50,0x00,0x00 },
			new byte[] { (byte)'\'', 8, 8, 0x00,0x00,0x05,0x03,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'(', 8, 8, 0x00,0x1C,0x22,0x41,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)')', 8, 8, 0x00,0x41,0x22,0x1C,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'*', 8, 8, 0x00,0x08,0x2A,0x1C,0x2A,0x08,0x00,0x00 },
			new byte[] { (byte)'+', 8, 8, 0x00,0x08,0x08,0x3E,0x08,0x08,0x00,0x00 },
			new byte[] { (byte)',', 8, 8, 0x00,0xA0,0x60,0x00,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'-', 8, 8, 0x00,0x08,0x08,0x08,0x08,0x08,0x00,0x00 },
			new byte[] { (byte)'.', 8, 8, 0x00,0x60,0x60,0x00,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'/', 8, 8, 0x00,0x20,0x10,0x08,0x04,0x02,0x00,0x00 },
			new byte[] { (byte)'0', 8, 8, 0x00,0x3E,0x51,0x49,0x45,0x3E,0x00,0x00 },
			new byte[] { (byte)'1', 8, 8, 0x00,0x00,0x42,0x7F,0x40,0x00,0x00,0x00 },
			new byte[] { (byte)'2', 8, 8, 0x00,0x62,0x51,0x49,0x49,0x46,0x00,0x00 },
			new byte[] { (byte)'3', 8, 8, 0x00,0x22,0x41,0x49,0x49,0x36,0x00,0x00 },
			new byte[] { (byte)'4', 8, 8, 0x00,0x18,0x14,0x12,0x7F,0x10,0x00,0x00 },
			new byte[] { (byte)'5', 8, 8, 0x00,0x27,0x45,0x45,0x45,0x39,0x00,0x00 },
			new byte[] { (byte)'6', 8, 8, 0x00,0x3C,0x4A,0x49,0x49,0x30,0x00,0x00 },
			new byte[] { (byte)'7', 8, 8, 0x00,0x01,0x71,0x09,0x05,0x03,0x00,0x00 },
			new byte[] { (byte)'8', 8, 8, 0x00,0x36,0x49,0x49,0x49,0x36,0x00,0x00 },
			new byte[] { (byte)'9', 8, 8, 0x00,0x06,0x49,0x49,0x29,0x1E,0x00,0x00 },
			new byte[] { (byte)':', 8, 8, 0x00,0x00,0x36,0x36,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)';', 8, 8, 0x00,0x00,0xAC,0x6C,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'<', 8, 8, 0x00,0x08,0x14,0x22,0x41,0x00,0x00,0x00 },
			new byte[] { (byte)'=', 8, 8, 0x00,0x14,0x14,0x14,0x14,0x14,0x00,0x00 },
			new byte[] { (byte)'>', 8, 8, 0x00,0x41,0x22,0x14,0x08,0x00,0x00,0x00 },
			new byte[] { (byte)'?', 8, 8, 0x00,0x02,0x01,0x51,0x09,0x06,0x00,0x00 },
			new byte[] { (byte)'@', 8, 8, 0x00,0x32,0x49,0x79,0x41,0x3E,0x00,0x00 },
			new byte[] { (byte)'A', 8, 8, 0x00,0x7E,0x09,0x09,0x09,0x7E,0x00,0x00 },
			new byte[] { (byte)'B', 8, 8, 0x00,0x7F,0x49,0x49,0x49,0x36,0x00,0x00 },
			new byte[] { (byte)'C', 8, 8, 0x00,0x3E,0x41,0x41,0x41,0x22,0x00,0x00 },
			new byte[] { (byte)'D', 8, 8, 0x00,0x7F,0x41,0x41,0x22,0x1C,0x00,0x00 },
			new byte[] { (byte)'E', 8, 8, 0x00,0x7F,0x49,0x49,0x49,0x41,0x00,0x00 },
			new byte[] { (byte)'F', 8, 8, 0x00,0x7F,0x09,0x09,0x09,0x01,0x00,0x00 },
			new byte[] { (byte)'G', 8, 8, 0x00,0x3E,0x41,0x41,0x51,0x72,0x00,0x00 },
			new byte[] { (byte)'H', 8, 8, 0x00,0x7F,0x08,0x08,0x08,0x7F,0x00,0x00 },
			new byte[] { (byte)'I', 8, 8, 0x00,0x41,0x7F,0x41,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'J', 8, 8, 0x00,0x20,0x40,0x41,0x3F,0x01,0x00,0x00 },
			new byte[] { (byte)'K', 8, 8, 0x00,0x7F,0x08,0x14,0x22,0x41,0x00,0x00 },
			new byte[] { (byte)'L', 8, 8, 0x00,0x7F,0x40,0x40,0x40,0x40,0x00,0x00 },
			new byte[] { (byte)'M', 8, 8, 0x00,0x7F,0x02,0x0C,0x02,0x7F,0x00,0x00 },
			new byte[] { (byte)'N', 8, 8, 0x00,0x7F,0x04,0x08,0x10,0x7F,0x00,0x00 },
			new byte[] { (byte)'O', 8, 8, 0x00,0x3E,0x41,0x41,0x41,0x3E,0x00,0x00 },
			new byte[] { (byte)'P', 8, 8, 0x00,0x7F,0x09,0x09,0x09,0x06,0x00,0x00 },
			new byte[] { (byte)'Q', 8, 8, 0x00,0x3E,0x41,0x51,0x21,0x5E,0x00,0x00 },
			new byte[] { (byte)'R', 8, 8, 0x00,0x7F,0x09,0x19,0x29,0x46,0x00,0x00 },
			new byte[] { (byte)'S', 8, 8, 0x00,0x26,0x49,0x49,0x49,0x32,0x00,0x00 },
			new byte[] { (byte)'T', 8, 8, 0x00,0x01,0x01,0x7F,0x01,0x01,0x00,0x00 },
			new byte[] { (byte)'U', 8, 8, 0x00,0x3F,0x40,0x40,0x40,0x3F,0x00,0x00 },
			new byte[] { (byte)'V', 8, 8, 0x00,0x1F,0x20,0x40,0x20,0x1F,0x00,0x00 },
			new byte[] { (byte)'W', 8, 8, 0x00,0x3F,0x40,0x38,0x40,0x3F,0x00,0x00 },
			new byte[] { (byte)'X', 8, 8, 0x00,0x63,0x14,0x08,0x14,0x63,0x00,0x00 },
			new byte[] { (byte)'Y', 8, 8, 0x00,0x03,0x04,0x78,0x04,0x03,0x00,0x00 },
			new byte[] { (byte)'Z', 8, 8, 0x00,0x61,0x51,0x49,0x45,0x43,0x00,0x00 },
			new byte[] { (byte)'[', 8, 8, 0x00,0x7F,0x41,0x41,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'\\', 8, 8, 0x00,0x02,0x04,0x08,0x10,0x20,0x00,0x00 },
			new byte[] { (byte)']', 8, 8, 0x00,0x41,0x41,0x7F,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'^', 8, 8, 0x00,0x04,0x02,0x01,0x02,0x04,0x00,0x00 },
			new byte[] { (byte)'_', 8, 8, 0x00,0x80,0x80,0x80,0x80,0x80,0x00,0x00 },
			new byte[] { (byte)'`', 8, 8, 0x00,0x01,0x02,0x04,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'a', 8, 8, 0x00,0x20,0x54,0x54,0x54,0x78,0x00,0x00 },
			new byte[] { (byte)'b', 8, 8, 0x00,0x7F,0x48,0x44,0x44,0x38,0x00,0x00 },
			new byte[] { (byte)'c', 8, 8, 0x00,0x38,0x44,0x44,0x28,0x00,0x00,0x00 },
			new byte[] { (byte)'d', 8, 8, 0x00,0x38,0x44,0x44,0x48,0x7F,0x00,0x00 },
			new byte[] { (byte)'e', 8, 8, 0x00,0x38,0x54,0x54,0x54,0x18,0x00,0x00 },
			new byte[] { (byte)'f', 8, 8, 0x00,0x08,0x7E,0x09,0x02,0x00,0x00,0x00 },
			new byte[] { (byte)'g', 8, 8, 0x00,0x18,0xA4,0xA4,0xA4,0x7C,0x00,0x00 },
			new byte[] { (byte)'h', 8, 8, 0x00,0x7F,0x08,0x04,0x04,0x78,0x00,0x00 },
			new byte[] { (byte)'i', 8, 8, 0x00,0x00,0x7D,0x00,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'j', 8, 8, 0x00,0x80,0x84,0x7D,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'k', 8, 8, 0x00,0x7F,0x10,0x28,0x44,0x00,0x00,0x00 },
			new byte[] { (byte)'l', 8, 8, 0x00,0x41,0x7F,0x40,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'m', 8, 8, 0x00,0x7C,0x04,0x18,0x04,0x78,0x00,0x00 },
			new byte[] { (byte)'n', 8, 8, 0x00,0x7C,0x08,0x04,0x7C,0x00,0x00,0x00 },
			new byte[] { (byte)'o', 8, 8, 0x00,0x38,0x44,0x44,0x38,0x00,0x00,0x00 },
			new byte[] { (byte)'p', 8, 8, 0x00,0xFC,0x24,0x24,0x18,0x00,0x00,0x00 },
			new byte[] { (byte)'q', 8, 8, 0x00,0x18,0x24,0x24,0xFC,0x00,0x00,0x00 },
			new byte[] { (byte)'r', 8, 8, 0x00,0x00,0x7C,0x08,0x04,0x00,0x00,0x00 },
			new byte[] { (byte)'s', 8, 8, 0x00,0x48,0x54,0x54,0x24,0x00,0x00,0x00 },
			new byte[] { (byte)'t', 8, 8, 0x00,0x04,0x7F,0x44,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'u', 8, 8, 0x00,0x3C,0x40,0x40,0x7C,0x00,0x00,0x00 },
			new byte[] { (byte)'v', 8, 8, 0x00,0x1C,0x20,0x40,0x20,0x1C,0x00,0x00 },
			new byte[] { (byte)'w', 8, 8, 0x00,0x3C,0x40,0x30,0x40,0x3C,0x00,0x00 },
			new byte[] { (byte)'x', 8, 8, 0x00,0x44,0x28,0x10,0x28,0x44,0x00,0x00 },
			new byte[] { (byte)'y', 8, 8, 0x00,0x1C,0xA0,0xA0,0x7C,0x00,0x00,0x00 },
			new byte[] { (byte)'z', 8, 8, 0x00,0x44,0x64,0x54,0x4C,0x44,0x00,0x00 },
			new byte[] { (byte)'{', 8, 8, 0x00,0x08,0x36,0x41,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'|', 8, 8, 0x00,0x00,0x7F,0x00,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'}', 8, 8, 0x00,0x41,0x36,0x08,0x00,0x00,0x00,0x00 },
			new byte[] { (byte)'~', 8, 8, 0x00,0x02,0x01,0x01,0x02,0x01,0x00,0x00 },
			new byte[] { (byte)0x7F, 8, 8, 0x00,0x02,0x05,0x05,0x02,0x00,0x00,0x00 },
			new byte[] { (byte)'°', 8, 8, 0x00,0x00,0x06,0x09,0x09,0x06,0x00,0x00 }
		};
        
        public byte[][] GetData()
        {
            return Fixed1L.fontData;
        }
    }
}

