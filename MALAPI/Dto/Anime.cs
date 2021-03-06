﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    [XmlRoot("entry")]
    public class Anime
    {
        [XmlElement("episode")]
        public int Episode { get; set; }
        [XmlElement("status")]
        public string Status { get; set; }
        [XmlElement("score")]
        public int Score { get; set; }
        [XmlElement("storage_type")]
        public int StorageType { get; set; }
        [XmlElement("storage_value")]
        public float StorageValue { get; set; }
        [XmlElement("times_rewatched")]
        public int TimesRewatched { get; set; }
        [XmlElement("rewatch_value")]
        public int RewatchValue { get; set; }

        [XmlElement("date_start")]
        public string DateStartStr
        {
            get
            {
                return DateStart.ToString("mmddyyyy");
            }
        }
        [XmlIgnore]
        public DateTime DateStart { get; set; }
        [XmlElement("date_finish")]
        public string DateEndStr
        {
            get
            {
                return DateEnd.ToString("mmddyyyy");
            }
        }
        [XmlIgnore]
        public DateTime DateEnd { get; set; }

        [XmlElement("priority")]
        public int Priority { get; set; }
        [XmlElement("enable_discussion")]
        public int EnableDiscussion { get; set; }
        [XmlElement("enable_rewatching")]
        public int EnableRewatching { get; set; }
        [XmlElement("comments")]
        public string Comments { get; set; }
        [XmlElement("tags")]
        public string Tags { get; set; }
    }
}
