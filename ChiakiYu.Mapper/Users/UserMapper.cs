﻿using ChiakiYu.EntityFramework;
using ChiakiYu.Model.Users;

namespace ChiakiYu.Mapper.Users
{
    public class UserMapper : EntityConfiguration<User, long>
    {
        public UserMapper()
        {
            ToTable("Sys_Users");
            //Property(n => n.IsActived).HasColumnType("int");
            //HasKey(c => c.Id).Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Property(n => n.UserName).IsRequired().HasMaxLength(256);
        }
    }
}