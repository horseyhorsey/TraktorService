namespace Horsesoft.Traktor.Models
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ENTRY : ENTRYMASTER
    {

        private ENTRYLOCATION lOCATIONField;
        private ENTRYALBUM aLBUMField;
        private ENTRYMODIFICATION_INFO mODIFICATION_INFOField;
        private ENTRYINFO iNFOField;
        private ENTRYTEMPO tEMPOField;
        private ENTRYLOUDNESS lOUDNESSField;
        private ENTRYMUSICAL_KEY mUSICAL_KEYField;
        private ENTRYCUE_V2 cUE_V2Field;

        private string mODIFIED_DATEField;
        private uint mODIFIED_TIMEField;
        private string aUDIO_IDField;
        private string tITLEField;
        private string aRTISTField;

        /// <remarks/>
        public ENTRYLOCATION LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public ENTRYALBUM ALBUM
        {
            get
            {
                return this.aLBUMField;
            }
            set
            {
                this.aLBUMField = value;
            }
        }

        /// <remarks/>
        public ENTRYMODIFICATION_INFO MODIFICATION_INFO
        {
            get
            {
                return this.mODIFICATION_INFOField;
            }
            set
            {
                this.mODIFICATION_INFOField = value;
            }
        }

        /// <remarks/>
        public ENTRYINFO INFO
        {
            get
            {
                return this.iNFOField;
            }
            set
            {
                this.iNFOField = value;
            }
        }

        /// <remarks/>
        public ENTRYTEMPO TEMPO
        {
            get
            {
                return this.tEMPOField;
            }
            set
            {
                this.tEMPOField = value;
            }
        }

        /// <remarks/>
        public ENTRYLOUDNESS LOUDNESS
        {
            get
            {
                return this.lOUDNESSField;
            }
            set
            {
                this.lOUDNESSField = value;
            }
        }

        /// <remarks/>
        public ENTRYMUSICAL_KEY MUSICAL_KEY
        {
            get
            {
                return this.mUSICAL_KEYField;
            }
            set
            {
                this.mUSICAL_KEYField = value;
            }
        }

        /// <remarks/>
        public ENTRYCUE_V2 CUE_V2
        {
            get
            {
                return this.cUE_V2Field;
            }
            set
            {
                this.cUE_V2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MODIFIED_DATE
        {
            get
            {
                return this.mODIFIED_DATEField;
            }
            set
            {
                this.mODIFIED_DATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint MODIFIED_TIME
        {
            get
            {
                return this.mODIFIED_TIMEField;
            }
            set
            {
                this.mODIFIED_TIMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AUDIO_ID
        {
            get
            {
                return this.aUDIO_IDField;
            }
            set
            {
                this.aUDIO_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TITLE
        {
            get
            {
                return this.tITLEField;
            }
            set
            {
                this.tITLEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ARTIST
        {
            get
            {
                return this.aRTISTField;
            }
            set
            {
                this.aRTISTField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYLOCATION
    {

        private string dIRField;

        private string fILEField;

        private string vOLUMEField;

        private string vOLUMEIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DIR
        {
            get
            {
                return this.dIRField;
            }
            set
            {
                this.dIRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FILE
        {
            get
            {
                return this.fILEField;
            }
            set
            {
                this.fILEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VOLUME
        {
            get
            {
                return this.vOLUMEField;
            }
            set
            {
                this.vOLUMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VOLUMEID
        {
            get
            {
                return this.vOLUMEIDField;
            }
            set
            {
                this.vOLUMEIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYALBUM
    {

        private byte oF_TRACKSField;

        private byte tRACKField;

        private string tITLEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OF_TRACKS
        {
            get
            {
                return this.oF_TRACKSField;
            }
            set
            {
                this.oF_TRACKSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TRACK
        {
            get
            {
                return this.tRACKField;
            }
            set
            {
                this.tRACKField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TITLE
        {
            get
            {
                return this.tITLEField;
            }
            set
            {
                this.tITLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYMODIFICATION_INFO
    {

        private string aUTHOR_TYPEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AUTHOR_TYPE
        {
            get
            {
                return this.aUTHOR_TYPEField;
            }
            set
            {
                this.aUTHOR_TYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYINFO
    {

        private uint bITRATEField;

        private string gENREField;

        private string lABELField;

        private string cOMMENTField;

        private ushort pRODUCERField;

        private string cOVERARTIDField;

        private string kEYField;

        private int pLAYTIMEField;

        private string iMPORT_DATEField;

        private string rELEASE_DATEField;

        private byte fLAGSField;

        private ushort fILESIZEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint BITRATE
        {
            get
            {
                return this.bITRATEField;
            }
            set
            {
                this.bITRATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GENRE
        {
            get
            {
                return this.gENREField;
            }
            set
            {
                this.gENREField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LABEL
        {
            get
            {
                return this.lABELField;
            }
            set
            {
                this.lABELField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COMMENT
        {
            get
            {
                return this.cOMMENTField;
            }
            set
            {
                this.cOMMENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort PRODUCER
        {
            get
            {
                return this.pRODUCERField;
            }
            set
            {
                this.pRODUCERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COVERARTID
        {
            get
            {
                return this.cOVERARTIDField;
            }
            set
            {
                this.cOVERARTIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string KEY
        {
            get
            {
                return this.kEYField;
            }
            set
            {
                this.kEYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PLAYTIME
        {
            get
            {
                return this.pLAYTIMEField;
            }
            set
            {
                this.pLAYTIMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IMPORT_DATE
        {
            get
            {
                return this.iMPORT_DATEField;
            }
            set
            {
                this.iMPORT_DATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RELEASE_DATE
        {
            get
            {
                return this.rELEASE_DATEField;
            }
            set
            {
                this.rELEASE_DATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FLAGS
        {
            get
            {
                return this.fLAGSField;
            }
            set
            {
                this.fLAGSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FILESIZE
        {
            get
            {
                return this.fILESIZEField;
            }
            set
            {
                this.fILESIZEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYTEMPO
    {

        private decimal bPMField;

        private byte bPM_QUALITYField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BPM
        {
            get
            {
                return this.bPMField;
            }
            set
            {
                this.bPMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BPM_QUALITY
        {
            get
            {
                return this.bPM_QUALITYField;
            }
            set
            {
                this.bPM_QUALITYField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYLOUDNESS
    {

        private decimal pEAK_DBField;

        private decimal pERCEIVED_DBField;

        private decimal aNALYZED_DBField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PEAK_DB
        {
            get
            {
                return this.pEAK_DBField;
            }
            set
            {
                this.pEAK_DBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PERCEIVED_DB
        {
            get
            {
                return this.pERCEIVED_DBField;
            }
            set
            {
                this.pERCEIVED_DBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ANALYZED_DB
        {
            get
            {
                return this.aNALYZED_DBField;
            }
            set
            {
                this.aNALYZED_DBField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYMUSICAL_KEY
    {

        private byte vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ENTRYCUE_V2
    {

        private string nAMEField;

        private byte dISPL_ORDERField;

        private byte tYPEField;

        private decimal sTARTField;

        private byte lENField;

        private sbyte rEPEATSField;

        private byte hOTCUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DISPL_ORDER
        {
            get
            {
                return this.dISPL_ORDERField;
            }
            set
            {
                this.dISPL_ORDERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal START
        {
            get
            {
                return this.sTARTField;
            }
            set
            {
                this.sTARTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte LEN
        {
            get
            {
                return this.lENField;
            }
            set
            {
                this.lENField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte REPEATS
        {
            get
            {
                return this.rEPEATSField;
            }
            set
            {
                this.rEPEATSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte HOTCUE
        {
            get
            {
                return this.hOTCUEField;
            }
            set
            {
                this.hOTCUEField = value;
            }
        }
    }


}
