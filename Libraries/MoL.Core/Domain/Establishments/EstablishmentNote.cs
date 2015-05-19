using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments.Enums;

namespace MoL.Core.Domain.Establishments
{
    public class EstablishmentNote : BaseEntity
    {
        public long FK_EstablishmentId { get; set; }
        public int? FK_NoteTypeId { get; set; }
        public long? NoteNumber { get; set; }
        public int FK_NoteSourceId { get; set; }
        public string NoteText { get; set; }
        public int FK_NoteStatusId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertLaborerName { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndLaborerName { get; set; }
        public string EndReason { get; set; }
        public int? FK_NoteApplicabilityId { get; set; }

        public virtual NoteApplicability NoteApplicability
        {
            get
            {
                return (NoteApplicability)this.FK_NoteApplicabilityId;
            }
            set
            {
                this.FK_NoteApplicabilityId = (int)value;
            }
        }
        public virtual NoteSource NoteSource
        {
            get
            {
                return (NoteSource)this.FK_NoteSourceId;
            }
            set
            {
                this.FK_NoteSourceId = (int)value;
            }
        }
        public virtual NoteStatus NoteStatus
        {
            get
            {
                return (NoteStatus)this.FK_NoteStatusId;
            }
            set
            {
                this.FK_NoteStatusId = (int)value;
            }
        }
        public virtual NoteType NoteType
        {
            get
            {
                return (NoteType)this.FK_NoteTypeId;
            }
            set
            {
                this.FK_NoteTypeId = (int)value;
            }
        }
        public virtual Establishment Establishment { get; set; }
    }
}
