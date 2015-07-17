﻿namespace Microsoft.TeamFoundation.Git.Helpers.Authentication
{
    /// <summary>
    /// Type of authentication and identity authority expected.
    /// </summary>
    internal enum AuthorityType
    {
        /// <summary>
        /// Basic username and password scheme
        /// </summary>
        Basic,
        /// <summary>
        /// Username and password scheme using Microsoft's Live system
        /// </summary>
        MicrosoftAccount,
        /// <summary>
        /// Azure Directory Authentication based, including support for ADFS
        /// </summary>
        AzureDirectory,
    }
}
