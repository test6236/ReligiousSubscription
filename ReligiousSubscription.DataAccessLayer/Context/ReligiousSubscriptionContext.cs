﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;

using ReligiousSubscription.Model.Person;
using ReligiousSubscription.Model.Object;

using ReligiousSubscription.Model.Generic_Repository.Interface;

namespace ReligiousSubscription.DataAccessLayer.Context
{
    public class ReligiousSubscriptionContext : DbContext
    {
        public static string ConStr = "ReligiousSubscriptionConnection";

        public ReligiousSubscriptionContext() : base(ConStr)
        {

        }

        public IDbSet<Member> Members { get; set; }
        public IDbSet<Household> Households { get; set; }
        public IDbSet<HouseholdTransfares> HouseholdsTransfares { get; set; }
        public IDbSet<Payment> Payments { get; set; }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }

        public System.Data.Entity.DbSet<ReligiousSubscription.Model.Object.PaymentType> PaymentTypes { get; set; }

        public System.Data.Entity.DbSet<ReligiousSubscription.Model.Object.HouseholdTransfares> HouseholdTransfares { get; set; }
    }
}