﻿using RestSharp;
using System;

namespace StopWatch
{
    internal interface IJiraApiRequestFactory
    {
        IRestRequest CreateValidateSessionRequest();
        IRestRequest CreateGetFavoriteFiltersRequest();
        IRestRequest CreateGetIssuesByJQLRequest(string jql);
        IRestRequest CreateGetIssueSummaryRequest(string key);
        IRestRequest CreatePostWorklogRequest(string key, TimeSpan time, string comment);
        IRestRequest CreatePostCommentRequest(string key, string comment);
        IRestRequest CreateAuthenticateRequest(string username, string password);
        IRestRequest CreateReAuthenticateRequest();
    }

}
