﻿using System;

namespace GigyaSDK.iOS
{
    public enum GSErrorCode {
        CanceledByUser = 200001,
        MissingRequiredParameter = 400002,
        InvalidAccessToken = 403001,
        InvalidTime = 403002,
        UnauthorizedUser = 403005,
        PermissionDenied = 403007,
        NoValidSession = 403012,
        PermissionNotRequested = 403022,
        ServerLoginFailure = 500002,
        ProviderError = 500023,
        NetworkFailure = 500026,
        LoadFailed = 500032
    }
}
