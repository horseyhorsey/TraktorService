using System;

namespace Horsesoft.Traktor.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NML
    {

        private NMLHEAD hEADField;

        private object mUSICFOLDERSField;

        private NMLCOLLECTION cOLLECTIONField;

        private NMLSETS sETSField;

        private NMLPLAYLISTS pLAYLISTSField;

        private NMLSORTING_ORDER[] sORTING_ORDERField;

        private byte vERSIONField;

        /// <remarks/>
        public NMLHEAD HEAD
        {
            get
            {
                return this.hEADField;
            }
            set
            {
                this.hEADField = value;
            }
        }
        /// <remarks/>
        public object MUSICFOLDERS
        {
            get
            {
                return this.mUSICFOLDERSField;
            }
            set
            {
                this.mUSICFOLDERSField = value;
            }
        }
        /// <remarks/>
        public NMLCOLLECTION COLLECTION
        {
            get
            {
                return this.cOLLECTIONField;
            }
            set
            {
                this.cOLLECTIONField = value;
            }
        }
        /// <remarks/>
        public NMLSETS SETS
        {
            get
            {
                return this.sETSField;
            }
            set
            {
                this.sETSField = value;
            }
        }
        /// <remarks/>
        public NMLPLAYLISTS PLAYLISTS
        {
            get
            {
                return this.pLAYLISTSField;
            }
            set
            {
                this.pLAYLISTSField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SORTING_ORDER")]
        public NMLSORTING_ORDER[] SORTING_ORDER
        {
            get
            {
                return this.sORTING_ORDERField;
            }
            set
            {
                this.sORTING_ORDERField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLHEAD
    {
        private string cOMPANYField;
        private string pROGRAMField;
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string COMPANY
        {
            get
            {
                return this.cOMPANYField;
            }
            set
            {
                this.cOMPANYField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PROGRAM
        {
            get
            {
                return this.pROGRAMField;
            }
            set
            {
                this.pROGRAMField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NMLCOLLECTION
    {

        private NMLCOLLECTIONENTRY[] eNTRYField;

        private ushort eNTRIESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ENTRY")]
        public NMLCOLLECTIONENTRY[] ENTRY
        {
            get
            {
                return this.eNTRYField;
            }
            set
            {
                this.eNTRYField = value;
            }
        }

        /// <summary>
        /// Count of all tracks in collection
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ENTRIES
        {
            get
            {
                return this.eNTRIESField;
            }
            set
            {
                this.eNTRIESField = value;
            }
        }

    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLCOLLECTIONENTRY : ENTRYMASTER
    {
        public override string ToString()
        {
            return "MusicKey: " + this.MUSICAL_KEY.VALUE.ToString()
                + "Key: " + INFO.KEY;
        }

        private NMLCOLLECTIONENTRYLOCATION lOCATIONField;

        private NMLCOLLECTIONENTRYALBUM aLBUMField;

        private NMLCOLLECTIONENTRYMODIFICATION_INFO mODIFICATION_INFOField;

        private NMLCOLLECTIONENTRYINFO iNFOField;

        private NMLCOLLECTIONENTRYTEMPO tEMPOField;

        private NMLCOLLECTIONENTRYLOUDNESS lOUDNESSField;

        private NMLCOLLECTIONENTRYMUSICAL_KEY mUSICAL_KEYField;

        private NMLCOLLECTIONENTRYLOOPINFO lOOPINFOField;

        private NMLCOLLECTIONENTRYCUE_V2[] cUE_V2Field;

        private NMLCOLLECTIONENTRYSTEMS sTEMSField;

        private string mODIFIED_DATEField;

        private uint mODIFIED_TIMEField;

        private bool mODIFIED_TIMEFieldSpecified;

        private byte lOCKField;

        private bool lOCKFieldSpecified;

        private System.DateTime lOCK_MODIFICATION_TIMEField;

        private bool lOCK_MODIFICATION_TIMEFieldSpecified;

        private string aUDIO_IDField;

        private string tITLEField;

        private string aRTISTField;

        /// <remarks/>
        public NMLCOLLECTIONENTRYLOCATION LOCATION
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
        public NMLCOLLECTIONENTRYALBUM ALBUM
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
        public NMLCOLLECTIONENTRYMODIFICATION_INFO MODIFICATION_INFO
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
        public NMLCOLLECTIONENTRYINFO INFO
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
        public NMLCOLLECTIONENTRYTEMPO TEMPO
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
        public NMLCOLLECTIONENTRYLOUDNESS LOUDNESS
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
        public NMLCOLLECTIONENTRYMUSICAL_KEY MUSICAL_KEY
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
        public NMLCOLLECTIONENTRYLOOPINFO LOOPINFO
        {
            get
            {
                return this.lOOPINFOField;
            }
            set
            {
                this.lOOPINFOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CUE_V2")]
        public NMLCOLLECTIONENTRYCUE_V2[] CUE_V2
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
        public NMLCOLLECTIONENTRYSTEMS STEMS
        {
            get
            {
                return this.sTEMSField;
            }
            set
            {
                this.sTEMSField = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MODIFIED_TIMESpecified
        {
            get
            {
                return this.mODIFIED_TIMEFieldSpecified;
            }
            set
            {
                this.mODIFIED_TIMEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte LOCK
        {
            get
            {
                return this.lOCKField;
            }
            set
            {
                this.lOCKField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOCKSpecified
        {
            get
            {
                return this.lOCKFieldSpecified;
            }
            set
            {
                this.lOCKFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public DateTime LOCK_MODIFICATION_TIME
        {
            get
            {
                return this.lOCK_MODIFICATION_TIMEField;
            }
            set
            {
                this.lOCK_MODIFICATION_TIMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOCK_MODIFICATION_TIMESpecified
        {
            get
            {
                return this.lOCK_MODIFICATION_TIMEFieldSpecified;
            }
            set
            {
                this.lOCK_MODIFICATION_TIMEFieldSpecified = value;
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
    public partial class NMLCOLLECTIONENTRYLOCATION
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
    public partial class NMLCOLLECTIONENTRYALBUM
    {

        private ushort tRACKField;

        private bool tRACKFieldSpecified;

        private string tITLEField;

        private byte oF_TRACKSField;

        private bool oF_TRACKSFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort TRACK
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TRACKSpecified
        {
            get
            {
                return this.tRACKFieldSpecified;
            }
            set
            {
                this.tRACKFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OF_TRACKSSpecified
        {
            get
            {
                return this.oF_TRACKSFieldSpecified;
            }
            set
            {
                this.oF_TRACKSFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLCOLLECTIONENTRYMODIFICATION_INFO
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
    public partial class NMLCOLLECTIONENTRYINFO
    {

        private uint bITRATEField;

        private bool bITRATEFieldSpecified;

        private string gENREField;

        private string lABELField;

        private string cOMMENTField;

        private string rEMIXERField;

        private string pRODUCERField;

        private string cOVERARTIDField;

        private string kEYField;

        private ushort pLAYTIMEField;

        private byte rANKINGField;

        private bool rANKINGFieldSpecified;

        private string iMPORT_DATEField;

        private string rELEASE_DATEField;

        private byte fLAGSField;

        private uint fILESIZEField;

        private byte pLAYCOUNTField;

        private bool pLAYCOUNTFieldSpecified;

        private string lAST_PLAYEDField;

        private string rATINGField;

        private string kEY_LYRICSField;

        private decimal pLAYTIME_FLOATField;

        private bool pLAYTIME_FLOATFieldSpecified;

        private string cATALOG_NOField;

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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BITRATESpecified
        {
            get
            {
                return this.bITRATEFieldSpecified;
            }
            set
            {
                this.bITRATEFieldSpecified = value;
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
        public string REMIXER
        {
            get
            {
                return this.rEMIXERField;
            }
            set
            {
                this.rEMIXERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PRODUCER
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
        public ushort PLAYTIME
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
        public byte RANKING
        {
            get
            {
                return this.rANKINGField;
            }
            set
            {
                this.rANKINGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RANKINGSpecified
        {
            get
            {
                return this.rANKINGFieldSpecified;
            }
            set
            {
                this.rANKINGFieldSpecified = value;
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
        public uint FILESIZE
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PLAYCOUNT
        {
            get
            {
                return this.pLAYCOUNTField;
            }
            set
            {
                this.pLAYCOUNTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PLAYCOUNTSpecified
        {
            get
            {
                return this.pLAYCOUNTFieldSpecified;
            }
            set
            {
                this.pLAYCOUNTFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LAST_PLAYED
        {
            get
            {
                return this.lAST_PLAYEDField;
            }
            set
            {
                this.lAST_PLAYEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RATING
        {
            get
            {
                return this.rATINGField;
            }
            set
            {
                this.rATINGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string KEY_LYRICS
        {
            get
            {
                return this.kEY_LYRICSField;
            }
            set
            {
                this.kEY_LYRICSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PLAYTIME_FLOAT
        {
            get
            {
                return this.pLAYTIME_FLOATField;
            }
            set
            {
                this.pLAYTIME_FLOATField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PLAYTIME_FLOATSpecified
        {
            get
            {
                return this.pLAYTIME_FLOATFieldSpecified;
            }
            set
            {
                this.pLAYTIME_FLOATFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CATALOG_NO
        {
            get
            {
                return this.cATALOG_NOField;
            }
            set
            {
                this.cATALOG_NOField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLCOLLECTIONENTRYTEMPO
    {

        private decimal bPMField;

        private byte bPM_QUALITYField;

        private decimal bPM_TRANSIENTCOHERENCEField;

        private bool bPM_TRANSIENTCOHERENCEFieldSpecified;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BPM_TRANSIENTCOHERENCE
        {
            get
            {
                return this.bPM_TRANSIENTCOHERENCEField;
            }
            set
            {
                this.bPM_TRANSIENTCOHERENCEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BPM_TRANSIENTCOHERENCESpecified
        {
            get
            {
                return this.bPM_TRANSIENTCOHERENCEFieldSpecified;
            }
            set
            {
                this.bPM_TRANSIENTCOHERENCEFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLCOLLECTIONENTRYLOUDNESS
    {

        private float pEAK_DBField;

        private bool pEAK_DBFieldSpecified;

        private string pERCEIVED_DBField;

        private string aNALYZED_DBField;

        private bool aNALYZED_DBFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float PEAK_DB
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PEAK_DBSpecified
        {
            get
            {
                return this.pEAK_DBFieldSpecified;
            }
            set
            {
                this.pEAK_DBFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PERCEIVED_DB
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
        public string ANALYZED_DB
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ANALYZED_DBSpecified
        {
            get
            {
                return this.aNALYZED_DBFieldSpecified;
            }
            set
            {
                this.aNALYZED_DBFieldSpecified = value;
            }
        }
    }

    /// <remarks/>

    public partial class NMLCOLLECTIONENTRYMUSICAL_KEY
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
    public partial class NMLCOLLECTIONENTRYLOOPINFO
    {

        private string oRIGINAL_TITLEField;

        private string oRIGINAL_TRACKIDField;

        private double oRIGINAL_LOOP_SIZEField;

        private byte oRIGINAL_LOOP_STARTField;

        private byte sAMPLE_TYPE_INFOField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ORIGINAL_TITLE
        {
            get
            {
                return this.oRIGINAL_TITLEField;
            }
            set
            {
                this.oRIGINAL_TITLEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ORIGINAL_TRACKID
        {
            get
            {
                return this.oRIGINAL_TRACKIDField;
            }
            set
            {
                this.oRIGINAL_TRACKIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double ORIGINAL_LOOP_SIZE
        {
            get
            {
                return this.oRIGINAL_LOOP_SIZEField;
            }
            set
            {
                this.oRIGINAL_LOOP_SIZEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ORIGINAL_LOOP_START
        {
            get
            {
                return this.oRIGINAL_LOOP_STARTField;
            }
            set
            {
                this.oRIGINAL_LOOP_STARTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SAMPLE_TYPE_INFO
        {
            get
            {
                return this.sAMPLE_TYPE_INFOField;
            }
            set
            {
                this.sAMPLE_TYPE_INFOField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLCOLLECTIONENTRYCUE_V2
    {

        private string nAMEField;

        private byte dISPL_ORDERField;

        private byte tYPEField;

        private decimal sTARTField;

        private decimal lENField;

        private sbyte rEPEATSField;

        private sbyte hOTCUEField;

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
        public decimal LEN
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
        public sbyte HOTCUE
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLCOLLECTIONENTRYSTEMS
    {

        private string sTEMSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STEMS
        {
            get
            {
                return this.sTEMSField;
            }
            set
            {
                this.sTEMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLSETS
    {

        private byte eNTRIESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ENTRIES
        {
            get
            {
                return this.eNTRIESField;
            }
            set
            {
                this.eNTRIESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTS
    {

        private NMLPLAYLISTSNODE nODEField;

        /// <remarks/>
        public NMLPLAYLISTSNODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODE
    {

        private NMLPLAYLISTSNODESUBNODES sUBNODESField;

        private string tYPEField;

        private string nAMEField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODES SUBNODES
        {
            get
            {
                return this.sUBNODESField;
            }
            set
            {
                this.sUBNODESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODES
    {

        private NMLPLAYLISTSNODESUBNODESNODE[] nODEField;

        private byte cOUNTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public NMLPLAYLISTSNODESUBNODESNODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte COUNT
        {
            get
            {
                return this.cOUNTField;
            }
            set
            {
                this.cOUNTField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODE
    {
        public override string ToString()
        {
            return this.nAMEField;
        }

        private NMLPLAYLISTSNODESUBNODESNODESUBNODES sUBNODESField;

        private NMLPLAYLISTSNODESUBNODESNODEPLAYLIST pLAYLISTField;

        private string tYPEField;

        private string nAMEField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODES SUBNODES
        {
            get
            {
                return this.sUBNODESField;
            }
            set
            {
                this.sUBNODESField = value;
            }
        }

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODEPLAYLIST PLAYLIST
        {
            get
            {
                return this.pLAYLISTField;
            }
            set
            {
                this.pLAYLISTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODES
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODE[] nODEField;

        private byte cOUNTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte COUNT
        {
            get
            {
                return this.cOUNTField;
            }
            set
            {
                this.cOUNTField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODE
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODES sUBNODESField;

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLIST pLAYLISTField;

        private string tYPEField;

        private string nAMEField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODES SUBNODES
        {
            get
            {
                return this.sUBNODESField;
            }
            set
            {
                this.sUBNODESField = value;
            }
        }

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLIST PLAYLIST
        {
            get
            {
                return this.pLAYLISTField;
            }
            set
            {
                this.pLAYLISTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODES
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODE[] nODEField;

        private byte cOUNTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte COUNT
        {
            get
            {
                return this.cOUNTField;
            }
            set
            {
                this.cOUNTField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODE
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODES sUBNODESField;

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLIST pLAYLISTField;

        private string tYPEField;

        private string nAMEField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODES SUBNODES
        {
            get
            {
                return this.sUBNODESField;
            }
            set
            {
                this.sUBNODESField = value;
            }
        }

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLIST PLAYLIST
        {
            get
            {
                return this.pLAYLISTField;
            }
            set
            {
                this.pLAYLISTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODES
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODE[] nODEField;

        private byte cOUNTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte COUNT
        {
            get
            {
                return this.cOUNTField;
            }
            set
            {
                this.cOUNTField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODE
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLIST pLAYLISTField;

        private string tYPEField;

        private string nAMEField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLIST PLAYLIST
        {
            get
            {
                return this.pLAYLISTField;
            }
            set
            {
                this.pLAYLISTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLIST
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY[] eNTRYField;

        private ushort eNTRIESField;

        private string tYPEField;

        private string uUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ENTRY")]
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY[] ENTRY
        {
            get
            {
                return this.eNTRYField;
            }
            set
            {
                this.eNTRYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ENTRIES
        {
            get
            {
                return this.eNTRIESField;
            }
            set
            {
                this.eNTRIESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY pRIMARYKEYField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY PRIMARYKEY
        {
            get
            {
                return this.pRIMARYKEYField;
            }
            set
            {
                this.pRIMARYKEYField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY
    {

        private string tYPEField;

        private string kEYField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLIST
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY[] eNTRYField;

        private ushort eNTRIESField;

        private string tYPEField;

        private string uUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ENTRY")]
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY[] ENTRY
        {
            get
            {
                return this.eNTRYField;
            }
            set
            {
                this.eNTRYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ENTRIES
        {
            get
            {
                return this.eNTRIESField;
            }
            set
            {
                this.eNTRIESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY pRIMARYKEYField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY PRIMARYKEY
        {
            get
            {
                return this.pRIMARYKEYField;
            }
            set
            {
                this.pRIMARYKEYField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY
    {

        private string tYPEField;

        private string kEYField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLIST
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY[] eNTRYField;

        private ushort eNTRIESField;

        private string tYPEField;

        private string uUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ENTRY")]
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY[] ENTRY
        {
            get
            {
                return this.eNTRYField;
            }
            set
            {
                this.eNTRYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ENTRIES
        {
            get
            {
                return this.eNTRIESField;
            }
            set
            {
                this.eNTRIESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLISTENTRY
    {

        private NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY pRIMARYKEYField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY PRIMARYKEY
        {
            get
            {
                return this.pRIMARYKEYField;
            }
            set
            {
                this.pRIMARYKEYField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY
    {

        private string tYPEField;

        private string kEYField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODEPLAYLIST
    {

        private NMLPLAYLISTSNODESUBNODESNODEPLAYLISTENTRY[] eNTRYField;

        private byte eNTRIESField;

        private string tYPEField;

        private string uUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ENTRY")]
        public NMLPLAYLISTSNODESUBNODESNODEPLAYLISTENTRY[] ENTRY
        {
            get
            {
                return this.eNTRYField;
            }
            set
            {
                this.eNTRYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ENTRIES
        {
            get
            {
                return this.eNTRIESField;
            }
            set
            {
                this.eNTRIESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODEPLAYLISTENTRY
    {

        private NMLPLAYLISTSNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY pRIMARYKEYField;

        /// <remarks/>
        public NMLPLAYLISTSNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY PRIMARYKEY
        {
            get
            {
                return this.pRIMARYKEYField;
            }
            set
            {
                this.pRIMARYKEYField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLPLAYLISTSNODESUBNODESNODEPLAYLISTENTRYPRIMARYKEY
    {

        private string tYPEField;

        private string kEYField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TYPE
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLSORTING_ORDER
    {

        private NMLSORTING_ORDERSORTING_DATA[] sORTING_DATAField;

        private string pATHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SORTING_DATA")]
        public NMLSORTING_ORDERSORTING_DATA[] SORTING_DATA
        {
            get
            {
                return this.sORTING_DATAField;
            }
            set
            {
                this.sORTING_DATAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PATH
        {
            get
            {
                return this.pATHField;
            }
            set
            {
                this.pATHField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NMLSORTING_ORDERSORTING_DATA
    {

        private byte iDXField;

        private byte oRDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte IDX
        {
            get
            {
                return this.iDXField;
            }
            set
            {
                this.iDXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ORD
        {
            get
            {
                return this.oRDField;
            }
            set
            {
                this.oRDField = value;
            }
        }
    }


}
