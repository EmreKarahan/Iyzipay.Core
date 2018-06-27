﻿using IyzipayCore.Request;

namespace IyzipayCore.Model
{
    public class BasicPaymentPostAuth : BasicPaymentResource
    {        
        public static BasicPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPaymentPostAuth>(options.BaseUrl + "/payment/postauth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
