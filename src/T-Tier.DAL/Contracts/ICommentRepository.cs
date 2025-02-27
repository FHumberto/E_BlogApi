﻿using T_Tier.DAL.Entities;

namespace T_Tier.DAL.Contracts;

public interface ICommentRepository : IRepository<Comment>
{
    public Task<IReadOnlyList<Comment?>> GetCommentsWithUser(string userId);
}