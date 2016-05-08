using System;

namespace Raspberry.IO.Components
{
    public interface IDs1337Connection
    {
        byte time_is_set();
        byte alarm_is_set();
        //byte time_is_valid();

        byte enable_interrupt();
        byte disable_interrupt();
        byte clear_interrupt();

        void readTime();
        void readAlarm();
        void writeTime();
        void writeTime(ulong value);
        void writeAlarm();
        void writeAlarm(ulong value);
        void setAlarmRepeat(byte repeat);

        //void	getTime(int *);
        byte getSeconds();
        byte getMinutes();
        byte getHours();
        byte getDays();
        byte getDayOfWeek();
        byte getMonths();
        uint getYears();
        ulong date_to_epoch_seconds(uint year, byte month, byte day, byte hour, byte minute, byte second);
        ulong date_to_epoch_seconds();
        void epoch_seconds_to_date(ulong value);
        //void snooze(ulong secondsToSnooze);
        //ulong date2seconds();

        //void writeTime(int *);

        void setSeconds(byte value);
        void setMinutes(byte value);
        void setHours(byte value);
        void setDays(byte value);
        void setDayOfWeek(byte value);
        void setMonths(byte value);
        void setYears(uint value);

        void start();
        void stop();
        byte getRegister(byte registerNumber);
        void setRegister(byte registerNumber, byte registerValue);
        //void	unsetRegister(byte registerNumber, byte registerMask);


    }
}

