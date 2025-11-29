using Microsoft.EntityFrameworkCore;
using JobMagnet.Domain.Entities;

namespace JobMagnet.Infrastructure
{
    public static class JobMagnetDbContextExtensions
    {
        public static void ApplyEnterpriseModel(this ModelBuilder modelBuilder)
        {
            // DbSet definitions are in main DbContext class.
            // Global query filters for soft-delete entities:
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Company>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Freelancer>().HasQueryFilter(f => !f.IsDeleted);
            modelBuilder.Entity<Job>().HasQueryFilter(j => !j.IsDeleted);
            modelBuilder.Entity<Project>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<JobApplication>().HasQueryFilter(ja => !ja.IsDeleted);
            modelBuilder.Entity<Proposal>().HasQueryFilter(pr => !pr.IsDeleted);
            modelBuilder.Entity<ProjectDelivery>().HasQueryFilter(pd => !pd.IsDeleted);
            modelBuilder.Entity<EscrowTransaction>().HasQueryFilter(et => !et.IsDeleted);
            modelBuilder.Entity<Dispute>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<CommunityPost>().HasQueryFilter(cp => !cp.IsDeleted);
            modelBuilder.Entity<CommunityReply>().HasQueryFilter(cr => !cr.IsDeleted);
            modelBuilder.Entity<Review>().HasQueryFilter(r => !r.IsDeleted);
            modelBuilder.Entity<UserDocument>().HasQueryFilter(ud => !ud.IsDeleted);
            modelBuilder.Entity<Payment>().HasQueryFilter(p => !p.IsDeleted);
            // add more as needed...
        }
    }
}
