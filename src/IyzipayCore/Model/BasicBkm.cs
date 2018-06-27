﻿using System;
using IyzipayCore.Request;

namespace IyzipayCore.Model
{
    public class BasicBkm : BasicPaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }
        public String PaymentStatus { get; set; }

        public static BasicBkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicBkm>(options.BaseUrl + "/payment/bkm/auth/detail/basic", GetHttpHeaders(request, options), request);
        }
    }
}
