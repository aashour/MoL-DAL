using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Mapping.Lookups
{
    public partial class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            ToTable("Lookup_Job", "dbo");
            HasKey(jb => jb.Id);
            Property(jb => jb.Id).HasColumnName("Id");
            Ignore(jb => jb.Deleted);
            Ignore(jb => jb.CreatedOnUtc);

            HasMany(jb => jb.EmployeeUsers).
                WithOptional(usr => usr.Job).
                HasForeignKey(usr => usr.JobId);

            HasMany(jb => jb.JobVacancies).
                WithOptional(vcn => vcn.Job).
                HasForeignKey(vcn => vcn.FK_JobId);

            HasMany(jb => jb.Laborers).
                WithOptional(lab => lab.Job).
                HasForeignKey(lab => lab.FK_JobId);
        }
    }
}
