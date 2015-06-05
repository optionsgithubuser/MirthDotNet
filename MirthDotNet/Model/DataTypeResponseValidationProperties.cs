﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MirthDotNet.Model
{
    [Serializable]
    public class DataTypeResponseValidationProperties
    {
        [XmlElement("successfulACKCode")]
        public string SuccessfulACKCode { get; set; }
        [XmlElement("errorACKCode")]
        public string ErrorACKCode { get; set; }
        [XmlElement("rejectedACKCode")]
        public string RejectedACKCode { get; set; }

        [XmlElement("validateMessageControlId")]
        public bool ValidateMessageControlId { get; set; }
        [XmlElement("originalMessageControlId")]
        public string PriginalMessageControlId { get; set; }
        [XmlElement("originalIdMapVariable")]
        public string OriginalIdMapVariable { get; set; }
    }
}
