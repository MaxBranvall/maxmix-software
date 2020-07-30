﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxMix.Services.Communication
{
    internal class MessageSettings : MessageBase
    {
        #region Constructor
        public MessageSettings() :base() { }
        public MessageSettings(bool displayNewSession, bool sleepWhenInactive, int sleepAfterSeconds, bool continuousScroll)
            : base()
        {
            _displayNewSession = displayNewSession;
            _sleepWhenInactive = sleepWhenInactive;
            _sleepAfterSeconds = sleepAfterSeconds;
            _continuousScroll = continuousScroll;
        }
        #endregion

        #region Consts
        #endregion

        #region Fields
        public bool _displayNewSession;
        public bool _sleepWhenInactive;
        public int _sleepAfterSeconds;
        public bool _continuousScroll;
        #endregion

        #region Properties
        public bool DisplayNewSession { get => _displayNewSession; }
        public bool SleepWhenInactive { get => _sleepWhenInactive; }
        public int SleepAfterSeconds { get => _sleepAfterSeconds; }
        public bool ContinuousScroll { get => _continuousScroll; }
        #endregion

        #region Private Methods
        #endregion

        #region Public Methods

        /*
        * ---------------------------------------------------
        * CHUNK                     TYPE        SIZE (BYTES)
        * ---------------------------------------------------
        * DISPLAYNEWSESSION         BYTE        1
        * SLEEPWHENINACTIVE         BYTE        1
        * SLEEPAFTERSECONDS         BYTE        1
        * CONTINUOUSSCROLL          BYTE        1
        * ---------------------------------------------------
        */

        public override byte[] GetBytes()
        {
            var result = new List<byte>();

            result.Add(Convert.ToByte(MessageId));
            result.Add(Convert.ToByte(DisplayNewSession));
            result.Add(Convert.ToByte(SleepWhenInactive));
            result.Add(Convert.ToByte(SleepAfterSeconds));
            result.Add(Convert.ToByte(ContinuousScroll));

            return result.ToArray();
        }
        #endregion
    }
}