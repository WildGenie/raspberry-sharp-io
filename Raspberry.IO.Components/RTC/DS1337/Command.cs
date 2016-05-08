using System;

namespace Raspberry.IO.Components.RTC.DS1337
{
	public class Command
	{
		public const byte DS1337_SEC =	0;
		public const byte DS1337_MIN =	1;
		public const byte DS1337_HR	= 2;
		public const byte DS1337_DOW =	3;
		public const byte DS1337_DATE = 4;
		public const byte DS1337_MTH =	5;
		public const byte DS1337_YR	= 6;

		public const int DS1337_BASE_YR = 2000;

		public const byte DS1337_CTRL_ID = 0x68;

		// Define register bit masks
		public const byte DS1337_CLOCKHALT = 0x80;

		public const byte DS1337_LO_BCD = 0x0f;
		public const byte DS1337_HI_BCD = 0xf0;

		public const byte DS1337_HI_SEC = 0x70;
		public const byte DS1337_HI_MIN = 0x70;
		public const byte DS1337_HI_HR = 0x30;
		public const byte DS1337_LO_DOW = 0x07;
		public const byte DS1337_HI_DATE = 0x30;
		public const byte DS1337_HI_MTH = 0x30;
		public const byte DS1337_HI_YR = 0xf0;

		public const byte DS1337_ARLM1 = 0x07;
		public const byte DS1337_ARLM1_LO_SEC = 0x0f;
		public const byte DS1337_ARLM1_HI_SEC = 0x70;
		public const byte DS1337_ARLM1_LO_MIN = 0x70;
		public const byte DS1337_ARLM1_HI_MIN = 0x0f;

		public const byte DS1337_SP = 0x0E;
		public const byte DS1337_SP_EOSC = 0x80;
		public const byte DS1337_SP_RS2 = 0x10;
		public const byte DS1337_SP_RS1 = 0x08;
		public const byte DS1337_SP_INTCN = 0x04;
		public const byte DS1337_SP_A2IE = 0x02;
		public const byte DS1337_SP_A1IE = 0x01;

		public const byte DS1337_STATUS = 0x0F;
		public const byte DS1337_STATUS_OSF = 0x80;
		public const byte DS1337_STATUS_A2F = 0x02;
		public const byte DS1337_STATUS_A1F = 0x01;

		public const byte EVERY_SECOND   =   0x17;
		public const byte EVERY_MINUTE   =   0x16;
		public const byte EVERY_HOUR     =   0x14;
		public const byte EVERY_DAY      =   0x10;
		public const byte EVERY_WEEK     =   0x08;
		public const byte EVERY_MONTH    =   0x00;
	}
}

