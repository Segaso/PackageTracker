using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using GemCard;

namespace PackageTracker {
    class RFIDReader {
        private readonly String DefaultReader = ConfigurationManager.AppSettings["RFIDReaderName"];
        private String[] ReaderList { get; set; }
        private int ReaderToUse = 0;
        private CardBase Reader;

        Main MainForm;
        public static SynchronizationContext ReaderContext;

        public RFIDReader(Main Form, SynchronizationContext UIContext) {
            ReaderContext = UIContext;
            MainForm = Form;

            int Result = SetupReaderList();
            if (Result == 1) {
                SetupReaderEvents();
                Start();
            }
        }

        public string GetCardNumber() {
            String ATR;
            byte[] ATRValue;
            String CardNumber = string.Empty;

            Reader.Connect(ReaderList[ReaderToUse], SHARE.Shared, PROTOCOL.T0orT1);

            //Get the ATR of the card
            ATRValue = Reader.GetAttribute(SCARD_ATTR_VALUE.ATR_STRING);
            ATR = (ATRValue != null) ? BitConverter.ToString(ATRValue).Replace("-", "") : string.Empty;
            CardNumber = ATR.Substring(ATR.Length - 6); //Last 6 Digits in the case of HID H1301

            if (CardNumber == String.Empty) {
                throw new InvalidOperationException("Failed reading card");
            }

            return CardNumber;
        }

        private void Reader_OnCardInserted(String e) {
            MainForm.SyncThreads(Convert.ToInt32(GetCardNumber()), ReaderContext);
            GetCardNumber();
            Reader.Disconnect(DISCONNECT.Unpower);
        }

        private void Reader_OnCardRemoved(String e) {
            Reader.Disconnect(DISCONNECT.Unpower);
        }

        private void Start() {
            Reader.StopCardEvents();

            Reader.StartCardEvents(ReaderList[ReaderToUse]);
        }

        private void SetupReaderEvents() {
            if (Reader != null) {
                //Previous card may not have been removed, dissonecting card in preperation for next read
                Reader.Disconnect(DISCONNECT.Unpower);
            } 
            Reader = new CardNative();
            Reader.OnCardInserted += new CardInsertedEventHandler(Reader_OnCardInserted);
            Reader.OnCardRemoved += new CardRemovedEventHandler(Reader_OnCardRemoved);
            
        }

        private int SetupReaderList() {
            int Result = 0;

            try {
                Reader = new CardNative();
                ReaderList = Reader.ListReaders();

                if (ReaderList != null) {
                    //Check to see if there is more than one RFID Reader detected. 
                    if (ReaderList.Length > 1) {
                        if (ReaderList.Contains(DefaultReader)) {
                            //Default Reader is in the list
                            ReaderToUse = Array.IndexOf(ReaderList, DefaultReader);
                        }
                    }
                    Result = 1;
                } else {
                    //No Reader Found
                    Result = -1;
                }
            } catch (Exception) {
                //No Reader Found
                Result = -1;
            }

            return Result;
        }
    }
}
