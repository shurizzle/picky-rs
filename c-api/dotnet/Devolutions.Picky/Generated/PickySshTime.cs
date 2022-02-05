// Automatically generated by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.Picky.Diplomat;
#pragma warning restore 0105

namespace Devolutions.Picky;

#nullable enable

/// <summary>
/// SSH datetime.
/// </summary>
public partial class PickySshTime: IDisposable
{
    private unsafe Raw.PickySshTime* _inner;

    public byte Day
    {
        get
        {
            return GetDay();
        }
    }

    public byte Hour
    {
        get
        {
            return GetHour();
        }
    }

    public byte Minute
    {
        get
        {
            return GetMinute();
        }
    }

    public byte Month
    {
        get
        {
            return GetMonth();
        }
    }

    public byte Second
    {
        get
        {
            return GetSecond();
        }
    }

    public ulong Timestamp
    {
        get
        {
            return GetTimestamp();
        }
    }

    public ushort Year
    {
        get
        {
            return GetYear();
        }
    }

    /// <summary>
    /// Creates a managed <c>PickySshTime</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// </remarks>
    /// <remarks>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe PickySshTime(Raw.PickySshTime* handle)
    {
        _inner = handle;
    }

    /// <returns>
    /// A <c>PickySshTime</c> allocated on Rust side.
    /// If a custom Drop implementation is implemented on Rust side, it WILL run on destruction.
    /// </returns>
    public static PickySshTime Now()
    {
        unsafe
        {
            Raw.PickySshTime* retVal = Raw.PickySshTime.Now();
            return new PickySshTime(retVal);
        }
    }

    /// <returns>
    /// A <c>PickySshTime</c> allocated on Rust side.
    /// If a custom Drop implementation is implemented on Rust side, it WILL run on destruction.
    /// </returns>
    public static PickySshTime FromTimestamp(ulong timestamp)
    {
        unsafe
        {
            Raw.PickySshTime* retVal = Raw.PickySshTime.FromTimestamp(timestamp);
            return new PickySshTime(retVal);
        }
    }

    public ulong GetTimestamp()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            ulong retVal = Raw.PickySshTime.GetTimestamp(_inner);
            return retVal;
        }
    }

    public byte GetMonth()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            byte retVal = Raw.PickySshTime.GetMonth(_inner);
            return retVal;
        }
    }

    public byte GetDay()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            byte retVal = Raw.PickySshTime.GetDay(_inner);
            return retVal;
        }
    }

    public byte GetHour()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            byte retVal = Raw.PickySshTime.GetHour(_inner);
            return retVal;
        }
    }

    public byte GetMinute()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            byte retVal = Raw.PickySshTime.GetMinute(_inner);
            return retVal;
        }
    }

    public byte GetSecond()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            byte retVal = Raw.PickySshTime.GetSecond(_inner);
            return retVal;
        }
    }

    public ushort GetYear()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            ushort retVal = Raw.PickySshTime.GetYear(_inner);
            return retVal;
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.PickySshTime* AsFFI()
    {
        return _inner;
    }

    /// <summary>
    /// Marks this object as moved into Rust side.
    /// </summary>
    public void MarkAsMoved()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("PickySshTime");
            }
            _inner = null;
        }
    }

    /// <summary>
    /// Restores unmanaged ressource handle to this object.
    /// </summary>
    public unsafe void RestoreHandle(Raw.PickySshTime* handle)
    {
        _inner = handle;
    }

    /// <summary>
    /// Destroys the underlying object immediately.
    /// </summary>
    public void Dispose()
    {
        unsafe
        {
            if (_inner == null)
            {
                return;
            }

            Raw.PickySshTime.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~PickySshTime()
    {
        Dispose();
    }
}