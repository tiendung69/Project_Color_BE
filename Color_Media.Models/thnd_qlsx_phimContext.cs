using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Color_Media.Models
{
    public partial class thnd_qlsx_phimContext : DbContext
    {
        public thnd_qlsx_phimContext()
        {
        }

        public thnd_qlsx_phimContext(DbContextOptions<thnd_qlsx_phimContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Approved> Approveds { get; set; } = null!;
        public virtual DbSet<Audit> Audits { get; set; } = null!;
        public virtual DbSet<Broadcasting> Broadcastings { get; set; } = null!;
        public virtual DbSet<Broadcastingdocument> Broadcastingdocuments { get; set; } = null!;
        public virtual DbSet<Commoncategory> Commoncategories { get; set; } = null!;
        public virtual DbSet<Contacttemplate> Contacttemplates { get; set; } = null!;
        public virtual DbSet<ElasticField> ElasticFields { get; set; } = null!;
        public virtual DbSet<Estimate> Estimates { get; set; } = null!;
        public virtual DbSet<Mappingfield> Mappingfields { get; set; } = null!;
        public virtual DbSet<Mappingtable> Mappingtables { get; set; } = null!;
        public virtual DbSet<Movieapproval> Movieapprovals { get; set; } = null!;
        public virtual DbSet<MovieapprovalDetail> MovieapprovalDetails { get; set; } = null!;
        public virtual DbSet<PostproductionPlaning> PostproductionPlanings { get; set; } = null!;
        public virtual DbSet<PostproductionProgress> PostproductionProgresses { get; set; } = null!;
        public virtual DbSet<PostproductionprogressMember> PostproductionprogressMembers { get; set; } = null!;
        public virtual DbSet<PreproductionExpense> PreproductionExpenses { get; set; } = null!;
        public virtual DbSet<PreproductionMember> PreproductionMembers { get; set; } = null!;
        public virtual DbSet<PreproductionPlaning> PreproductionPlanings { get; set; } = null!;
        public virtual DbSet<PreproductionProgress> PreproductionProgresses { get; set; } = null!;
        public virtual DbSet<PreproductionSegment> PreproductionSegments { get; set; } = null!;
        public virtual DbSet<PreproductionprogressMember> PreproductionprogressMembers { get; set; } = null!;
        public virtual DbSet<PreproductionsegmentMember> PreproductionsegmentMembers { get; set; } = null!;
        public virtual DbSet<ReportCost> ReportCosts { get; set; } = null!;
        public virtual DbSet<ReportProgress> ReportProgresses { get; set; } = null!;
        public virtual DbSet<RoleRight> RoleRights { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<TeamMember> TeamMembers { get; set; } = null!;
        public virtual DbSet<Topic> Topics { get; set; } = null!;
        public virtual DbSet<TopicDocument> TopicDocuments { get; set; } = null!;
        public virtual DbSet<TopicMember> TopicMembers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRight> UserRights { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<VCommoncategory> VCommoncategories { get; set; } = null!;
        public virtual DbSet<Video> Videos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-DO6GJV4A;Initial Catalog=thnd_qlsx_phim;User Id=sa;Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Approved>(entity =>
            {
                entity.ToTable("approved");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.ProcessedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.ToTable("audit");

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.AuditData).HasMaxLength(2000);

                entity.Property(e => e.EntityName).HasMaxLength(45);

                entity.Property(e => e.ProcessedAt).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<Broadcasting>(entity =>
            {
                entity.ToTable("broadcasting");

                entity.Property(e => e.BroadcastingTime).HasColumnType("datetime");

                entity.Property(e => e.Reciever).HasMaxLength(200);

                entity.Property(e => e.SubmissionTime).HasColumnType("datetime");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.Broadcastings)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_broadcasting_commoncategory");

                entity.HasOne(d => d.PostProductionPlaning)
                    .WithMany(p => p.Broadcastings)
                    .HasForeignKey(d => d.PostProductionPlaningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_broadcasting_postproduction_planing");
            });

            modelBuilder.Entity<Broadcastingdocument>(entity =>
            {
                entity.ToTable("broadcastingdocument");

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FileType).HasMaxLength(200);

                entity.Property(e => e.FileUrl).HasMaxLength(200);

                entity.HasOne(d => d.Broadcasting)
                    .WithMany(p => p.Broadcastingdocuments)
                    .HasForeignKey(d => d.BroadcastingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_broadcastingdocument_broadcasting");
            });

            modelBuilder.Entity<Commoncategory>(entity =>
            {
                entity.ToTable("commoncategory");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<Contacttemplate>(entity =>
            {
                entity.ToTable("contacttemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElasticField>(entity =>
            {
                entity.ToTable("ElasticField");

                entity.Property(e => e.FieldName).HasMaxLength(200);

                entity.Property(e => e.TableName).HasMaxLength(200);
            });

            modelBuilder.Entity<Estimate>(entity =>
            {
                entity.ToTable("estimate");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.HumanResourceEstimate).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.OtherResourceEstimate).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.TaskName).HasMaxLength(250);

                entity.Property(e => e.TimeEstimate).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_estimate_user");

                entity.HasOne(d => d.PreProductPlaning)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.PreProductPlaningId)
                    .HasConstraintName("FK_estimate_preproduction_planing");
            });

            modelBuilder.Entity<Mappingfield>(entity =>
            {
                entity.ToTable("mappingfield");

                entity.Property(e => e.NewField).HasMaxLength(100);

                entity.Property(e => e.OriginField).HasMaxLength(100);

                entity.Property(e => e.Table).HasMaxLength(100);
            });

            modelBuilder.Entity<Mappingtable>(entity =>
            {
                entity.ToTable("mappingtable");

                entity.Property(e => e.NewTable).HasMaxLength(100);

                entity.Property(e => e.OriginTable).HasMaxLength(100);
            });

            modelBuilder.Entity<Movieapproval>(entity =>
            {
                entity.ToTable("movieapproval");

                entity.HasIndex(e => e.PostProductionPlaningId, "FK_movieapproval_postproduction_planing_idx");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.Content).HasMaxLength(4000);

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");

                entity.Property(e => e.Suggested).HasMaxLength(4000);

                entity.HasOne(d => d.PostProductionPlaning)
                    .WithMany(p => p.Movieapprovals)
                    .HasForeignKey(d => d.PostProductionPlaningId)
                    .HasConstraintName("FK_movieapproval_postproduction_planing");
            });

            modelBuilder.Entity<MovieapprovalDetail>(entity =>
            {
                entity.ToTable("movieapproval_detail");

                entity.HasIndex(e => e.UserId, "FK_moviceapproval_detail_User_idx");

                entity.HasIndex(e => e.MovieApprovalId, "FK_movieapproval_detail_movieapproval_idx");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.Role).HasMaxLength(2000);

                entity.Property(e => e.Suggested).HasMaxLength(4000);

                entity.HasOne(d => d.MovieApproval)
                    .WithMany(p => p.MovieapprovalDetails)
                    .HasForeignKey(d => d.MovieApprovalId)
                    .HasConstraintName("FK_movieapproval_detail_movieapproval");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MovieapprovalDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_moviceapproval_detail_User");
            });

            modelBuilder.Entity<PostproductionPlaning>(entity =>
            {
                entity.ToTable("postproduction_planing");

                entity.HasIndex(e => e.PreProductionId, "FK_postproduction_planing_preproduction_planing_idx");

                entity.Property(e => e.Budget).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CloseNote).HasMaxLength(4000);

                entity.Property(e => e.CloseReason).HasMaxLength(2000);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.WorkContent).HasMaxLength(4000);

                entity.HasOne(d => d.PreProduction)
                    .WithMany(p => p.PostproductionPlanings)
                    .HasForeignKey(d => d.PreProductionId)
                    .HasConstraintName("FK_postproduction_planing_preproduction_planing");
            });

            modelBuilder.Entity<PostproductionProgress>(entity =>
            {
                entity.ToTable("postproduction_progress");

                entity.HasIndex(e => e.PostProductionId, "FK_postproduction_progress_postproduction_plaing_idx");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Expense).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TotalProgress).HasColumnType("decimal(14, 2)");

                entity.HasOne(d => d.PostProduction)
                    .WithMany(p => p.PostproductionProgresses)
                    .HasForeignKey(d => d.PostProductionId)
                    .HasConstraintName("FK_postproduction_progress_postproduction_plaing");
            });

            modelBuilder.Entity<PostproductionprogressMember>(entity =>
            {
                entity.ToTable("postproductionprogress_member");

                entity.HasIndex(e => e.UserId, "FK_postproductionprogress_member_user_idx");

                entity.HasIndex(e => e.PostProductionProgressId, "postproductionprogress_member_postproduction_progress_idx");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.PercentCompleted).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Role).HasMaxLength(200);

                entity.HasOne(d => d.PostProductionProgress)
                    .WithMany(p => p.PostproductionprogressMembers)
                    .HasForeignKey(d => d.PostProductionProgressId)
                    .HasConstraintName("FK_postproductionprogress_member_postproduction_progress");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostproductionprogressMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_postproductionprogress_member_user");
            });

            modelBuilder.Entity<PreproductionExpense>(entity =>
            {
                entity.ToTable("preproduction_expense");

                entity.HasIndex(e => e.SegmentId, "FK_preproduction_expanse_preproduction_segment_idx");

                entity.HasIndex(e => e.PreProductionId, "FK_preproduction_expense_preproduction_planing_idx");

                entity.Property(e => e.Amount).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.Reason).HasMaxLength(2000);

                entity.HasOne(d => d.PreProduction)
                    .WithMany(p => p.PreproductionExpenses)
                    .HasForeignKey(d => d.PreProductionId)
                    .HasConstraintName("FK_preproduction_expense_preproduction_planing");

                entity.HasOne(d => d.Segment)
                    .WithMany(p => p.PreproductionExpenses)
                    .HasForeignKey(d => d.SegmentId)
                    .HasConstraintName("FK_preproduction_expanse_preproduction_segment");
            });

            modelBuilder.Entity<PreproductionMember>(entity =>
            {
                entity.ToTable("preproduction_member");

                entity.HasIndex(e => e.PreProductionId, "FK_preproduction_member_preproduction_planing_idx");

                entity.HasIndex(e => e.MemberId, "FK_preproduction_member_user_idx");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Role).HasMaxLength(200);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.PreproductionMembers)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_preproduction_member_user");

                entity.HasOne(d => d.PreProduction)
                    .WithMany(p => p.PreproductionMembers)
                    .HasForeignKey(d => d.PreProductionId)
                    .HasConstraintName("FK_preproduction_member_preproduction_planing");
            });

            modelBuilder.Entity<PreproductionPlaning>(entity =>
            {
                entity.ToTable("preproduction_planing");

                entity.HasIndex(e => e.TeamId, "FK_preproduction_planing_team_idx");

                entity.HasIndex(e => e.TopicId, "FK_preproduction_planing_topic_idx");

                entity.HasIndex(e => e.ApprovedMember, "FK_preproduction_planing_user_idx");

                entity.Property(e => e.Budget).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CloseExpense).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CloseNote).HasMaxLength(4000);

                entity.Property(e => e.CloseReason).HasMaxLength(2000);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Scenario).HasColumnType("ntext");

                entity.HasOne(d => d.ApprovedMemberNavigation)
                    .WithMany(p => p.PreproductionPlanings)
                    .HasForeignKey(d => d.ApprovedMember)
                    .HasConstraintName("FK_preproduction_planing_user");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.PreproductionPlanings)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_preproduction_planing_team");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PreproductionPlanings)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_preproduction_planing_topic");
            });

            modelBuilder.Entity<PreproductionProgress>(entity =>
            {
                entity.ToTable("preproduction_progress");

                entity.HasIndex(e => e.PreProductionId, "FK_preproduction_progress_preproduction_planing_idx");

                entity.HasIndex(e => e.SegmentId, "FK_preproduction_progress_preproduction_segment_idx");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Expense).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.SegmentProgress).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Status).HasComment("0: New; 1 : Duyet; -1: Tu choi");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TotalProgress).HasColumnType("decimal(14, 2)");

                entity.HasOne(d => d.PreProduction)
                    .WithMany(p => p.PreproductionProgresses)
                    .HasForeignKey(d => d.PreProductionId)
                    .HasConstraintName("FK_preproduction_progress_preproduction_planing");

                entity.HasOne(d => d.Segment)
                    .WithMany(p => p.PreproductionProgresses)
                    .HasForeignKey(d => d.SegmentId)
                    .HasConstraintName("FK_preproduction_progress_preproduction_segment");
            });

            modelBuilder.Entity<PreproductionSegment>(entity =>
            {
                entity.ToTable("preproduction_segment");

                entity.HasIndex(e => e.CommuneId, "FK_preproduction_segment_commune_idx");

                entity.HasIndex(e => e.DistrictId, "FK_preproduction_segment_districti_idx");

                entity.HasIndex(e => e.PreProductionId, "FK_preproduction_segment_preproduction_planing_idx");

                entity.HasIndex(e => e.ProvinceId, "FK_preproduction_segment_province_idx");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Budget).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Scenario).HasColumnType("ntext");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.PreproductionSegmentCommunes)
                    .HasForeignKey(d => d.CommuneId)
                    .HasConstraintName("FK_preproduction_segment_commune");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.PreproductionSegmentDistricts)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_preproduction_segment_districti");

                entity.HasOne(d => d.PreProduction)
                    .WithMany(p => p.PreproductionSegments)
                    .HasForeignKey(d => d.PreProductionId)
                    .HasConstraintName("FK_preproduction_segment_preproduction_planing");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.PreproductionSegmentProvinces)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_preproduction_segment_province");
            });

            modelBuilder.Entity<PreproductionprogressMember>(entity =>
            {
                entity.ToTable("preproductionprogress_member");

                entity.HasIndex(e => e.PreProductionProgressId, "FK_preproductionprogress_member_preoproduction_progress_idx");

                entity.HasIndex(e => e.UserId, "FK_preproductionprogress_member_user_idx");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.PercentComplete).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Role).HasMaxLength(200);

                entity.HasOne(d => d.PreProductionProgress)
                    .WithMany(p => p.PreproductionprogressMembers)
                    .HasForeignKey(d => d.PreProductionProgressId)
                    .HasConstraintName("FK_preproductionprogress_member_preoproduction_progress");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PreproductionprogressMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_preproductionprogress_member_user");
            });

            modelBuilder.Entity<PreproductionsegmentMember>(entity =>
            {
                entity.ToTable("preproductionsegment_member");

                entity.HasIndex(e => e.PreProductionSegmentId, "FK_preproductionsegment_member_preproduction_segment_idx");

                entity.HasIndex(e => e.UserId, "FK_preproductionsegment_member_user_idx");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Role).HasMaxLength(200);

                entity.HasOne(d => d.PreProductionSegment)
                    .WithMany(p => p.PreproductionsegmentMembers)
                    .HasForeignKey(d => d.PreProductionSegmentId)
                    .HasConstraintName("FK_preproductionsegment_member_preproduction_segment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PreproductionsegmentMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_preproductionsegment_member_user");
            });

            modelBuilder.Entity<ReportCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReportCost");

                entity.Property(e => e.EstimatedBudget).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.EstimatedEnd).HasColumnType("datetime");

                entity.Property(e => e.MinEstimatedBegin).HasColumnType("datetime");

                entity.Property(e => e.PostProductionFromDate).HasColumnType("datetime");

                entity.Property(e => e.PostProductionToDate).HasColumnType("datetime");

                entity.Property(e => e.PreProductionPlanName).HasMaxLength(200);

                entity.Property(e => e.TopicName).HasMaxLength(200);
            });

            modelBuilder.Entity<ReportProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReportProgress");

                entity.Property(e => e.EstimatedEnd).HasColumnType("datetime");

                entity.Property(e => e.MinEstimatedBegin).HasColumnType("datetime");

                entity.Property(e => e.PostProductionFromDate).HasColumnType("datetime");

                entity.Property(e => e.PostProductionToDate).HasColumnType("datetime");

                entity.Property(e => e.PreProductionPlanName).HasMaxLength(200);

                entity.Property(e => e.TopicName).HasMaxLength(200);

                entity.Property(e => e.TotalProgress).HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<RoleRight>(entity =>
            {
                entity.ToTable("role_right");

                entity.HasIndex(e => e.RightId, "roleright_right_idx");

                entity.HasIndex(e => e.RoleId, "roleright_role_idx");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Right)
                    .WithMany(p => p.RoleRightRights)
                    .HasForeignKey(d => d.RightId)
                    .HasConstraintName("roleright_right");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleRightRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("roleright_role");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("team");

                entity.HasIndex(e => e.LeaderId, "FK_team_user_idx");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.Leader)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.LeaderId)
                    .HasConstraintName("FK_team_user");
            });

            modelBuilder.Entity<TeamMember>(entity =>
            {
                entity.ToTable("team_member");

                entity.HasIndex(e => e.TeamId, "FK_team_member_team_idx");

                entity.HasIndex(e => e.UserId, "FK_team_member_user_idx");

                entity.Property(e => e.Role).HasMaxLength(200);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_team_member_team");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_team_member_user");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("topic");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EstimatedBegin).HasColumnType("datetime");

                entity.Property(e => e.EstimatedBroadcasting).HasColumnType("datetime");

                entity.Property(e => e.EstimatedBudget).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.EstimatedCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EstimatedEnd).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Scenario).HasMaxLength(4000);
            });

            modelBuilder.Entity<TopicDocument>(entity =>
            {
                entity.ToTable("topic_document");

                entity.HasIndex(e => e.TopicId, "FK_topic_document_topic_idx");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FileUrl).HasMaxLength(200);

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TopicDocuments)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_topic_document_topic");
            });

            modelBuilder.Entity<TopicMember>(entity =>
            {
                entity.ToTable("topic_member");

                entity.HasIndex(e => e.TopicId, "FK_topic_member_topic_idx");

                entity.HasIndex(e => e.MemberId, "FK_topic_member_user_idx");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Role).HasMaxLength(200);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TopicMembers)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_topic_member_user");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TopicMembers)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_topic_member_topic");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.DepartId, "user_depart_idx");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasComment("1-Active; -1 -Delete");

                entity.Property(e => e.Tel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Depart)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartId)
                    .HasConstraintName("user_depart");
            });

            modelBuilder.Entity<UserRight>(entity =>
            {
                entity.ToTable("user_right");

                entity.HasOne(d => d.Right)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.RightId)
                    .HasConstraintName("FK_user_right_commoncategory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_user_right_user");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("user_role");

                entity.HasIndex(e => e.RoleId, "userrole_role_idx");

                entity.HasIndex(e => e.UserId, "userrole_user_idx");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("userrole_role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("userrole_user");
            });

            modelBuilder.Entity<VCommoncategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_commoncategory");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Grand).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ParentName).HasMaxLength(200);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("video");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.VideoLength).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.VideoName).HasMaxLength(200);

                entity.Property(e => e.VideoSize).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.VideoUrl).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
