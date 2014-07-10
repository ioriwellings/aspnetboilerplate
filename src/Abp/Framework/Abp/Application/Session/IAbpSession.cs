﻿namespace Abp.Application.Session
{
    /// <summary>
    /// Defines some session informations that can be useful for applications.
    /// </summary>
    public interface IAbpSession
    {
        /// <summary>
        /// Gets current UserId of null.
        /// </summary>
        int? UserId { get; }

        /// <summary>
        /// Gets current TenantId or null.
        /// </summary>
        int? TenantId { get; }
    }
}