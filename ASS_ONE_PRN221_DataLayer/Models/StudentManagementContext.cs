using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class StudentManagementContext : DbContext
    {
        public StudentManagementContext()
        {
        }

        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS01;uid=sa;pwd=1234;database=StudentManagement");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.AttendanceCode);

                entity.ToTable("Attendance");

                entity.Property(e => e.AttendanceCode).HasMaxLength(50);

                entity.Property(e => e.AttendanceDate).HasColumnType("datetime");

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.StudentCode).HasMaxLength(50);

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.ClassCode)
                    .HasConstraintName("FK_Attendance_Class");

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.CourseCode)
                    .HasConstraintName("FK_Attendance_Course");

                entity.HasOne(d => d.StudentCodeNavigation)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.StudentCode)
                    .HasConstraintName("FK_Attendance_Student");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClassCode);

                entity.ToTable("Class");

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.ClassName).HasMaxLength(150);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseCode);

                entity.ToTable("Course");

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.CourseName).HasMaxLength(50);

                entity.Property(e => e.MajorCode).HasMaxLength(50);

                entity.HasOne(d => d.MajorCodeNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.MajorCode)
                    .HasConstraintName("FK_Course_Major");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.EnrollmentCode)
                    .HasName("PK__Enrollme__670CB47F78B96086");

                entity.ToTable("Enrollment");

                entity.Property(e => e.EnrollmentCode).HasMaxLength(50);

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StudentCode).HasMaxLength(50);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.CourseCode)
                    .HasConstraintName("FK_Enrollment_Course");

                entity.HasOne(d => d.StudentCodeNavigation)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.StudentCode)
                    .HasConstraintName("FK_Enrollment_Student");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.GradeCode);

                entity.ToTable("Grade");

                entity.Property(e => e.GradeCode).HasMaxLength(50);

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.Grade1).HasColumnName("Grade");

                entity.Property(e => e.StudentCode).HasMaxLength(50);

                entity.Property(e => e.TeacherCode).HasMaxLength(50);

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.ClassCode)
                    .HasConstraintName("FK_Grade_Class");

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.CourseCode)
                    .HasConstraintName("FK_Grade_Course");

                entity.HasOne(d => d.StudentCodeNavigation)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentCode)
                    .HasConstraintName("FK_Grade_Student");

                entity.HasOne(d => d.TeacherCodeNavigation)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.TeacherCode)
                    .HasConstraintName("FK_Grade_Teacher");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.HasKey(e => e.MajorCode);

                entity.ToTable("Major");

                entity.Property(e => e.MajorCode).HasMaxLength(50);

                entity.Property(e => e.MajorName).HasMaxLength(150);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentCode);

                entity.ToTable("Student");

                entity.Property(e => e.StudentCode).HasMaxLength(50);

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.StudentAddress).HasMaxLength(500);

                entity.Property(e => e.StudentMail).HasMaxLength(150);

                entity.Property(e => e.StudentName).HasMaxLength(200);

                entity.Property(e => e.StudentPhone).HasMaxLength(13);

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassCode)
                    .HasConstraintName("FK_Student_Class");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.TeacherCode);

                entity.ToTable("Teacher");

                entity.Property(e => e.TeacherCode).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.TeacherName).HasMaxLength(200);

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.ClassCode)
                    .HasConstraintName("FK_Teacher_Class");

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.CourseCode)
                    .HasConstraintName("FK_Teacher_Course");
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.HasKey(e => e.TimetableCode);

                entity.ToTable("Timetable");

                entity.Property(e => e.TimetableCode).HasMaxLength(50);

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.TeacherCode).HasMaxLength(50);

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany(p => p.Timetables)
                    .HasForeignKey(d => d.ClassCode)
                    .HasConstraintName("FK_Timetable_Class");

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.Timetables)
                    .HasForeignKey(d => d.CourseCode)
                    .HasConstraintName("FK_Timetable_Course");

                entity.HasOne(d => d.TeacherCodeNavigation)
                    .WithMany(p => p.Timetables)
                    .HasForeignKey(d => d.TeacherCode)
                    .HasConstraintName("FK_Timetable_Teacher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
