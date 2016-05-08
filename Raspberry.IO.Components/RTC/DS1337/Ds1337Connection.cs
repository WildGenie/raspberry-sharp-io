using System;
using Raspberry.IO.InterIntegratedCircuit;

namespace Raspberry.IO.Components.RTC.DS1337
{
	public class Ds1337Connection : IDs1337Connection
	{
		#region Fields

		readonly I2cDeviceConnection connection;
		readonly object syncObject = new object ();
		byte time_set;
		byte alarm_repeat;
		byte[] rtc_bcd = new byte[7];
		// used prior to read/set DS1337 registers;

		#endregion

		public Ds1337Connection (I2cDeviceConnection connection)
		{
			this.connection = connection;
		}

		public byte alarm_is_set ()
		{
			throw new NotImplementedException ();
		}

		public byte clear_interrupt ()
		{
			throw new NotImplementedException ();
		}

		public ulong date_to_epoch_seconds ()
		{
			throw new NotImplementedException ();
		}

		public ulong date_to_epoch_seconds (uint year, byte month, byte day, byte hour, byte minute, byte second)
		{
			throw new NotImplementedException ();
		}

		public byte disable_interrupt ()
		{
			throw new NotImplementedException ();
		}

		public byte enable_interrupt ()
		{
			throw new NotImplementedException ();
		}

		public void epoch_seconds_to_date (ulong value)
		{
			throw new NotImplementedException ();
		}

		public byte getDayOfWeek ()
		{
			throw new NotImplementedException ();
		}

		public byte getDays ()
		{
			throw new NotImplementedException ();
		}

		public byte getHours ()
		{
			throw new NotImplementedException ();
		}

		public byte getMinutes ()
		{
			throw new NotImplementedException ();
		}

		public byte getMonths ()
		{
			throw new NotImplementedException ();
		}

		public byte getRegister (byte registerNumber)
		{
			throw new NotImplementedException ();
		}

		public byte getSeconds ()
		{
			throw new NotImplementedException ();
		}

		public uint getYears ()
		{
			throw new NotImplementedException ();
		}

		public void readAlarm ()
		{
			throw new NotImplementedException ();
		}

		public void readTime ()
		{
			throw new NotImplementedException ();
		}

		public void setAlarmRepeat (byte repeat)
		{
			throw new NotImplementedException ();
		}

		public void setDayOfWeek (byte value)
		{
			throw new NotImplementedException ();
		}

		public void setDays (byte value)
		{
			throw new NotImplementedException ();
		}

		public void setHours (byte value)
		{
			throw new NotImplementedException ();
		}

		public void setMinutes (byte value)
		{
			throw new NotImplementedException ();
		}

		public void setMonths (byte value)
		{
			throw new NotImplementedException ();
		}

		public void setRegister (byte registerNumber, byte registerValue)
		{
			throw new NotImplementedException ();
		}

		public void setSeconds (byte value)
		{
			throw new NotImplementedException ();
		}

		public void setYears (uint value)
		{
			throw new NotImplementedException ();
		}

		public void start ()
		{
			throw new NotImplementedException ();
		}

		public void stop ()
		{
			throw new NotImplementedException ();
		}

		public byte time_is_set ()
		{
			throw new NotImplementedException ();
		}

		public void writeAlarm ()
		{
			throw new NotImplementedException ();
		}

		public void writeAlarm (ulong value)
		{
			throw new NotImplementedException ();
		}

		public void writeTime ()
		{
			throw new NotImplementedException ();
		}

		public void writeTime (ulong value)
		{
			throw new NotImplementedException ();
		}


		void read ()
		{
		}

		void save ()
		{
		}

		byte bcd2bin (byte value)
		{
			throw new NotImplementedException ();
		}

		byte bin2bcd (byte value)
		{
			throw new NotImplementedException ();
		}
	}
}

